namespace PropertyGridControlTest
{
   partial class SearchPropertyXtraUserControl
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
         this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
         this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
         this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
         this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
         this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
         this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.propertyXtraUserControl1 = new PropertyGridControlTest.PropertyXtraUserControl();
         ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
         this.panelControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
         this.panelControl2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
         this.panelControl3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
         this.panelControl4.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         this.SuspendLayout();
         // 
         // panelControl1
         // 
         this.panelControl1.Controls.Add(this.comboBoxEdit1);
         this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panelControl1.Location = new System.Drawing.Point(0, 0);
         this.panelControl1.Name = "panelControl1";
         this.panelControl1.Size = new System.Drawing.Size(737, 32);
         this.panelControl1.TabIndex = 0;
         // 
         // panelControl2
         // 
         this.panelControl2.Controls.Add(this.panelControl3);
         this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panelControl2.Location = new System.Drawing.Point(0, 32);
         this.panelControl2.Name = "panelControl2";
         this.panelControl2.Size = new System.Drawing.Size(737, 838);
         this.panelControl2.TabIndex = 1;
         // 
         // comboBoxEdit1
         // 
         this.comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.comboBoxEdit1.Location = new System.Drawing.Point(3, 3);
         this.comboBoxEdit1.Name = "comboBoxEdit1";
         this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.comboBoxEdit1.Size = new System.Drawing.Size(731, 26);
         this.comboBoxEdit1.TabIndex = 0;
         // 
         // panelControl3
         // 
         this.panelControl3.Controls.Add(this.panelControl4);
         this.panelControl3.Controls.Add(this.searchControl1);
         this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panelControl3.Location = new System.Drawing.Point(3, 3);
         this.panelControl3.Name = "panelControl3";
         this.panelControl3.Size = new System.Drawing.Size(731, 832);
         this.panelControl3.TabIndex = 0;
         // 
         // searchControl1
         // 
         this.searchControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.searchControl1.Location = new System.Drawing.Point(3, 3);
         this.searchControl1.Name = "searchControl1";
         this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
         this.searchControl1.Size = new System.Drawing.Size(725, 26);
         this.searchControl1.TabIndex = 0;
         // 
         // panelControl4
         // 
         this.panelControl4.Controls.Add(this.propertyXtraUserControl1);
         this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panelControl4.Location = new System.Drawing.Point(3, 29);
         this.panelControl4.Name = "panelControl4";
         this.panelControl4.Size = new System.Drawing.Size(725, 800);
         this.panelControl4.TabIndex = 1;
         // 
         // barManager1
         // 
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.Form = this;
         this.barManager1.MaxItemId = 0;
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(737, 0);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 870);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(737, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 870);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(737, 0);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 870);
         // 
         // propertyXtraUserControl1
         // 
         this.propertyXtraUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.propertyXtraUserControl1.Location = new System.Drawing.Point(3, 3);
         this.propertyXtraUserControl1.Name = "propertyXtraUserControl1";
         this.propertyXtraUserControl1.Size = new System.Drawing.Size(719, 794);
         this.propertyXtraUserControl1.TabIndex = 0;
         // 
         // SearchPropertyXtraUserControl
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.panelControl2);
         this.Controls.Add(this.panelControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "SearchPropertyXtraUserControl";
         this.Size = new System.Drawing.Size(737, 870);
         ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
         this.panelControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
         this.panelControl2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
         this.panelControl3.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
         this.panelControl4.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.PanelControl panelControl1;
      private DevExpress.XtraEditors.PanelControl panelControl2;
      private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
      private DevExpress.XtraEditors.PanelControl panelControl3;
      private DevExpress.XtraEditors.PanelControl panelControl4;
      private DevExpress.XtraEditors.SearchControl searchControl1;
      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private PropertyXtraUserControl propertyXtraUserControl1;
   }
}
