namespace TreeListTest
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
         this.toolsBar = new DevExpress.XtraBars.Bar();
         this.mainMenuBar = new DevExpress.XtraBars.Bar();
         this.statusBar = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.treeList = new DevExpress.XtraTreeList.TreeList();
         this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
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
         this.barManager1.MainMenu = this.mainMenuBar;
         this.barManager1.MaxItemId = 0;
         this.barManager1.StatusBar = this.statusBar;
         // 
         // toolsBar
         // 
         this.toolsBar.BarName = "Tools";
         this.toolsBar.DockCol = 0;
         this.toolsBar.DockRow = 1;
         this.toolsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.toolsBar.Text = "Tools";
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
         this.barDockControlTop.Size = new System.Drawing.Size(881, 54);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 693);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(881, 26);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 54);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 639);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(881, 54);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 639);
         // 
         // treeList
         // 
         this.treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
         this.treeList.Cursor = System.Windows.Forms.Cursors.Default;
         this.treeList.DataSource = null;
         this.treeList.Dock = System.Windows.Forms.DockStyle.Fill;
         this.treeList.Location = new System.Drawing.Point(0, 54);
         this.treeList.Name = "treeList";
         this.treeList.BeginUnboundLoad();
         this.treeList.AppendNode(new object[] {
            "Alex"}, -1);
         this.treeList.AppendNode(new object[] {
            "Mello"}, -1);
         this.treeList.AppendNode(new object[] {
            "Alex Mello"}, 1);
         this.treeList.AppendNode(new object[] {
            "Occulate"}, -1);
         this.treeList.EndUnboundLoad();
         this.treeList.OptionsView.ShowCheckBoxes = true;
         this.treeList.Size = new System.Drawing.Size(881, 639);
         this.treeList.TabIndex = 4;
         // 
         // treeListColumn1
         // 
         this.treeListColumn1.Caption = "treeListColumn1";
         this.treeListColumn1.FieldName = "treeListColumn1";
         this.treeListColumn1.Name = "treeListColumn1";
         this.treeListColumn1.Visible = true;
         this.treeListColumn1.VisibleIndex = 0;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(881, 719);
         this.Controls.Add(this.treeList);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
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
      private DevExpress.XtraTreeList.TreeList treeList;
      private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
   }
}

