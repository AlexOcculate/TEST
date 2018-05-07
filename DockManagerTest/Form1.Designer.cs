namespace DockManagerTest
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if( disposing && (components != null) )
         {
            components.Dispose( );
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.toolsBar = new DevExpress.XtraBars.Bar();
         this.dockManagerBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.createDockManagerBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.clearDockManagerBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.destroyDockManagerbarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.addControlsToPanelbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.removeActiveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.hideFloatingPlanelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.dockingPanelsBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.dockPanelToLeftPanelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.dockAsTabBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.DockAsSplitToBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
         this.showAutoHiddenPanelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.hideAutoHiddenPanelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.closedPanelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.snapModeBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.snapModeNoneBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.snapModeAllBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.snapModeFormsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.snapModeScreensBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.snapModeOwnerFormsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.snapModeOwnerControlBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.snapModeInheritBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.floatPanelsBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.getFloatPanelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.mainMenuBar = new DevExpress.XtraBars.Bar();
         this.statusBar = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.skinsBarSubItem = new DevExpress.XtraBars.SkinBarSubItem();
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.barDockingMenuItem = new DevExpress.XtraBars.BarDockingMenuItem();
         this.memoEdit = new DevExpress.XtraEditors.MemoEdit();
         this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
         this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
         this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
         this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
         this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
         this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.toolsBar,
            this.mainMenuBar,
            this.statusBar});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.createDockManagerBarButtonItem,
            this.dockManagerBarSubItem,
            this.skinsBarSubItem,
            this.destroyDockManagerbarButtonItem1,
            this.dockPanelToLeftPanelBarButtonItem,
            this.addControlsToPanelbarButtonItem,
            this.clearDockManagerBarButtonItem,
            this.removeActiveBarButtonItem,
            this.hideFloatingPlanelsBarButtonItem,
            this.barButtonItem1,
            this.dockingPanelsBarSubItem,
            this.dockAsTabBarButtonItem,
            this.DockAsSplitToBarButtonItem,
            this.showAutoHiddenPanelsBarButtonItem,
            this.barSubItem1,
            this.hideAutoHiddenPanelsBarButtonItem,
            this.closedPanelsBarButtonItem,
            this.snapModeAllBarButtonItem,
            this.snapModeBarSubItem,
            this.snapModeFormsBarButtonItem,
            this.snapModeScreensBarButtonItem,
            this.snapModeOwnerFormsBarButtonItem,
            this.snapModeOwnerControlBarButtonItem,
            this.snapModeNoneBarButtonItem,
            this.snapModeInheritBarButtonItem,
            this.floatPanelsBarSubItem,
            this.getFloatPanelsBarButtonItem,
            this.barDockingMenuItem,
            this.barSubItem2,
            this.skinBarSubItem1,
            this.barMdiChildrenListItem1,
            this.barDockingMenuItem1,
            this.barWorkspaceMenuItem1});
         this.barManager1.MainMenu = this.mainMenuBar;
         this.barManager1.MaxItemId = 36;
         this.barManager1.StatusBar = this.statusBar;
         // 
         // toolsBar
         // 
         this.toolsBar.BarName = "Tools";
         this.toolsBar.DockCol = 0;
         this.toolsBar.DockRow = 1;
         this.toolsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.toolsBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.dockManagerBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.dockingPanelsBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.closedPanelsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.snapModeBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.floatPanelsBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
         this.toolsBar.Text = "Tools";
         // 
         // dockManagerBarSubItem
         // 
         this.dockManagerBarSubItem.Caption = "DockManager";
         this.dockManagerBarSubItem.Id = 1;
         this.dockManagerBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.createDockManagerBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.clearDockManagerBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.destroyDockManagerbarButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addControlsToPanelbarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeActiveBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.hideFloatingPlanelsBarButtonItem, true)});
         this.dockManagerBarSubItem.Name = "dockManagerBarSubItem";
         // 
         // createDockManagerBarButtonItem
         // 
         this.createDockManagerBarButtonItem.Caption = "Create DockManager";
         this.createDockManagerBarButtonItem.Id = 0;
         this.createDockManagerBarButtonItem.Name = "createDockManagerBarButtonItem";
         this.createDockManagerBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.createDockManagerBarButtonItem_ItemClick);
         // 
         // clearDockManagerBarButtonItem
         // 
         this.clearDockManagerBarButtonItem.Caption = "Clear DockManager";
         this.clearDockManagerBarButtonItem.Id = 6;
         this.clearDockManagerBarButtonItem.Name = "clearDockManagerBarButtonItem";
         this.clearDockManagerBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearDockManagerBarButtonItem_ItemClick);
         // 
         // destroyDockManagerbarButtonItem1
         // 
         this.destroyDockManagerbarButtonItem1.Caption = "Destroy DockManager";
         this.destroyDockManagerbarButtonItem1.Id = 3;
         this.destroyDockManagerbarButtonItem1.Name = "destroyDockManagerbarButtonItem1";
         this.destroyDockManagerbarButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.destroyDockManagerbarButtonItem1_ItemClick);
         // 
         // addControlsToPanelbarButtonItem
         // 
         this.addControlsToPanelbarButtonItem.Caption = "Add Controls To Panel";
         this.addControlsToPanelbarButtonItem.Id = 5;
         this.addControlsToPanelbarButtonItem.Name = "addControlsToPanelbarButtonItem";
         this.addControlsToPanelbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addControlsToPanelbarButtonItem_ItemClick);
         // 
         // removeActiveBarButtonItem
         // 
         this.removeActiveBarButtonItem.Caption = "Remove Active Panel";
         this.removeActiveBarButtonItem.Id = 7;
         this.removeActiveBarButtonItem.Name = "removeActiveBarButtonItem";
         this.removeActiveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.removeActiveBarButtonItem_ItemClick);
         // 
         // hideFloatingPlanelsBarButtonItem
         // 
         this.hideFloatingPlanelsBarButtonItem.Caption = "Hide Floating Panels";
         this.hideFloatingPlanelsBarButtonItem.Id = 8;
         this.hideFloatingPlanelsBarButtonItem.Name = "hideFloatingPlanelsBarButtonItem";
         this.hideFloatingPlanelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hideFloatingPlanelsBarButtonItem_ItemClick);
         // 
         // dockingPanelsBarSubItem
         // 
         this.dockingPanelsBarSubItem.Caption = "Dock Panels";
         this.dockingPanelsBarSubItem.Id = 10;
         this.dockingPanelsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.dockPanelToLeftPanelBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.dockAsTabBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.DockAsSplitToBarButtonItem)});
         this.dockingPanelsBarSubItem.Name = "dockingPanelsBarSubItem";
         // 
         // dockPanelToLeftPanelBarButtonItem
         // 
         this.dockPanelToLeftPanelBarButtonItem.Caption = "Dock Panel To Left Panel";
         this.dockPanelToLeftPanelBarButtonItem.Id = 4;
         this.dockPanelToLeftPanelBarButtonItem.Name = "dockPanelToLeftPanelBarButtonItem";
         this.dockPanelToLeftPanelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.dockPanelToLeftPanelBarButtonItem_ItemClick);
         // 
         // dockAsTabBarButtonItem
         // 
         this.dockAsTabBarButtonItem.Caption = "Dock As Tab";
         this.dockAsTabBarButtonItem.Id = 11;
         this.dockAsTabBarButtonItem.Name = "dockAsTabBarButtonItem";
         // 
         // DockAsSplitToBarButtonItem
         // 
         this.DockAsSplitToBarButtonItem.Caption = "Dock To (as Split)";
         this.DockAsSplitToBarButtonItem.Id = 12;
         this.DockAsSplitToBarButtonItem.Name = "DockAsSplitToBarButtonItem";
         this.DockAsSplitToBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DockAsSplitToBarButtonItem_ItemClick);
         // 
         // barSubItem1
         // 
         this.barSubItem1.Caption = "Auto Hidden Panels";
         this.barSubItem1.Id = 14;
         this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.showAutoHiddenPanelsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.hideAutoHiddenPanelsBarButtonItem)});
         this.barSubItem1.Name = "barSubItem1";
         // 
         // showAutoHiddenPanelsBarButtonItem
         // 
         this.showAutoHiddenPanelsBarButtonItem.Caption = "Show Panels";
         this.showAutoHiddenPanelsBarButtonItem.Id = 13;
         this.showAutoHiddenPanelsBarButtonItem.Name = "showAutoHiddenPanelsBarButtonItem";
         this.showAutoHiddenPanelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showAutoHiddenPanelsBarButtonItem_ItemClick);
         // 
         // hideAutoHiddenPanelsBarButtonItem
         // 
         this.hideAutoHiddenPanelsBarButtonItem.Caption = "Hide Panels";
         this.hideAutoHiddenPanelsBarButtonItem.Id = 15;
         this.hideAutoHiddenPanelsBarButtonItem.Name = "hideAutoHiddenPanelsBarButtonItem";
         this.hideAutoHiddenPanelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hideAutoHiddenPanelsBarButtonItem_ItemClick);
         // 
         // closedPanelsBarButtonItem
         // 
         this.closedPanelsBarButtonItem.Caption = "Closed Panels";
         this.closedPanelsBarButtonItem.Id = 16;
         this.closedPanelsBarButtonItem.Name = "closedPanelsBarButtonItem";
         this.closedPanelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
         // 
         // snapModeBarSubItem
         // 
         this.snapModeBarSubItem.Caption = "Snap Mode";
         this.snapModeBarSubItem.Id = 18;
         this.snapModeBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.snapModeNoneBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.snapModeAllBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.snapModeFormsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.snapModeScreensBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.snapModeOwnerFormsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.snapModeOwnerControlBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.snapModeInheritBarButtonItem)});
         this.snapModeBarSubItem.Name = "snapModeBarSubItem";
         // 
         // snapModeNoneBarButtonItem
         // 
         this.snapModeNoneBarButtonItem.Caption = "None";
         this.snapModeNoneBarButtonItem.Id = 23;
         this.snapModeNoneBarButtonItem.Name = "snapModeNoneBarButtonItem";
         this.snapModeNoneBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.snapModelNoneBarButtonItem_ItemClick);
         // 
         // snapModeAllBarButtonItem
         // 
         this.snapModeAllBarButtonItem.Caption = "Snap All";
         this.snapModeAllBarButtonItem.Id = 17;
         this.snapModeAllBarButtonItem.Name = "snapModeAllBarButtonItem";
         this.snapModeAllBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.snapModelAllBarButtonItem_ItemClick);
         // 
         // snapModeFormsBarButtonItem
         // 
         this.snapModeFormsBarButtonItem.Caption = "Snap Forms";
         this.snapModeFormsBarButtonItem.Id = 19;
         this.snapModeFormsBarButtonItem.Name = "snapModeFormsBarButtonItem";
         this.snapModeFormsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.snapModeFormsBarButtonItem_ItemClick);
         // 
         // snapModeScreensBarButtonItem
         // 
         this.snapModeScreensBarButtonItem.Caption = "Snap Screens";
         this.snapModeScreensBarButtonItem.Id = 20;
         this.snapModeScreensBarButtonItem.Name = "snapModeScreensBarButtonItem";
         this.snapModeScreensBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.snapModeScreensBarButtonItem_ItemClick);
         // 
         // snapModeOwnerFormsBarButtonItem
         // 
         this.snapModeOwnerFormsBarButtonItem.Caption = "Owner Form";
         this.snapModeOwnerFormsBarButtonItem.Id = 21;
         this.snapModeOwnerFormsBarButtonItem.Name = "snapModeOwnerFormsBarButtonItem";
         this.snapModeOwnerFormsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.snapModeOwnerFormsBarButtonItem_ItemClick);
         // 
         // snapModeOwnerControlBarButtonItem
         // 
         this.snapModeOwnerControlBarButtonItem.Caption = "Owner Control";
         this.snapModeOwnerControlBarButtonItem.Id = 22;
         this.snapModeOwnerControlBarButtonItem.Name = "snapModeOwnerControlBarButtonItem";
         this.snapModeOwnerControlBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.snapModeOwnerControlBarButtonItem_ItemClick);
         // 
         // snapModeInheritBarButtonItem
         // 
         this.snapModeInheritBarButtonItem.Caption = "Inherit";
         this.snapModeInheritBarButtonItem.Id = 24;
         this.snapModeInheritBarButtonItem.Name = "snapModeInheritBarButtonItem";
         this.snapModeInheritBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.snapModeInheritBarButtonItem_ItemClick);
         // 
         // floatPanelsBarSubItem
         // 
         this.floatPanelsBarSubItem.Caption = "Float Panels";
         this.floatPanelsBarSubItem.Id = 25;
         this.floatPanelsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.getFloatPanelsBarButtonItem)});
         this.floatPanelsBarSubItem.Name = "floatPanelsBarSubItem";
         // 
         // getFloatPanelsBarButtonItem
         // 
         this.getFloatPanelsBarButtonItem.Caption = "barButtonItem2";
         this.getFloatPanelsBarButtonItem.Id = 26;
         this.getFloatPanelsBarButtonItem.Name = "getFloatPanelsBarButtonItem";
         this.getFloatPanelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.getFloatPanelsBarButtonItem_ItemClick_1);
         // 
         // mainMenuBar
         // 
         this.mainMenuBar.BarName = "Main menu";
         this.mainMenuBar.DockCol = 0;
         this.mainMenuBar.DockRow = 0;
         this.mainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.mainMenuBar.OptionsBar.MultiLine = true;
         this.mainMenuBar.OptionsBar.UseWholeRow = true;
         this.mainMenuBar.Text = "Main menu";
         // 
         // statusBar
         // 
         this.statusBar.BarName = "Status bar";
         this.statusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         this.statusBar.DockCol = 0;
         this.statusBar.DockRow = 0;
         this.statusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         this.statusBar.OptionsBar.AllowQuickCustomization = false;
         this.statusBar.OptionsBar.DrawDragBorder = false;
         this.statusBar.OptionsBar.UseWholeRow = true;
         this.statusBar.Text = "Status bar";
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlTop.Size = new System.Drawing.Size(1481, 62);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 726);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlBottom.Size = new System.Drawing.Size(1481, 18);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 664);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(1481, 62);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlRight.Size = new System.Drawing.Size(0, 664);
         // 
         // skinsBarSubItem
         // 
         this.skinsBarSubItem.Caption = "Skins && Themes";
         this.skinsBarSubItem.Id = 2;
         this.skinsBarSubItem.Name = "skinsBarSubItem";
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "barButtonItem1";
         this.barButtonItem1.Id = 9;
         this.barButtonItem1.Name = "barButtonItem1";
         // 
         // barDockingMenuItem
         // 
         this.barDockingMenuItem.Caption = "barDockingMenuItem1";
         this.barDockingMenuItem.Id = 27;
         this.barDockingMenuItem.Name = "barDockingMenuItem";
         // 
         // memoEdit
         // 
         this.memoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
         this.memoEdit.Location = new System.Drawing.Point(0, 62);
         this.memoEdit.Margin = new System.Windows.Forms.Padding(4);
         this.memoEdit.MenuManager = this.barManager1;
         this.memoEdit.Name = "memoEdit";
         this.memoEdit.Properties.AcceptsTab = true;
         this.memoEdit.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
         this.memoEdit.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.memoEdit.Size = new System.Drawing.Size(1481, 664);
         this.memoEdit.TabIndex = 4;
         // 
         // barSubItem2
         // 
         this.barSubItem2.Caption = "Others";
         this.barSubItem2.Id = 31;
         this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDockingMenuItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barWorkspaceMenuItem1)});
         this.barSubItem2.Name = "barSubItem2";
         // 
         // skinBarSubItem1
         // 
         this.skinBarSubItem1.Caption = "Skins && Themes";
         this.skinBarSubItem1.Id = 32;
         this.skinBarSubItem1.Name = "skinBarSubItem1";
         // 
         // barMdiChildrenListItem1
         // 
         this.barMdiChildrenListItem1.Caption = "MDI Children";
         this.barMdiChildrenListItem1.Id = 33;
         this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
         // 
         // barDockingMenuItem1
         // 
         this.barDockingMenuItem1.Caption = "Docking";
         this.barDockingMenuItem1.Id = 34;
         this.barDockingMenuItem1.Name = "barDockingMenuItem1";
         // 
         // barWorkspaceMenuItem1
         // 
         this.barWorkspaceMenuItem1.Caption = "Workspace";
         this.barWorkspaceMenuItem1.Id = 35;
         this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
         this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
         // 
         // workspaceManager1
         // 
         this.workspaceManager1.TargetControl = this;
         this.workspaceManager1.TransitionType = pushTransition1;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1481, 744);
         this.Controls.Add(this.memoEdit);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar toolsBar;
      private DevExpress.XtraBars.Bar mainMenuBar;
      private DevExpress.XtraBars.Bar statusBar;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem createDockManagerBarButtonItem;
      private DevExpress.XtraBars.BarSubItem dockManagerBarSubItem;
      private DevExpress.XtraBars.SkinBarSubItem skinsBarSubItem;
      private DevExpress.XtraBars.BarButtonItem destroyDockManagerbarButtonItem1;
      private DevExpress.XtraBars.BarButtonItem dockPanelToLeftPanelBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem addControlsToPanelbarButtonItem;
      private DevExpress.XtraBars.BarButtonItem clearDockManagerBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem removeActiveBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem hideFloatingPlanelsBarButtonItem;
      private DevExpress.XtraBars.BarSubItem dockingPanelsBarSubItem;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
      private DevExpress.XtraBars.BarButtonItem dockAsTabBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem DockAsSplitToBarButtonItem;
      private DevExpress.XtraBars.BarSubItem barSubItem1;
      private DevExpress.XtraBars.BarButtonItem showAutoHiddenPanelsBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem hideAutoHiddenPanelsBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem closedPanelsBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem snapModeAllBarButtonItem;
      private DevExpress.XtraBars.BarSubItem snapModeBarSubItem;
      private DevExpress.XtraBars.BarButtonItem snapModeNoneBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem snapModeFormsBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem snapModeScreensBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem snapModeOwnerFormsBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem snapModeOwnerControlBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem snapModeInheritBarButtonItem;
      private DevExpress.XtraBars.BarSubItem floatPanelsBarSubItem;
      private DevExpress.XtraBars.BarButtonItem getFloatPanelsBarButtonItem;
      private DevExpress.XtraEditors.MemoEdit memoEdit;
      private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem;
      private DevExpress.XtraBars.BarSubItem barSubItem2;
      private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
      private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
      private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
      private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
      private DevExpress.Utils.WorkspaceManager workspaceManager1;
   }
}

