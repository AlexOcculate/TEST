using DevExpress.XtraCharts;
using DevExpress.XtraEditors.CustomEditor;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GridPlusChart
{
   /*
   
   - DataSource <-One---Many->> DataSourceDetails
   
   - DataSource
   . - ID : String -- DataSource Unique ID.
   . - Name : String -- DataSource Name.
   . - Creation : DateTime -- Date and Time when it was created.
   
   - DataSource Details
   . - ID : FK --> DataSource.ID
   . - Argument : String -- Argument Name
   . - Value : Integer -- Argument Value
   
   ID | Name | Creation | BAR CHART DIAGRAM 
   
   */
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      private const string FOOBAR_DATASETNAME = "FooBar";
      private const string MASTER_TABLENAME = "Master";
      private const string DETAIL_TABLENAME = "Detail";
      private const string ID_COLUMNNAME = "ID";
      private const string NAME_COLUMNNAME = "Name";
      private const string ARG_COLUMNNAME = "Argument";
      private const string VAL_COLUMNNAME = "Value";
      //
      private const string CU_GRID_COL_CHART_FIELDNAME = "CUChart";
      private const string CU_GRID_COL_STRING_CAPTION = "Custom Unbound String";
      //
      private const string CU_GRID_COL_STRING_FIELDNAME = "CUString";
      private const string CU_GRID_COL_CHART_CAPTION = "Custom Unbound Chart";
      //
      private DataSet _ds;
      private Dictionary<int, string> cuString = new Dictionary<int, string>();
      private Dictionary<int, List<SeriesArgVal>> cuChart = new Dictionary<int, List<SeriesArgVal>>();

      public Form1()
      {
         this.InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         this._ds = this.CreateDataSet();
         this.gridControl1.DataSource = this._ds;
         this.gridControl1.DataMember = MASTER_TABLENAME;
         this.CreateCUGridColString();
         this.CreateCUGridColChart();
         this.gridView1.CustomUnboundColumnData += this.GridView1_CustomUnboundColumnData;
      }

      private void CreateCUGridColChart()
      {
         GridColumn gc = new GridColumn()
         {
            Caption = CU_GRID_COL_CHART_CAPTION,
            FieldName = CU_GRID_COL_CHART_FIELDNAME,
            UnboundType = DevExpress.Data.UnboundColumnType.Object,
            Visible = true
         };
         this.gridView1.Columns.Add(gc);
         {
            Series serie = new Series("Objects", ViewType.Bar);
            serie.ArgumentDataMember = ARG_COLUMNNAME;
            serie.ValueDataMembers.AddRange(new string[ ] { VAL_COLUMNNAME });
            ChartControl cc = new ChartControl();
            cc.Series.Add(serie);
            //
            RepositoryItemAnyControl item = new RepositoryItemAnyControl() { Control = cc };
            //column.View.GridControl.RepositoryItems.Add( item );
            this.gridControl1.RepositoryItems.Add(item);
            //((GridView) column.View).OptionsSelection.EnableAppearanceHideSelection = false;
            gc.OptionsColumn.AllowEdit = false;
            gc.OptionsFilter.AllowFilter = false;
            gc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            gc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            gc.ColumnEdit = item;
         }
      }

      private void CreateCUGridColString()
      {
         GridColumn gc = new GridColumn()
         {
            Caption = CU_GRID_COL_STRING_CAPTION,
            FieldName = CU_GRID_COL_STRING_FIELDNAME,
            UnboundType = DevExpress.Data.UnboundColumnType.String,
            Visible = true
         };
         this.gridView1.Columns.Add(gc);
      }

      private void GridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
      {
         if(e.Column.FieldName == CU_GRID_COL_STRING_FIELDNAME)
         {
            this.getCUString(e);
            return;
         }
         if(e.Column.FieldName == CU_GRID_COL_CHART_FIELDNAME)
         {
            this.getCUChart(e);
            return;
         }
      }

      private void getCUChart(DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
      {
         if(e.IsGetData)
         {
            if(this.cuChart.ContainsKey(e.ListSourceRowIndex))
            {
               e.Value = this.cuChart[e.ListSourceRowIndex];
            } else
            {
               DataRowView drv = e.Row as DataRowView;
               string mid = drv[ID_COLUMNNAME].ToString();
               DataTable dt = this._ds.Tables[DETAIL_TABLENAME];
               List<SeriesArgVal> list = new List<SeriesArgVal>();
               foreach(DataRow dr in dt.Rows)
               {
                  string did = dr[ID_COLUMNNAME].ToString();
                  if(string.Compare(did, mid, StringComparison.Ordinal) == 0)
                  {
                     string argument = dr[ARG_COLUMNNAME].ToString();
                     int value = (int) dr[VAL_COLUMNNAME];
                     list.Add(new SeriesArgVal(argument, value));
                  }
               }
               this.cuChart.Add(e.ListSourceRowIndex, list);
               e.Value = list;
            }
         }
      }

      private void getCUString(DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
      {
         if(e.IsGetData)
         {
            if(this.cuString.ContainsKey(e.ListSourceRowIndex))
            {
               e.Value = this.cuString[e.ListSourceRowIndex];
            } else
            {
               DataRowView drv = e.Row as DataRowView;
               string mid = drv[ID_COLUMNNAME].ToString();
               DataTable dt = this._ds.Tables[DETAIL_TABLENAME];
               string x = null;
               foreach(DataRow dr in dt.Rows)
               {
                  string did = dr[ID_COLUMNNAME].ToString();
                  if(string.Compare(did, mid, StringComparison.Ordinal) == 0)
                  {
                     string argument = dr[ARG_COLUMNNAME].ToString();
                     string value = dr[VAL_COLUMNNAME].ToString();
                     x += $" {argument}:{value}";
                  }
               }
               x = $"{{ {x} }}";
               this.cuString.Add(e.ListSourceRowIndex, x);
               e.Value = x;
            }
         }
      }

      private DataSet CreateDataSet()
      {
         // Master <-One---Many->> Details
         // {ID,Name} <-One--Many->> {ID,Argument,Value}
         // Detail Tables contains the Bar Chart {argument:value} set
         DataSet ds = new DataSet(FOOBAR_DATASETNAME);

         DataTable mt = new DataTable(MASTER_TABLENAME);
         ds.Tables.Add(mt);

         mt.Columns.Add(ID_COLUMNNAME, typeof(string));
         mt.Columns.Add(NAME_COLUMNNAME, typeof(string));

         // Add data rows to the table. 
         mt.Rows.Add(new object[ ] { "10", "M10" });
         mt.Rows.Add(new object[ ] { "20", "M20" });
         mt.Rows.Add(new object[ ] { "30", "M30" });
         mt.Rows.Add(new object[ ] { "40", "M40" });
         mt.Rows.Add(new object[ ] { "50", "M50" });
         mt.Rows.Add(new object[ ] { "60", "M60" });

         DataTable dt = new DataTable(DETAIL_TABLENAME);
         ds.Tables.Add(dt);

         dt.Columns.Add(ID_COLUMNNAME, typeof(string));
         dt.Columns.Add(ARG_COLUMNNAME, typeof(string));
         dt.Columns.Add(VAL_COLUMNNAME, typeof(int));

         // Add data rows to the table. 
         dt.Rows.Add(new object[ ] { "10", "A", 10 });
         dt.Rows.Add(new object[ ] { "10", "B", 100 });
         dt.Rows.Add(new object[ ] { "10", "C", 40 });
         // "D" Missing!!!
         //
         dt.Rows.Add(new object[ ] { "20", "A", 1 });
         dt.Rows.Add(new object[ ] { "20", "B", 10 });
         dt.Rows.Add(new object[ ] { "20", "C", 140 });
         dt.Rows.Add(new object[ ] { "20", "D", 40 });
         //
         // ID=30 DOES NOT EXIST!
         //
         dt.Rows.Add(new object[ ] { "40", "A", 1 });
         dt.Rows.Add(new object[ ] { "40", "B", 10 });
         dt.Rows.Add(new object[ ] { "40", "C", 140 });
         // "D" Missing!!!
         //
         dt.Rows.Add(new object[ ] { "50", "A", 5 });
         dt.Rows.Add(new object[ ] { "50", "B", 10 });
         dt.Rows.Add(new object[ ] { "50", "C", 14 });
         dt.Rows.Add(new object[ ] { "50", "D", 40 });
         //
         // ID=60 DOES NOT EXIST!

         return ds;
      }
   }
}
