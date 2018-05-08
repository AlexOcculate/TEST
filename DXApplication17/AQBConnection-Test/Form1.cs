﻿using DevExpress.XtraGrid.Columns;
using DPControls.Controls.MetadataPuller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;

namespace AQBConnection_Test
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      private DataTable dataTable = MetadataPullerXtraUserControl.CreateMetadataItemTable();
      private SQLiteConnectionStringBuilder sqliteCSBuilder = new SQLiteConnectionStringBuilder()
      {
         DataSource = @"D:\TEMP\SQLite\mydb.db"
      };
      private SqlConnectionStringBuilder msssCSBuilder = new SqlConnectionStringBuilder()
      {
         DataSource = @"DBSRV\QWERTY",
         //UserID = @"DBSRV\user02",
         //Password = @"8a0IucJ@Nx1Qy5HfFrX0Ob3m",
         UserID = @"user02",
         Password = @"user02",
         //InitialCatalog = @"Sales"
      };

      public Form1()
      {
         this.InitializeComponent();
         {
            this.aqbGridControl.UseEmbeddedNavigator = true;
            this.aqbGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.aqbGridView.OptionsView.ShowAutoFilterRow = true;
            this.aqbGridView.OptionsFind.AlwaysVisible = true;
            this.aqbGridView.OptionsView.ShowPreview = true;
            this.aqbGridView.OptionsMenu.ShowConditionalFormattingItem = true;
         }
         {
            this.aqbGridControl.DataSource = this.dataTable;
            GridColumnCollection columns = this.aqbGridView.Columns;
            foreach(GridColumn gc in columns)
            {
               string fieldName = gc.FieldName;
               string name = gc.Name;
               gc.Visible = MetadataPullerXtraUserControl.IsFieldVisibleByDefault(fieldName);
            }
         }
         //   {
         //      this.aqb
         //   }
      }

      #region --- Event Handlers ---
      private void testAQBSqliteAUTOConnectionBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         MetadataPullerXtraUserControl.CreateFirstTableSqlite(this.sqliteCSBuilder.ConnectionString);
         using(ActiveQueryBuilder.Core.SQLContext sqlContext = MetadataPullerXtraUserControl.CreateAqbQbAuto(this.sqliteCSBuilder.ConnectionString))
         {
            this.dataTable.Rows.Clear(); // = MetadataPullerXtraUserControl.CreateMetadataItemTable();
            MetadataPullerXtraUserControl.DrillDownAqbSqlContext(sqlContext, this.dataTable, "XPTO");
            this.aqbGridControl.DataSource = this.dataTable;
            this.aqbPivotGridControl.DataSource = this.dataTable;
         }
      }

      private void testAQBSqliteConnectionBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         MetadataPullerXtraUserControl.CreateFirstTableSqlite(this.sqliteCSBuilder.ConnectionString);
         using(ActiveQueryBuilder.Core.SQLContext sqlContext = MetadataPullerXtraUserControl.CreateAqbSqlContext4SQLiteOnline(this.sqliteCSBuilder.ConnectionString))
         {
            this.dataTable.Rows.Clear( ); // = MetadataPullerXtraUserControl.CreateMetadataItemTable();
            MetadataPullerXtraUserControl.DrillDownAqbSqlContext(sqlContext, this.dataTable, "XPTO");
            this.aqbGridControl.DataSource = this.dataTable;
            this.aqbPivotGridControl.DataSource = this.dataTable;
         }
      }

      private void testAQBMsssAutoConnectionBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         using(ActiveQueryBuilder.Core.SQLContext sqlContext = MetadataPullerXtraUserControl.CreateAqbQbMSSS(this.msssCSBuilder.ConnectionString))
         {
            this.dataTable.Rows.Clear( ); // = MetadataPullerXtraUserControl.CreateMetadataItemTable();
            MetadataPullerXtraUserControl.DrillDownAqbSqlContext(sqlContext, this.dataTable, "XPTO");
            this.aqbGridControl.DataSource = this.dataTable;
            this.aqbPivotGridControl.DataSource = this.dataTable;
            this.aqbPivotGridControl.RetrieveFields();
         }
      }
      #endregion

      private void aqbGridView_FocusedRowChanged( object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e )
      {
         int dsRowIndex = this.aqbGridView.GetDataSourceRowIndex(e.FocusedRowHandle);
         if(dsRowIndex < 0)
         {
            return;
         }

         DataTable table = this.aqbGridControl.DataSource as DataTable;
         // object o = this.claimsGridControl.DataSource;
         DataRow row = table.Rows[dsRowIndex];
         this.propertyGridControl.SelectedObject = null;
         this.propertyGridControl.SelectedObject = MetadataPullerXtraUserControl.CreateMetadataItemProps(row);
      }

      private void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
      {
         if(e.Document == this.aqbGridControlDocument)
         {
            e.Control = this.aqbGridControl;
            return;
         }

         if(e.Document == this.aqbPivotGridControlDocument)
         {
            e.Control = this.aqbPivotGridControl;
            return;
         }
         if( e.Document == this.document1 )
         {
            e.Control = this.dashboardViewer1;
            return;
         }
      }

      private void tabbedView1_ControlReleasing( object sender, DevExpress.XtraBars.Docking2010.Views.ControlReleasingEventArgs e )
      {
         e.Cancel = true;
         //or 
         //e.KeepControl = true; 
      }

   }
}
