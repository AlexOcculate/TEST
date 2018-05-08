using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AQBMetadata
{
   public sealed class COL
   {
      private static readonly Dictionary<int, COL> dicId = new Dictionary<int, COL>( );
      private static readonly Dictionary<string, COL> dicName = new Dictionary<string, COL>( );

      public static readonly COL MI_ID = new COL( 0, "ID", typeof( int ) );
      public static readonly COL MI_DATASTORE_NAME = new COL( 1, "DataStoreName", typeof( string ) );
      public static readonly COL MI_SNAPSHOT_NAME = new COL( 1, "SnapshotName", typeof( string ) );
      public static readonly COL MI_LAST_WRITE_TIME_UTC = new COL( 1, "LastWriteTimeUTC", typeof( System.DateTime ) );

      /*
public static DataTable CreateMetadataItemTable( string name = MetadataItem_TblName )
{
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.METADATA_PROVIDER_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.SYNTAX_PROVIDER_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( int );
      c.ColumnName = MetadataItemProps.PARENT_ID_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( bool );
      c.ColumnName = MetadataItemProps.IS_SYSTEM_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.TYPE_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.PARENT_TYPE_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.CARDINALYTY_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( int );
      c.ColumnName = MetadataItemProps.FIELDSCOUNT_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.FIELDS_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.REFERENCED_CARDINALYTY_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.REFERENCED_OBJECT_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.REFERENCED_OBJECT_NAME_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( int );
      c.ColumnName = MetadataItemProps.REFERENCED_FIELDS_COUNT_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.REFERENCED_FIELDS_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.SERVER_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.DATABASE_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.SCHEMA_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.OBJECT_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.NAMEFULLQUALIFIED_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.NAMEQUOTED_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.ALTNAME_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.FIELD_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( bool );
      c.ColumnName = MetadataItemProps.HAS_DEFAULT_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.EXPRESSION_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.FIELD_TYPE_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.FIELD_TYPE_NAME_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( bool );
      c.ColumnName = MetadataItemProps.IS_NULLABLE_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( int );
      c.ColumnName = MetadataItemProps.PRECISION_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( int );
      c.ColumnName = MetadataItemProps.SCALE_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( int );
      c.ColumnName = MetadataItemProps.SIZE_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( bool );
      c.ColumnName = MetadataItemProps.IS_PK_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( bool );
      c.ColumnName = MetadataItemProps.IS_READONLY_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.DESCRIPTION_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( object );
      c.ColumnName = MetadataItemProps.TAG_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   {
      DataColumn c = new DataColumn( );
      c.DataType = typeof( string );
      c.ColumnName = MetadataItemProps.USERDATA_FIELDNAME;
      c.ReadOnly = true;
      t.Columns.Add( c );
   }
   return t;
}
*/

      private readonly int _id;
      private readonly string _name;
      private readonly Type _type;

      private COL( int value, string name, Type type )
      {
         this._id = value;
         this._name = name;
         this._type = type;
         dicId[ value ] = this;
         dicName[ name ] = this;
      }

      public static int Count
      {
         get { return dicId.Count; }
      }
      public int ID
      {
         get { return this._id; }
      }
      public string NAME
      {
         get { return this._name; }
      }
      public Type TYPE
      {
         get { return this._type; }
      }

      public static implicit operator COL( string str )
      {
         COL result;
         if( dicName.TryGetValue( str, out result ) )
            return result;
         else
            throw new InvalidCastException( );
      }
      public static implicit operator COL( int id )
      {
         COL result;
         if( dicId.TryGetValue( id, out result ) )
            return result;
         else
            throw new InvalidCastException( );
      }

      public override string ToString()
      {
         return this._name;
      }





      public void lalal()
      {
         DataColumn[ ] q = new DataColumn[ COL.Count ];
         for( int i = 0; i < COL.Count; i++ )
         {
            COL col = i;
            q[ i ] = new DataColumn( )
            {
               ColumnName = col.NAME,
               DataType = col.TYPE,
               ReadOnly = true
            };
         }
         DataTable t = new DataTable( "METADATA_ITEM" );
         t.Columns.AddRange( q );
      }
   }
}
