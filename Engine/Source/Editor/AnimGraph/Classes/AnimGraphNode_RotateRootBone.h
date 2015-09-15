// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.


#pragma once
#include "AnimGraphNode_Base.h"
#include "Animation/AnimNode_RotateRootBone.h"
#include "AnimGraphNode_RotateRootBone.generated.h"

UCLASS(MinimalAPI)
class UAnimGraphNode_RotateRootBone : public UAnimGraphNode_Base
{
	GENERATED_UCLASS_BODY()

	UPROPERTY(EditAnywhere, Category=Settings)
	FAnimNode_RotateRootBone Node;

	//~ Begin UEdGraphNode Interface.
	virtual FLinearColor GetNodeTitleColor() const override;
	virtual FText GetTooltipText() const override;
	virtual FText GetNodeTitle(ENodeTitleType::Type TitleType) const override;
	//~ End UEdGraphNode Interface.

	// UAnimGraphNode_Base interface
	virtual FString GetNodeCategory() const override;
	//~ End of UAnimGraphNode_Base Interface
};
