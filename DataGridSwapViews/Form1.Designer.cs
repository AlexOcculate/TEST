namespace DataGridSwapViews
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
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.gridViewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.layoutViewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.cardViewBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.winExplorerBarSubItem = new DevExpress.XtraBars.BarSubItem();
         this.defaultWinExplorerViewStyleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.contentWinExplorerViewStyleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.listWinExplorerViewStyleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.tilesWinExplorerViewStyleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.smallWinExplorerViewStyleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.mediumWinExplorerViewStyleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.largeWinExplorerViewStyleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.extralargeWinExplorerViewStyleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.skinBarSubItem = new DevExpress.XtraBars.SkinBarSubItem();
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.fooBarDataSet = new System.Data.DataSet();
         this.masterTable = new System.Data.DataTable();
         this.masterIDColumn = new System.Data.DataColumn();
         this.masterNameColumn = new System.Data.DataColumn();
         this.masterDescrColumn = new System.Data.DataColumn();
         this.detailTable = new System.Data.DataTable();
         this.detailMasterIDColumn = new System.Data.DataColumn();
         this.detailArgColumn = new System.Data.DataColumn();
         this.detailValColumn = new System.Data.DataColumn();
         this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
         this.colIDColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colnameColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colmasterDescrColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
         this.colIDColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colnameColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colmasterDescrColumn = new DevExpress.XtraGrid.Columns.GridColumn();
         this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
         this.colIDColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
         this.layoutViewField_colIDColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
         this.colnameColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
         this.layoutViewField_colnameColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
         this.colmasterDescrColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
         this.layoutViewField_colmasterDescrColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
         this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colIDColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colnameColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colmasterDescrColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.fooBarDataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.masterTable)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.detailTable)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIDColumn2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colnameColumn2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colmasterDescrColumn2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         this.SuspendLayout();
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
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.gridViewBarButtonItem,
            this.layoutViewBarButtonItem,
            this.cardViewBarButtonItem,
            this.skinBarSubItem,
            this.winExplorerBarSubItem,
            this.contentWinExplorerViewStyleBarButtonItem,
            this.listWinExplorerViewStyleBarButtonItem,
            this.tilesWinExplorerViewStyleBarButtonItem,
            this.smallWinExplorerViewStyleBarButtonItem,
            this.mediumWinExplorerViewStyleBarButtonItem,
            this.largeWinExplorerViewStyleBarButtonItem,
            this.extralargeWinExplorerViewStyleBarButtonItem,
            this.defaultWinExplorerViewStyleBarButtonItem});
         this.barManager1.MainMenu = this.bar2;
         this.barManager1.MaxItemId = 14;
         this.barManager1.StatusBar = this.bar3;
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 1;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.gridViewBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.layoutViewBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.cardViewBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.winExplorerBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem)});
         this.bar1.Text = "Tools";
         // 
         // gridViewBarButtonItem
         // 
         this.gridViewBarButtonItem.Caption = "Grid";
         this.gridViewBarButtonItem.Id = 0;
         this.gridViewBarButtonItem.Name = "gridViewBarButtonItem";
         this.gridViewBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.gridViewBarButtonItem_ItemClick);
         // 
         // layoutViewBarButtonItem
         // 
         this.layoutViewBarButtonItem.Caption = "Layout";
         this.layoutViewBarButtonItem.Id = 1;
         this.layoutViewBarButtonItem.Name = "layoutViewBarButtonItem";
         this.layoutViewBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.layoutViewBarButtonItem_ItemClick);
         // 
         // cardViewBarButtonItem
         // 
         this.cardViewBarButtonItem.Caption = "Card";
         this.cardViewBarButtonItem.Id = 2;
         this.cardViewBarButtonItem.Name = "cardViewBarButtonItem";
         this.cardViewBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cardViewBarButtonItem_ItemClick);
         // 
         // winExplorerBarSubItem
         // 
         this.winExplorerBarSubItem.Caption = "WinExplorer";
         this.winExplorerBarSubItem.Id = 5;
         this.winExplorerBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.defaultWinExplorerViewStyleBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.contentWinExplorerViewStyleBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.listWinExplorerViewStyleBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.tilesWinExplorerViewStyleBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.smallWinExplorerViewStyleBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.mediumWinExplorerViewStyleBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.largeWinExplorerViewStyleBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.extralargeWinExplorerViewStyleBarButtonItem)});
         this.winExplorerBarSubItem.Name = "winExplorerBarSubItem";
         // 
         // defaultWinExplorerViewStyleBarButtonItem
         // 
         this.defaultWinExplorerViewStyleBarButtonItem.Caption = "Default";
         this.defaultWinExplorerViewStyleBarButtonItem.Id = 13;
         this.defaultWinExplorerViewStyleBarButtonItem.Name = "defaultWinExplorerViewStyleBarButtonItem";
         this.defaultWinExplorerViewStyleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.defaultWinExplorerViewStyleBarButtonItem_ItemClick);
         // 
         // contentWinExplorerViewStyleBarButtonItem
         // 
         this.contentWinExplorerViewStyleBarButtonItem.Caption = "Content";
         this.contentWinExplorerViewStyleBarButtonItem.Id = 6;
         this.contentWinExplorerViewStyleBarButtonItem.Name = "contentWinExplorerViewStyleBarButtonItem";
         this.contentWinExplorerViewStyleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.contentWinExplorerViewStyleBarButtonItem_ItemClick);
         // 
         // listWinExplorerViewStyleBarButtonItem
         // 
         this.listWinExplorerViewStyleBarButtonItem.Caption = "List";
         this.listWinExplorerViewStyleBarButtonItem.Id = 7;
         this.listWinExplorerViewStyleBarButtonItem.Name = "listWinExplorerViewStyleBarButtonItem";
         this.listWinExplorerViewStyleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.listWinExplorerViewStyleBarButtonItem_ItemClick);
         // 
         // tilesWinExplorerViewStyleBarButtonItem
         // 
         this.tilesWinExplorerViewStyleBarButtonItem.Caption = "Tiles";
         this.tilesWinExplorerViewStyleBarButtonItem.Id = 8;
         this.tilesWinExplorerViewStyleBarButtonItem.Name = "tilesWinExplorerViewStyleBarButtonItem";
         this.tilesWinExplorerViewStyleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tilesWinExplorerViewStyleBarButtonItem_ItemClick);
         // 
         // smallWinExplorerViewStyleBarButtonItem
         // 
         this.smallWinExplorerViewStyleBarButtonItem.Caption = "Small";
         this.smallWinExplorerViewStyleBarButtonItem.Id = 9;
         this.smallWinExplorerViewStyleBarButtonItem.Name = "smallWinExplorerViewStyleBarButtonItem";
         this.smallWinExplorerViewStyleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.smallWinExplorerViewStyleBarButtonItem_ItemClick);
         // 
         // mediumWinExplorerViewStyleBarButtonItem
         // 
         this.mediumWinExplorerViewStyleBarButtonItem.Caption = "Medium";
         this.mediumWinExplorerViewStyleBarButtonItem.Id = 10;
         this.mediumWinExplorerViewStyleBarButtonItem.Name = "mediumWinExplorerViewStyleBarButtonItem";
         this.mediumWinExplorerViewStyleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mediumWinExplorerViewStyleBarButtonItem_ItemClick);
         // 
         // largeWinExplorerViewStyleBarButtonItem
         // 
         this.largeWinExplorerViewStyleBarButtonItem.Caption = "Large";
         this.largeWinExplorerViewStyleBarButtonItem.Id = 11;
         this.largeWinExplorerViewStyleBarButtonItem.Name = "largeWinExplorerViewStyleBarButtonItem";
         this.largeWinExplorerViewStyleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.largeWinExplorerViewStyleBarButtonItem_ItemClick);
         // 
         // extralargeWinExplorerViewStyleBarButtonItem
         // 
         this.extralargeWinExplorerViewStyleBarButtonItem.Caption = "ExtraLarge";
         this.extralargeWinExplorerViewStyleBarButtonItem.Id = 12;
         this.extralargeWinExplorerViewStyleBarButtonItem.Name = "extralargeWinExplorerViewStyleBarButtonItem";
         this.extralargeWinExplorerViewStyleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.extralargeWinExplorerViewStyleBarButtonItem_ItemClick);
         // 
         // skinBarSubItem
         // 
         this.skinBarSubItem.Caption = "Skin && Themes";
         this.skinBarSubItem.Id = 4;
         this.skinBarSubItem.Name = "skinBarSubItem";
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
         this.barDockControlTop.Size = new System.Drawing.Size(994, 50);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 601);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(994, 22);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 551);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(994, 50);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 551);
         // 
         // gridControl1
         // 
         this.gridControl1.DataMember = "Master";
         this.gridControl1.DataSource = this.fooBarDataSet;
         this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
         this.gridControl1.Location = new System.Drawing.Point(0, 50);
         this.gridControl1.MainView = this.cardView1;
         this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
         this.gridControl1.MenuManager = this.barManager1;
         this.gridControl1.Name = "gridControl1";
         this.gridControl1.Size = new System.Drawing.Size(994, 551);
         this.gridControl1.TabIndex = 4;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1,
            this.winExplorerView1,
            this.layoutView1,
            this.gridView1});
         // 
         // fooBarDataSet
         // 
         this.fooBarDataSet.DataSetName = "FooBar";
         this.fooBarDataSet.Relations.AddRange(new System.Data.DataRelation[] {
            new System.Data.DataRelation("MasterDetail", "Master", "Detail", new string[] {
                        "IDColumn"}, new string[] {
                        "masterIDColumn"}, false)});
         this.fooBarDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.masterTable,
            this.detailTable});
         // 
         // masterTable
         // 
         this.masterTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.masterIDColumn,
            this.masterNameColumn,
            this.masterDescrColumn});
         this.masterTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "IDColumn"}, true)});
         this.masterTable.PrimaryKey = new System.Data.DataColumn[] {
        this.masterIDColumn};
         this.masterTable.TableName = "Master";
         // 
         // masterIDColumn
         // 
         this.masterIDColumn.AllowDBNull = false;
         this.masterIDColumn.Caption = "ID";
         this.masterIDColumn.ColumnName = "IDColumn";
         // 
         // masterNameColumn
         // 
         this.masterNameColumn.Caption = "Name";
         this.masterNameColumn.ColumnName = "nameColumn";
         // 
         // masterDescrColumn
         // 
         this.masterDescrColumn.Caption = "Description";
         this.masterDescrColumn.ColumnName = "masterDescrColumn";
         // 
         // detailTable
         // 
         this.detailTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.detailMasterIDColumn,
            this.detailArgColumn,
            this.detailValColumn});
         this.detailTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "masterIDColumn",
                        "argColumn"}, true),
            new System.Data.ForeignKeyConstraint("MasterDetail", "Master", new string[] {
                        "IDColumn"}, new string[] {
                        "masterIDColumn"}, System.Data.AcceptRejectRule.Cascade, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
         this.detailTable.PrimaryKey = new System.Data.DataColumn[] {
        this.detailMasterIDColumn,
        this.detailArgColumn};
         this.detailTable.TableName = "Detail";
         // 
         // detailMasterIDColumn
         // 
         this.detailMasterIDColumn.AllowDBNull = false;
         this.detailMasterIDColumn.Caption = "ID";
         this.detailMasterIDColumn.ColumnName = "masterIDColumn";
         // 
         // detailArgColumn
         // 
         this.detailArgColumn.AllowDBNull = false;
         this.detailArgColumn.Caption = "Type";
         this.detailArgColumn.ColumnName = "argColumn";
         // 
         // detailValColumn
         // 
         this.detailValColumn.Caption = "Count";
         this.detailValColumn.ColumnName = "valColumn";
         this.detailValColumn.DataType = typeof(short);
         // 
         // cardView1
         // 
         this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDColumn3,
            this.colnameColumn3,
            this.colmasterDescrColumn3});
         this.cardView1.FocusedCardTopFieldIndex = 0;
         this.cardView1.GridControl = this.gridControl1;
         this.cardView1.Name = "cardView1";
         this.cardView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.cardView1_CustomUnboundColumnData);
         // 
         // colIDColumn3
         // 
         this.colIDColumn3.FieldName = "IDColumn";
         this.colIDColumn3.Name = "colIDColumn3";
         this.colIDColumn3.Visible = true;
         this.colIDColumn3.VisibleIndex = 0;
         // 
         // colnameColumn3
         // 
         this.colnameColumn3.FieldName = "nameColumn";
         this.colnameColumn3.Name = "colnameColumn3";
         this.colnameColumn3.Visible = true;
         this.colnameColumn3.VisibleIndex = 1;
         // 
         // colmasterDescrColumn3
         // 
         this.colmasterDescrColumn3.FieldName = "masterDescrColumn";
         this.colmasterDescrColumn3.Name = "colmasterDescrColumn3";
         this.colmasterDescrColumn3.Visible = true;
         this.colmasterDescrColumn3.VisibleIndex = 2;
         // 
         // winExplorerView1
         // 
         this.winExplorerView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDColumn,
            this.colnameColumn,
            this.colmasterDescrColumn});
         this.winExplorerView1.GridControl = this.gridControl1;
         this.winExplorerView1.Name = "winExplorerView1";
         this.winExplorerView1.OptionsView.ShowCheckBoxes = true;
         this.winExplorerView1.OptionsView.ShowCheckBoxInGroupCaption = true;
         this.winExplorerView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.winExplorerView1_CustomUnboundColumnData);
         // 
         // colIDColumn
         // 
         this.colIDColumn.FieldName = "IDColumn";
         this.colIDColumn.Name = "colIDColumn";
         this.colIDColumn.Visible = true;
         this.colIDColumn.VisibleIndex = 0;
         // 
         // colnameColumn
         // 
         this.colnameColumn.FieldName = "nameColumn";
         this.colnameColumn.Name = "colnameColumn";
         this.colnameColumn.Visible = true;
         this.colnameColumn.VisibleIndex = 1;
         // 
         // colmasterDescrColumn
         // 
         this.colmasterDescrColumn.FieldName = "masterDescrColumn";
         this.colmasterDescrColumn.Name = "colmasterDescrColumn";
         this.colmasterDescrColumn.Visible = true;
         this.colmasterDescrColumn.VisibleIndex = 2;
         // 
         // layoutView1
         // 
         this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colIDColumn2,
            this.colnameColumn2,
            this.colmasterDescrColumn2});
         this.layoutView1.GridControl = this.gridControl1;
         this.layoutView1.Name = "layoutView1";
         this.layoutView1.TemplateCard = this.layoutViewCard1;
         this.layoutView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.layoutView1_CustomUnboundColumnData);
         // 
         // colIDColumn2
         // 
         this.colIDColumn2.FieldName = "IDColumn";
         this.colIDColumn2.LayoutViewField = this.layoutViewField_colIDColumn2;
         this.colIDColumn2.Name = "colIDColumn2";
         // 
         // layoutViewField_colIDColumn2
         // 
         this.layoutViewField_colIDColumn2.EditorPreferredWidth = 138;
         this.layoutViewField_colIDColumn2.Location = new System.Drawing.Point(0, 0);
         this.layoutViewField_colIDColumn2.Name = "layoutViewField_colIDColumn2";
         this.layoutViewField_colIDColumn2.Size = new System.Drawing.Size(204, 20);
         this.layoutViewField_colIDColumn2.TextSize = new System.Drawing.Size(105, 13);
         // 
         // colnameColumn2
         // 
         this.colnameColumn2.FieldName = "nameColumn";
         this.colnameColumn2.LayoutViewField = this.layoutViewField_colnameColumn2;
         this.colnameColumn2.Name = "colnameColumn2";
         // 
         // layoutViewField_colnameColumn2
         // 
         this.layoutViewField_colnameColumn2.EditorPreferredWidth = 138;
         this.layoutViewField_colnameColumn2.Location = new System.Drawing.Point(0, 20);
         this.layoutViewField_colnameColumn2.Name = "layoutViewField_colnameColumn2";
         this.layoutViewField_colnameColumn2.Size = new System.Drawing.Size(204, 20);
         this.layoutViewField_colnameColumn2.TextSize = new System.Drawing.Size(105, 13);
         // 
         // colmasterDescrColumn2
         // 
         this.colmasterDescrColumn2.FieldName = "masterDescrColumn";
         this.colmasterDescrColumn2.LayoutViewField = this.layoutViewField_colmasterDescrColumn2;
         this.colmasterDescrColumn2.Name = "colmasterDescrColumn2";
         // 
         // layoutViewField_colmasterDescrColumn2
         // 
         this.layoutViewField_colmasterDescrColumn2.EditorPreferredWidth = 138;
         this.layoutViewField_colmasterDescrColumn2.Location = new System.Drawing.Point(0, 40);
         this.layoutViewField_colmasterDescrColumn2.Name = "layoutViewField_colmasterDescrColumn2";
         this.layoutViewField_colmasterDescrColumn2.Size = new System.Drawing.Size(204, 20);
         this.layoutViewField_colmasterDescrColumn2.TextSize = new System.Drawing.Size(105, 13);
         // 
         // layoutViewCard1
         // 
         this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
         this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colIDColumn2,
            this.layoutViewField_colnameColumn2,
            this.layoutViewField_colmasterDescrColumn2});
         this.layoutViewCard1.Name = "layoutViewCard1";
         this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDColumn1,
            this.colnameColumn1,
            this.colmasterDescrColumn1});
         this.gridView1.GridControl = this.gridControl1;
         this.gridView1.Name = "gridView1";
         this.gridView1.OptionsMenu.DialogFormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
         this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
         this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
         this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
         // 
         // colIDColumn1
         // 
         this.colIDColumn1.FieldName = "IDColumn";
         this.colIDColumn1.Name = "colIDColumn1";
         this.colIDColumn1.Visible = true;
         this.colIDColumn1.VisibleIndex = 0;
         // 
         // colnameColumn1
         // 
         this.colnameColumn1.FieldName = "nameColumn";
         this.colnameColumn1.Name = "colnameColumn1";
         this.colnameColumn1.Visible = true;
         this.colnameColumn1.VisibleIndex = 1;
         // 
         // colmasterDescrColumn1
         // 
         this.colmasterDescrColumn1.FieldName = "masterDescrColumn";
         this.colmasterDescrColumn1.Name = "colmasterDescrColumn1";
         this.colmasterDescrColumn1.Visible = true;
         this.colmasterDescrColumn1.VisibleIndex = 2;
         // 
         // defaultLookAndFeel1
         // 
         this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(994, 623);
         this.Controls.Add(this.gridControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.fooBarDataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.masterTable)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.detailTable)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIDColumn2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colnameColumn2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colmasterDescrColumn2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
      private DevExpress.XtraBars.BarButtonItem gridViewBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem layoutViewBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem cardViewBarButtonItem;
      private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
      private DevExpress.XtraBars.BarSubItem winExplorerBarSubItem;
      private DevExpress.XtraBars.BarButtonItem defaultWinExplorerViewStyleBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem contentWinExplorerViewStyleBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem listWinExplorerViewStyleBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem tilesWinExplorerViewStyleBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem smallWinExplorerViewStyleBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem mediumWinExplorerViewStyleBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem largeWinExplorerViewStyleBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem extralargeWinExplorerViewStyleBarButtonItem;
      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
      private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
      private DevExpress.XtraGrid.Views.Card.CardView cardView1;
      private System.Data.DataSet fooBarDataSet;
      private System.Data.DataTable masterTable;
      private System.Data.DataColumn masterIDColumn;
      private System.Data.DataColumn masterNameColumn;
      private System.Data.DataColumn masterDescrColumn;
      private System.Data.DataTable detailTable;
      private System.Data.DataColumn detailMasterIDColumn;
      private System.Data.DataColumn detailArgColumn;
      private System.Data.DataColumn detailValColumn;
      private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
      private DevExpress.XtraGrid.Columns.GridColumn colIDColumn;
      private DevExpress.XtraGrid.Columns.GridColumn colnameColumn;
      private DevExpress.XtraGrid.Columns.GridColumn colmasterDescrColumn;
      private DevExpress.XtraGrid.Columns.LayoutViewColumn colIDColumn2;
      private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIDColumn2;
      private DevExpress.XtraGrid.Columns.LayoutViewColumn colnameColumn2;
      private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colnameColumn2;
      private DevExpress.XtraGrid.Columns.LayoutViewColumn colmasterDescrColumn2;
      private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colmasterDescrColumn2;
      private DevExpress.XtraGrid.Columns.GridColumn colIDColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn colnameColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn colmasterDescrColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn colIDColumn3;
      private DevExpress.XtraGrid.Columns.GridColumn colnameColumn3;
      private DevExpress.XtraGrid.Columns.GridColumn colmasterDescrColumn3;
   }
}

