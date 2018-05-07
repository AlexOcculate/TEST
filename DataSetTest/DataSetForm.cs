using System;
using System.Data;
using System.Linq;

namespace DataSetTest
{
   public partial class DataSetForm : DevExpress.XtraEditors.XtraForm
   {
      private DataTable _gridTable;
      private int tblCounter = 0;

      public DataSetForm()
      {
         this.InitializeComponent( );
         //
         this._gridTable = CreateTable01( "GRID_TABLE" );
         this._gridTable.RowChanged += new System.Data.DataRowChangeEventHandler( this.Row_Changed );
         this.gridControl1.DataSource = this._gridTable;

         ////
         //DemonstrateMergeTable();
      }

      private void DataSetForm_Load( object sender, EventArgs e )
      {
      }
      private void Row_Changed( object sender, DataRowChangeEventArgs e )
      {
         switch( e.Action )
         {
            case DataRowAction.Add:
               Console.WriteLine( $"Row changed {e.Action}\t{e.Row.ItemArray[ 0 ]} @ {e.Row.Table.TableName}" );
               break;
            case DataRowAction.Nothing:
            case DataRowAction.Delete:
            case DataRowAction.Change:
            case DataRowAction.Rollback:
            case DataRowAction.Commit:
            case DataRowAction.ChangeOriginal:
            case DataRowAction.ChangeCurrentAndOriginal:
            default:
               break;
         }
      }


      private void addTable01BarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         DataTable t = CreateTable01( ""+ ++this.tblCounter);
         AddDataTable01( t );
         this._gridTable.Merge(t, false, MissingSchemaAction.Add);
         this.gridControl1.DataSource = null;
         this.gridControl1.DataSource = this._gridTable;
         //this.gridControl1.RefreshDataSource();
         //this.gridControl1.Refresh();
      }

      private void DemonstrateMergeTable()
      {
         DataTable table1 = CreateTable01( "T001" );
         AddDataTable01( table1 );
         // Accept changes.
         table1.AcceptChanges( );
         PrintValues( table1, "Original values" );

         DataTable table2 = CreateTable02( table1 );
         AddDataTable02( table2 );

         // Merge table2 into the table1.
         Console.WriteLine( "Merging" );
         table1.Merge( table2, false, MissingSchemaAction.Add );
         PrintValues( table1, "Merged With table1, schema added" );
         //
      }

      private DataTable CreateTable01( string name )
      {
         
         DataTable o = new DataTable( name );
         // Add columns
         DataColumn idColumn = new DataColumn( "id", typeof( int ) );
         DataColumn itemColumn = new DataColumn( "item", typeof( int ) );
         DataColumn tableColumn = new DataColumn( "table#", typeof( int ) );
         o.Columns.Add( idColumn );
         o.Columns.Add( itemColumn );
         o.Columns.Add( tableColumn );
         // Set the primary key column.
         o.PrimaryKey = new DataColumn[ ] { idColumn };
         // Add RowChanged event handler for the table.
         return o;
      }
      private void AddDataTable01( DataTable tbl )
      {
         // Add ten rows.
         DataRow row;
         for( int i = 0; i <= 9; i++ )
         {
            row = tbl.NewRow( );
            row[ "id" ] = i + (this.tblCounter*1000);
            row[ "item" ] = i;
            row[ "table#" ] = this.tblCounter;
            tbl.Rows.Add( row );
         }
      }
      private DataTable CreateTable02( DataTable tbl )
      {
         // Create a second DataTable identical to the first.
         DataTable o = tbl.Clone( );
         o.TableName = "CLONED_TABLE";
         // Add column to the second column, so that the schemas no longer match.
         o.Columns.Add( "newColumn", typeof( string ) );
         return o;
      }
      private void AddDataTable02( DataTable tbl )
      {
         // Add three rows. Note that the id column can't be the 
         // same as existing rows in the original table.
         DataRow row = tbl.NewRow( );
         row[ "id" ] = 14;
         row[ "item" ] = 774;
         row[ "newColumn" ] = "new column 1";
         tbl.Rows.Add( row );
         //
         row = tbl.NewRow( );
         row[ "id" ] = 12;
         row[ "item" ] = 555;
         row[ "newColumn" ] = "new column 2";
         tbl.Rows.Add( row );
         //
         row = tbl.NewRow( );
         row[ "id" ] = 13;
         row[ "item" ] = 665;
         row[ "newColumn" ] = "new column 3";
         tbl.Rows.Add( row );
      }

      private void PrintValues( DataTable table, string label )
      {
         // Display the values in the supplied DataTable:
         Console.WriteLine( label );
         foreach( DataRow row in table.Rows )
         {
            foreach( DataColumn col in table.Columns )
            {
               Console.Write( "\t " + row[ col ].ToString( ) );
            }
            Console.WriteLine( );
         }
      }

   }
}