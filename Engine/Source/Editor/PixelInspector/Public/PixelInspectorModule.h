// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

#include "ModuleInterface.h"
#include "UnrealEd.h"


namespace PixelInspector { class SPixelInspector; };

/**
* The module holding all of the UI related pieces for pixel inspector
*/
class FPixelInspectorModule : public IModuleInterface
{
public:
	/**
	* Called right after the module DLL has been loaded and the module object has been created
	*/
	virtual void StartupModule();

	/**
	* Called before the module is unloaded, right before the module object is destroyed.
	*/
	virtual void ShutdownModule();

	/** Creates the HLOD Outliner widget */
	virtual TSharedRef<SWidget> CreatePixelInspectorWidget();

	virtual bool IsPixelInspectorEnable();

	virtual bool GetViewportRealtime(int32 ViewportUid, bool IsCurrentlyRealtime, bool IsMouseInsideViewport);

	virtual void CreatePixelInspectorRequest(FIntPoint ScreenPosition, int32 viewportUniqueId, FSceneInterface *SceneInterface);

	virtual void ReadBackSync();

	virtual void RegisterTabSpawner(const TSharedPtr<FWorkspaceItem>& WorkspaceGroup);

	virtual void UnregisterTabSpawner();

private:
	TSharedRef<SDockTab> MakePixelInspectorTab(const FSpawnTabArgs&);

	bool bHasRegisteredTabSpawners;
	TSharedPtr<PixelInspector::SPixelInspector> HPixelInspectorWindow;

	TMap<uint32, bool> OriginalViewportStates;
};