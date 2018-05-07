namespace PropertyGridControlTest
{
   partial class CompletePropertyControl
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
         this.propertyDescriptionControl1 = new DevExpress.XtraVerticalGrid.PropertyDescriptionControl();
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.categorySortBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.alphabeticSortBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.expandBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.collapseBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
         this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // propertyGridControl1
         // 
         this.propertyGridControl1.Location = new System.Drawing.Point(0, 72);
         this.propertyGridControl1.Name = "propertyGridControl1";
         this.propertyGridControl1.OptionsFind.FindFilterColumns = "Caption";
         this.propertyGridControl1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
         this.propertyGridControl1.OptionsView.ShowFilterPanelMode = DevExpress.XtraVerticalGrid.ShowFilterPanelMode.ShowAlways;
         this.propertyGridControl1.Size = new System.Drawing.Size(708, 780);
         this.propertyGridControl1.TabIndex = 0;
         this.propertyGridControl1.FocusedRowChanged += new DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventHandler(this.propertyGridControl1_FocusedRowChanged);
         // 
         // propertyDescriptionControl1
         // 
         this.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.propertyDescriptionControl1.Location = new System.Drawing.Point(0, 752);
         this.propertyDescriptionControl1.Name = "propertyDescriptionControl1";
         this.propertyDescriptionControl1.PropertyGrid = this.propertyGridControl1;
         this.propertyDescriptionControl1.Size = new System.Drawing.Size(708, 100);
         this.propertyDescriptionControl1.TabIndex = 1;
         this.propertyDescriptionControl1.TabStop = false;
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.Form = this;
         this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.categorySortBarButtonItem,
            this.alphabeticSortBarButtonItem,
            this.expandBarButtonItem,
            this.collapseBarButtonItem});
         this.barManager1.MaxItemId = 5;
         this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 0;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar1.FloatSize = new System.Drawing.Size(433, 40);
         this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.categorySortBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.alphabeticSortBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.expandBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.collapseBarButtonItem)});
         this.bar1.OptionsBar.DisableClose = true;
         this.bar1.OptionsBar.DisableCustomization = true;
         this.bar1.OptionsBar.DrawBorder = false;
         this.bar1.OptionsBar.DrawDragBorder = false;
         this.bar1.Text = "Tools";
         // 
         // categorySortBarButtonItem
         // 
         this.categorySortBarButtonItem.Caption = "Category Sort";
         this.categorySortBarButtonItem.Id = 0;
         this.categorySortBarButtonItem.Name = "categorySortBarButtonItem";
         this.categorySortBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.categoryBarButtonItem_ItemClick);
         // 
         // alphabeticSortBarButtonItem
         // 
         this.alphabeticSortBarButtonItem.Caption = "Alphabetic Sort";
         this.alphabeticSortBarButtonItem.Id = 1;
         this.alphabeticSortBarButtonItem.Name = "alphabeticSortBarButtonItem";
         this.alphabeticSortBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.alphabeticSortBarButtonItem_ItemClick);
         // 
         // expandBarButtonItem
         // 
         this.expandBarButtonItem.Caption = "Expand";
         this.expandBarButtonItem.Id = 3;
         this.expandBarButtonItem.Name = "expandBarButtonItem";
         this.expandBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.expandBarButtonItem_ItemClick);
         // 
         // collapseBarButtonItem
         // 
         this.collapseBarButtonItem.Caption = "Collapse";
         this.collapseBarButtonItem.Id = 4;
         this.collapseBarButtonItem.Name = "collapseBarButtonItem";
         this.collapseBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.collapseBarButtonItem_ItemClick);
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(708, 40);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 852);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(708, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 812);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(708, 40);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 812);
         // 
         // repositoryItemComboBox1
         // 
         this.repositoryItemComboBox1.AutoHeight = false;
         this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
         // 
         // searchControl1
         // 
         this.searchControl1.Client = this.propertyGridControl1;
         this.searchControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.searchControl1.Location = new System.Drawing.Point(0, 40);
         this.searchControl1.MenuManager = this.barManager1;
         this.searchControl1.Name = "searchControl1";
         this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton(),
            new DevExpress.XtraEditors.Repository.MRUButton()});
         this.searchControl1.Properties.Client = this.propertyGridControl1;
         this.searchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
         this.searchControl1.Properties.ShowMRUButton = true;
         this.searchControl1.Size = new System.Drawing.Size(708, 26);
         this.searchControl1.TabIndex = 6;
         // 
         // CompletePropertyControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.searchControl1);
         this.Controls.Add(this.propertyDescriptionControl1);
         this.Controls.Add(this.propertyGridControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "CompletePropertyControl";
         this.Size = new System.Drawing.Size(708, 852);
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
      private DevExpress.XtraVerticalGrid.PropertyDescriptionControl propertyDescriptionControl1;
      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem categorySortBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem alphabeticSortBarButtonItem;
      private DevExpress.XtraBars.BarButtonItem expandBarButtonItem;
      private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
      private DevExpress.XtraBars.BarButtonItem collapseBarButtonItem;
      private DevExpress.XtraEditors.SearchControl searchControl1;
   }
}
