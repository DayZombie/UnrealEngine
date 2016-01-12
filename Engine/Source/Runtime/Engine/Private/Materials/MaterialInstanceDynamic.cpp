// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

/*==============================================================================
	MaterialInstanceDynamic.cpp: MaterialInstanceDynamic implementation.
==============================================================================*/

#include "EnginePrivate.h"
#include "MaterialInstanceSupport.h"

UMaterialInstanceDynamic::UMaterialInstanceDynamic(const FObjectInitializer& ObjectInitializer)
	: Super(ObjectInitializer)
{
}

UMaterialInstanceDynamic* UMaterialInstanceDynamic::Create(UMaterialInterface* ParentMaterial, UObject* InOuter)
{
	UObject* Outer = InOuter ? InOuter : GetTransientPackage();
	UMaterialInstanceDynamic* MID = NewObject<UMaterialInstanceDynamic>(Outer);
	MID->SetParentInternal(ParentMaterial, false);
	return MID;
}

void UMaterialInstanceDynamic::SetVectorParameterValue(FName ParameterName, FLinearColor Value)
{
	SetVectorParameterValueInternal(ParameterName,Value);
}

FLinearColor UMaterialInstanceDynamic::K2_GetVectorParameterValue(FName ParameterName)
{
	FLinearColor Result(0,0,0);
	Super::GetVectorParameterValue(ParameterName, Result);
	return Result;
}

void UMaterialInstanceDynamic::SetScalarParameterValue(FName ParameterName, float Value)
{
	SetScalarParameterValueInternal(ParameterName,Value);
}

float UMaterialInstanceDynamic::K2_GetScalarParameterValue(FName ParameterName)
{
	float Result = 0.f;
	Super::GetScalarParameterValue(ParameterName, Result);
	return Result;
}

void UMaterialInstanceDynamic::SetTextureParameterValue(FName ParameterName, UTexture* Value)
{
	SetTextureParameterValueInternal(ParameterName,Value);
}

UTexture* UMaterialInstanceDynamic::K2_GetTextureParameterValue(FName ParameterName)
{
	UTexture* Result = NULL;
	Super::GetTextureParameterValue(ParameterName, Result);
	return Result;
}

void UMaterialInstanceDynamic::SetFontParameterValue(FName ParameterName,class UFont* FontValue,int32 FontPage)
{
	SetFontParameterValueInternal(ParameterName,FontValue,FontPage);
}

void UMaterialInstanceDynamic::ClearParameterValues()
{
	ClearParameterValuesInternal();
}


// could be optimized but surely faster than GetAllVectorParameterNames()
void GameThread_FindAllScalarParameterNames(UMaterialInstance* MaterialInstance, TArray<FName>& InOutNames)
{
	while(MaterialInstance)
	{
		for(int32 i = 0, Num = MaterialInstance->ScalarParameterValues.Num(); i < Num; ++i)
		{
			InOutNames.AddUnique(MaterialInstance->ScalarParameterValues[i].ParameterName);
		}

		MaterialInstance = Cast<UMaterialInstance>(MaterialInstance->Parent);
	}
}

// could be optimized but surely faster than GetAllVectorParameterNames()
void GameThread_FindAllVectorParameterNames(UMaterialInstance* MaterialInstance, TArray<FName>& InOutNames)
{
	while(MaterialInstance)
	{
		for(int32 i = 0, Num = MaterialInstance->VectorParameterValues.Num(); i < Num; ++i)
		{
			InOutNames.AddUnique(MaterialInstance->VectorParameterValues[i].ParameterName);
		}

		MaterialInstance = Cast<UMaterialInstance>(MaterialInstance->Parent);
	}
}

// Finds a parameter by name from the game thread, traversing the chain up to the BaseMaterial.
FScalarParameterValue* GameThread_GetScalarParameterValue(UMaterialInstance* MaterialInstance, FName Name)
{
	UMaterialInterface* It = 0;

	while(MaterialInstance)
	{
		if(FScalarParameterValue* Ret = GameThread_FindParameterByName(MaterialInstance->ScalarParameterValues, Name))
		{
			return Ret;
		}

		It = MaterialInstance->Parent;
		MaterialInstance = Cast<UMaterialInstance>(It);
	}

	return 0;
}

// Finds a parameter by name from the game thread, traversing the chain up to the BaseMaterial.
FVectorParameterValue* GameThread_GetVectorParameterValue(UMaterialInstance* MaterialInstance, FName Name)
{
	UMaterialInterface* It = 0;

	while(MaterialInstance)
	{
		if(FVectorParameterValue* Ret = GameThread_FindParameterByName(MaterialInstance->VectorParameterValues, Name))
		{
			return Ret;
		}

		It = MaterialInstance->Parent;
		MaterialInstance = Cast<UMaterialInstance>(It);
	}

	return 0;
}

void UMaterialInstanceDynamic::K2_InterpolateMaterialInstanceParams(UMaterialInstance* SourceA, UMaterialInstance* SourceB, float Alpha)
{
	if(SourceA && SourceB)
	{
		UMaterial* BaseA = SourceA->GetBaseMaterial();
		UMaterial* BaseB = SourceB->GetBaseMaterial();

		if(BaseA == BaseB)
		{
			// todo: can be optimized, at least we can reserve
			TArray<FName> Names;

			GameThread_FindAllScalarParameterNames(SourceA, Names);
			GameThread_FindAllScalarParameterNames(SourceB, Names);

			// Interpolate the scalar parameters common to both materials
			for(int32 Idx = 0, Count = Names.Num(); Idx < Count; ++Idx)
			{
				FName Name = Names[Idx];

				auto ParamValueA = GameThread_GetScalarParameterValue(SourceA, Name);
				auto ParamValueB = GameThread_GetScalarParameterValue(SourceB, Name);

				if(ParamValueA || ParamValueB)
				{
					auto Default = 0.0f;

					if(!ParamValueA || !ParamValueB)
					{
						BaseA->GetScalarParameterValue(Name, Default);
					}

					auto ValueA = ParamValueA ? ParamValueA->ParameterValue : Default;
					auto ValueB = ParamValueB ? ParamValueB->ParameterValue : Default;

					SetScalarParameterValue(Name, FMath::Lerp(ValueA, ValueB, Alpha));
				}
			}

			// reused array to minimize further allocations
			Names.Empty();
			GameThread_FindAllVectorParameterNames(SourceA, Names);
			GameThread_FindAllVectorParameterNames(SourceB, Names);

			// Interpolate the vector parameters common to both
			for(int32 Idx = 0, Count = Names.Num(); Idx < Count; ++Idx)
			{
				FName Name = Names[Idx];

				auto ParamValueA = GameThread_GetVectorParameterValue(SourceA, Name);
				auto ParamValueB = GameThread_GetVectorParameterValue(SourceB, Name);

				if(ParamValueA || ParamValueB)
				{
					auto Default = FLinearColor(EForceInit::ForceInit);

					if(!ParamValueA || !ParamValueB)
					{
						BaseA->GetVectorParameterValue(Name, Default);
					}

					auto ValueA = ParamValueA ? ParamValueA->ParameterValue : Default;
					auto ValueB = ParamValueB ? ParamValueB->ParameterValue : Default;

					SetVectorParameterValue(Name, FMath::Lerp(ValueA, ValueB, Alpha));
				}
			}
		}
		else
		{
			// to find bad usage of this method
			// Maybe we can log a content error instead
			// ensure(BaseA == BaseB);
		}
	}
}

void UMaterialInstanceDynamic::K2_CopyMaterialInstanceParameters(UMaterialInterface* Source)
{
	CopyMaterialInstanceParameters(Source);
}

void UMaterialInstanceDynamic::CopyInterpParameters(UMaterialInstance* Source)
{
	// we might expose as blueprint function so we have the input a pointer instead of a reference
	if(Source)
	{
		// copy the array and update the renderer data structures

		for (auto& it : Source->ScalarParameterValues)
		{
			SetScalarParameterValue(it.ParameterName, it.ParameterValue);
		}

		for (auto& it : Source->VectorParameterValues)
		{
			SetVectorParameterValue(it.ParameterName, it.ParameterValue);
		}

		// the other parameters don't interpolate but if we expose this to blueprints we could copy them for consistency
	}
}

void UMaterialInstanceDynamic::CopyParameterOverrides(UMaterialInstance* MaterialInstance)
{
	ClearParameterValues();
	VectorParameterValues = MaterialInstance->VectorParameterValues;
	ScalarParameterValues = MaterialInstance->ScalarParameterValues;
	TextureParameterValues = MaterialInstance->TextureParameterValues;
	FontParameterValues = MaterialInstance->FontParameterValues;
	InitResources();
}
