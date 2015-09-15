// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.
#pragma once

#include "K2Node_BaseMCDelegate.h"
#include "K2Node_ClearDelegate.generated.h"

UCLASS(MinimalAPI)
class UK2Node_ClearDelegate : public UK2Node_BaseMCDelegate
{
	GENERATED_UCLASS_BODY()

public:
	// UEdGraphNode interface
	virtual FText GetNodeTitle(ENodeTitleType::Type TitleType) const override;
	//~ End of UEdGraphNode Interface

	//~ Begin of UK2Node Interface
	virtual class FNodeHandlingFunctor* CreateNodeHandler(class FKismetCompilerContext& CompilerContext) const override;
	//~ End of UK2Node Interface
};
