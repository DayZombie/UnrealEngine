﻿// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

#pragma once

#include "RetainerBox.generated.h"

/**
 * The Retainer Box renders children widgets to a render target first before
 * later rendering that render target to the screen.  This allows both frequency
 * and phase to be controlled so that the UI can actually render less often than the
 * frequency of the main game render.  It also has the side benefit of allow materials
 * to be applied to the render target after drawing the widgets to apply a simple post process.
 *
 * * Single Child
 * * Caching / Performance
 */
UCLASS()
class UMG_API URetainerBox : public UContentWidget
{
	GENERATED_UCLASS_BODY()

public:
	/**
	 * The Phase this widget will draw on.
	 *
	 * If the Phase is 0, and the PhaseCount is 1, the widget will be drawn fresh every frame.
	 * If the Phase were 0, and the PhaseCount were 2, this retainer would draw a fresh frame every
	 * other frame.  So in a 60Hz game, the UI would render at 30Hz.
	 */
	UPROPERTY(EditAnywhere, Category="Phasing", meta=( UIMin=0, ClampMin=0 ))
	int32 Phase;

	/**
	 * The PhaseCount controls how many phases are possible know what to modulus the current frame 
	 * count by to determine if this is the current frame to draw the widget on.
	 * 
	 * If the Phase is 0, and the PhaseCount is 1, the widget will be drawn fresh every frame.  
	 * If the Phase were 0, and the PhaseCount were 2, this retainer would draw a fresh frame every 
	 * other frame.  So in a 60Hz game, the UI would render at 30Hz.
	 */
	UPROPERTY(EditAnywhere, Category="Phasing", meta=( UIMin=1, ClampMin=1 ))
	int32 PhaseCount;

public:

	/**
	 * Get the current dynamic effect material applied to the retainer box.
	 */
	UFUNCTION(BlueprintCallable, Category="Retainer|Effect")
	UMaterialInstanceDynamic* GetEffectMaterial() const;

	/**
	 * Set a new effect material to the retainer widget.
	 */
	UFUNCTION(BlueprintCallable, Category="Retainer|Effect")
	void SetEffectMaterial(UMaterialInterface* EffectMaterial);

	/**
	 * Sets the name of the texture parameter to set the render target to on the material.
	 */
	UFUNCTION(BlueprintCallable, Category="Retainer|Effect")
	void SetTextureParameter(FName TextureParameter);

	virtual void ReleaseSlateResources(bool bReleaseChildren) override;

#if WITH_EDITOR
	virtual const FSlateBrush* GetEditorIcon() override;
	virtual const FText GetPaletteCategory() override;
#endif

protected:

	/**
	 * The effect to optionally apply to the render target.  We will set the texture sampler based on the name
	 * set in the @TextureParameter property.
	 */
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category="Effect")
	UMaterialInterface* EffectMaterial;

	/**
	 * The texture sampler parameter of the @EffectMaterial, that we'll set to the render target.
	 */
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category="Effect")
	FName TextureParameter;

	// UPanelWidget
	virtual void OnSlotAdded(UPanelSlot* Slot) override;
	virtual void OnSlotRemoved(UPanelSlot* Slot) override;
	// End UPanelWidget

	// UWidget interface
	virtual TSharedRef<SWidget> RebuildWidget() override;
	virtual void SynchronizeProperties() override;
	// End of UWidget interface

protected:
	TSharedPtr<class SRetainerWidget> MyRetainerWidget;
};
