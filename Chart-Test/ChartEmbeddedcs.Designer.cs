namespace Chart_Test
{
   partial class ChartEmbeddedcs
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
         DevExpress.XtraCharts.TextAnnotation textAnnotation1 = new DevExpress.XtraCharts.TextAnnotation();
         DevExpress.XtraCharts.SeriesPointAnchorPoint seriesPointAnchorPoint1 = new DevExpress.XtraCharts.SeriesPointAnchorPoint();
         DevExpress.XtraCharts.RelativePosition relativePosition1 = new DevExpress.XtraCharts.RelativePosition();
         DevExpress.XtraCharts.TextAnnotation textAnnotation2 = new DevExpress.XtraCharts.TextAnnotation();
         DevExpress.XtraCharts.SeriesPointAnchorPoint seriesPointAnchorPoint2 = new DevExpress.XtraCharts.SeriesPointAnchorPoint();
         DevExpress.XtraCharts.RelativePosition relativePosition2 = new DevExpress.XtraCharts.RelativePosition();
         DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
         DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
         DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("alex", new object[] {
            ((object)(20D))}, 0);
         DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("simone", new object[] {
            ((object)(30D))}, 1);
         this.barManager1 = new DevExpress.XtraBars.BarManager();
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(seriesPointAnchorPoint1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(textAnnotation2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(seriesPointAnchorPoint2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
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
         this.barManager1.MainMenu = this.bar2;
         this.barManager1.MaxItemId = 0;
         this.barManager1.StatusBar = this.bar3;
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 1;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar1.Text = "Tools";
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
         this.barDockControlTop.Size = new System.Drawing.Size(696, 48);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 410);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(696, 22);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 48);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 362);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(696, 48);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 362);
         // 
         // chartControl1
         // 
         seriesPointAnchorPoint1.SeriesID = 0;
         seriesPointAnchorPoint1.SeriesPointID = 0;
         textAnnotation1.AnchorPoint = seriesPointAnchorPoint1;
         textAnnotation1.Name = "Text Annotation 1";
         textAnnotation1.ShapePosition = relativePosition1;
         seriesPointAnchorPoint2.SeriesID = 0;
         seriesPointAnchorPoint2.SeriesPointID = 1;
         textAnnotation2.AnchorPoint = seriesPointAnchorPoint2;
         textAnnotation2.Name = "Text Annotation 2";
         textAnnotation2.ShapePosition = relativePosition2;
         textAnnotation2.Text = "LAlalalalal";
         this.chartControl1.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation1,
            textAnnotation2});
         xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
         xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
         this.chartControl1.Diagram = xyDiagram1;
         this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.chartControl1.Legend.Name = "Default Legend";
         this.chartControl1.Location = new System.Drawing.Point(0, 48);
         this.chartControl1.Name = "chartControl1";
         series1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
         series1.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.True;
         series1.CrosshairLabelPattern = "{A}";
         series1.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.True;
         series1.LegendName = "Default Legend";
         series1.Name = "Series 1";
         seriesPoint1.ColorSerializable = "#FF8080";
         seriesPoint2.ColorSerializable = "Green";
         series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2});
         series1.SeriesID = 0;
         series1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
         series1.ToolTipPointPattern = "{V}";
         series1.ToolTipSeriesPattern = "{S:f1}";
         this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
         this.chartControl1.Size = new System.Drawing.Size(696, 362);
         this.chartControl1.TabIndex = 4;
         this.chartControl1.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
         // 
         // ChartEmbeddedcs
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(696, 432);
         this.Controls.Add(this.chartControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "ChartEmbeddedcs";
         this.Text = "ChartEmbeddedcs";
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(seriesPointAnchorPoint1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(seriesPointAnchorPoint2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(textAnnotation2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
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
      private DevExpress.XtraCharts.ChartControl chartControl1;
   }
}