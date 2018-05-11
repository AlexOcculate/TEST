using System;
using System.Linq;

namespace GridCardAndLayoutView
{
   public partial class MetadataItem
   {
      public const string ID_FIELDNAME = "ID";
      public const string PARENT_ID_FIELDNAME = "ParentID";
      public const string PARENT_TYPE_FIELDNAME = "ParentType";
      //
      public const string ALTNAME_FIELDNAME = "AltName";
      public const string CARDINALYTY_FIELDNAME = "Cardinality";
      public const string DATABASE_FIELDNAME = "Database";
      public const string DATASTORE_NAME_FIELDNAME = "DataStoreName";
      public const string DESCRIPTION_FIELDNAME = "Description";
      public const string EXPRESSION_FIELDNAME = "Expression";
      public const string FIELD_FIELDNAME = "Field";
      public const string FIELD_TYPE_FIELDNAME = "FieldType";
      public const string FIELD_TYPE_NAME_FIELDNAME = "FieldTypeName";
      public const string FIELDS_FIELDNAME = "Fields";
      public const string FIELDSCOUNT_FIELDNAME = "FieldsCount";
      public const string HAS_DEFAULT_FIELDNAME = "HasDefault";
      public const string IS_NULLABLE_FIELDNAME = "IsNullable";
      public const string IS_PK_FIELDNAME = "IsPK";
      public const string IS_READONLY_FIELDNAME = "IsRO";
      public const string IS_SYSTEM_FIELDNAME = "IsSystem";
      public const string LASTWRITETIMEUTC_FIELDNAME = "LastWriteTimeUtc";
      public const string METADATA_PROVIDER_FIELDNAME = "MetadataProvider";
      public const string NAMEFULLQUALIFIED_FIELDNAME = "NameFullQualified";
      public const string NAMEQUOTED_FIELDNAME = "NameQuoted";
      public const string OBJECT_FIELDNAME = "ObjectName";
      public const string PRECISION_FIELDNAME = "Precision";
      public const string REFERENCED_CARDINALYTY_FIELDNAME = "ReferencedCardinality";
      public const string REFERENCED_FIELDS_FIELDNAME = "ReferencedFields";
      public const string REFERENCED_FIELDS_COUNT_FIELDNAME = "ReferencedFieldsCount";
      public const string REFERENCED_OBJECT_FIELDNAME = "ReferencedObject";
      public const string REFERENCED_OBJECT_NAME_FIELDNAME = "ReferencedObjectName";
      public const string SCALE_FIELDNAME = "Scale";
      public const string SCHEMA_FIELDNAME = "Schema";
      public const string SERVER_FIELDNAME = "Server";
      public const string SIZE_FIELDNAME = "Size";
      public const string SNAPSHOT_FILE_FIELDNAME = "SnapshotFile";
      public const string SYNTAX_PROVIDER_FIELDNAME = "SyntaxProvider";
      public const string TAG_FIELDNAME = "Tag";
      public const string TYPE_FIELDNAME = "Type";
      public const string USERDATA_FIELDNAME = "UserData";

      #region --- DATASET ---
      //    public const string DataStoreConfig_TblName = "DataStoreConfig";
      //    public const string DataStoreSnapshotFile_TblName = "DataStoreSnapshotFiles";
      public const string MetadataItem_TblName = "MetadataItem";

      public static System.Data.DataTable CreateMetadataItemTable( string name = MetadataItem_TblName )
      {
         System.Data.DataTable t = new System.Data.DataTable( name );
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = ID_FIELDNAME;
            c.Caption = "Id";
            c.ReadOnly = true;
            c.Unique = false;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = DATASTORE_NAME_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string ); // typeof( System.IO.FileInfo );
            c.ColumnName = SNAPSHOT_FILE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( System.DateTime );
            c.ColumnName = LASTWRITETIMEUTC_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = METADATA_PROVIDER_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = SYNTAX_PROVIDER_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = PARENT_ID_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = IS_SYSTEM_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = TYPE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = PARENT_TYPE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = CARDINALYTY_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = FIELDSCOUNT_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = FIELDS_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = REFERENCED_CARDINALYTY_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = REFERENCED_OBJECT_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = REFERENCED_OBJECT_NAME_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = REFERENCED_FIELDS_COUNT_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = REFERENCED_FIELDS_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = SERVER_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = DATABASE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = SCHEMA_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = OBJECT_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = NAMEFULLQUALIFIED_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = NAMEQUOTED_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = ALTNAME_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = FIELD_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = HAS_DEFAULT_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = EXPRESSION_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = FIELD_TYPE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = FIELD_TYPE_NAME_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = IS_NULLABLE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = PRECISION_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = SCALE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( int );
            c.ColumnName = SIZE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = IS_PK_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( bool );
            c.ColumnName = IS_READONLY_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = DESCRIPTION_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( object );
            c.ColumnName = TAG_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = USERDATA_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         return t;
      }
      #endregion
      public static bool IsFieldVisibleByDefault( string fieldName )
      {
         switch( fieldName )
         {
            case ALTNAME_FIELDNAME:
            case CARDINALYTY_FIELDNAME:
            case DESCRIPTION_FIELDNAME:
            case EXPRESSION_FIELDNAME:
            case FIELD_TYPE_FIELDNAME:
            case FIELD_TYPE_NAME_FIELDNAME:
            case FIELDS_FIELDNAME:
            case FIELDSCOUNT_FIELDNAME:
            case HAS_DEFAULT_FIELDNAME:
            case IS_NULLABLE_FIELDNAME:
            case IS_PK_FIELDNAME:
            case IS_READONLY_FIELDNAME:
            case IS_SYSTEM_FIELDNAME:
            case LASTWRITETIMEUTC_FIELDNAME:
            case METADATA_PROVIDER_FIELDNAME:
            case NAMEFULLQUALIFIED_FIELDNAME:
            case NAMEQUOTED_FIELDNAME:
            case OBJECT_FIELDNAME:
            case PRECISION_FIELDNAME:
            case REFERENCED_CARDINALYTY_FIELDNAME:
            case REFERENCED_FIELDS_FIELDNAME:
            case REFERENCED_FIELDS_COUNT_FIELDNAME:
            case REFERENCED_OBJECT_FIELDNAME:
            case REFERENCED_OBJECT_NAME_FIELDNAME:
            case SCALE_FIELDNAME:
            case SERVER_FIELDNAME:
            case SIZE_FIELDNAME:
            case SNAPSHOT_FILE_FIELDNAME:
            case SYNTAX_PROVIDER_FIELDNAME:
            case TAG_FIELDNAME:
            case USERDATA_FIELDNAME:
               return false;
            case ID_FIELDNAME:
            case PARENT_ID_FIELDNAME:
            case PARENT_TYPE_FIELDNAME:
            case DATASTORE_NAME_FIELDNAME:
            case DATABASE_FIELDNAME:
            case SCHEMA_FIELDNAME:
            case FIELD_FIELDNAME:
            case TYPE_FIELDNAME:
            default:
               return true;
         }
      }
   }
}
