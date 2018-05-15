using AQBMetadata;
using AQBMetadata.ORMDataModel;
using DataPhilosophiae.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;

namespace DXApplication19
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      private SQLiteConnectionStringBuilder sqliteCSBuilder = new SQLiteConnectionStringBuilder( )
      {
         DataSource = @"D:\TEMP\SQLite\mydb.db"
      };
      private SqlConnectionStringBuilder msssCSBuilder = new SqlConnectionStringBuilder( )
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
         this.InitializeComponent( );
      }

      private void Form1_Load( object sender, EventArgs e )
      {

         //## @#$% TIMESTAMP + 
         Dictionary<string, SysConnectionString> sysCSList = AQBMetadata.MdItem.GetSysConnectionStringList( );
         // Cross-Platform Core Libraries > DevExpress ORM Tool > Getting Started > Tutorial 1 - Your First Data-Aware Application with XPO
         //if( this.xpCollection1.Count == 0 )
         {
            //string cs01 = this.msssCSBuilder.ConnectionString;
            //string cs02 = this.sqliteCSBuilder.ConnectionString;

            ActiveQueryBuilder.Core.SQLContext sQLContext = AQBMetadata.MdItem.CreateAqbQbMSSS( sysCSList[ "MSSQL" ].ConnectionString );
            //ActiveQueryBuilder.Core.SQLContext sQLContext = AQBMetadata.MdItem.CreateAqbSqlContext4SQLiteOnline( ConnectionHelper.ConnectionString );
            //ActiveQueryBuilder.Core.SQLContext sQLContext = CreateAqbSqlContext4SQLiteOnline( this.sqliteCSBuilder.ConnectionString );
            System.Data.DataTable dataTable = AQBMetadata.MdItem.CreateMetadataItemTable( );
            AQBMetadata.MdItem.DrillDownAqbSqlContext( sQLContext, dataTable, "alex" );
            f( dataTable );
         }
      }
      private void f( DataTable dataTable )
      {
         foreach( DataRow r in dataTable.Rows )
         {
            MetadataItemXpObject o = new MetadataItemXpObject( this.session1 );
            {
               o.Count = (UInt32) r[ MdItem.COUNT_FIELDNAME ];
               o.ID = (Int32) r[ MdItem.ID_FIELDNAME ];
               o.DataStoreName = (string) r[ MdItem.DATASTORE_NAME_FIELDNAME ];
               o.SnapshotName = (string) r[ MdItem.SNAPSHOT_FILE_FIELDNAME ].ToString( );
               // o.LastWriteTimeUtc = (System.DateTime) r[ MdItem.LAST_WRITE_TIME_UTC_FIELDNAME ];
               o.MetadataProvider = (string) r[ MdItem.METADATA_PROVIDER_FIELDNAME ];
               o.SyntaxProvider = (string) r[ MdItem.SYNTAX_PROVIDER_FIELDNAME ];
               o.ParentID = (Int32) r[ MdItem.PARENT_ID_FIELDNAME ];
               o.IsSystem = (bool) r[ MdItem.IS_SYSTEM_FIELDNAME ];
               o.Type = (string) r[ MdItem.TYPE_FIELDNAME ];
               o.ParentType = (string) r[ MdItem.PARENT_TYPE_FIELDNAME ];
               o.FkCardinality = (string) r[ MdItem.CARDINALYTY_FIELDNAME ].ToString( );
               o.FieldsCount = (Int32) r[ MdItem.FIELDS_COUNT_FIELDNAME ];
               o.FkFields = (string) r[ MdItem.FK_FIELDS_FIELDNAME ].ToString( );
               o.TkCardinality = (string) r[ MdItem.REFERENCED_CARDINALYTY_FIELDNAME ].ToString( );
               o.TkObject = (string) r[ MdItem.REFERENCED_OBJECT_FIELDNAME ].ToString( );
               o.ReferencedObjectName = (string) r[ MdItem.REFERENCED_OBJECT_NAME_FIELDNAME ].ToString( );
               o.ReferencedFieldsCount = (Int32) r[ MdItem.REFERENCED_FIELDS_COUNT_FIELDNAME ];
               o.ReferencedFields = (string) r[ MdItem.REFERENCED_FIELDS_FIELDNAME ].ToString( );
               o.Server = (string) r[ MdItem.SERVER_FIELDNAME ].ToString( );
               o.Database = (string) r[ MdItem.DATABASE_FIELDNAME ].ToString( );
               o.Schema = (string) r[ MdItem.SCHEMA_FIELDNAME ].ToString( );
               o.ObjectName = (string) r[ MdItem.OBJECT_FIELDNAME ].ToString( );
               o.NameFullQualified = (string) r[ MdItem.NAMEFULLQUALIFIED_FIELDNAME ].ToString( );
               o.NameQuoted = r[ MdItem.NAMEQUOTED_FIELDNAME ].ToString( );
               o.AltName = r[ MdItem.ALTNAME_FIELDNAME ].ToString( );
               o.Name = r[ MdItem.NAME_FIELD_FIELDNAME ].ToString( );
               o.HasDefault = (bool) r[ MdItem.HAS_DEFAULT_FIELDNAME ];
               o.Expression = r[ MdItem.EXPRESSION_FIELDNAME ].ToString( );
               //
               o.DatabaseDatatype = (string) r[MdItem.FIELD_DATABASE_DATATYPE_FIELDNAME].ToString();
               o.DotNetDatatype = (string) r[ MdItem.FIELD_DOT_NET_DATATYPE_FIELDNAME ].ToString();
               o.IsNullable = (bool) r[ MdItem.IS_NULLABLE_FIELDNAME ];
               o.Precision = (Int32) r[ MdItem.PRECISION_FIELDNAME ];
               o.Scale = (int) r[ MdItem.SCALE_FIELDNAME ];
               o.Size = (Int32) r[ MdItem.SIZE_FIELDNAME ];
               o.IsPK = (bool) r[ MdItem.IS_PK_FIELDNAME ];
               o.IsRO = (bool) r[ MdItem.IS_READONLY_FIELDNAME ];
               o.Description = r[ MdItem.DESCRIPTION_FIELDNAME ].ToString( );
               o.Tag = r[ MdItem.TAG_FIELDNAME ].ToString( );
               o.UserData = r[ MdItem.USERDATA_FIELDNAME ].ToString( );
            }
            //
            o.Save( );
            this.xpCollection1.Add( o );
         }
      }
   }
}
