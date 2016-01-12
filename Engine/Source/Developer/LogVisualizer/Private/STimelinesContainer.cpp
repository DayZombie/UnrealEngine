// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

#include "LogVisualizer.h"
#include "STimelinesContainer.h"
#include "STimeline.h"
#include "STimelineBar.h"
#include "TimeSliderController.h"
#include "SVisualLoggerReport.h"

#define LOCTEXT_NAMESPACE "STimelinesContainer"

TSharedRef<SWidget> STimelinesContainer::GetRightClickMenuContent()
{
	FMenuBuilder MenuBuilder(true, NULL);
	MenuBuilder.BeginSection("VisualLogReports", LOCTEXT("VisualLogReports", "VisualLog Reports"));
	{
		MenuBuilder.AddMenuEntry(
			LOCTEXT("GenarateReport", "Genarate Report"),
			LOCTEXT("GenarateReportTooltip", "Genarate report from Visual Log events."),
			FSlateIcon(),
			FUIAction(FExecuteAction::CreateSP(this, &STimelinesContainer::GenerateReport))
			);
	}
	MenuBuilder.EndSection();

	FDisplayMetrics DisplayMetrics;
	FSlateApplication::Get().GetDisplayMetrics(DisplayMetrics);

	const FVector2D DisplaySize(
		DisplayMetrics.PrimaryDisplayWorkAreaRect.Right - DisplayMetrics.PrimaryDisplayWorkAreaRect.Left,
		DisplayMetrics.PrimaryDisplayWorkAreaRect.Bottom - DisplayMetrics.PrimaryDisplayWorkAreaRect.Top);

	return
		SNew(SVerticalBox)

		+ SVerticalBox::Slot()
		.MaxHeight(DisplaySize.Y * 0.5)
		[
			MenuBuilder.MakeWidget()
		];
}

void STimelinesContainer::SetSelectionState(TSharedPtr<STimeline> AffectedNode, bool bSelect, bool bDeselectOtherNodes)
{
	const FName RowName = AffectedNode->GetName();
	const bool bIsSelected = FVisualLoggerDatabase::Get().IsRowSelected(RowName);
	if (bSelect && (!bIsSelected || bDeselectOtherNodes))
	{
		FVisualLoggerDatabase::Get().SelectRow(RowName, bDeselectOtherNodes);
	}
	else if (!bSelect && bIsSelected && AffectedNode.IsValid())
	{
		FVisualLoggerDatabase::Get().DeselectRow(RowName);
	}
}


void STimelinesContainer::OnObjectSelectionChanged(const TArray<FName>& RowNames)
{
	CachedSelectedTimelines.Reset();
	for (TSharedPtr<STimeline>& Timeline : TimelineItems)
	{
		if (RowNames.Find(Timeline->GetName()) != INDEX_NONE)
		{
			CachedSelectedTimelines.Add(Timeline);
		}
	}

	if (CachedSelectedTimelines.Num() >= 1)
	{
		FSlateApplication::Get().SetKeyboardFocus(SharedThis(CachedSelectedTimelines[CachedSelectedTimelines.Num()-1].Get()), EFocusCause::Navigation);
	}
}

bool STimelinesContainer::IsNodeSelected(TSharedPtr<STimeline> Node) const
{
	return FVisualLoggerDatabase::Get().IsRowSelected(Node->GetName());// SelectedNodes.Contains(Node);
}

void STimelinesContainer::ChangeSelection(TSharedPtr<STimeline> InTimeline, const FPointerEvent& MouseEvent)
{
	if (MouseEvent.IsLeftShiftDown() == false)
	{
		if (MouseEvent.IsLeftControlDown())
		{
			SetSelectionState(InTimeline, !InTimeline->IsSelected(), false);
		}
		else
		{
			SetSelectionState(InTimeline, true, true);
		}
	}
	else
	{
		if (CachedSelectedTimelines.Num() == 0 && TimelineItems.Num())
		{
			SetSelectionState(TimelineItems[0], true, true);
		}

		TSharedPtr<STimeline> LastSelected = CachedSelectedTimelines.Num() ? CachedSelectedTimelines[CachedSelectedTimelines.Num() - 1] : nullptr;
		if (LastSelected.IsValid())
		{
			bool bStartedSelection = false;
			for (TSharedPtr<STimeline>& TimelineItem : TimelineItems)
			{
				if (TimelineItem == LastSelected || InTimeline == TimelineItem)
				{
					if (!bStartedSelection)
					{
						bStartedSelection = true;
					}
					else
					{
						bStartedSelection = false;
						break;
					}
				}
				if (bStartedSelection)
				{
					SetSelectionState(TimelineItem, true, false);
				}
			}
		}
		SetSelectionState(InTimeline, true, false);
	}
}

FReply STimelinesContainer::OnMouseButtonDown(const FGeometry& MyGeometry, const FPointerEvent& MouseEvent)
{
	if (MouseEvent.GetEffectingButton() != EKeys::LeftMouseButton)
	{
		return TimeSliderController->OnMouseButtonDown(*this, MyGeometry, MouseEvent);
	}
	return FReply::Unhandled();
}

FReply STimelinesContainer::OnMouseButtonUp(const FGeometry& MyGeometry, const FPointerEvent& MouseEvent)
{
	if (MouseEvent.GetEffectingButton() != EKeys::LeftMouseButton)
	{
		return TimeSliderController->OnMouseButtonUp(*this, MyGeometry, MouseEvent);
	}
	return FReply::Unhandled();
}

FReply STimelinesContainer::OnMouseMove(const FGeometry& MyGeometry, const FPointerEvent& MouseEvent)
{
	if (MouseEvent.GetEffectingButton() != EKeys::LeftMouseButton)
	{
		return TimeSliderController->OnMouseMove(*this, MyGeometry, MouseEvent);
	}
	return FReply::Unhandled();
}

FReply STimelinesContainer::OnMouseWheel(const FGeometry& MyGeometry, const FPointerEvent& MouseEvent)
{
	if (MouseEvent.IsLeftControlDown() || MouseEvent.IsLeftShiftDown())
	{
		return TimeSliderController->OnMouseWheel(*this, MyGeometry, MouseEvent);
	}
	return FReply::Unhandled();
}

FReply STimelinesContainer::OnKeyDown(const FGeometry& MyGeometry, const FKeyEvent& InKeyEvent)
{
	if (InKeyEvent.GetKey() == EKeys::A && InKeyEvent.IsLeftControlDown())
	{
		for (TSharedPtr<STimeline>& Timeline : TimelineItems)
		{
			SetSelectionState(Timeline, true, false);
		}

		return FReply::Handled();
	}
	else if (InKeyEvent.GetKey() == EKeys::Platform_Delete && CachedSelectedTimelines.Num() > 0)
	{
		TWeakPtr<STimeline>  NotSelectedOne;
		for (TSharedPtr<STimeline>& CurrentNode : CachedSelectedTimelines)
		{
			TSharedPtr<STimeline> LastSelected = CachedSelectedTimelines[CachedSelectedTimelines.Num() - 1];
			bool bFoundSelectedOne = false;

			for (TSharedPtr<STimeline>& Timeline : TimelineItems)
			{
				if (IsNodeSelected(Timeline) == false)
				{
					NotSelectedOne = Timeline;
				}
				if (LastSelected == Timeline)
				{
					if (bFoundSelectedOne && NotSelectedOne.IsValid())
					{
						break;
					}
					bFoundSelectedOne = true;
				}
			}
			FVisualLoggerDatabase::Get().RemoveRow(CurrentNode->GetName());
			TimelineItems.Remove(CurrentNode);
			ContainingBorder->RemoveSlot(CurrentNode.ToSharedRef());
		}

		SetSelectionState(NotSelectedOne.Pin(), true, true);
		return FReply::Handled();
	}
	else if (InKeyEvent.GetKey() == EKeys::Up || InKeyEvent.GetKey() == EKeys::Down)
	{
		TSharedPtr<STimeline> PreviousTimeline;
		TSharedPtr<STimeline> LastSelected = CachedSelectedTimelines[CachedSelectedTimelines.Num() - 1];
		for (int32 Index = 0; Index < TimelineItems.Num(); ++Index)
		{
			auto& CurrentItem = TimelineItems[Index];
			if (LastSelected == CurrentItem)
			{
				if (InKeyEvent.GetKey() == EKeys::Up && PreviousTimeline.IsValid())
				{
					SetSelectionState(PreviousTimeline, true, true);
				}
				else if (InKeyEvent.GetKey() == EKeys::Down)
				{
					// let's find next visible time line
					if (TimelineItems.IsValidIndex(Index + 1))
					{
						for (int32 i = Index + 1; i < TimelineItems.Num(); ++i)
						{
							if (TimelineItems[i]->GetVisibility() == EVisibility::Visible)
							{
								SetSelectionState(TimelineItems[i], true, true);
								break;
							}
						}
					}
				}
				break;
			}

			if (CurrentItem->GetVisibility() == EVisibility::Visible)
			{
				PreviousTimeline = CurrentItem;
			}
		}
		return FReply::Handled();
	}

	return FReply::Unhandled();
}

void STimelinesContainer::ResetData()
{
	for (TSharedPtr<STimeline>& Timeline : TimelineItems)
	{
		ContainingBorder->RemoveSlot(Timeline.ToSharedRef());
		Timeline.Reset();
	}
	TimelineItems.Reset();

	for (auto& CurrentItem : CachedSelectedTimelines)
	{
		CurrentItem.Reset();
	}
	CachedSelectedTimelines.Reset();

	CachedMinTime = FLT_MAX;
	CachedMaxTime = 0;
	TimeSliderController->SetClampRange(0, 5);
	TimeSliderController->SetTimeRange(0, 5);
}

void STimelinesContainer::Construct(const FArguments& InArgs, TSharedRef<SVisualLoggerView> InVisualLoggerView, TSharedRef<FVisualLoggerTimeSliderController> InTimeSliderController)
{
	TimeSliderController = InTimeSliderController;
	VisualLoggerView = InVisualLoggerView;

	ChildSlot
		[
			SNew(SBorder)
			.Padding(0)
			.VAlign(VAlign_Top)
			.BorderImage(FLogVisualizerStyle::Get().GetBrush("ToolPanel.GroupBorder"))
			[
				SAssignNew(ContainingBorder, SVerticalBox)
			]
		];

	CachedMinTime = FLT_MAX;
	CachedMaxTime = 0;

	FVisualLoggerDatabase::Get().GetEvents().OnNewRow.AddRaw(this, &STimelinesContainer::OnNewRowHandler);
	FVisualLoggerDatabase::Get().GetEvents().OnNewItem.AddRaw(this, &STimelinesContainer::OnNewItemHandler);
	FVisualLoggerDatabase::Get().GetEvents().OnRowSelectionChanged.AddRaw(this, &STimelinesContainer::OnObjectSelectionChanged);
	FVisualLoggerDatabase::Get().GetEvents().OnRowChangedVisibility.AddRaw(this, &STimelinesContainer::OnRowChangedVisibility);
}

STimelinesContainer::~STimelinesContainer()
{
	FVisualLoggerDatabase::Get().GetEvents().OnNewRow.RemoveAll(this);
	FVisualLoggerDatabase::Get().GetEvents().OnNewItem.RemoveAll(this);
	FVisualLoggerDatabase::Get().GetEvents().OnRowSelectionChanged.RemoveAll(this);
	FVisualLoggerDatabase::Get().GetEvents().OnRowChangedVisibility.RemoveAll(this);
}

void STimelinesContainer::OnNewRowHandler(const FVisualLoggerDBRow& DBRow)
{
	TSharedPtr<STimeline> NewTimeline;

	ContainingBorder->AddSlot()
		[
			SAssignNew(NewTimeline, STimeline, TimeSliderController, SharedThis(this), DBRow.GetOwnerName(), DBRow.GetOwnerClassName())
			.OnGetMenuContent(this, &STimelinesContainer::GetRightClickMenuContent)
		];

	TimelineItems.Add(NewTimeline.ToSharedRef());
	// make sure the new entry doesn't show if it doesn't match CurrentSearchText
	NewTimeline->OnSearchChanged(CurrentSearchText);
}

void STimelinesContainer::OnNewItemHandler(const FVisualLoggerDBRow& BDRow, int32 ItemIndex)
{
	const FVisualLogDevice::FVisualLogEntryItem& Entry = BDRow.GetItems()[ItemIndex];
	CachedMinTime = CachedMinTime < Entry.Entry.TimeStamp ? CachedMinTime : Entry.Entry.TimeStamp;
	CachedMaxTime = CachedMaxTime > Entry.Entry.TimeStamp ? CachedMaxTime : Entry.Entry.TimeStamp;

	TRange<float> LocalViewRange = TimeSliderController->GetTimeSliderArgs().ViewRange.Get();
	TRange<float> ClampRange = TimeSliderController->GetTimeSliderArgs().ClampRange.Get();
	float ZoomLevel = LocalViewRange.Size<float>() / ClampRange.Size<float>();

	TimeSliderController->GetTimeSliderArgs().ClampRange = TRange<float>(CachedMinTime, CachedMaxTime + 0.1f);
	//if ( FMath::Abs(ZoomLevel - 1) <= SMALL_NUMBER)
	//{
		TimeSliderController->GetTimeSliderArgs().ViewRange = TimeSliderController->GetTimeSliderArgs().ClampRange;
	//}
}

void STimelinesContainer::OnSearchChanged(const FText& Filter)
{
	CurrentSearchText = Filter;
	for (TSharedPtr<STimeline>& Timeline : TimelineItems)
	{
		Timeline->OnSearchChanged(Filter);
	}
}

void STimelinesContainer::OnFiltersChanged()
{
	for (TSharedPtr<STimeline>& Timeline : TimelineItems)
	{
		Timeline->OnFiltersChanged();
	}
}

void STimelinesContainer::OnFiltersSearchChanged(const FText& Filter)
{
	for (TSharedPtr<STimeline>& Timeline : TimelineItems)
	{
		Timeline->OnFiltersSearchChanged(Filter);
	}
}

void STimelinesContainer::GenerateReport()
{
	TSharedRef<SWindow> NewWindow = SNew(SWindow)
		.ClientSize(FVector2D(720, 768))
		.Title(NSLOCTEXT("LogVisualizerReport", "WindowTitle", "Log Visualizer Report"))
		[
			SNew(SVisualLoggerReport, CachedSelectedTimelines, VisualLoggerView)
		];

	FSlateApplication::Get().AddWindow(NewWindow);
}


void STimelinesContainer::OnRowChangedVisibility(const FName& InName)
{
	for (TSharedPtr<STimeline>& Timeline : TimelineItems)
	{
		if (InName == Timeline->GetName())
		{
			Timeline->SetVisibility(FVisualLoggerDatabase::Get().IsRowVisible(InName) ? EVisibility::Visible : EVisibility::Collapsed);
			break;
		}
	}
	
}

#undef LOCTEXT_NAMESPACE
