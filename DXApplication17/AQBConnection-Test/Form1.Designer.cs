namespace AQBConnection_Test
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
         DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
         this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
         this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
         this.testAQBSqliteAUTOConnectionBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.testAQBSqliteConnectionBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
         this.testAQBMsssAutoConnectionBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
         this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
         this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
         this.propertyGridControl = new DevExpress.XtraVerticalGrid.PropertyGridControl();
         this.aqbSqliteGridDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
         this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
         this.aqbGridControl = new DevExpress.XtraGrid.GridControl();
         this.aqbGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
         this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
         this.dockPanel1.SuspendLayout();
         this.dockPanel1_Container.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).BeginInit();
         this.aqbSqliteGridDockPanel.SuspendLayout();
         this.dockPanel2_Container.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.aqbGridControl)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.aqbGridView)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
         this.SuspendLayout();
         // 
         // documentGroup1
         // 
         this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.document1});
         // 
         // document1
         // 
         this.document1.Caption = "AQB SQLite Grid";
         this.document1.ControlName = "aqbSqliteGridDockPanel";
         this.document1.FloatLocation = new System.Drawing.Point(0, 0);
         this.document1.FloatSize = new System.Drawing.Size(200, 200);
         this.document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.True;
         this.document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
         this.document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.DockManager = this.dockManager1;
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.testAQBSqliteConnectionBarButtonItem,
            this.testAQBSqliteAUTOConnectionBarButtonItem,
            this.testAQBMsssAutoConnectionBarButtonItem,
            this.barSubItem1,
            this.barSubItem2});
         this.barManager1.MainMenu = this.bar2;
         this.barManager1.MaxItemId = 5;
         this.barManager1.StatusBar = this.bar3;
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 1;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
         this.bar1.Text = "Tools";
         // 
         // barSubItem1
         // 
         this.barSubItem1.Caption = "SQLite";
         this.barSubItem1.Id = 3;
         this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.testAQBSqliteAUTOConnectionBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.testAQBSqliteConnectionBarButtonItem)});
         this.barSubItem1.Name = "barSubItem1";
         // 
         // testAQBSqliteAUTOConnectionBarButtonItem
         // 
         this.testAQBSqliteAUTOConnectionBarButtonItem.Caption = "Test AQB SQLite (Auto) Connection";
         this.testAQBSqliteAUTOConnectionBarButtonItem.Id = 1;
         this.testAQBSqliteAUTOConnectionBarButtonItem.Name = "testAQBSqliteAUTOConnectionBarButtonItem";
         this.testAQBSqliteAUTOConnectionBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.testAQBSqliteAUTOConnectionBarButtonItem_ItemClick);
         // 
         // testAQBSqliteConnectionBarButtonItem
         // 
         this.testAQBSqliteConnectionBarButtonItem.Caption = "Test AQB SQLite Connection";
         this.testAQBSqliteConnectionBarButtonItem.Id = 0;
         this.testAQBSqliteConnectionBarButtonItem.Name = "testAQBSqliteConnectionBarButtonItem";
         this.testAQBSqliteConnectionBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.testAQBSqliteConnectionBarButtonItem_ItemClick);
         // 
         // barSubItem2
         // 
         this.barSubItem2.Caption = "MSSS";
         this.barSubItem2.Id = 4;
         this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.testAQBMsssAutoConnectionBarButtonItem)});
         this.barSubItem2.Name = "barSubItem2";
         // 
         // testAQBMsssAutoConnectionBarButtonItem
         // 
         this.testAQBMsssAutoConnectionBarButtonItem.Caption = "Test AQB MSSS (Auto) Connection";
         this.testAQBMsssAutoConnectionBarButtonItem.Id = 2;
         this.testAQBMsssAutoConnectionBarButtonItem.Name = "testAQBMsssAutoConnectionBarButtonItem";
         this.testAQBMsssAutoConnectionBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.testAQBMsssAutoConnectionBarButtonItem_ItemClick);
         // 
         // bar2
         // 
         this.bar2.BarName = "Main menu";
         this.bar2.DockCol = 0;
         this.bar2.DockRow = 0;
         this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // bar3
         // 
         this.bar3.BarName = "Status bar";
         this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         this.bar3.DockCol = 0;
         this.bar3.DockRow = 0;
         this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         this.bar3.OptionsBar.AllowQuickCustomization = false;
         this.bar3.OptionsBar.DrawDragBorder = false;
         this.bar3.OptionsBar.UseWholeRow = true;
         this.bar3.Text = "Status bar";
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(876, 48);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 749);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(876, 18);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 701);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(876, 48);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 701);
         // 
         // dockManager1
         // 
         this.dockManager1.Form = this;
         this.dockManager1.MenuManager = this.barManager1;
         this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.aqbSqliteGridDockPanel});
         this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
         // 
         // dockPanel1
         // 
         this.dockPanel1.Controls.Add(this.dockPanel1_Container);
         this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
         this.dockPanel1.ID = new System.Guid("25bf9aaf-f9ee-445c-9310-785cdabd9fe7");
         this.dockPanel1.Location = new System.Drawing.Point(0, 48);
         this.dockPanel1.Name = "dockPanel1";
         this.dockPanel1.OriginalSize = new System.Drawing.Size(387, 200);
         this.dockPanel1.Size = new System.Drawing.Size(387, 701);
         this.dockPanel1.Text = "dockPanel1";
         // 
         // dockPanel1_Container
         // 
         this.dockPanel1_Container.Controls.Add(this.propertyGridControl);
         this.dockPanel1_Container.Location = new System.Drawing.Point(4, 38);
         this.dockPanel1_Container.Name = "dockPanel1_Container";
         this.dockPanel1_Container.Size = new System.Drawing.Size(378, 659);
         this.dockPanel1_Container.TabIndex = 0;
         // 
         // propertyGridControl
         // 
         this.propertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.propertyGridControl.Location = new System.Drawing.Point(0, 0);
         this.propertyGridControl.Name = "propertyGridControl";
         this.propertyGridControl.Size = new System.Drawing.Size(378, 659);
         this.propertyGridControl.TabIndex = 0;
         // 
         // aqbSqliteGridDockPanel
         // 
         this.aqbSqliteGridDockPanel.Controls.Add(this.dockPanel2_Container);
         this.aqbSqliteGridDockPanel.DockedAsTabbedDocument = true;
         this.aqbSqliteGridDockPanel.ID = new System.Guid("1fbd7c75-ee28-4bab-9b13-8bb79d31c52e");
         this.aqbSqliteGridDockPanel.Name = "aqbSqliteGridDockPanel";
         this.aqbSqliteGridDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
         this.aqbSqliteGridDockPanel.Text = "AQB SQLite Grid";
         // 
         // dockPanel2_Container
         // 
         this.dockPanel2_Container.Controls.Add(this.aqbGridControl);
         this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
         this.dockPanel2_Container.Name = "dockPanel2_Container";
         this.dockPanel2_Container.Size = new System.Drawing.Size(483, 671);
         this.dockPanel2_Container.TabIndex = 0;
         // 
         // aqbSqliteGridControl
         // 
         this.aqbGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.aqbGridControl.Location = new System.Drawing.Point(0, 0);
         this.aqbGridControl.MainView = this.aqbGridView;
         this.aqbGridControl.MenuManager = this.barManager1;
         this.aqbGridControl.Name = "aqbSqliteGridControl";
         this.aqbGridControl.Size = new System.Drawing.Size(483, 671);
         this.aqbGridControl.TabIndex = 0;
         this.aqbGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.aqbGridView});
         // 
         // gridView1
         // 
         this.aqbGridView.GridControl = this.aqbGridControl;
         this.aqbGridView.Name = "gridView1";
         this.aqbGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
         // 
         // documentManager1
         // 
         this.documentManager1.ContainerControl = this;
         this.documentManager1.View = this.tabbedView1;
         this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
         // 
         // tabbedView1
         // 
         this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
         this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document1});
         dockingContainer1.Element = this.documentGroup1;
         this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer1});
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(876, 767);
         this.Controls.Add(this.dockPanel1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
         this.dockPanel1.ResumeLayout(false);
         this.dockPanel1_Container.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl)).EndInit();
         this.aqbSqliteGridDockPanel.ResumeLayout(false);
         this.dockPanel2_Container.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.aqbGridControl)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.aqbGridView)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem testAQBSqliteConnectionBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem testAQBSqliteAUTOConnectionBarButtonItem;
      private DevExpress.XtraBars.Docking.DockManager dockManager1;
      private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
      private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
      private DevExpress.XtraBars.Docking.DockPanel aqbSqliteGridDockPanel;
      private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
      private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
      private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
      private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
      private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
      private DevExpress.XtraGrid.GridControl aqbGridControl;
      private DevExpress.XtraGrid.Views.Grid.GridView aqbGridView;
      private DevExpress.XtraBars.BarSubItem barSubItem1;
      private DevExpress.XtraBars.BarSubItem barSubItem2;
      private DevExpress.XtraBars.BarButtonItem testAQBMsssAutoConnectionBarButtonItem;
      private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl;
   }
}

