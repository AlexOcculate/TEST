namespace OfficeInspiredUIManual
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
         this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
         this.navigationBarItem1 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
         this.navigationBarItem2 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
         this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
         this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
         ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
         this.SuspendLayout();
         // 
         // officeNavigationBar1
         // 
         this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navigationBarItem1,
            this.navigationBarItem2});
         this.officeNavigationBar1.Location = new System.Drawing.Point(0, 646);
         this.officeNavigationBar1.Name = "officeNavigationBar1";
         this.officeNavigationBar1.Size = new System.Drawing.Size(586, 59);
         this.officeNavigationBar1.TabIndex = 0;
         this.officeNavigationBar1.Text = "officeNavigationBar1";
         // 
         // navigationBarItem1
         // 
         this.navigationBarItem1.Name = "navigationBarItem1";
         this.navigationBarItem1.Text = "Item1";
         // 
         // navigationBarItem2
         // 
         this.navigationBarItem2.Name = "navigationBarItem2";
         this.navigationBarItem2.Text = "Item2";
         // 
         // navBarControl1
         // 
         this.navBarControl1.ActiveGroup = this.navBarGroup1;
         this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
         this.navBarControl1.Location = new System.Drawing.Point(3, 48);
         this.navBarControl1.Name = "navBarControl1";
         this.navBarControl1.Size = new System.Drawing.Size(140, 593);
         this.navBarControl1.TabIndex = 1;
         this.navBarControl1.Text = "navBarControl1";
         // 
         // navBarGroup1
         // 
         this.navBarGroup1.Caption = "navBarGroup1";
         this.navBarGroup1.Expanded = true;
         this.navBarGroup1.Name = "navBarGroup1";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(586, 705);
         this.Controls.Add(this.navBarControl1);
         this.Controls.Add(this.officeNavigationBar1);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
      private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem1;
      private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem2;
      private DevExpress.XtraNavBar.NavBarControl navBarControl1;
      private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
   }
}

