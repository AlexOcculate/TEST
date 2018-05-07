using DevExpress.XtraCharts;
using System;
using System.Linq;

namespace Chart_Test
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         this.InitializeComponent( );
         this.Controls.Add( CreateChart( ) );
      }

      private ChartControl CreateChart()
      {
         //XYDiagram xyDiagram1 = new XYDiagram( );
         //xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
         //xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
         //
         SeriesPoint sp1 = new SeriesPoint( "sch", new object[ ] { ((object) (20D)) } )
         {
            ColorSerializable = "#F79646"
         };
         SeriesPoint sp2 = new SeriesPoint( "tbl", new object[ ] { ((object) (100D)) } )
         {
            ColorSerializable = "#4BACC6"
         };
         SeriesPoint sp3 = new SeriesPoint( "vw", new object[ ] { ((object) (50D)) } )
         {
            ColorSerializable = "#8064A2"
         };
         SeriesPoint sp4 = new SeriesPoint( "col", new object[ ] { ((object) (2000D)) } )
         {
            ColorSerializable = "#9BBB59"
         };
         //
         Series series1 = new Series( "alex", ViewType.Bar );
         series1.Points.AddRange( new DevExpress.XtraCharts.SeriesPoint[ ]
         {
               sp1,
               sp2,
               sp3,
               sp4
         } );
         ChartControl cc = new ChartControl( )
         {
            Name = "chartControl1",
            //Diagram = xyDiagram1,
            Dock = System.Windows.Forms.DockStyle.Fill,
            Location = new System.Drawing.Point( 0, 46 ),
            Size = new System.Drawing.Size( 632, 214 ),
            SeriesSerializable = new DevExpress.XtraCharts.Series[ ]
            {
               series1
            }
         };
         cc.Legend.Name = "Default Legend";
         //
         return cc;
      }
      private ChartControl CreateChartControl()
      {
         XYDiagram xyDiagram1 = new XYDiagram( );
         Series series1 = new Series( "alex", ViewType.Bar );
         //SeriesPoint sp1 = new SeriesPoint( "sch", new object[ ] { ((object) (20D)) } );
         //SeriesPoint sp2 = new SeriesPoint( "tbl", new object[ ] { ((object) (100D)) } );
         //SeriesPoint sp3 = new SeriesPoint( "vw", new object[ ] { ((object) (50D)) } );
         //SeriesPoint sp4 = new SeriesPoint( "col", new object[ ] { ((object) (2000D)) } );
         ChartControl cc = new ChartControl( )
         {
            //  Diagram = xyDiagram1
         };
         //
         ((System.ComponentModel.ISupportInitialize) (cc)).BeginInit( );
         //((System.ComponentModel.ISupportInitialize) (xyDiagram1)).BeginInit( );
         ((System.ComponentModel.ISupportInitialize) (series1)).BeginInit( );
         {
            //xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            //xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            //chartControl1.Diagram = xyDiagram1;
            cc.Dock = System.Windows.Forms.DockStyle.Fill;
            cc.Legend.Name = "Default Legend";
            cc.Location = new System.Drawing.Point( 0, 46 );
            cc.Name = "chartControl1";
            //sp1.ColorSerializable = "#F79646";
            //sp2.ColorSerializable = "#4BACC6";
            //sp3.ColorSerializable = "#8064A2";
            //sp4.ColorSerializable = "#9BBB59";
            //series1.Points.AddRange( new DevExpress.XtraCharts.SeriesPoint[ ]
            //{
            //   sp1,
            //   sp2,
            //   sp3,
            //   sp4
            //} );
            cc.SeriesSerializable = new DevExpress.XtraCharts.Series[ ]
            {
               series1
            };
            cc.Size = new System.Drawing.Size( 632, 214 );
            cc.TabIndex = 4;
         }
         //((System.ComponentModel.ISupportInitialize) (xyDiagram1)).EndInit( );
         ((System.ComponentModel.ISupportInitialize) (series1)).EndInit( );
         ((System.ComponentModel.ISupportInitialize) (cc)).EndInit( );
         //
         return cc;
      }
   }
}
