// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

#pragma once
#include "K2Node_GameplayCueEvent.generated.h"


UCLASS()
class UK2Node_GameplayCueEvent : public UK2Node_Event
{
	GENERATED_UCLASS_BODY()

	// UObject interface
	virtual void Serialize(FArchive& Ar) override;
	//~ End of UObject Interface

	//~ Begin UEdGraphNode Interface
	virtual FText GetTooltipText() const override;
	virtual FText GetNodeTitle(ENodeTitleType::Type TitleType) const override;
	virtual bool IsCompatibleWithGraph(const UEdGraph* TargetGraph) const override;
	//~ End UEdGraphNode Interface
	
	//~ Begin UK2Node Interface
	virtual void GetMenuActions(FBlueprintActionDatabaseRegistrar& ActionRegistrar) const override;
	//~ End UK2Node Interface
};