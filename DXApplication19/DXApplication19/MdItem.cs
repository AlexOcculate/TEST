using AQBMetadata.ORMDataModel;
using DataPhilosophiae.Model;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace AQBMetadata
{
   public class MdItem
   {
      public const string ALTNAME_FIELDNAME = "AltName";
      public const string CARDINALYTY_FIELDNAME = "Cardinality";
      public const string COUNT_FIELDNAME = "Count";
      public const string DATABASE_FIELDNAME = "Database";
      public const string DATASTORE_NAME_FIELDNAME = "DataStoreName";
      public const string DESCRIPTION_FIELDNAME = "Description";
      public const string EXPRESSION_FIELDNAME = "Expression";
      public const string NAME_FIELD_FIELDNAME = "Field";
      public const string FIELD_DOT_NET_DATATYPE_FIELDNAME = "FieldType";
      public const string FIELD_DATABASE_DATATYPE_FIELDNAME = "FieldTypeName";
      public const string FK_FIELDS_FIELDNAME = "Fields";
      public const string FIELDS_COUNT_FIELDNAME = "FieldsCount";
      public const string HAS_DEFAULT_FIELDNAME = "HasDefault";
      public const string ID_FIELDNAME = "ID";
      public const string IS_NULLABLE_FIELDNAME = "IsNullable";
      public const string IS_PK_FIELDNAME = "IsPK";
      public const string IS_READONLY_FIELDNAME = "IsRO";
      public const string IS_SYSTEM_FIELDNAME = "IsSystem";
      public const string LAST_WRITE_TIME_UTC_FIELDNAME = "LastWriteTimeUtc";
      public const string METADATA_PROVIDER_FIELDNAME = "MetadataProvider";
      public const string NAMEFULLQUALIFIED_FIELDNAME = "NameFullQualified";
      public const string NAMEQUOTED_FIELDNAME = "NameQuoted";
      public const string OBJECT_FIELDNAME = "ObjectName";
      public const string PARENT_ID_FIELDNAME = "ParentID";
      public const string PARENT_TYPE_FIELDNAME = "ParentType";
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

      public static bool IsFieldVisibleByDefault( string fieldName )
      {
         switch( fieldName )
         {
            case ALTNAME_FIELDNAME:
            case CARDINALYTY_FIELDNAME:
            case DESCRIPTION_FIELDNAME:
            case EXPRESSION_FIELDNAME:
            case FIELD_DOT_NET_DATATYPE_FIELDNAME:
            case FIELD_DATABASE_DATATYPE_FIELDNAME:
            case FK_FIELDS_FIELDNAME:
            case FIELDS_COUNT_FIELDNAME:
            case HAS_DEFAULT_FIELDNAME:
            case IS_NULLABLE_FIELDNAME:
            case IS_PK_FIELDNAME:
            case IS_READONLY_FIELDNAME:
            case IS_SYSTEM_FIELDNAME:
            case LAST_WRITE_TIME_UTC_FIELDNAME:
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
            case NAME_FIELD_FIELDNAME:
            case TYPE_FIELDNAME:
            default:
               return true;
         }
      }

      public static Dictionary<string, SysConnectionString> GetSysConnectionStringList()
      {
         Dictionary<string, SysConnectionString> list = new Dictionary<string, SysConnectionString>( );
         ConnectionStringSettingsCollection css = ConfigurationManager.ConnectionStrings;
         if( css != null )
         {
            for( int i = 0; i < css.Count; i++ )
            {
               SysConnectionString o = new SysConnectionString( )
               {
                  Name = css[ i ].Name,
                  ProviderName = css[ i ].ProviderName,
                  ConnectionString = css[ i ].ConnectionString,
                  IsSys = true
               };
               list.Add( o.Name, o );
            }
         }
         return list;
      }

      public const string MetadataItem_TblName = "MetadataItem";

      public static DataTable CreateMetadataItemTable( string name = MetadataItem_TblName )
      {
         System.Data.DataTable t = new System.Data.DataTable( name );
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( uint );
            c.ColumnName = COUNT_FIELDNAME;
            c.ReadOnly = true;
            c.Unique = false;
            t.Columns.Add( c );
         }
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
         //{
         //   System.Data.DataColumn c = new System.Data.DataColumn( );
         //   c.DataType = typeof( System.DateTime );
         //   c.ColumnName = LAST_WRITE_TIME_UTC_FIELDNAME;
         //   c.ReadOnly = true;
         //   t.Columns.Add( c );
         //}
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
            c.ColumnName = FIELDS_COUNT_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = FK_FIELDS_FIELDNAME;
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
            c.ColumnName = NAME_FIELD_FIELDNAME;
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
            c.ColumnName = FIELD_DOT_NET_DATATYPE_FIELDNAME;
            c.ReadOnly = true;
            t.Columns.Add( c );
         }
         {
            System.Data.DataColumn c = new System.Data.DataColumn( );
            c.DataType = typeof( string );
            c.ColumnName = FIELD_DATABASE_DATATYPE_FIELDNAME;
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

      public static void CreateFirstTableSqlite( string connectionString )
      {
         //SQLiteConnectionStringBuilder builder = new SQLiteConnectionStringBuilder( );
         //builder.DataSource = @"D:\TEMP\SQLite\mydb.db";
         //
         using( SQLiteConnection conn = new SQLiteConnection( connectionString ) )
         {
            conn.Open( );
            string sql = "create table if not exists highscores (name varchar(20), score int)";
            using( SQLiteCommand command = new SQLiteCommand( sql, conn ) )
            {
               command.ExecuteNonQuery( );
            }
         }
      }

      //public static MetadataItemProps CreateMetadataItemProps( DataRow row )
      //{
      //   string type = (string) row[ TYPE_FIELDNAME ];
      //   switch( type )
      //   {
      //      case "Server":
      //         return new MetadataItemPropsServer( row );
      //      case "Database":
      //         return new MetadataItemPropsDatabase( row );
      //      case "Schema":
      //         return new MetadataItemPropsSchema( row );
      //      case "Namespace":
      //         return new MetadataItemPropsNamespace( row );
      //      case "Objects":
      //         return new MetadataItemPropsObjects( row );
      //      case "Table":
      //         return new MetadataItemPropsTable( row );
      //      case "View":
      //         return new MetadataItemPropsView( row );
      //      case "Synonym":
      //         return new MetadataItemPropsSynonym( row );
      //      case "Field":
      //         return new MetadataItemPropsField( row );
      //      case "ForeignKey":
      //         return new MetadataItemPropsFK( row );
      //      case "Package":
      //         return new MetadataItemPropsPackage( row );
      //      case "Procedure":
      //         return new MetadataItemPropsProcedure( row );
      //      case "Parameter":
      //         return new MetadataItemPropsParameter( row );
      //      case "ObjectMetadata":
      //         return new MetadataItemPropsObjectMetadata( row );
      //      case "Aggregate":
      //         return new MetadataItemPropsAggregate( row );
      //      case "UserQuery":
      //         return new MetadataItemPropsUserQuery( row );
      //      case "UserField":
      //         return new MetadataItemPropsUserField( row );
      //      default:
      //         return new MetadataItemProps( row );
      //   }
      //}

      /*
      https://support.activequerybuilder.com/hc/en-us/articles/115001055349-Getting-started-with-AQB-NET-3-in-the-Separated-Controls-UI-or-Non-visual-mode
      
      Your initialization code will look as follows:
      
      // Non-visual objects
      _sqlContext = new SQLContext
      {
      SyntaxProvider = new MSSQLSyntaxProvider 
      {
      ServerVersion = MSSQLServerVersion.MSSQL2012
      },
      MetadataProvider = new OLEDBMetadataProvider 
      {
      Connection = new OleDbConnection() 
      {
      ConnectionString = ""
      }
      }
      };
      
      _sqlQuery = new SQLQuery(_sqlContext);
      
      Sergey Smagin
      Ok, then you need only the SQLContext object.
      
      sqlContext.MetadataContainer.ExportToXML();
      
      */

      #region --- Active Query Builder ---
      public static bool TestAqbSqlContext4SQLiteConnection( string cs )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider( )
            {
               Connection = new System.Data.SQLite.SQLiteConnection( )
               {
                  ConnectionString = cs
               }
            }
         };
         {
            // sc.MetadataContainer.LoadingOptions.OfflineMode = false;
            // sc.MetadataContainer.LoadingOptions.LoadSystemObjects = false;
            // sc.MetadataContainer.LoadingOptions.LoadDefaultDatabaseOnly = true;
            sc.LoadingOptions.OfflineMode = false;
            sc.LoadingOptions.LoadSystemObjects = false;
            sc.LoadingOptions.LoadDefaultDatabaseOnly = true;
            sc.MetadataContainer.LoadAll( false );
         }
         ActiveQueryBuilder.Core.MetadataList items = sc.MetadataContainer.Items;
         return items == null ? false : true;
      }

      public static ActiveQueryBuilder.Core.SQLContext CreateAqbSqlContext4SQLiteOffline( string filepath )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider( ),
            //MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider( )
            //{
            //   Connection = new System.Data.SQLite.SQLiteConnection( )
            //   {
            //      ConnectionString = cs.ConnectionString
            //   }
            //}
         };
         {
            sc.MetadataContainer.LoadingOptions.OfflineMode = true;
            sc.MetadataContainer.ImportFromXML( filepath );
         }
         return sc;
      }

      #region --- SQLite Handle and AQB-QB ---
      public static ActiveQueryBuilder.Core.SQLContext CreateAqbSqlContext4SQLiteOnline( string cs )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( );
         sc.SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider( );
         sc.MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider( );
         sc.MetadataProvider.Connection = new System.Data.SQLite.SQLiteConnection( );
         sc.MetadataProvider.Connection.ConnectionString = cs;
         //
         //ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         //{
         //   SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider( ),
         //   MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider( )
         //   {
         //      Connection = new System.Data.SQLite.SQLiteConnection( )
         //      {
         //         ConnectionString = cs
         //      }
         //   }
         //};
         //
         //{
         //   sc.MetadataContainer.LoadAll( WithField );
         //   sc.MetadataContainer.LoadingOptions.OfflineMode = true;
         //   sc.MetadataContainer.ImportFromXML( filepath );
         //}
         return sc;
      }
      #endregion

      #region --- Auto Handle and AQB-QB ---
      public static ActiveQueryBuilder.Core.SQLContext CreateAqbQbAuto( string connectionString )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.AutoSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.UniversalMetadataProvider( )
         };
         //qb.MetadataProvider.Connection = new System.Data.SqlClient.SqlConnection( ds.ConnectionString );
         sc.MetadataProvider.Connection = new System.Data.SQLite.SQLiteConnection( connectionString );
         {
            sc.LoadingOptions.OfflineMode = false;
            sc.LoadingOptions.LoadSystemObjects = true;
            sc.LoadingOptions.LoadDefaultDatabaseOnly = false;
            sc.MetadataContainer.LoadAll( true );
         }
         return sc;
      }
      #endregion

      #region --- MSSS Handle and AQB-QB ---
      public static ActiveQueryBuilder.Core.SQLContext CreateAqbQbMSSS( string connectionString )
      {
         ActiveQueryBuilder.Core.SQLContext sc = new ActiveQueryBuilder.Core.SQLContext( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.MSSQLMetadataProvider( )
         };
         //qb.MetadataProvider.Connection = new System.Data.SQLite.SQLiteConnection( ds.ConnectionString );
         sc.MetadataProvider.Connection = new System.Data.SqlClient.SqlConnection( connectionString );
         {
            sc.LoadingOptions.OfflineMode = false;
            sc.LoadingOptions.LoadSystemObjects = false;
            sc.LoadingOptions.LoadDefaultDatabaseOnly = true;
            sc.MetadataContainer.LoadAll( true );
         }
         return sc;
      }
      #endregion

      private class StackItem
      {
         public ActiveQueryBuilder.Core.MetadataList list;
         public int index;
         public int parentID;
         public int grandParentID;
      }

      public static void DrillDownAqbSqlContextXPO(
         string dataStoreName,
         ActiveQueryBuilder.Core.SQLContext sc,
         XPCollection xpc,
         DevExpress.Xpo.Session session
          )
      {
         ActiveQueryBuilder.Core.MetadataList items = sc.MetadataContainer.Items;
         //
         System.Collections.Generic.Stack<StackItem> stack = new System.Collections.Generic.Stack<StackItem>( );
         stack.Push( new StackItem { list = items, index = 0, parentID = -1, grandParentID = -1 } );
         do
         {
            StackItem si = stack.Pop( );
            ActiveQueryBuilder.Core.MetadataList actualMIList = si.list;
            int actualIndex = si.index;
            int actualParentID = si.grandParentID; // IMPORTANT!!!
            for( ; actualIndex < actualMIList.Count; actualIndex++ )
            {
               //System.Data.DataRow row = tbl.NewRow( );
               MetadataItemXpObject o = new MetadataItemXpObject( session );
               o.DataStoreName = dataStoreName;
               MetadataItemXpObject o = ExtractMetadataItemXPO( actualMIList[ actualIndex ], actualParentID );
               xpc.Add( o );
               if( actualMIList[ actualIndex ].Items.Count > 0 ) // branch...
               {
                  int count = xpc.Count;
                  int parentId = ((MetadataItemXpObject) xpc[ count - 1 ]).ID;
                  // Push the "next" Item...
                  stack.Push( new StackItem
                  {
                     list = actualMIList,
                     index = actualIndex + 1,
                     parentID = parentId,
                     grandParentID = actualParentID
                  } );
                  // Reset the loop to process the "actual" Item...
                  actualParentID = parentId;
                  actualMIList = actualMIList[ actualIndex ].Items;
                  actualIndex = -1;
               }
            } // for(;;)...
         } while( stack.Count > 0 );
      }
      private static MetadataItemXpObject ExtractMetadataItemXPO( ActiveQueryBuilder.Core.MetadataItem mi, int parentID )
      {
         switch( mi.Type )
         {
            case ActiveQueryBuilder.Core.MetadataType.Database:
            case ActiveQueryBuilder.Core.MetadataType.Schema:
               return ExtractNamespaceXPO( mi, parentID );
            case ActiveQueryBuilder.Core.MetadataType.Table:
            case ActiveQueryBuilder.Core.MetadataType.View:
               return ExtractTableXPO( mi, parentID );
            case ActiveQueryBuilder.Core.MetadataType.Procedure:
               return ExtractProcedureXPO( mi, parentID );
            case ActiveQueryBuilder.Core.MetadataType.Synonym:
               return ExtractSynonymXPO( mi, parentID );
            case ActiveQueryBuilder.Core.MetadataType.Field:
               return ExtractFieldXPO( mi, parentID );
            case ActiveQueryBuilder.Core.MetadataType.ForeignKey:
               return ExtractForeignKeyXPO( mi, parentID );
            case ActiveQueryBuilder.Core.MetadataType.Root:
            case ActiveQueryBuilder.Core.MetadataType.Server:
            case ActiveQueryBuilder.Core.MetadataType.Package:
            case ActiveQueryBuilder.Core.MetadataType.Namespaces:
            case ActiveQueryBuilder.Core.MetadataType.ObjectMetadata:
            case ActiveQueryBuilder.Core.MetadataType.Objects:
            case ActiveQueryBuilder.Core.MetadataType.Aggregate:
            case ActiveQueryBuilder.Core.MetadataType.Parameter:
            case ActiveQueryBuilder.Core.MetadataType.UserQuery:
            case ActiveQueryBuilder.Core.MetadataType.UserField:
            case ActiveQueryBuilder.Core.MetadataType.All:
            default:
               return ExtractItemXPO( mi, parentID );
         }
      }
      private static MetadataItemXpObject ExtractNamespaceXPO( ActiveQueryBuilder.Core.MetadataItem mi, int parentID )
      {
         throw new NotImplementedException( );
      }
      private static MetadataItemXpObject ExtractTableXPO( ActiveQueryBuilder.Core.MetadataItem mi, int parentID )
      {
         throw new NotImplementedException( );
      }
      private static MetadataItemXpObject ExtractProcedureXPO( ActiveQueryBuilder.Core.MetadataItem mi, int parentID )
      {
         throw new NotImplementedException( );
      }
      private static MetadataItemXpObject ExtractSynonymXPO( ActiveQueryBuilder.Core.MetadataItem mi, int parentID )
      {
         throw new NotImplementedException( );
      }
      private static MetadataItemXpObject ExtractFieldXPO( ActiveQueryBuilder.Core.MetadataItem mi, int parentID )
      {
         throw new NotImplementedException( );
      }
      private static MetadataItemXpObject ExtractForeignKeyXPO( ActiveQueryBuilder.Core.MetadataItem mi, int parentID )
      {
         throw new NotImplementedException( );
      }
      private static MetadataItemXpObject ExtractItemXPO( ActiveQueryBuilder.Core.MetadataItem mi, int parentID )
      {
         throw new NotImplementedException( );
      }

      public static void DrillDownAqbSqlContext(
         ActiveQueryBuilder.Core.SQLContext sc
         , System.Data.DataTable tbl
         , string dataStoreName
         )
      {
         ActiveQueryBuilder.Core.MetadataList items = sc.MetadataContainer.Items;
         //
         System.Collections.Generic.Stack<StackItem> stack = new System.Collections.Generic.Stack<StackItem>( );
         stack.Push( new StackItem { list = items, index = 0, parentID = -1, grandParentID = -1 } );
         do
         {
            StackItem si = stack.Pop( );
            ActiveQueryBuilder.Core.MetadataList actualMIList = si.list;
            int actualIndex = si.index;
            int actualParentID = si.grandParentID; // IMPORTANT!!!
            for( ; actualIndex < actualMIList.Count; actualIndex++ )
            {
               System.Data.DataRow row = tbl.NewRow( );
               row[ DATASTORE_NAME_FIELDNAME ] = dataStoreName;
               ExtractMetadataItem( row, actualMIList[ actualIndex ], actualParentID, tbl );
               tbl.Rows.Add( row );
               if( actualMIList[ actualIndex ].Items.Count > 0 ) // branch...
               {
                  int count = tbl.Rows.Count;
                  System.Data.DataRowCollection rows = tbl.Rows;
                  int parentId = (int) rows[ count - 1 ][ ID_FIELDNAME ];
                  // Push the "next" Item...
                  stack.Push( new StackItem
                  {
                     list = actualMIList,
                     index = actualIndex + 1,
                     parentID = parentId,
                     grandParentID = actualParentID
                  } );
                  // Reset the loop to process the "actual" Item...
                  actualParentID = parentId;
                  actualMIList = actualMIList[ actualIndex ].Items;
                  actualIndex = -1;
               }
            } // for(;;)...
         } while( stack.Count > 0 );
      }

      private static void ExtractMetadataItem(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         switch( mi.Type )
         {
            case ActiveQueryBuilder.Core.MetadataType.Database:
            case ActiveQueryBuilder.Core.MetadataType.Schema:
               ExtractNamespace( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Table:
            case ActiveQueryBuilder.Core.MetadataType.View:
               ExtractTable( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Procedure:
               ExtractProcedure( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Synonym:
               ExtractSynonym( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Field:
               ExtractField( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.ForeignKey:
               ExtractForeignKey( row, mi, parentID, tbl );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Root:
            case ActiveQueryBuilder.Core.MetadataType.Server:
            case ActiveQueryBuilder.Core.MetadataType.Package:
            case ActiveQueryBuilder.Core.MetadataType.Namespaces:
            case ActiveQueryBuilder.Core.MetadataType.ObjectMetadata:
            case ActiveQueryBuilder.Core.MetadataType.Objects:
            case ActiveQueryBuilder.Core.MetadataType.Aggregate:
            case ActiveQueryBuilder.Core.MetadataType.Parameter:
            case ActiveQueryBuilder.Core.MetadataType.UserQuery:
            case ActiveQueryBuilder.Core.MetadataType.UserField:
            case ActiveQueryBuilder.Core.MetadataType.All:
            default:
               ExtractItem( row, mi, parentID, tbl );
               break;
         }
      }

      private static void ExtractNamespace(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            //ActiveQueryBuilder.Core.MetadataNamespace m = mi as ActiveQueryBuilder.Core.MetadataNamespace;
         }
      }

      private static void ExtractProcedure(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
         }
      }

      private static void ExtractSynonym(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
            row[ REFERENCED_OBJECT_FIELDNAME ] = m.ReferencedObject?.NameFull;
            //
            for( int i = 0; i < m.ReferencedObjectName.Count; i++ )
            {
               ActiveQueryBuilder.Core.MetadataQualifiedNamePart x = m.ReferencedObjectName[ i ];
               row[ REFERENCED_OBJECT_NAME_FIELDNAME ] += "[ "
               + System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), x.Type )
               + ":"
               + x.Name
               + "]"
            ;
            }
         }
      }

      private static void ExtractTable(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            //ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
         }
      }

      private static void ExtractField(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         {
            ActiveQueryBuilder.Core.MetadataField m = mi as ActiveQueryBuilder.Core.MetadataField;
            row[ EXPRESSION_FIELDNAME ] = m.Expression;
            row[ FIELD_DOT_NET_DATATYPE_FIELDNAME ] = System.Enum.GetName( typeof( System.Data.DbType ), m.FieldType );
            row[ FIELD_DATABASE_DATATYPE_FIELDNAME ] = m.FieldTypeName;
            row[ IS_NULLABLE_FIELDNAME ] = m.Nullable;
            row[ PRECISION_FIELDNAME ] = m.Precision;
            row[ SCALE_FIELDNAME ] = m.Scale;
            row[ SIZE_FIELDNAME ] = m.Size;
            row[ IS_PK_FIELDNAME ] = m.PrimaryKey;
            row[ IS_READONLY_FIELDNAME ] = m.ReadOnly;
         }
      }

      private static void ExtractForeignKey(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         if( mi == null )
         {
            return;
         }

         ExtractItem( row, mi, parentID, tbl );
         row[ FIELD_DOT_NET_DATATYPE_FIELDNAME ] = null;
         {
            ActiveQueryBuilder.Core.MetadataForeignKey m = mi as ActiveQueryBuilder.Core.MetadataForeignKey;
            row[ REFERENCED_OBJECT_FIELDNAME ] = m.ReferencedObject.NameFull;
            //
            for( int i = 0; i < m.ReferencedObjectName.Count; i++ )
            {
               ActiveQueryBuilder.Core.MetadataQualifiedNamePart x = m.ReferencedObjectName[ i ];
               row[ REFERENCED_OBJECT_NAME_FIELDNAME ] += "[ "
               + System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), x.Type )
               + ":"
               + x.Name
               + "]"
            ;
            }
            //
            row[ REFERENCED_FIELDS_COUNT_FIELDNAME ] = m.ReferencedFields.Count;
            for( int i = 0; i < m.ReferencedFields.Count; i++ )
            {
               row[ REFERENCED_FIELDS_FIELDNAME ] += "[ " + m.ReferencedFields[ i ] + "]";
            }
            //
            row[ REFERENCED_CARDINALYTY_FIELDNAME ] = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataForeignKeyCardinality ), m.ReferencedCardinality );
            //
            row[ FIELDS_COUNT_FIELDNAME ] = m.Fields.Count;
            for( int i = 0; i < m.Fields.Count; i++ )
            {
               row[ FK_FIELDS_FIELDNAME ] += "[" + m.Fields[ i ] + "]"
            ;
            }
            //
            row[ CARDINALYTY_FIELDNAME ] = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataForeignKeyCardinality ), m.Cardinality );
         }
      }

      private static void ExtractItem(
         System.Data.DataRow row
         , ActiveQueryBuilder.Core.MetadataItem mi
         , int parentID
         , System.Data.DataTable tbl
         )
      {
         {
            row[ MdItem.FIELD_DATABASE_DATATYPE_FIELDNAME ] = string.Empty;
            row[ MdItem.FIELD_DOT_NET_DATATYPE_FIELDNAME ] = string.Empty;
            row[ FIELDS_COUNT_FIELDNAME ] = 0;
            row[ MdItem.REFERENCED_FIELDS_COUNT_FIELDNAME ] = 0;
            row[ IS_NULLABLE_FIELDNAME ] = false;
            row[ PRECISION_FIELDNAME ] = 0;
            row[ SCALE_FIELDNAME ] = 0;
            row[ SIZE_FIELDNAME ] = 0;
            row[ IS_PK_FIELDNAME ] = false;
            row[ IS_READONLY_FIELDNAME ] = false;
         }
         //
         row[ COUNT_FIELDNAME ] = 1;
         row[ ID_FIELDNAME ] = tbl.Rows.Count;
         row[ PARENT_ID_FIELDNAME ] = parentID;
         row[ METADATA_PROVIDER_FIELDNAME ] = mi.SQLContext?.MetadataProvider?.Description;
         row[ SYNTAX_PROVIDER_FIELDNAME ] = mi.SQLContext?.SyntaxProvider?.Description;
         if( mi.Parent != null )
         {
            row[ PARENT_TYPE_FIELDNAME ] = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), mi.Parent.Type );
         }
         row[ TYPE_FIELDNAME ] = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), mi.Type );
         row[ IS_SYSTEM_FIELDNAME ] = mi.System;
         ////
         //string rootName = mi.Root?.Name;
         row[ SERVER_FIELDNAME ] = mi.Server?.Name;
         row[ DATABASE_FIELDNAME ] = mi.Database?.Name;
         row[ SCHEMA_FIELDNAME ] = mi.Schema?.Name;
         row[ OBJECT_FIELDNAME ] = mi.Object?.Name;
         ////
         row[ NAMEFULLQUALIFIED_FIELDNAME ] = mi.NameFull + (mi.NameFull.EndsWith( "." ) ? "<?>" : string.Empty);
         row[ NAMEQUOTED_FIELDNAME ] = mi.NameQuoted;
         row[ ALTNAME_FIELDNAME ] = mi.AltName;
         row[ NAME_FIELD_FIELDNAME ] = mi.Name != null ? mi.Name : " <?>";
         ////
         row[ HAS_DEFAULT_FIELDNAME ] = mi.Default;
         row[ DESCRIPTION_FIELDNAME ] = mi.Description;
         row[ TAG_FIELDNAME ] = mi.Tag;
         row[ USERDATA_FIELDNAME ] = mi.UserData;
      }
      #endregion
   }
}
