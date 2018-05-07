using DevExpress.XtraCharts;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace DataGridSwapViews
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      private const string CU_GRID_COL_CHECKBOX_FIELDNAME = "CUCheckbox";
      private const string CU_GRID_COL_CHECKBOX_CAPTION = "Custom Unbound Checkbox";
      //
      private const string CU_GRID_COL_STRING_FIELDNAME = "CUString";
      private const string CU_GRID_COL_STRING_CAPTION = "Custom Unbound String";
      //
      private const string CU_GRID_COL_CHART_FIELDNAME = "CUChart";
      private const string CU_GRID_COL_CHART_CAPTION = "Custom Unbound Chart";
      //
      private Dictionary<int, string> cuString = new Dictionary<int, string>( );
      private Dictionary<int, List<SeriesArgVal>> cuChart = new Dictionary<int, List<SeriesArgVal>>( );

      public Form1()
      {
         this.InitializeComponent( );
      }

      private void Form1_Load( object sender, EventArgs e )
      {
         this.createDataValues( );
         this.createCustomUnboundColumns( );
         this.gridControl1.DataSource = this.fooBarDataSet;
         this.gridControl1.DataMember = "Master";
         this.gridControl1.ForceInitialize( );
         {
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowPreview = true;
            this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
         }
         //
         //
         this.winExplorerView1.OptionsView.ShowCheckBoxes = true;
         this.winExplorerView1.OptionsView.ShowCheckBoxInGroupCaption = true;
      }

      #region --- SWAP Events ---
      private void gridViewBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.gridControl1.MainView = this.gridView1;
      }

      private void layoutViewBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.gridControl1.MainView = this.layoutView1;
      }

      private void cardViewBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.gridControl1.MainView = this.cardView1;
      }

      private void defaultWinExplorerViewStyleBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Default;
         this.gridControl1.MainView = this.winExplorerView1;
      }

      private void contentWinExplorerViewStyleBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Content;
         this.gridControl1.MainView = this.winExplorerView1;
      }

      private void listWinExplorerViewStyleBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.List;
         this.gridControl1.MainView = this.winExplorerView1;
      }

      private void tilesWinExplorerViewStyleBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Tiles;
         this.gridControl1.MainView = this.winExplorerView1;
      }

      private void smallWinExplorerViewStyleBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Small;
         this.gridControl1.MainView = this.winExplorerView1;
      }

      private void mediumWinExplorerViewStyleBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
         this.gridControl1.MainView = this.winExplorerView1;
      }

      private void largeWinExplorerViewStyleBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Large;
         this.gridControl1.MainView = this.winExplorerView1;
      }

      private void extralargeWinExplorerViewStyleBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge;
         this.gridControl1.MainView = this.winExplorerView1;
      }
      #endregion

      #region --- Custom Unbound Columns ---
      private void createCustomUnboundColumns()
      {
         this.createCUGridColString( );
         this.createCUGridColChart( );
      }

      private void gridView1_CustomUnboundColumnData( object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e )
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

      private void cardView1_CustomUnboundColumnData( object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e )
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

      private void layoutView1_CustomUnboundColumnData( object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e )
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

      private void winExplorerView1_CustomUnboundColumnData( object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e )
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
         if( e.Column.FieldName == CU_GRID_COL_CHECKBOX_FIELDNAME )
         {
            e.Value = true;
            return;
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
               string mid = drv[ this.masterIDColumn.ColumnName ].ToString( );
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
               string mid = drv[ this.masterIDColumn.ColumnName ].ToString( );
               DataTable dt = this.fooBarDataSet.Tables[ this.detailTable.TableName ];
               List<SeriesArgVal> list = new List<SeriesArgVal>( );
               foreach( DataRow dr in dt.Rows )
               {
                  string did = dr[ this.detailMasterIDColumn.ColumnName ].ToString( );
                  if( string.Compare( did, mid, StringComparison.Ordinal ) == 0 )
                  {
                     string argument = dr[ this.detailArgColumn.ColumnName ].ToString( );
                     object objvalue = dr[ this.detailValColumn.ColumnName ];
                     int value = (short) dr[ this.detailValColumn.ColumnName ];
                     list.Add( new SeriesArgVal( argument, value ) );
                  }
               }
               this.cuChart.Add( e.ListSourceRowIndex, list );
               e.Value = list;
            }
         }
      }

      private void createCUGridColString()
      {
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.gridView1.Columns.Add( gc );
         }
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.cardView1.Columns.Add( gc );
         }
         {
            LayoutViewColumn lvc = new LayoutViewColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.layoutView1.Columns.Add( lvc );
         }
         //
         #region --- WinExplorer: Custom Unbound Columns ---
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_CHECKBOX_CAPTION,
               FieldName = CU_GRID_COL_CHECKBOX_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.Boolean,
               Visible = true
            };
            this.winExplorerView1.Columns.Add( gc );
            this.winExplorerView1.ColumnSet.TextColumn = gc;
         }
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_CHECKBOX_CAPTION,
               FieldName = CU_GRID_COL_CHECKBOX_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.Boolean,
               Visible = true
            };
            this.winExplorerView1.Columns.Add( gc );
            this.winExplorerView1.ColumnSet.EnabledColumn = gc;
         }
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.winExplorerView1.Columns.Add( gc );
            this.winExplorerView1.ColumnSet.TextColumn = gc;
         }
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.winExplorerView1.Columns.Add( gc );
            this.winExplorerView1.ColumnSet.DescriptionColumn = gc;
         }
         //
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.winExplorerView1.Columns.Add( gc );
            this.winExplorerView1.ColumnSet.SmallImageColumn = gc;
         }
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.winExplorerView1.Columns.Add( gc );
            this.winExplorerView1.ColumnSet.MediumImageColumn = gc;
         }
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.winExplorerView1.Columns.Add( gc );
            this.winExplorerView1.ColumnSet.LargeImageColumn = gc;
         }
         {
            GridColumn gc = new GridColumn( )
            {
               Caption = CU_GRID_COL_STRING_CAPTION,
               FieldName = CU_GRID_COL_STRING_FIELDNAME,
               UnboundType = DevExpress.Data.UnboundColumnType.String,
               Visible = true
            };
            this.winExplorerView1.Columns.Add( gc );
            this.winExplorerView1.ColumnSet.ExtraLargeImageColumn = gc;
         }
         #endregion
      }

      private void createCUGridColChart()
      {
         //TODO: WHY TOOLTIP IS NOT WORKING???
         //TODO: HOW-TO INSERT CHART in WinExplorer Views
         ChartControl cc = new ChartControl( );
         {
            cc.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            Series series = new Series( "Objects", ViewType.Bar );
            {
               ((SideBySideBarSeriesView) series.View).ColorEach = true;
               series.ArgumentDataMember = SeriesArgVal.ARG_COLUMNNAME;
               series.ValueDataMembers.AddRange( new string[ ] { SeriesArgVal.VAL_COLUMNNAME } );
               series.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
               series.ToolTipPointPattern = "{V}";
               series.ToolTipSeriesPattern = "{S:f1}";
               series.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.True;
               series.CrosshairHighlightPoints = DevExpress.Utils.DefaultBoolean.True;
               series.CrosshairLabelPattern = "{A}";
               series.CrosshairLabelVisibility = DevExpress.Utils.DefaultBoolean.True;
            }
            cc.Series.Add( series );
            {
               XYDiagram diagram = (XYDiagram) cc.Diagram;

               // Enable automatic scale breaks creation,  
               // and define their maximum number. 
               diagram.AxisY.AutoScaleBreaks.Enabled = true;
               diagram.AxisY.AutoScaleBreaks.MaxCount = 5;

               // Define the scale breaks' options, which are common 
               // for both manual and automatic scale breaks. 
               diagram.AxisY.ScaleBreakOptions.Style = ScaleBreakStyle.Waved;
               diagram.AxisY.ScaleBreakOptions.SizeInPixels = 1;
               diagram.AxisY.ScaleBreakOptions.Color = Color.Turquoise;

               // Add scale breaks to the Y-axis collection,  
               // with their Edge1 and Edge2 properties defined in the constructor. 
               //diagram.AxisY.ScaleBreaks.Add( new ScaleBreak( "Scale Break 1", 10, 100 ) );
               //diagram.AxisY.ScaleBreaks.Add( new ScaleBreak( "Scale Break 2", 110, 2000 ) );
            }
         }
         RepositoryItemAnyControl item = new RepositoryItemAnyControl( ) { Control = cc };
         //column.View.GridControl.RepositoryItems.Add( item );
         this.gridControl1.RepositoryItems.Add( item );
         //((GridView) column.View).OptionsSelection.EnableAppearanceHideSelection = false;
         {
            {
               GridColumn gc = new GridColumn( )
               {
                  Caption = CU_GRID_COL_CHART_CAPTION,
                  FieldName = CU_GRID_COL_CHART_FIELDNAME,
                  UnboundType = DevExpress.Data.UnboundColumnType.Object,
                  Visible = true
               };
               gc.OptionsColumn.AllowEdit = false;
               gc.OptionsFilter.AllowFilter = false;
               gc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
               gc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
               gc.ColumnEdit = item;
               this.gridView1.Columns.Add( gc );
            }
            {
               GridColumn gc = new GridColumn( )
               {
                  Caption = CU_GRID_COL_CHART_CAPTION,
                  FieldName = CU_GRID_COL_CHART_FIELDNAME,
                  UnboundType = DevExpress.Data.UnboundColumnType.Object,
                  Visible = true
               };
               gc.OptionsColumn.AllowEdit = false;
               gc.OptionsFilter.AllowFilter = false;
               gc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
               gc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
               gc.ColumnEdit = item;
               this.cardView1.Columns.Add( gc );
            }
            {
               LayoutViewColumn lvc = new LayoutViewColumn( )
               {
                  Caption = CU_GRID_COL_CHART_CAPTION,
                  FieldName = CU_GRID_COL_CHART_FIELDNAME,
                  UnboundType = DevExpress.Data.UnboundColumnType.Object,
                  Visible = true
               };
               lvc.OptionsColumn.AllowEdit = false;
               lvc.OptionsFilter.AllowFilter = false;
               lvc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
               lvc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
               lvc.ColumnEdit = item;
               this.layoutView1.Columns.Add( lvc );
            }
            {
               GridColumn gc = new GridColumn( )
               {
                  Caption = CU_GRID_COL_CHART_CAPTION,
                  FieldName = CU_GRID_COL_CHART_FIELDNAME,
                  UnboundType = DevExpress.Data.UnboundColumnType.Object,
                  Visible = true
               };
               gc.OptionsColumn.AllowEdit = false;
               gc.OptionsFilter.AllowFilter = false;
               gc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
               gc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
               gc.ColumnEdit = item;
               this.winExplorerView1.Columns.Add( gc );
            }
         }
      }
      #endregion

      private void createDataValues()
      {
         this.masterTable.Rows.Add( new object[ ] { "M01", "A01", "Descr A01" } );
         this.masterTable.Rows.Add( new object[ ] { "M02", "B02", "Descr B02" } );
         this.masterTable.Rows.Add( new object[ ] { "M03", "C03", "Descr C03" } );
         this.masterTable.Rows.Add( new object[ ] { "M04", "D04", "Descr D04" } );
         this.masterTable.Rows.Add( new object[ ] { "M05", "E05", "Descr E05" } );
         this.masterTable.Rows.Add( new object[ ] { "M06", "F06", "Descr F06" } );
         //
         this.detailTable.Rows.Add( new object[ ] { "M01", "AAA", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M01", "BBB", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M01", "CCC", 1000 } );
         //
         this.detailTable.Rows.Add( new object[ ] { "M02", "CCC", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M02", "YYY", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M02", "ZZZ", 1000 } );
         //
         this.detailTable.Rows.Add( new object[ ] { "M03", "AAA", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "BBB", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "CCC", 1000 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "DDD", 30 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "EEE", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "FFF", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "GGG", 1000 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "HHH", 30 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "III", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "JJJ", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "KKK", 1000 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "LLL", 30 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "MMM", 1 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "NNN", 5 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "OOO", 4000 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "PPP", 30 } );
         this.detailTable.Rows.Add( new object[ ] { "M03", "QQQ", 10030 } );
      }
   }
}
