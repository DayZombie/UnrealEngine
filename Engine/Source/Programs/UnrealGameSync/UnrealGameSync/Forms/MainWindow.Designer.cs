﻿// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

namespace UnrealGameSync
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.label1 = new System.Windows.Forms.Label();
			this.ProjectList = new System.Windows.Forms.ComboBox();
			this.BrowseProject = new System.Windows.Forms.Button();
			this.OptionsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.OptionsContextMenu_ScheduledSync = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_SyncPrecompiledEditor = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_AutoResolveConflicts = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_SyncFilter = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.OptionsContextMenu_EditorBuildConfiguration = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_BuildConfig_Debug = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_BuildConfig_DebugGame = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_BuildConfig_Development = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_UseIncrementalBuilds = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_CustomizeBuildSteps = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.OptionsContextMenu_EditorArguments = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_TimeZone = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_TimeZone_Local = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_TimeZone_PerforceServer = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_AutomaticallyRunAtStartup = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu_KeepInTray = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.OptionsContextMenu_Diagnostics = new System.Windows.Forms.ToolStripMenuItem();
			this.OnlyShowReviewedCheckBox = new System.Windows.Forms.CheckBox();
			this.RunAfterSyncCheckBox = new System.Windows.Forms.CheckBox();
			this.BuildAfterSyncCheckBox = new System.Windows.Forms.CheckBox();
			this.AfterSyncingLabel = new System.Windows.Forms.Label();
			this.BuildListContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.BuildListContextMenu_LaunchEditor = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_Sync = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_SyncContentOnly = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_SyncOnlyThisChange = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_Build = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_Rebuild = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_GenerateProjectFiles = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_Cancel = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_OpenVisualStudio = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.BuildListContextMenu_MarkGood = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_MarkBad = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_WithdrawReview = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_LeaveComment = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_EditComment = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_StartInvestigating = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_FinishInvestigating = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.BuildListContextMenu_AddStar = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_RemoveStar = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_TimeZoneSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.BuildListContextMenu_ShowServerTimes = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListContextMenu_ShowLocalTimes = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.BuildListContextMenu_MoreInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.NotifyMenu_OpenUnrealGameSync = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.NotifyMenu_SyncNow = new System.Windows.Forms.ToolStripMenuItem();
			this.NotifyMenu_LaunchEditor = new System.Windows.Forms.ToolStripMenuItem();
			this.NotifyMenu_ExitSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.NotifyMenu_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.BuildListToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.OpenSolutionAfterSyncCheckBox = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.OptionsButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Splitter = new UnrealGameSync.LogSplitContainer();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.StatusPanel = new UnrealGameSync.StatusPanel();
			this.BuildList = new UnrealGameSync.BuildListControl();
			this.IconColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ChangeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AuthorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CISColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1 = new System.Windows.Forms.Panel();
			this.SyncLog = new UnrealGameSync.LogControl();
			this.MoreToolsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.MoreActionsContextMenu_CustomToolSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.MoreToolsContextMenu_CleanWorkspace = new System.Windows.Forms.ToolStripMenuItem();
			this.SyncContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SyncContextMenu_LatestChange = new System.Windows.Forms.ToolStripMenuItem();
			this.SyncContextMenu_LatestGoodChange = new System.Windows.Forms.ToolStripMenuItem();
			this.SyncContextMenu_LatestStarredChange = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.SyncContexMenu_EnterChangelist = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsContextMenu.SuspendLayout();
			this.BuildListContextMenu.SuspendLayout();
			this.NotifyMenu.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
			this.Splitter.Panel1.SuspendLayout();
			this.Splitter.Panel2.SuspendLayout();
			this.Splitter.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.MoreToolsContextMenu.SuspendLayout();
			this.SyncContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Project:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ProjectList
			// 
			this.ProjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ProjectList.FormattingEnabled = true;
			this.ProjectList.Location = new System.Drawing.Point(54, 4);
			this.ProjectList.Name = "ProjectList";
			this.ProjectList.Size = new System.Drawing.Size(1059, 21);
			this.ProjectList.TabIndex = 1;
			this.ProjectList.SelectionChangeCommitted += new System.EventHandler(this.ProjectList_SelectionChangeCommitted);
			this.ProjectList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProjectList_KeyDown);
			// 
			// BrowseProject
			// 
			this.BrowseProject.AutoSize = true;
			this.BrowseProject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BrowseProject.Location = new System.Drawing.Point(1119, 3);
			this.BrowseProject.Name = "BrowseProject";
			this.BrowseProject.Size = new System.Drawing.Size(34, 23);
			this.BrowseProject.TabIndex = 2;
			this.BrowseProject.Text = "...";
			this.BrowseProject.UseVisualStyleBackColor = true;
			this.BrowseProject.Click += new System.EventHandler(this.BrowseProject_Click);
			// 
			// OptionsContextMenu
			// 
			this.OptionsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsContextMenu_ScheduledSync,
            this.OptionsContextMenu_SyncPrecompiledEditor,
            this.OptionsContextMenu_AutoResolveConflicts,
            this.OptionsContextMenu_SyncFilter,
            this.toolStripSeparator3,
            this.OptionsContextMenu_EditorBuildConfiguration,
            this.OptionsContextMenu_UseIncrementalBuilds,
            this.OptionsContextMenu_CustomizeBuildSteps,
            this.toolStripSeparator5,
            this.OptionsContextMenu_EditorArguments,
            this.OptionsContextMenu_TimeZone,
            this.OptionsContextMenu_AutomaticallyRunAtStartup,
            this.OptionsContextMenu_KeepInTray,
            this.toolStripSeparator6,
            this.OptionsContextMenu_Diagnostics});
			this.OptionsContextMenu.Name = "ToolsMenuStrip";
			this.OptionsContextMenu.Size = new System.Drawing.Size(268, 308);
			// 
			// OptionsContextMenu_ScheduledSync
			// 
			this.OptionsContextMenu_ScheduledSync.Name = "OptionsContextMenu_ScheduledSync";
			this.OptionsContextMenu_ScheduledSync.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_ScheduledSync.Text = "Scheduled Sync...";
			this.OptionsContextMenu_ScheduledSync.Click += new System.EventHandler(this.OptionsContextMenu_ScheduleSync_Click);
			// 
			// OptionsContextMenu_SyncPrecompiledEditor
			// 
			this.OptionsContextMenu_SyncPrecompiledEditor.Name = "OptionsContextMenu_SyncPrecompiledEditor";
			this.OptionsContextMenu_SyncPrecompiledEditor.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_SyncPrecompiledEditor.Text = "Sync Precompiled Editor";
			this.OptionsContextMenu_SyncPrecompiledEditor.Click += new System.EventHandler(this.OptionsContextMenu_SyncPrecompiledEditor_Click);
			// 
			// OptionsContextMenu_AutoResolveConflicts
			// 
			this.OptionsContextMenu_AutoResolveConflicts.Name = "OptionsContextMenu_AutoResolveConflicts";
			this.OptionsContextMenu_AutoResolveConflicts.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_AutoResolveConflicts.Text = "Auto-Resolve Conflicts";
			this.OptionsContextMenu_AutoResolveConflicts.Click += new System.EventHandler(this.OptionsContextMenu_AutoResolveConflicts_Click);
			// 
			// OptionsContextMenu_SyncFilter
			// 
			this.OptionsContextMenu_SyncFilter.Name = "OptionsContextMenu_SyncFilter";
			this.OptionsContextMenu_SyncFilter.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_SyncFilter.Text = "Sync Filter...";
			this.OptionsContextMenu_SyncFilter.Click += new System.EventHandler(this.OptionsContextMenu_SyncFilter_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(264, 6);
			// 
			// OptionsContextMenu_EditorBuildConfiguration
			// 
			this.OptionsContextMenu_EditorBuildConfiguration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsContextMenu_BuildConfig_Debug,
            this.OptionsContextMenu_BuildConfig_DebugGame,
            this.OptionsContextMenu_BuildConfig_Development});
			this.OptionsContextMenu_EditorBuildConfiguration.Name = "OptionsContextMenu_EditorBuildConfiguration";
			this.OptionsContextMenu_EditorBuildConfiguration.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_EditorBuildConfiguration.Text = "Editor Build Configuration";
			// 
			// OptionsContextMenu_BuildConfig_Debug
			// 
			this.OptionsContextMenu_BuildConfig_Debug.Name = "OptionsContextMenu_BuildConfig_Debug";
			this.OptionsContextMenu_BuildConfig_Debug.Size = new System.Drawing.Size(145, 22);
			this.OptionsContextMenu_BuildConfig_Debug.Text = "Debug";
			this.OptionsContextMenu_BuildConfig_Debug.Click += new System.EventHandler(this.OptionsContextMenu_BuildConfig_Debug_Click);
			// 
			// OptionsContextMenu_BuildConfig_DebugGame
			// 
			this.OptionsContextMenu_BuildConfig_DebugGame.Name = "OptionsContextMenu_BuildConfig_DebugGame";
			this.OptionsContextMenu_BuildConfig_DebugGame.Size = new System.Drawing.Size(145, 22);
			this.OptionsContextMenu_BuildConfig_DebugGame.Text = "DebugGame";
			this.OptionsContextMenu_BuildConfig_DebugGame.Click += new System.EventHandler(this.OptionsContextMenu_BuildConfig_DebugGame_Click);
			// 
			// OptionsContextMenu_BuildConfig_Development
			// 
			this.OptionsContextMenu_BuildConfig_Development.Checked = true;
			this.OptionsContextMenu_BuildConfig_Development.CheckState = System.Windows.Forms.CheckState.Checked;
			this.OptionsContextMenu_BuildConfig_Development.Name = "OptionsContextMenu_BuildConfig_Development";
			this.OptionsContextMenu_BuildConfig_Development.Size = new System.Drawing.Size(145, 22);
			this.OptionsContextMenu_BuildConfig_Development.Text = "Development";
			this.OptionsContextMenu_BuildConfig_Development.Click += new System.EventHandler(this.OptionsContextMenu_BuildConfig_Development_Click);
			// 
			// OptionsContextMenu_UseIncrementalBuilds
			// 
			this.OptionsContextMenu_UseIncrementalBuilds.Name = "OptionsContextMenu_UseIncrementalBuilds";
			this.OptionsContextMenu_UseIncrementalBuilds.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_UseIncrementalBuilds.Text = "Use Incremental Builds";
			this.OptionsContextMenu_UseIncrementalBuilds.Click += new System.EventHandler(this.OptionsContextMenu_UseIncrementalBuilds_Click);
			// 
			// OptionsContextMenu_CustomizeBuildSteps
			// 
			this.OptionsContextMenu_CustomizeBuildSteps.Name = "OptionsContextMenu_CustomizeBuildSteps";
			this.OptionsContextMenu_CustomizeBuildSteps.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_CustomizeBuildSteps.Text = "Customize Build Steps...";
			this.OptionsContextMenu_CustomizeBuildSteps.Click += new System.EventHandler(this.OptionsContextMenu_EditBuildSteps_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(264, 6);
			// 
			// OptionsContextMenu_EditorArguments
			// 
			this.OptionsContextMenu_EditorArguments.Name = "OptionsContextMenu_EditorArguments";
			this.OptionsContextMenu_EditorArguments.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_EditorArguments.Text = "Editor Command Line Arguments...";
			this.OptionsContextMenu_EditorArguments.Click += new System.EventHandler(this.OptionsContextMenu_EditorArguments_Click);
			// 
			// OptionsContextMenu_TimeZone
			// 
			this.OptionsContextMenu_TimeZone.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsContextMenu_TimeZone_Local,
            this.OptionsContextMenu_TimeZone_PerforceServer});
			this.OptionsContextMenu_TimeZone.Name = "OptionsContextMenu_TimeZone";
			this.OptionsContextMenu_TimeZone.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_TimeZone.Text = "Time Zone";
			// 
			// OptionsContextMenu_TimeZone_Local
			// 
			this.OptionsContextMenu_TimeZone_Local.Name = "OptionsContextMenu_TimeZone_Local";
			this.OptionsContextMenu_TimeZone_Local.Size = new System.Drawing.Size(153, 22);
			this.OptionsContextMenu_TimeZone_Local.Text = "Local";
			this.OptionsContextMenu_TimeZone_Local.Click += new System.EventHandler(this.BuildListContextMenu_ShowLocalTimes_Click);
			// 
			// OptionsContextMenu_TimeZone_PerforceServer
			// 
			this.OptionsContextMenu_TimeZone_PerforceServer.Name = "OptionsContextMenu_TimeZone_PerforceServer";
			this.OptionsContextMenu_TimeZone_PerforceServer.Size = new System.Drawing.Size(153, 22);
			this.OptionsContextMenu_TimeZone_PerforceServer.Text = "Perforce Server";
			this.OptionsContextMenu_TimeZone_PerforceServer.Click += new System.EventHandler(this.BuildListContextMenu_ShowServerTimes_Click);
			// 
			// OptionsContextMenu_AutomaticallyRunAtStartup
			// 
			this.OptionsContextMenu_AutomaticallyRunAtStartup.Name = "OptionsContextMenu_AutomaticallyRunAtStartup";
			this.OptionsContextMenu_AutomaticallyRunAtStartup.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_AutomaticallyRunAtStartup.Text = "Automatically run at startup";
			this.OptionsContextMenu_AutomaticallyRunAtStartup.Click += new System.EventHandler(this.OptionsContextMenu_AutomaticallyRunAtStartup_Click);
			// 
			// OptionsContextMenu_KeepInTray
			// 
			this.OptionsContextMenu_KeepInTray.Name = "OptionsContextMenu_KeepInTray";
			this.OptionsContextMenu_KeepInTray.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_KeepInTray.Text = "Stay in notification area when closed";
			this.OptionsContextMenu_KeepInTray.Click += new System.EventHandler(this.OptionsContextMenu_KeepInTray_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(264, 6);
			// 
			// OptionsContextMenu_Diagnostics
			// 
			this.OptionsContextMenu_Diagnostics.Name = "OptionsContextMenu_Diagnostics";
			this.OptionsContextMenu_Diagnostics.Size = new System.Drawing.Size(267, 22);
			this.OptionsContextMenu_Diagnostics.Text = "Diagnostics...";
			this.OptionsContextMenu_Diagnostics.Click += new System.EventHandler(this.OptionsContextMenu_Diagnostics_Click);
			// 
			// OnlyShowReviewedCheckBox
			// 
			this.OnlyShowReviewedCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.OnlyShowReviewedCheckBox.AutoSize = true;
			this.OnlyShowReviewedCheckBox.Location = new System.Drawing.Point(3, 6);
			this.OnlyShowReviewedCheckBox.Name = "OnlyShowReviewedCheckBox";
			this.OnlyShowReviewedCheckBox.Size = new System.Drawing.Size(166, 17);
			this.OnlyShowReviewedCheckBox.TabIndex = 3;
			this.OnlyShowReviewedCheckBox.Text = "Only show reviewed changes";
			this.OnlyShowReviewedCheckBox.UseVisualStyleBackColor = true;
			this.OnlyShowReviewedCheckBox.CheckedChanged += new System.EventHandler(this.OnlyShowReviewedCheckBox_CheckedChanged);
			// 
			// RunAfterSyncCheckBox
			// 
			this.RunAfterSyncCheckBox.AutoSize = true;
			this.RunAfterSyncCheckBox.Location = new System.Drawing.Point(138, 3);
			this.RunAfterSyncCheckBox.Name = "RunAfterSyncCheckBox";
			this.RunAfterSyncCheckBox.Size = new System.Drawing.Size(45, 17);
			this.RunAfterSyncCheckBox.TabIndex = 6;
			this.RunAfterSyncCheckBox.Text = "Run";
			this.RunAfterSyncCheckBox.UseVisualStyleBackColor = true;
			this.RunAfterSyncCheckBox.CheckedChanged += new System.EventHandler(this.RunAfterSyncCheckBox_CheckedChanged);
			// 
			// BuildAfterSyncCheckBox
			// 
			this.BuildAfterSyncCheckBox.AutoSize = true;
			this.BuildAfterSyncCheckBox.Location = new System.Drawing.Point(84, 3);
			this.BuildAfterSyncCheckBox.Name = "BuildAfterSyncCheckBox";
			this.BuildAfterSyncCheckBox.Size = new System.Drawing.Size(48, 17);
			this.BuildAfterSyncCheckBox.TabIndex = 5;
			this.BuildAfterSyncCheckBox.Text = "Build";
			this.BuildAfterSyncCheckBox.UseVisualStyleBackColor = true;
			this.BuildAfterSyncCheckBox.CheckedChanged += new System.EventHandler(this.BuildAfterSyncCheckBox_CheckedChanged);
			// 
			// AfterSyncingLabel
			// 
			this.AfterSyncingLabel.AutoSize = true;
			this.AfterSyncingLabel.Location = new System.Drawing.Point(3, 0);
			this.AfterSyncingLabel.Name = "AfterSyncingLabel";
			this.AfterSyncingLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.AfterSyncingLabel.Size = new System.Drawing.Size(75, 17);
			this.AfterSyncingLabel.TabIndex = 4;
			this.AfterSyncingLabel.Text = "After syncing:";
			// 
			// BuildListContextMenu
			// 
			this.BuildListContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BuildListContextMenu_LaunchEditor,
            this.BuildListContextMenu_Sync,
            this.BuildListContextMenu_SyncContentOnly,
            this.BuildListContextMenu_SyncOnlyThisChange,
            this.BuildListContextMenu_Build,
            this.BuildListContextMenu_Rebuild,
            this.BuildListContextMenu_GenerateProjectFiles,
            this.BuildListContextMenu_Cancel,
            this.BuildListContextMenu_OpenVisualStudio,
            this.toolStripSeparator4,
            this.BuildListContextMenu_MarkGood,
            this.BuildListContextMenu_MarkBad,
            this.BuildListContextMenu_WithdrawReview,
            this.BuildListContextMenu_LeaveComment,
            this.BuildListContextMenu_EditComment,
            this.BuildListContextMenu_StartInvestigating,
            this.BuildListContextMenu_FinishInvestigating,
            this.toolStripSeparator1,
            this.BuildListContextMenu_AddStar,
            this.BuildListContextMenu_RemoveStar,
            this.BuildListContextMenu_TimeZoneSeparator,
            this.BuildListContextMenu_ShowServerTimes,
            this.BuildListContextMenu_ShowLocalTimes,
            this.toolStripSeparator2,
            this.BuildListContextMenu_MoreInfo});
			this.BuildListContextMenu.Name = "BuildListContextMenu";
			this.BuildListContextMenu.Size = new System.Drawing.Size(200, 490);
			// 
			// BuildListContextMenu_LaunchEditor
			// 
			this.BuildListContextMenu_LaunchEditor.Name = "BuildListContextMenu_LaunchEditor";
			this.BuildListContextMenu_LaunchEditor.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_LaunchEditor.Text = "Launch editor";
			this.BuildListContextMenu_LaunchEditor.Click += new System.EventHandler(this.BuildListContextMenu_LaunchEditor_Click);
			// 
			// BuildListContextMenu_Sync
			// 
			this.BuildListContextMenu_Sync.Name = "BuildListContextMenu_Sync";
			this.BuildListContextMenu_Sync.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_Sync.Text = "Sync";
			this.BuildListContextMenu_Sync.Click += new System.EventHandler(this.BuildListContextMenu_Sync_Click);
			// 
			// BuildListContextMenu_SyncContentOnly
			// 
			this.BuildListContextMenu_SyncContentOnly.Name = "BuildListContextMenu_SyncContentOnly";
			this.BuildListContextMenu_SyncContentOnly.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_SyncContentOnly.Text = "Sync (Just Content)";
			this.BuildListContextMenu_SyncContentOnly.Click += new System.EventHandler(this.BuildListContextMenu_SyncContentOnly_Click);
			// 
			// BuildListContextMenu_SyncOnlyThisChange
			// 
			this.BuildListContextMenu_SyncOnlyThisChange.Name = "BuildListContextMenu_SyncOnlyThisChange";
			this.BuildListContextMenu_SyncOnlyThisChange.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_SyncOnlyThisChange.Text = "Sync (Just This Change)";
			this.BuildListContextMenu_SyncOnlyThisChange.Click += new System.EventHandler(this.BuildListContextMenu_SyncOnlyThisChange_Click);
			// 
			// BuildListContextMenu_Build
			// 
			this.BuildListContextMenu_Build.Name = "BuildListContextMenu_Build";
			this.BuildListContextMenu_Build.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_Build.Text = "Build";
			this.BuildListContextMenu_Build.Click += new System.EventHandler(this.BuildListContextMenu_Build_Click);
			// 
			// BuildListContextMenu_Rebuild
			// 
			this.BuildListContextMenu_Rebuild.Name = "BuildListContextMenu_Rebuild";
			this.BuildListContextMenu_Rebuild.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_Rebuild.Text = "Rebuild";
			this.BuildListContextMenu_Rebuild.Click += new System.EventHandler(this.BuildListContextMenu_Rebuild_Click);
			// 
			// BuildListContextMenu_GenerateProjectFiles
			// 
			this.BuildListContextMenu_GenerateProjectFiles.Name = "BuildListContextMenu_GenerateProjectFiles";
			this.BuildListContextMenu_GenerateProjectFiles.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_GenerateProjectFiles.Text = "Generate project files";
			this.BuildListContextMenu_GenerateProjectFiles.Click += new System.EventHandler(this.BuildListContextMenu_GenerateProjectFiles_Click);
			// 
			// BuildListContextMenu_Cancel
			// 
			this.BuildListContextMenu_Cancel.Name = "BuildListContextMenu_Cancel";
			this.BuildListContextMenu_Cancel.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_Cancel.Text = "Cancel";
			this.BuildListContextMenu_Cancel.Click += new System.EventHandler(this.BuildListContextMenu_CancelSync_Click);
			// 
			// BuildListContextMenu_OpenVisualStudio
			// 
			this.BuildListContextMenu_OpenVisualStudio.Name = "BuildListContextMenu_OpenVisualStudio";
			this.BuildListContextMenu_OpenVisualStudio.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_OpenVisualStudio.Text = "Open in Visual Studio...";
			this.BuildListContextMenu_OpenVisualStudio.Click += new System.EventHandler(this.BuildListContextMenu_OpenVisualStudio_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
			// 
			// BuildListContextMenu_MarkGood
			// 
			this.BuildListContextMenu_MarkGood.Name = "BuildListContextMenu_MarkGood";
			this.BuildListContextMenu_MarkGood.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_MarkGood.Text = "Mark as good";
			this.BuildListContextMenu_MarkGood.Click += new System.EventHandler(this.BuildListContextMenu_MarkGood_Click);
			// 
			// BuildListContextMenu_MarkBad
			// 
			this.BuildListContextMenu_MarkBad.Name = "BuildListContextMenu_MarkBad";
			this.BuildListContextMenu_MarkBad.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_MarkBad.Text = "Mark as bad";
			this.BuildListContextMenu_MarkBad.Click += new System.EventHandler(this.BuildListContextMenu_MarkBad_Click);
			// 
			// BuildListContextMenu_WithdrawReview
			// 
			this.BuildListContextMenu_WithdrawReview.Name = "BuildListContextMenu_WithdrawReview";
			this.BuildListContextMenu_WithdrawReview.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_WithdrawReview.Text = "Withdraw review";
			this.BuildListContextMenu_WithdrawReview.Click += new System.EventHandler(this.BuildListContextMenu_WithdrawReview_Click);
			// 
			// BuildListContextMenu_LeaveComment
			// 
			this.BuildListContextMenu_LeaveComment.Name = "BuildListContextMenu_LeaveComment";
			this.BuildListContextMenu_LeaveComment.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_LeaveComment.Text = "Leave comment...";
			this.BuildListContextMenu_LeaveComment.Click += new System.EventHandler(this.BuildListContextMenu_LeaveOrEditComment_Click);
			// 
			// BuildListContextMenu_EditComment
			// 
			this.BuildListContextMenu_EditComment.Name = "BuildListContextMenu_EditComment";
			this.BuildListContextMenu_EditComment.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_EditComment.Text = "Edit comment...";
			this.BuildListContextMenu_EditComment.Click += new System.EventHandler(this.BuildListContextMenu_LeaveOrEditComment_Click);
			// 
			// BuildListContextMenu_StartInvestigating
			// 
			this.BuildListContextMenu_StartInvestigating.Name = "BuildListContextMenu_StartInvestigating";
			this.BuildListContextMenu_StartInvestigating.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_StartInvestigating.Text = "Start investigating";
			this.BuildListContextMenu_StartInvestigating.Click += new System.EventHandler(this.BuildListContextMenu_StartInvestigating_Click);
			// 
			// BuildListContextMenu_FinishInvestigating
			// 
			this.BuildListContextMenu_FinishInvestigating.Name = "BuildListContextMenu_FinishInvestigating";
			this.BuildListContextMenu_FinishInvestigating.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_FinishInvestigating.Text = "Finish investigating";
			this.BuildListContextMenu_FinishInvestigating.Click += new System.EventHandler(this.BuildListContextMenu_FinishInvestigating_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
			// 
			// BuildListContextMenu_AddStar
			// 
			this.BuildListContextMenu_AddStar.Name = "BuildListContextMenu_AddStar";
			this.BuildListContextMenu_AddStar.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_AddStar.Text = "Add Star";
			this.BuildListContextMenu_AddStar.Click += new System.EventHandler(this.BuildListContextMenu_AddStar_Click);
			// 
			// BuildListContextMenu_RemoveStar
			// 
			this.BuildListContextMenu_RemoveStar.Name = "BuildListContextMenu_RemoveStar";
			this.BuildListContextMenu_RemoveStar.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_RemoveStar.Text = "Remove Star";
			this.BuildListContextMenu_RemoveStar.Click += new System.EventHandler(this.BuildListContextMenu_RemoveStar_Click);
			// 
			// BuildListContextMenu_TimeZoneSeparator
			// 
			this.BuildListContextMenu_TimeZoneSeparator.Name = "BuildListContextMenu_TimeZoneSeparator";
			this.BuildListContextMenu_TimeZoneSeparator.Size = new System.Drawing.Size(196, 6);
			// 
			// BuildListContextMenu_ShowServerTimes
			// 
			this.BuildListContextMenu_ShowServerTimes.Name = "BuildListContextMenu_ShowServerTimes";
			this.BuildListContextMenu_ShowServerTimes.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_ShowServerTimes.Text = "Show server times";
			this.BuildListContextMenu_ShowServerTimes.Click += new System.EventHandler(this.BuildListContextMenu_ShowServerTimes_Click);
			// 
			// BuildListContextMenu_ShowLocalTimes
			// 
			this.BuildListContextMenu_ShowLocalTimes.Name = "BuildListContextMenu_ShowLocalTimes";
			this.BuildListContextMenu_ShowLocalTimes.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_ShowLocalTimes.Text = "Show local times";
			this.BuildListContextMenu_ShowLocalTimes.Click += new System.EventHandler(this.BuildListContextMenu_ShowLocalTimes_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
			// 
			// BuildListContextMenu_MoreInfo
			// 
			this.BuildListContextMenu_MoreInfo.Name = "BuildListContextMenu_MoreInfo";
			this.BuildListContextMenu_MoreInfo.Size = new System.Drawing.Size(199, 22);
			this.BuildListContextMenu_MoreInfo.Text = "More Info...";
			this.BuildListContextMenu_MoreInfo.Click += new System.EventHandler(this.BuildListContextMenu_MoreInfo_Click);
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.ContextMenuStrip = this.NotifyMenu;
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "UnrealGameSync";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
			this.NotifyIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDown);
			// 
			// NotifyMenu
			// 
			this.NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotifyMenu_OpenUnrealGameSync,
            this.toolStripSeparator7,
            this.NotifyMenu_SyncNow,
            this.NotifyMenu_LaunchEditor,
            this.NotifyMenu_ExitSeparator,
            this.NotifyMenu_Exit});
			this.NotifyMenu.Name = "NotifyMenu";
			this.NotifyMenu.Size = new System.Drawing.Size(197, 104);
			// 
			// NotifyMenu_OpenUnrealGameSync
			// 
			this.NotifyMenu_OpenUnrealGameSync.Name = "NotifyMenu_OpenUnrealGameSync";
			this.NotifyMenu_OpenUnrealGameSync.Size = new System.Drawing.Size(196, 22);
			this.NotifyMenu_OpenUnrealGameSync.Text = "Open UnrealGameSync";
			this.NotifyMenu_OpenUnrealGameSync.Click += new System.EventHandler(this.NotifyMenu_OpenUnrealGameSync_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(193, 6);
			// 
			// NotifyMenu_SyncNow
			// 
			this.NotifyMenu_SyncNow.Name = "NotifyMenu_SyncNow";
			this.NotifyMenu_SyncNow.Size = new System.Drawing.Size(196, 22);
			this.NotifyMenu_SyncNow.Text = "Sync Now";
			this.NotifyMenu_SyncNow.Click += new System.EventHandler(this.NotifyMenu_SyncNow_Click);
			// 
			// NotifyMenu_LaunchEditor
			// 
			this.NotifyMenu_LaunchEditor.Name = "NotifyMenu_LaunchEditor";
			this.NotifyMenu_LaunchEditor.Size = new System.Drawing.Size(196, 22);
			this.NotifyMenu_LaunchEditor.Text = "Launch Editor";
			this.NotifyMenu_LaunchEditor.Click += new System.EventHandler(this.NotifyMenu_LaunchEditor_Click);
			// 
			// NotifyMenu_ExitSeparator
			// 
			this.NotifyMenu_ExitSeparator.Name = "NotifyMenu_ExitSeparator";
			this.NotifyMenu_ExitSeparator.Size = new System.Drawing.Size(193, 6);
			// 
			// NotifyMenu_Exit
			// 
			this.NotifyMenu_Exit.Name = "NotifyMenu_Exit";
			this.NotifyMenu_Exit.Size = new System.Drawing.Size(196, 22);
			this.NotifyMenu_Exit.Text = "Exit";
			this.NotifyMenu_Exit.Click += new System.EventHandler(this.NotifyMenu_Exit_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.AfterSyncingLabel);
			this.flowLayoutPanel1.Controls.Add(this.BuildAfterSyncCheckBox);
			this.flowLayoutPanel1.Controls.Add(this.RunAfterSyncCheckBox);
			this.flowLayoutPanel1.Controls.Add(this.OpenSolutionAfterSyncCheckBox);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(452, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 23);
			this.flowLayoutPanel1.TabIndex = 8;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// OpenSolutionAfterSyncCheckBox
			// 
			this.OpenSolutionAfterSyncCheckBox.AutoSize = true;
			this.OpenSolutionAfterSyncCheckBox.Location = new System.Drawing.Point(189, 3);
			this.OpenSolutionAfterSyncCheckBox.Name = "OpenSolutionAfterSyncCheckBox";
			this.OpenSolutionAfterSyncCheckBox.Size = new System.Drawing.Size(93, 17);
			this.OpenSolutionAfterSyncCheckBox.TabIndex = 7;
			this.OpenSolutionAfterSyncCheckBox.Text = "Open Solution";
			this.OpenSolutionAfterSyncCheckBox.UseVisualStyleBackColor = true;
			this.OpenSolutionAfterSyncCheckBox.CheckedChanged += new System.EventHandler(this.OpenSolutionAfterSyncCheckBox_CheckedChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.ProjectList, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.BrowseProject, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1156, 29);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.OnlyShowReviewedCheckBox, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.OptionsButton, 2, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 617);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1156, 29);
			this.tableLayoutPanel3.TabIndex = 11;
			// 
			// OptionsButton
			// 
			this.OptionsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.OptionsButton.AutoSize = true;
			this.OptionsButton.Image = global::UnrealGameSync.Properties.Resources.DropList;
			this.OptionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.OptionsButton.Location = new System.Drawing.Point(1021, 3);
			this.OptionsButton.Name = "OptionsButton";
			this.OptionsButton.Size = new System.Drawing.Size(132, 23);
			this.OptionsButton.TabIndex = 7;
			this.OptionsButton.Text = "Options";
			this.OptionsButton.UseVisualStyleBackColor = true;
			this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.Splitter, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(6);
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1168, 652);
			this.tableLayoutPanel2.TabIndex = 12;
			// 
			// Splitter
			// 
			this.Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Splitter.Location = new System.Drawing.Point(12, 41);
			this.Splitter.Margin = new System.Windows.Forms.Padding(6);
			this.Splitter.Name = "Splitter";
			this.Splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Splitter.Panel1
			// 
			this.Splitter.Panel1.Controls.Add(this.tableLayoutPanel4);
			// 
			// Splitter.Panel2
			// 
			this.Splitter.Panel2.Controls.Add(this.panel1);
			this.Splitter.Panel2MinSize = 50;
			this.Splitter.Size = new System.Drawing.Size(1144, 570);
			this.Splitter.SplitterDistance = 361;
			this.Splitter.SplitterWidth = 28;
			this.Splitter.TabIndex = 0;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.StatusPanel, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.BuildList, 0, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1144, 361);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// StatusPanel
			// 
			this.StatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.StatusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StatusPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StatusPanel.Location = new System.Drawing.Point(0, 0);
			this.StatusPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.StatusPanel.Name = "StatusPanel";
			this.StatusPanel.Size = new System.Drawing.Size(1144, 125);
			this.StatusPanel.TabIndex = 1;
			// 
			// BuildList
			// 
			this.BuildList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IconColumn,
            this.ChangeColumn,
            this.TimeColumn,
            this.AuthorColumn,
            this.DescriptionColumn,
            this.CISColumn,
            this.StatusColumn});
			this.BuildList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BuildList.FullRowSelect = true;
			this.BuildList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.BuildList.Location = new System.Drawing.Point(0, 128);
			this.BuildList.Margin = new System.Windows.Forms.Padding(0);
			this.BuildList.MultiSelect = false;
			this.BuildList.Name = "BuildList";
			this.BuildList.OwnerDraw = true;
			this.BuildList.Size = new System.Drawing.Size(1144, 233);
			this.BuildList.TabIndex = 0;
			this.BuildList.UseCompatibleStateImageBehavior = false;
			this.BuildList.View = System.Windows.Forms.View.Details;
			this.BuildList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.BuildList_DrawColumnHeader);
			this.BuildList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.BuildList_DrawItem);
			this.BuildList.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.BuildList_DrawSubItem);
			this.BuildList.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.BuildList_ItemMouseHover);
			this.BuildList.SelectedIndexChanged += new System.EventHandler(this.BuildList_SelectedIndexChanged);
			this.BuildList.FontChanged += new System.EventHandler(this.BuildList_FontChanged);
			this.BuildList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BuildList_MouseClick);
			this.BuildList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BuildList_MouseDoubleClick);
			this.BuildList.MouseLeave += new System.EventHandler(this.BuildList_MouseLeave);
			this.BuildList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BuildList_MouseMove);
			// 
			// IconColumn
			// 
			this.IconColumn.Text = "";
			this.IconColumn.Width = 45;
			// 
			// ChangeColumn
			// 
			this.ChangeColumn.Text = "Change";
			this.ChangeColumn.Width = 74;
			// 
			// TimeColumn
			// 
			this.TimeColumn.Text = "Time";
			// 
			// AuthorColumn
			// 
			this.AuthorColumn.Text = "Author";
			this.AuthorColumn.Width = 120;
			// 
			// DescriptionColumn
			// 
			this.DescriptionColumn.Text = "Description";
			this.DescriptionColumn.Width = 245;
			// 
			// CISColumn
			// 
			this.CISColumn.Text = "CIS";
			this.CISColumn.Width = 184;
			// 
			// StatusColumn
			// 
			this.StatusColumn.Text = "Status";
			this.StatusColumn.Width = 375;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.SyncLog);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1144, 181);
			this.panel1.TabIndex = 0;
			// 
			// SyncLog
			// 
			this.SyncLog.BackColor = System.Drawing.Color.White;
			this.SyncLog.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.SyncLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SyncLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SyncLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.SyncLog.Location = new System.Drawing.Point(0, 0);
			this.SyncLog.Name = "SyncLog";
			this.SyncLog.Size = new System.Drawing.Size(1142, 179);
			this.SyncLog.TabIndex = 0;
			// 
			// MoreToolsContextMenu
			// 
			this.MoreToolsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoreActionsContextMenu_CustomToolSeparator,
            this.MoreToolsContextMenu_CleanWorkspace});
			this.MoreToolsContextMenu.Name = "MoreActionsContextMenu";
			this.MoreToolsContextMenu.Size = new System.Drawing.Size(175, 32);
			// 
			// MoreActionsContextMenu_CustomToolSeparator
			// 
			this.MoreActionsContextMenu_CustomToolSeparator.Name = "MoreActionsContextMenu_CustomToolSeparator";
			this.MoreActionsContextMenu_CustomToolSeparator.Size = new System.Drawing.Size(171, 6);
			// 
			// MoreToolsContextMenu_CleanWorkspace
			// 
			this.MoreToolsContextMenu_CleanWorkspace.Name = "MoreToolsContextMenu_CleanWorkspace";
			this.MoreToolsContextMenu_CleanWorkspace.Size = new System.Drawing.Size(174, 22);
			this.MoreToolsContextMenu_CleanWorkspace.Text = "Clean Workspace...";
			this.MoreToolsContextMenu_CleanWorkspace.Click += new System.EventHandler(this.MoreToolsContextMenu_CleanWorkspace_Click);
			// 
			// SyncContextMenu
			// 
			this.SyncContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SyncContextMenu_LatestChange,
            this.SyncContextMenu_LatestGoodChange,
            this.SyncContextMenu_LatestStarredChange,
            this.toolStripSeparator8,
            this.SyncContexMenu_EnterChangelist});
			this.SyncContextMenu.Name = "SyncContextMenu";
			this.SyncContextMenu.Size = new System.Drawing.Size(190, 98);
			// 
			// SyncContextMenu_LatestChange
			// 
			this.SyncContextMenu_LatestChange.Name = "SyncContextMenu_LatestChange";
			this.SyncContextMenu_LatestChange.Size = new System.Drawing.Size(189, 22);
			this.SyncContextMenu_LatestChange.Text = "Latest Change";
			this.SyncContextMenu_LatestChange.Click += new System.EventHandler(this.SyncContextMenu_LatestChange_Click);
			// 
			// SyncContextMenu_LatestGoodChange
			// 
			this.SyncContextMenu_LatestGoodChange.Name = "SyncContextMenu_LatestGoodChange";
			this.SyncContextMenu_LatestGoodChange.Size = new System.Drawing.Size(189, 22);
			this.SyncContextMenu_LatestGoodChange.Text = "Latest Good Change";
			this.SyncContextMenu_LatestGoodChange.Click += new System.EventHandler(this.SyncContextMenu_LatestGoodChange_Click);
			// 
			// SyncContextMenu_LatestStarredChange
			// 
			this.SyncContextMenu_LatestStarredChange.Name = "SyncContextMenu_LatestStarredChange";
			this.SyncContextMenu_LatestStarredChange.Size = new System.Drawing.Size(189, 22);
			this.SyncContextMenu_LatestStarredChange.Text = "Latest Starred Change";
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(186, 6);
			// 
			// SyncContexMenu_EnterChangelist
			// 
			this.SyncContexMenu_EnterChangelist.Name = "SyncContexMenu_EnterChangelist";
			this.SyncContexMenu_EnterChangelist.Size = new System.Drawing.Size(189, 22);
			this.SyncContexMenu_EnterChangelist.Text = "Specific Changelist...";
			this.SyncContexMenu_EnterChangelist.Click += new System.EventHandler(this.SyncContextMenu_EnterChangelist_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 652);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 350);
			this.Name = "MainWindow";
			this.Text = "UnrealGameSync";
			this.Activated += new System.EventHandler(this.MainWindow_Activated);
			this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.OptionsContextMenu.ResumeLayout(false);
			this.BuildListContextMenu.ResumeLayout(false);
			this.NotifyMenu.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.Splitter.Panel1.ResumeLayout(false);
			this.Splitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Splitter)).EndInit();
			this.Splitter.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.MoreToolsContextMenu.ResumeLayout(false);
			this.SyncContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private BuildListControl BuildList;
		private LogControl SyncLog;
		private System.Windows.Forms.ColumnHeader IconColumn;
		private System.Windows.Forms.ColumnHeader TimeColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ProjectList;
		private System.Windows.Forms.Button BrowseProject;
		private System.Windows.Forms.ColumnHeader DescriptionColumn;
		private System.Windows.Forms.ColumnHeader StatusColumn;
		private System.Windows.Forms.ColumnHeader ChangeColumn;
		private System.Windows.Forms.ColumnHeader AuthorColumn;
		private System.Windows.Forms.Button OptionsButton;
		private System.Windows.Forms.ContextMenuStrip OptionsContextMenu;
		private System.Windows.Forms.CheckBox OnlyShowReviewedCheckBox;
		private System.Windows.Forms.CheckBox RunAfterSyncCheckBox;
		private System.Windows.Forms.CheckBox BuildAfterSyncCheckBox;
		private System.Windows.Forms.Label AfterSyncingLabel;
		private System.Windows.Forms.ContextMenuStrip BuildListContextMenu;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_Cancel;
		private LogSplitContainer Splitter;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_MoreInfo;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_AddStar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_MarkGood;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_MarkBad;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_StartInvestigating;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_Sync;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.NotifyIcon NotifyIcon;
		private System.Windows.Forms.ContextMenuStrip NotifyMenu;
		private System.Windows.Forms.ToolStripMenuItem NotifyMenu_OpenUnrealGameSync;
		private System.Windows.Forms.ToolStripSeparator NotifyMenu_ExitSeparator;
		private System.Windows.Forms.ToolStripMenuItem NotifyMenu_Exit;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_RemoveStar;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_FinishInvestigating;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_LaunchEditor;
		private System.Windows.Forms.ToolTip BuildListToolTip;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_AutoResolveConflicts;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_EditorArguments;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_OpenVisualStudio;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_Build;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_GenerateProjectFiles;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_EditorBuildConfiguration;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_BuildConfig_Debug;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_BuildConfig_DebugGame;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_BuildConfig_Development;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_UseIncrementalBuilds;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_Rebuild;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_WithdrawReview;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_ScheduledSync;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_LeaveComment;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem NotifyMenu_SyncNow;
		private System.Windows.Forms.ToolStripMenuItem NotifyMenu_LaunchEditor;
		private System.Windows.Forms.ColumnHeader CISColumn;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_EditComment;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ToolStripSeparator BuildListContextMenu_TimeZoneSeparator;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_ShowServerTimes;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_ShowLocalTimes;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_CustomizeBuildSteps;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_TimeZone;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_TimeZone_Local;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_TimeZone_PerforceServer;
		private System.Windows.Forms.CheckBox OpenSolutionAfterSyncCheckBox;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_AutomaticallyRunAtStartup;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_SyncPrecompiledEditor;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private StatusPanel StatusPanel;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_SyncContentOnly;
		private System.Windows.Forms.ContextMenuStrip MoreToolsContextMenu;
		private System.Windows.Forms.ToolStripMenuItem MoreToolsContextMenu_CleanWorkspace;
		private System.Windows.Forms.ToolStripSeparator MoreActionsContextMenu_CustomToolSeparator;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_Diagnostics;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_SyncFilter;
		private System.Windows.Forms.ToolStripMenuItem BuildListContextMenu_SyncOnlyThisChange;
		private System.Windows.Forms.ContextMenuStrip SyncContextMenu;
		private System.Windows.Forms.ToolStripMenuItem SyncContextMenu_LatestChange;
		private System.Windows.Forms.ToolStripMenuItem SyncContextMenu_LatestGoodChange;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem SyncContexMenu_EnterChangelist;
		private System.Windows.Forms.ToolStripMenuItem SyncContextMenu_LatestStarredChange;
		private System.Windows.Forms.ToolStripMenuItem OptionsContextMenu_KeepInTray;
	}
}

