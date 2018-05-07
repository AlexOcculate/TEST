using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;

namespace Chart_Test
{
   public partial class BindUsingTemplatesRuntime : DevExpress.XtraEditors.XtraForm
   {
      public BindUsingTemplatesRuntime()
      {
         InitializeComponent( );
      }
      private DataTable CreateChartData()
      {
         // Create an empty table. 
         DataTable table = new DataTable( "Table1" );

         // Add three columns to the table. 
         table.Columns.Add( "Month", typeof( String ) );
         table.Columns.Add( "Section", typeof( String ) );
         table.Columns.Add( "Value", typeof( Int32 ) );

         // Add data rows to the table. 
         table.Rows.Add( new object[ ] { "Jan", "Section1", 10 } );
         table.Rows.Add( new object[ ] { "Jan", "Section2", 20 } );
         table.Rows.Add( new object[ ] { "Feb", "Section1", 20 } );
         table.Rows.Add( new object[ ] { "Feb", "Section2", 30 } );
         table.Rows.Add( new object[ ] { "March", "Section1", 15 } );
         table.Rows.Add( new object[ ] { "March", "Section2", 25 } );

         return table;
      }

      private void BindUsingTemplatesRuntime_Load( object sender, EventArgs e )
      {
         // Create a chart. 
         ChartControl chart = new ChartControl( );

         // Generate a data table and bind the chart to it. 
         chart.DataSource = CreateChartData( );

         // Specify data members to bind the chart's series template. 
         chart.SeriesDataMember = "Month";
         chart.SeriesTemplate.ArgumentDataMember = "Section";
         chart.SeriesTemplate.ValueDataMembers.AddRange( new string[ ] { "Value" } );

         // Specify the template's series view. 
         chart.SeriesTemplate.View = new StackedBarSeriesView( );

         // Specify the template's name prefix. 
         chart.SeriesNameTemplate.BeginText = "Month: ";

         // Dock the chart into its parent, and add it to the current form. 
         chart.Dock = DockStyle.Fill;
         this.Controls.Add( chart );

      }
      private DataSet CreateDataSet()
      {
         // Master <-One---Many->> Details
         // {ID,Name} <-One--Many->> {ID,Argument,Value}
         // Detail Tables contains the Bar Chart {argument:value} set
         DataSet ds = new DataSet( "FooBar" );

         DataTable mt = new DataTable( "Master" );

         mt.Columns.Add( "ID", typeof( String ) );
         mt.Columns.Add( "Name", typeof( String ) );

         // Add data rows to the table. 
         mt.Rows.Add( new object[ ] { "10", "M10" } );
         mt.Rows.Add( new object[ ] { "20", "M20" } );
         mt.Rows.Add( new object[ ] { "30", "M30" } );
         mt.Rows.Add( new object[ ] { "40", "M40" } );
         mt.Rows.Add( new object[ ] { "50", "M50" } );
         mt.Rows.Add( new object[ ] { "60", "M60" } );

         DataTable dt = new DataTable( "Detail" );

         dt.Columns.Add( "ID", typeof( String ) );
         dt.Columns.Add( "Argument", typeof( String ) );
         dt.Columns.Add( "Value", typeof( int ) );

         // Add data rows to the table. 
         dt.Rows.Add( new object[ ] { "10", "A", 10 } );
         dt.Rows.Add( new object[ ] { "10", "B", 100 } );
         dt.Rows.Add( new object[ ] { "10", "C", 40 } );
         // "D" Missing!!!
         //
         dt.Rows.Add( new object[ ] { "20", "A", 1 } );
         dt.Rows.Add( new object[ ] { "20", "B", 10 } );
         dt.Rows.Add( new object[ ] { "20", "C", 140 } );
         dt.Rows.Add( new object[ ] { "20", "D", 40 } );
         //
         // ID=30 DOES NOT EXIST!
         //
         dt.Rows.Add( new object[ ] { "40", "A", 1 } );
         dt.Rows.Add( new object[ ] { "40", "B", 10 } );
         dt.Rows.Add( new object[ ] { "40", "C", 140 } );
         // "D" Missing!!!
         //
         dt.Rows.Add( new object[ ] { "50", "A", 5 } );
         dt.Rows.Add( new object[ ] { "50", "B", 10 } );
         dt.Rows.Add( new object[ ] { "50", "C", 14 } );
         dt.Rows.Add( new object[ ] { "50", "D", 40 } );
         //
         // ID=60 DOES NOT EXIST!

         return ds;
      }
   }


}