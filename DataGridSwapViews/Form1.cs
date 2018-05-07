using DevExpress.XtraCharts;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataGridSwapViews
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      private const string CU_GRID_COL_CHART_FIELDNAME = "CUChart";
      private const string CU_GRID_COL_STRING_CAPTION = "Custom Unbound String";
      //
      private const string CU_GRID_COL_STRING_FIELDNAME = "CUString";
      private const string CU_GRID_COL_CHART_CAPTION = "Custom Unbound Chart";
      //
      private Dictionary<int, string> cuString = new Dictionary<int, string>( );
      private Dictionary<int, List<SeriesArgVal>> cuChart = new Dictionary<int, List<SeriesArgVal>>( );

      public Form1()
      {
         InitializeComponent( );
      }

      private void Form1_Load( object sender, EventArgs e )
      {
         this.createDataValues( );
         this.createCustomUnboundColumns( );
      }

      private void gridViewBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.gridControl1.MainView = this.gridView1;
         this.gridControl1.DataSource = this.fooBarDataSet;
         this.gridControl1.DataMember = "Master";
      }

      private void layoutViewBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.gridControl1.MainView = this.layoutView1;
         this.gridControl1.DataSource = this.fooBarDataSet;
         this.gridControl1.DataMember = "Master";
      }

      private void cardViewBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.gridControl1.MainView = this.cardView1;
         this.gridControl1.DataSource = this.fooBarDataSet;
         this.gridControl1.DataMember = "Master";
      }

      private void explorerBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.gridControl1.MainView = this.winExplorerView1;
         this.gridControl1.DataSource = this.fooBarDataSet;
         this.gridControl1.DataMember = "Master";
      }

      private void GridView1_CustomUnboundColumnData( object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e )
      {
         if( e.Column.FieldName == CU_GRID_COL_STRING_FIELDNAME )
         {
            this.getCUString( e );
            return;
         }
         if( e.Column.FieldName == CU_GRID_COL_CHART_FIELDNAME )
         {
            this.getCUChart( e );
            return;
         }
      }

      private void getCUChart( DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e )
      {
         if( e.IsGetData )
         {
            if( this.cuChart.ContainsKey( e.ListSourceRowIndex ) )
            {
               e.Value = this.cuChart[ e.ListSourceRowIndex ];
            }
            else
            {
               DataRowView drv = e.Row as DataRowView;
               string mid = drv[ this.idColumn.ColumnName ].ToString( );
               DataTable dt = this.fooBarDataSet.Tables[ this.detailTable.TableName ];
               List<SeriesArgVal> list = new List<SeriesArgVal>( );
               foreach( DataRow dr in dt.Rows )
               {
                  string did = dr[ this.detailMasterIDColumn.ColumnName ].ToString( );
                  if( string.Compare( did, mid, StringComparison.Ordinal ) == 0 )
                  {
                     string argument = dr[ this.detailArgColumn.ColumnName ].ToString( );
                     object objvalue = dr[ this.detailValColumn.ColumnName ];
                     int value = (Int16) dr[ this.detailValColumn.ColumnName ];
                     list.Add( new SeriesArgVal( argument, value ) );
                  }
               }
               this.cuChart.Add( e.ListSourceRowIndex, list );
               e.Value = list;
            }
         }
      }

      private void getCUString( DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e )
      {
         if( e.IsGetData )
         {
            if( this.cuString.ContainsKey( e.ListSourceRowIndex ) )
            {
               e.Value = this.cuString[ e.ListSourceRowIndex ];
            }
            else
            {
               DataRowView drv = e.Row as DataRowView;
               string mid = drv[ this.idColumn.ColumnName ].ToString( );
               DataTable dt = this.fooBarDataSet.Tables[ this.detailTable.TableName ];
               string x = null;
               foreach( DataRow dr in dt.Rows )
               {
                  string did = dr[ this.detailMasterIDColumn.ColumnName ].ToString( );
                  if( string.Compare( did, mid, StringComparison.Ordinal ) == 0 )
                  {
                     string argument = dr[ this.detailArgColumn.ColumnName ].ToString( );
                     string value = dr[ this.detailValColumn.ColumnName ].ToString( );
                     x += $" {argument}:{value}";
                  }
               }
               x = $"{{ {x} }}";
               this.cuString.Add( e.ListSourceRowIndex, x );
               e.Value = x;
            }
         }
      }

      private void createCustomUnboundColumns()
      {
         this.createCUGridColString( );
         this.createCUGridColChart( );
         this.gridView1.CustomUnboundColumnData += this.GridView1_CustomUnboundColumnData;
         this.cardView1.CustomUnboundColumnData += this.GridView1_CustomUnboundColumnData;
         this.layoutView1.CustomUnboundColumnData += this.GridView1_CustomUnboundColumnData;
         this.winExplorerView1.CustomUnboundColumnData += this.GridView1_CustomUnboundColumnData;
      }

      private void createCUGridColChart()
      {
         GridColumn gc = new GridColumn( )
         {
            Caption = CU_GRID_COL_CHART_CAPTION,
            FieldName = CU_GRID_COL_CHART_FIELDNAME,
            UnboundType = DevExpress.Data.UnboundColumnType.Object,
            Visible = true
         };
         this.gridView1.Columns.Add( gc );
         this.cardView1.Columns.Add( gc );
         LayoutViewColumn lvc = new LayoutViewColumn( )
         {
            Caption = CU_GRID_COL_CHART_CAPTION,
            FieldName = CU_GRID_COL_CHART_FIELDNAME,
            UnboundType = DevExpress.Data.UnboundColumnType.Object,
            Visible = true
         };
         this.layoutView1.Columns.Add( lvc );
         this.winExplorerView1.Columns.Add( gc );
         {
            Series serie = new Series( "Objects", ViewType.Bar );
            serie.ArgumentDataMember = SeriesArgVal.ARG_COLUMNNAME;
            serie.ValueDataMembers.AddRange( new string[ ] { SeriesArgVal.VAL_COLUMNNAME } );
            ChartControl cc = new ChartControl( );
            cc.Series.Add( serie );
            //
            RepositoryItemAnyControl item = new RepositoryItemAnyControl( ) { Control = cc };
            //column.View.GridControl.RepositoryItems.Add( item );
            this.gridControl1.RepositoryItems.Add( item );
            //((GridView) column.View).OptionsSelection.EnableAppearanceHideSelection = false;
            gc.OptionsColumn.AllowEdit = false;
            gc.OptionsFilter.AllowFilter = false;
            gc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            gc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gc.ColumnEdit = item;
         }
      }

      private void createCUGridColString()
      {
         GridColumn gc = new GridColumn( )
         {
            Caption = CU_GRID_COL_STRING_CAPTION,
            FieldName = CU_GRID_COL_STRING_FIELDNAME,
            UnboundType = DevExpress.Data.UnboundColumnType.String,
            Visible = true
         };
         this.gridView1.Columns.Add( gc );
         //
         this.cardView1.Columns.Add( gc );
         //
         LayoutViewColumn lvc = new LayoutViewColumn()
         {
            Caption = CU_GRID_COL_STRING_CAPTION,
            FieldName = CU_GRID_COL_STRING_FIELDNAME,
            UnboundType = DevExpress.Data.UnboundColumnType.String,
            Visible = true
         };
         this.layoutView1.Columns.Add( lvc );
         //
         this.winExplorerView1.Columns.Add( gc );
      }

      private void createDataValues()
      {
         this.masterTable.Rows.Add( new object[ ] { "M01", "A01" } );
         this.masterTable.Rows.Add( new object[ ] { "M02", "B02" } );
         this.masterTable.Rows.Add( new object[ ] { "M03", "C03" } );
         this.masterTable.Rows.Add( new object[ ] { "M04", "D04" } );
         this.masterTable.Rows.Add( new object[ ] { "M05", "E05" } );
         this.masterTable.Rows.Add( new object[ ] { "M06", "F06" } );
         //
         this.detailTable.Rows.Add( new object[ ] { "M01", "DB", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M01", "SCH", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M01", "TBL", 1000 } );
         //
         this.detailTable.Rows.Add( new object[ ] { "M02", "DB", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M02", "SCH", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M02", "TBL", 1000 } );
         //
         this.detailTable.Rows.Add( new object[ ] { "M03", "DB", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "SCH", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "TBL", 1000 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "VW", 30 } );
      }
   }
}
