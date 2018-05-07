namespace PropertyGridControlTest
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
         this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
         this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
         this.completePropertyControl1 = new PropertyGridControlTest.CompletePropertyControl();
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
         this.SuspendLayout();
         // 
         // propertyGridControl1
         // 
         this.propertyGridControl1.Location = new System.Drawing.Point(12, 12);
         this.propertyGridControl1.Name = "propertyGridControl1";
         this.propertyGridControl1.Size = new System.Drawing.Size(400, 752);
         this.propertyGridControl1.TabIndex = 0;
         this.propertyGridControl1.Click += new System.EventHandler(this.propertyGridControl1_Click);
         // 
         // vGridControl1
         // 
         this.vGridControl1.Location = new System.Drawing.Point(418, 12);
         this.vGridControl1.Name = "vGridControl1";
         this.vGridControl1.Size = new System.Drawing.Size(502, 752);
         this.vGridControl1.TabIndex = 1;
         // 
         // completePropertyControl1
         // 
         this.completePropertyControl1.Dock = System.Windows.Forms.DockStyle.Right;
         this.completePropertyControl1.Location = new System.Drawing.Point(926, 0);
         this.completePropertyControl1.Name = "completePropertyControl1";
         this.completePropertyControl1.Size = new System.Drawing.Size(567, 776);
         this.completePropertyControl1.TabIndex = 2;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1493, 776);
         this.Controls.Add(this.completePropertyControl1);
         this.Controls.Add(this.vGridControl1);
         this.Controls.Add(this.propertyGridControl1);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
      private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
      private CompletePropertyControl completePropertyControl1;
   }
}

