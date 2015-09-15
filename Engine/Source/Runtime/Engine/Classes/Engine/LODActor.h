// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

#pragma once
#include "LODActor.generated.h"

/**
 * LODActor is an instance of an autogenerated StaticMesh Actors by Hierarchical LOD System
 * This is essentially just StaticMeshActor that you can't move or edit, but it contains multiple actors reference
 *
 * @see https://docs.unrealengine.com/latest/INT/Engine/Actors/LODActor/
 * @see UStaticMesh
 */
UCLASS(notplaceable, hidecategories=(Object, Collision, Display, Input, Blueprint, Transform))
class ENGINE_API ALODActor : public AActor
{
	GENERATED_UCLASS_BODY()

private_subobject:
	// disable display of this component
	UPROPERTY(/*Category=LODActor, VisibleAnywhere*/)
	class UStaticMeshComponent* StaticMeshComponent;

public:
	UPROPERTY(Category=LODActor, VisibleAnywhere)
	TArray<class AActor*> SubActors;

	/** what distance do you want this to show up instead of SubActors */
	UPROPERTY(Category=LODActor, EditAnywhere, meta=(ClampMin = "0", UIMin = "0"))
	float LODDrawDistance;
	
	/** what distance do you want this to show up instead of SubActors */
	UPROPERTY(Category=LODActor, VisibleAnywhere)
	int32 LODLevel;

	/** assets that were created for this, so that we can delete them */
	UPROPERTY(Category=LODActor, VisibleAnywhere)
	TArray<class UObject*> SubObjects;

#if WITH_EDITOR
	//~ Begin AActor Interface
	virtual void CheckForErrors() override;
	virtual bool GetReferencedContentObjects( TArray<UObject*>& Objects ) const override;
	//~ End AActor Interface
#endif // WITH_EDITOR	

	/** Sets StaticMesh and IsPreviewActor to true if InStaticMesh equals nullptr */
	void SetStaticMesh(class UStaticMesh* InStaticMesh);
	
	/** Returns whether or not this is a preview actor instance, meaning it has no StaticMesh */
	const bool IsPreviewActorInstance() { return bIsPreviewActor;  }
	
protected:
	//~ Begin UObject Interface.
	virtual FString GetDetailedInfoInternal() const override;
	virtual FBox GetComponentsBoundingBox(bool bNonColliding = false) const override;	
#if WITH_EDITOR
	virtual void PostEditChangeProperty(FPropertyChangedEvent& PropertyChangedEvent) override;
	virtual void EditorApplyTranslation(const FVector& DeltaTranslation, bool bAltDown, bool bShiftDown, bool bCtrlDown) override;
	virtual void EditorApplyRotation(const FRotator& DeltaRotation, bool bAltDown, bool bShiftDown, bool bCtrlDown) override;
	virtual void EditorApplyScale(const FVector& DeltaScale, const FVector* PivotLocation, bool bAltDown, bool bShiftDown, bool bCtrlDown) override;
	virtual void EditorApplyMirror(const FVector& MirrorScale, const FVector& PivotLocation) override;
#endif // WITH_EDITOR	
	virtual void PostRegisterAllComponents() override;
	//~ End UObject Interface.
		
protected:
#if WITH_EDITORONLY_DATA
	/** Visualization component for rendering the LODActors bounds (cluster bounds)*/
	UPROPERTY()
	class UDrawSphereComponent* DrawSphereComponent;
#endif // WITH_EDITORONLY_DATA

	/** Whether or not this is a preview actor, will not fire StaticMesh map errors if so*/
	bool bIsPreviewActor;

public:
	/** Returns StaticMeshComponent subobject **/
	class UStaticMeshComponent* GetStaticMeshComponent() const { return StaticMeshComponent; }

#if WITH_EDITORONLY_DATA
	/** Returns StaticMeshComponent subobject **/
	class UDrawSphereComponent* GetDrawSphereComponent() const { return DrawSphereComponent; }
#endif // WITH_EDITORONLY_DATA
}; 
