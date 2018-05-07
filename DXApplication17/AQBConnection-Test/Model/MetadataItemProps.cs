using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Xml.Serialization;

namespace AQBConnection_Test.Model
{
   public partial class MetadataItemProps
   {
      private DataRow o;

      #region --- ID ---
      public const string ID_FIELDNAME = "ID";
      public const string ID_DISPLAYNAME = "ID";
      public const string ID_DESCRIPTION = null;
      public const string ID_CATEGORY = "IDs";
      public const string ID_XMLNAME = "id";
      [DisplayName( ID_DISPLAYNAME )]
      [Description( ID_DESCRIPTION )]
      [Category( PARENT_ID_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( ID_XMLNAME )]
      public int ID
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[ ID_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ ID_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- PARENT ID ---
      public const string PARENT_ID_FIELDNAME = "ParentID";
      public const string PARENT_ID_DISPLAYNAME = "Parent ID";
      public const string PARENT_ID_DESCRIPTION = null;
      public const string PARENT_ID_CATEGORY = ID_CATEGORY;
      public const string PARENT_ID_XMLNAME = "pid";
      [DisplayName( PARENT_ID_DISPLAYNAME )]
      [Description( PARENT_ID_DESCRIPTION )]
      [Category( PARENT_ID_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( PARENT_ID_XMLNAME )]
      public int ParentID
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[ PARENT_ID_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ PARENT_ID_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- DATASTORE NAME ---
      public const string DATASTORE_NAME_FIELDNAME = "DataStoreName";
      public const string DATASTORE_NAME_DISPLAYNAME = "DataStore Name";
      public const string DATASTORE_NAME_DESCRIPTION = null;
      public const string DATASTORE_NAME_CATEGORY = ID_CATEGORY;
      public const string DATASTORE_NAME_XMLNAME = "ds";
      [DisplayName( DATASTORE_NAME_DISPLAYNAME )]
      [Description( DATASTORE_NAME_DESCRIPTION )]
      [Category( DATASTORE_NAME_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( DATASTORE_NAME_XMLNAME )]
      public string DataStoreName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ DATASTORE_NAME_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ DATASTORE_NAME_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- SNAPSHOT FILE ---
      public const string SNAPSHOT_FILE_FIELDNAME = "SnapshotFile";
      public const string SNAPSHOT_FILE_DISPLAYNAME = "Snapshot File";
      public const string SNAPSHOT_FILE_DESCRIPTION = null;
      public const string SNAPSHOT_FILE_CATEGORY = ID_CATEGORY;
      public const string SNAPSHOT_FILE_XMLNAME = "ss";
      [DisplayName( SNAPSHOT_FILE_DISPLAYNAME )]
      [Description( SNAPSHOT_FILE_DESCRIPTION )]
      [Category( SNAPSHOT_FILE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( SNAPSHOT_FILE_XMLNAME )]
      public string SnapshotFile
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ SNAPSHOT_FILE_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ SNAPSHOT_FILE_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- LAST WRITE TIME UTC ---
      public const string LASTWRITETIMEUTC_FIELDNAME = "LastWriteTimeUtc";
      public const string LASTWRITETIMEUTC_DISPLAYNAME = "Las tWrite Time UTC";
      public const string LASTWRITETIMEUTC_DESCRIPTION = null;
      public const string LASTWRITETIMEUTC_CATEGORY = ID_CATEGORY;
      public const string LASTWRITETIMEUTC_XMLNAME = "ss";
      [DisplayName( LASTWRITETIMEUTC_DISPLAYNAME )]
      [Description( LASTWRITETIMEUTC_DESCRIPTION )]
      [Category( LASTWRITETIMEUTC_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( LASTWRITETIMEUTC_XMLNAME )]
      public System.DateTime LastWriteTimeUtc
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (System.DateTime) this.o[ LASTWRITETIMEUTC_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ LASTWRITETIMEUTC_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- METADATA PROVIDER ---
      public const string METADATA_PROVIDER_FIELDNAME = "MetadataProvider";
      public const string METADATA_PROVIDER_DISPLAYNAME = "Metadata Provider";
      public const string METADATA_PROVIDER_DESCRIPTION = null;
      public const string METADATA_PROVIDER_CATEGORY = "Query Builder";
      public const string METADATA_PROVIDER_XMLNAME = "mp";
      [DisplayName( METADATA_PROVIDER_DISPLAYNAME )]
      [Description( METADATA_PROVIDER_DESCRIPTION )]
      [Category( METADATA_PROVIDER_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( METADATA_PROVIDER_XMLNAME )]
      public string MetadataProvider
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ METADATA_PROVIDER_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ METADATA_PROVIDER_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- SYNTAX PROVIDER ---
      public const string SYNTAX_PROVIDER_FIELDNAME = "SyntaxProvider";
      public const string SYNTAX_PROVIDER_DISPLAYNAME = "Syntax Provider";
      public const string SYNTAX_PROVIDER_DESCRIPTION = null;
      public const string SYNTAX_PROVIDER_CATEGORY = "Query Builder";
      public const string SYNTAX_PROVIDER_XMLNAME = "sp";
      [DisplayName( SYNTAX_PROVIDER_DISPLAYNAME )]
      [Description( SYNTAX_PROVIDER_DESCRIPTION )]
      [Category( SYNTAX_PROVIDER_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( SYNTAX_PROVIDER_XMLNAME )]
      public string SyntaxProvider
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ SYNTAX_PROVIDER_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ SYNTAX_PROVIDER_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- TYPE ---
      public const string TYPE_FIELDNAME = "Type";
      public const string TYPE_DISPLAYNAME = "Type";
      public const string TYPE_DESCRIPTION = null;
      public const string TYPE_CATEGORY = "Types";
      public const string TYPE_XMLNAME = "tp";
      [DisplayName( TYPE_DISPLAYNAME )]
      [Description( TYPE_DESCRIPTION )]
      [Category( TYPE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( TYPE_XMLNAME )]
      public string Type
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ TYPE_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ TYPE_FIELDNAME ] = value;
         }
      }

      #endregion

      #region --- PARENT TYPE ---
      public const string PARENT_TYPE_FIELDNAME = "ParentType";
      public const string PARENT_TYPE_DISPLAYNAME = "Parent Type";
      public const string PARENT_TYPE_DESCRIPTION = null;
      public const string PARENT_TYPE_CATEGORY = "Types";
      public const string PARENT_TYPE_XMLNAME = "pt";
      [DisplayName( PARENT_TYPE_DISPLAYNAME )]
      [Description( PARENT_TYPE_DESCRIPTION )]
      [Category( PARENT_TYPE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( PARENT_TYPE_XMLNAME )]
      public string ParentType
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (string) this.o[ PARENT_TYPE_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ PARENT_TYPE_FIELDNAME ] = value;
         }
      }

      #endregion

      #region --- IS SYSTEM ---
      public const string IS_SYSTEM_FIELDNAME = "IsSystem";
      public const string IS_SYSTEM_DISPLAYNAME = "Is System?";
      public const string IS_SYSTEM_DESCRIPTION = null;
      public const string IS_SYSTEM_CATEGORY = "Types";
      public const string IS_SYSTEM_XMLNAME = "pt";
      [DisplayName( IS_SYSTEM_DISPLAYNAME )]
      [Description( IS_SYSTEM_DESCRIPTION )]
      [Category( IS_SYSTEM_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( IS_SYSTEM_XMLNAME )]
      public bool IsSystem
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (bool) this.o[ IS_SYSTEM_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ IS_SYSTEM_FIELDNAME ] = value;
         }
      }

      #endregion

      #region --- CARDINALITY ---
      public const string CARDINALYTY_FIELDNAME = "Cardinality";
      public const string CARDINALYTY_DISPLAYNAME = "FK Cardinality";
      public const string CARDINALYTY_DESCRIPTION = null;
      public const string CARDINALYTY_CATEGORY = "Cardinality";
      public const string CARDINALYTY_XMLNAME = "cd";
      [DisplayName( CARDINALYTY_DISPLAYNAME )]
      [Description( CARDINALYTY_DESCRIPTION )]
      [Category( CARDINALYTY_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( CARDINALYTY_XMLNAME )]
      public string Cardinality
      {
         //[System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ CARDINALYTY_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ CARDINALYTY_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- FIELDS_COUNT ---
      public const string FIELDSCOUNT_FIELDNAME = "FieldsCount";
      public const string FIELDSCOUNT_DISPLAYNAME = "FK Fields Count";
      public const string FIELDSCOUNT_DESCRIPTION = null;
      public const string FIELDSCOUNT_CATEGORY = CARDINALYTY_CATEGORY;
      public const string FIELDSCOUNT_XMLNAME = "fc";
      [DisplayName( FIELDSCOUNT_DISPLAYNAME )]
      [Description( FIELDSCOUNT_DESCRIPTION )]
      [Category( FIELDSCOUNT_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( FIELDSCOUNT_XMLNAME )]
      public int FieldsCount
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            int value = (int) this.o[ FIELDSCOUNT_FIELDNAME ];
            return value;
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ FIELDSCOUNT_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- FIELDS ---
      public const string FIELDS_FIELDNAME = "Fields";
      public const string FIELDS_DISPLAYNAME = "FK Fields";
      public const string FIELDS_DESCRIPTION = null;
      public const string FIELDS_CATEGORY = CARDINALYTY_CATEGORY;
      public const string FIELDS_XMLNAME = "fds";
      [DisplayName( FIELDS_DISPLAYNAME )]
      [Description( FIELDS_DESCRIPTION )]
      [Category( FIELDS_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( FIELDS_XMLNAME )]
      public List<string> Fields
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            List<string> l = new List<string>( );
            l.Add( this.o[ FIELDS_FIELDNAME ].ToString( ) );
            return l;
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            //this.o[ FIELDS_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- ReferencedCardinality ---
      public const string REFERENCED_CARDINALYTY_FIELDNAME = "ReferencedCardinality";
      public const string REFERENCED_CARDINALYTY_DISPLAYNAME = "TK Cardinality";
      public const string REFERENCED_CARDINALYTY_DESCRIPTION = null;
      public const string REFERENCED_CARDINALYTY_CATEGORY = CARDINALYTY_CATEGORY;
      public const string REFERENCED_CARDINALYTY_XMLNAME = "rc";
      [DisplayName( REFERENCED_CARDINALYTY_DISPLAYNAME )]
      [Description( REFERENCED_CARDINALYTY_DESCRIPTION )]
      [Category( REFERENCED_CARDINALYTY_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( REFERENCED_CARDINALYTY_XMLNAME )]
      public string ReferencedCardinality
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ REFERENCED_CARDINALYTY_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ REFERENCED_CARDINALYTY_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- ReferencedObject ---
      public const string REFERENCED_OBJECT_FIELDNAME = "ReferencedObject";
      public const string REFERENCED_OBJECT_DISPLAYNAME = "TK Object";
      public const string REFERENCED_OBJECT_DESCRIPTION = null;
      public const string REFERENCED_OBJECT_CATEGORY = CARDINALYTY_CATEGORY;
      public const string REFERENCED_OBJECT_XMLNAME = "ro";
      [DisplayName( REFERENCED_OBJECT_DISPLAYNAME )]
      [Description( REFERENCED_OBJECT_DESCRIPTION )]
      [Category( REFERENCED_OBJECT_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( REFERENCED_OBJECT_XMLNAME )]
      public string ReferencedObject
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ REFERENCED_OBJECT_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ REFERENCED_OBJECT_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- ReferencedObjectName ---
      public const string REFERENCED_OBJECT_NAME_FIELDNAME = "ReferencedObjectName";
      public const string REFERENCED_OBJECT_NAME_DISPLAYNAME = "TK Object Name";
      public const string REFERENCED_OBJECT_NAME_DESCRIPTION = null;
      public const string REFERENCED_OBJECT_NAME_CATEGORY = CARDINALYTY_CATEGORY;
      public const string REFERENCED_OBJECT_NAME_XMLNAME = "ron";
      [DisplayName( REFERENCED_OBJECT_NAME_DISPLAYNAME )]
      [Description( REFERENCED_OBJECT_NAME_DESCRIPTION )]
      [Category( REFERENCED_OBJECT_NAME_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( REFERENCED_OBJECT_NAME_XMLNAME )]
      public string ReferencedObjectName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ REFERENCED_OBJECT_NAME_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ REFERENCED_OBJECT_NAME_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- ReferencedFieldCount ---
      public const string REFERENCED_FIELDS_COUNT_FIELDNAME = "ReferencedFieldsCount";
      public const string REFERENCED_FIELDS_COUNT_DISPLAYNAME = "TK Fields Count";
      public const string REFERENCED_FIELDS_COUNT_DESCRIPTION = null;
      public const string REFERENCED_FIELDS_COUNT_CATEGORY = CARDINALYTY_CATEGORY;
      public const string REFERENCED_FIELDS_COUNT_XMLNAME = "rfc";
      [DisplayName( REFERENCED_FIELDS_COUNT_DISPLAYNAME )]
      [Description( REFERENCED_FIELDS_COUNT_DESCRIPTION )]
      [Category( REFERENCED_FIELDS_COUNT_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( REFERENCED_FIELDS_COUNT_XMLNAME )]
      public int ReferencedFieldsCount
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[ REFERENCED_FIELDS_COUNT_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ REFERENCED_FIELDS_COUNT_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- ReferencedFields ---
      public const string REFERENCED_FIELDS_FIELDNAME = "ReferencedFields";
      public const string REFERENCED_FIELDS_DISPLAYNAME = "TK Fields";
      public const string REFERENCED_FIELDS_DESCRIPTION = null;
      public const string REFERENCED_FIELDS_CATEGORY = CARDINALYTY_CATEGORY;
      public const string REFERENCED_FIELDS_XMLNAME = "rf";
      [DisplayName( REFERENCED_FIELDS_DISPLAYNAME )]
      [Description( REFERENCED_FIELDS_DESCRIPTION )]
      [Category( REFERENCED_FIELDS_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( REFERENCED_FIELDS_XMLNAME )]
      public List<string> ReferencedFields
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            List<string> l = new List<string>( );
            l.Add( this.o[ REFERENCED_FIELDS_FIELDNAME ].ToString( ) );
            return l;
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            //this.o[ REFERENCED_FIELDS_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- SERVER ---
      public const string SERVER_FIELDNAME = "Server";
      public const string SERVER_DISPLAYNAME = "Server";
      public const string SERVER_DESCRIPTION = null;
      public const string SERVER_CATEGORY = ID_CATEGORY;
      public const string SERVER_XMLNAME = "svr";
      [DisplayName( SERVER_DISPLAYNAME )]
      [Description( SERVER_DESCRIPTION )]
      [Category( SERVER_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( SERVER_XMLNAME )]
      public string Server
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ SERVER_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ SERVER_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- DATABASE ---
      public const string DATABASE_FIELDNAME = "Database";
      public const string DATABASE_DISPLAYNAME = "Database";
      public const string DATABASE_DESCRIPTION = null;
      public const string DATABASE_CATEGORY = ID_CATEGORY;
      public const string DATABASE_XMLNAME = "db";
      [DisplayName( DATABASE_DISPLAYNAME )]
      [Description( DATABASE_DESCRIPTION )]
      [Category( DATABASE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( DATABASE_XMLNAME )]
      public string Database
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ DATABASE_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ DATABASE_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- SCHEMA ---
      public const string SCHEMA_FIELDNAME = "Schema";
      public const string SCHEMA_DISPLAYNAME = "Schema";
      public const string SCHEMA_DESCRIPTION = null;
      public const string SCHEMA_CATEGORY = ID_CATEGORY;
      public const string SCHEMA_XMLNAME = "sch";
      [DisplayName( SCHEMA_DISPLAYNAME )]
      [Description( SCHEMA_DESCRIPTION )]
      [Category( SCHEMA_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( SCHEMA_XMLNAME )]
      public string Schema
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ SCHEMA_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ SCHEMA_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- OBJECT_NAME ---
      public const string OBJECT_FIELDNAME = "ObjectName";
      public const string OBJECT_DISPLAYNAME = "Parent Name";
      public const string OBJECT_DESCRIPTION = null;
      public const string OBJECT_CATEGORY = ID_CATEGORY;
      public const string OBJECT_XMLNAME = "on";
      [DisplayName( OBJECT_DISPLAYNAME )]
      [Description( OBJECT_DESCRIPTION )]
      [Category( OBJECT_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( OBJECT_XMLNAME )]
      public string ObjectName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ OBJECT_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ OBJECT_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- NameFullQualified ---
      public const string NAMEFULLQUALIFIED_FIELDNAME = "NameFullQualified";
      public const string NAMEFULLQUALIFIED_DISPLAYNAME = "Name Full Qualified";
      public const string NAMEFULLQUALIFIED_DESCRIPTION = null;
      public const string NAMEFULLQUALIFIED_CATEGORY = ID_CATEGORY;
      public const string NAMEFULLQUALIFIED_XMLNAME = "nfq";
      [DisplayName( NAMEFULLQUALIFIED_DISPLAYNAME )]
      [Description( NAMEFULLQUALIFIED_DESCRIPTION )]
      [Category( NAMEFULLQUALIFIED_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( NAMEFULLQUALIFIED_XMLNAME )]
      public string NameFullQualified
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ NAMEFULLQUALIFIED_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ NAMEFULLQUALIFIED_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- NameQuoted ---
      public const string NAMEQUOTED_FIELDNAME = "NameQuoted";
      public const string NAMEQUOTED_DISPLAYNAME = "Name Full Qualified";
      public const string NAMEQUOTED_DESCRIPTION = null;
      public const string NAMEQUOTED_CATEGORY = ID_CATEGORY;
      public const string NAMEQUOTED_XMLNAME = "nq";
      [DisplayName( NAMEQUOTED_DISPLAYNAME )]
      [Description( NAMEQUOTED_DESCRIPTION )]
      [Category( NAMEQUOTED_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( NAMEQUOTED_XMLNAME )]
      public string NameQuoted
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ NAMEQUOTED_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ NAMEQUOTED_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- ALT NAME ----
      public const string ALTNAME_FIELDNAME = "AltName";
      public const string ALTNAME_DISPLAYNAME = "Alt Name";
      public const string ALTNAME_DESCRIPTION = null;
      public const string ALTNAME_CATEGORY = ID_CATEGORY;
      public const string ALTNAME_XMLNAME = "an";
      [DisplayName( ALTNAME_DISPLAYNAME )]
      [Description( ALTNAME_DESCRIPTION )]
      [Category( ALTNAME_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( ALTNAME_XMLNAME )]
      public string AltName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ ALTNAME_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ ALTNAME_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- FIELD ---
      public const string FIELD_FIELDNAME = "Field";
      public const string FIELD_DISPLAYNAME = "Name";
      public const string FIELD_DESCRIPTION = null;
      public const string FIELD_CATEGORY = ID_CATEGORY;
      public const string FIELD_XMLNAME = "fld";
      [DisplayName( FIELD_DISPLAYNAME )]
      [Description( FIELD_DESCRIPTION )]
      [Category( FIELD_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( FIELD_XMLNAME )]
      public string Field
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ FIELD_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ FIELD_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- HAS DEFAULT ---
      public const string HAS_DEFAULT_FIELDNAME = "HasDefault";
      public const string HAS_DEFAULT_DISPLAYNAME = "Has Default?";
      public const string HAS_DEFAULT_DESCRIPTION = null;
      public const string HAS_DEFAULT_CATEGORY = "Misc";
      public const string HAS_DEFAULT_XMLNAME = "hd";
      [DisplayName( HAS_DEFAULT_DISPLAYNAME )]
      [Description( HAS_DEFAULT_DESCRIPTION )]
      [Category( HAS_DEFAULT_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( HAS_DEFAULT_XMLNAME )]
      public bool HasDefault
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (Boolean) this.o[ HAS_DEFAULT_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ HAS_DEFAULT_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- EXPRESSION ---
      public const string EXPRESSION_FIELDNAME = "Expression";
      public const string EXPRESSION_DISPLAYNAME = "Expression";
      public const string EXPRESSION_DESCRIPTION = null;
      public const string EXPRESSION_CATEGORY = "Misc";
      public const string EXPRESSION_XMLNAME = "xpr";
      [DisplayName( EXPRESSION_DISPLAYNAME )]
      [Description( EXPRESSION_DESCRIPTION )]
      [Category( EXPRESSION_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( EXPRESSION_XMLNAME )]
      public string Expression
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ EXPRESSION_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ EXPRESSION_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- FIELD TYPE ---
      public const string FIELD_TYPE_FIELDNAME = "FieldType";
      public const string FIELD_TYPE_DISPLAYNAME = ".Net Type Name";
      public const string FIELD_TYPE_DESCRIPTION = null;
      public const string FIELD_TYPE_CATEGORY = "Misc";
      public const string FIELD_TYPE_XMLNAME = "ft";
      [DisplayName( FIELD_TYPE_DISPLAYNAME )]
      [Description( FIELD_TYPE_DESCRIPTION )]
      [Category( FIELD_TYPE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( FIELD_TYPE_XMLNAME )]
      public string FieldType
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ FIELD_TYPE_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ FIELD_TYPE_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- FIELD TYPE NAME ---
      public const string FIELD_TYPE_NAME_FIELDNAME = "FieldTypeName";
      public const string FIELD_TYPE_NAME_DISPLAYNAME = "Database Type Name";
      public const string FIELD_TYPE_NAME_DESCRIPTION = null;
      public const string FIELD_TYPE_NAME_CATEGORY = "Misc";
      public const string FIELD_TYPE_NAME_XMLNAME = "ftn";
      [DisplayName( FIELD_TYPE_NAME_DISPLAYNAME )]
      [Description( FIELD_TYPE_NAME_DESCRIPTION )]
      [Category( FIELD_TYPE_NAME_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( FIELD_TYPE_NAME_XMLNAME )]
      public string FieldTypeName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ FIELD_TYPE_NAME_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ FIELD_TYPE_NAME_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- IS NULLABLE ---
      public const string IS_NULLABLE_FIELDNAME = "IsNullable";
      public const string IS_NULLABLE_DISPLAYNAME = "Is Nullable?";
      public const string IS_NULLABLE_DESCRIPTION = null;
      public const string IS_NULLABLE_CATEGORY = "Misc";
      public const string IS_NULLABLE_XMLNAME = "nlb";
      [DisplayName( IS_NULLABLE_DISPLAYNAME )]
      [Description( IS_NULLABLE_DESCRIPTION )]
      [Category( IS_NULLABLE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( IS_NULLABLE_XMLNAME )]
      public bool IsNullable
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (Boolean) this.o[ IS_NULLABLE_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ IS_NULLABLE_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- PREC ---
      public const string PRECISION_FIELDNAME = "Precision";
      public const string PRECISION_DISPLAYNAME = "Prec";
      public const string PRECISION_DESCRIPTION = null;
      public const string PRECISION_CATEGORY = "Misc";
      public const string PRECISION_XMLNAME = "prec";
      [DisplayName( PRECISION_DISPLAYNAME )]
      [Description( PRECISION_DESCRIPTION )]
      [Category( PRECISION_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( PRECISION_XMLNAME )]
      public int Precision
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[ PRECISION_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ PRECISION_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- SCALE ---
      public const string SCALE_FIELDNAME = "Scale";
      public const string SCALE_DISPLAYNAME = "Scale";
      public const string SCALE_DESCRIPTION = null;
      public const string SCALE_CATEGORY = "Misc";
      public const string SCALE_XMLNAME = "sc";
      [DisplayName( SCALE_DISPLAYNAME )]
      [Description( SCALE_DESCRIPTION )]
      [Category( SCALE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( SCALE_XMLNAME )]
      public int Scale
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[ SCALE_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ SCALE_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- SIZE ---
      public const string SIZE_FIELDNAME = "Size";
      public const string SIZE_DISPLAYNAME = "Size";
      public const string SIZE_DESCRIPTION = null;
      public const string SIZE_CATEGORY = "Misc";
      public const string SIZE_XMLNAME = "sz";
      [DisplayName( SIZE_DISPLAYNAME )]
      [Description( SIZE_DESCRIPTION )]
      [Category( SIZE_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( SIZE_XMLNAME )]
      public long Size
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[ SIZE_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ SIZE_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- IS PK ? ---
      public const string IS_PK_FIELDNAME = "IsPK";
      public const string IS_PK_DISPLAYNAME = "Is PK?";
      public const string IS_PK_DESCRIPTION = null;
      public const string IS_PK_CATEGORY = "Keys";
      public const string IS_PK_XMLNAME = "pk";
      [DisplayName( IS_PK_DISPLAYNAME )]
      [Description( IS_PK_DESCRIPTION )]
      [Category( IS_PK_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( IS_PK_XMLNAME )]
      public bool IsPK
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (Boolean) this.o[ IS_PK_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ IS_PK_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- IS READONLY ? ---
      public const string IS_READONLY_FIELDNAME = "IsRO";
      public const string IS_READONLY_DISPLAYNAME = "Is R/O?";
      public const string IS_READONLY_DESCRIPTION = null;
      public const string IS_READONLY_CATEGORY = "Misc";
      public const string IS_READONLY_XMLNAME = "ro";
      [DisplayName( IS_READONLY_DISPLAYNAME )]
      [Description( IS_READONLY_DESCRIPTION )]
      [Category( IS_READONLY_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( IS_READONLY_XMLNAME )]
      public bool IsRO
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (Boolean) this.o[ IS_READONLY_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ IS_READONLY_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- DESCRIPTION ---
      public const string DESCRIPTION_FIELDNAME = "Description";
      public const string DESCRIPTION_DISPLAYNAME = "Description";
      public const string DESCRIPTION_DESCRIPTION = null;
      public const string DESCRIPTION_CATEGORY = "Misc";
      public const string DESCRIPTION_XMLNAME = "dscr";
      [DisplayName( DESCRIPTION_DISPLAYNAME )]
      [Description( DESCRIPTION_DESCRIPTION )]
      [Category( DESCRIPTION_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( DESCRIPTION_XMLNAME )]
      public string Description
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ DESCRIPTION_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ DESCRIPTION_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- TAG ---
      public const string TAG_FIELDNAME = "Tag";
      public const string TAG_DISPLAYNAME = "Tag";
      public const string TAG_DESCRIPTION = null;
      public const string TAG_CATEGORY = "Misc";
      public const string TAG_XMLNAME = "tag";
      [DisplayName( TAG_DISPLAYNAME )]
      [Description( TAG_DESCRIPTION )]
      [Category( TAG_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( TAG_XMLNAME )]
      public object Tag
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ TAG_FIELDNAME ];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ TAG_FIELDNAME ] = value;
         }
      }
      #endregion

      #region --- USERDATA ---
      public const string USERDATA_FIELDNAME = "UserData";
      public const string USERDATA_DISPLAYNAME = "Tag";
      public const string USERDATA_DESCRIPTION = null;
      public const string USERDATA_CATEGORY = "Misc";
      public const string USERDATA_XMLNAME = "ud";
      [DisplayName( USERDATA_DISPLAYNAME )]
      [Description( USERDATA_DESCRIPTION )]
      [Category( USERDATA_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlElement( USERDATA_XMLNAME )]
      public string UserData
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return this.o[ USERDATA_FIELDNAME ].ToString( );
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[ USERDATA_FIELDNAME ] = value;
         }
      }
      #endregion

      public override string ToString()
      {
         //return string.Format("0:{1}", this.Type, this.NameFullQualified);
         return base.ToString( );
      }

      public MetadataItemProps( DataRow row )
      {
         this.o = row;
      }
   }
}

/*
      #region --- TS_STR ---
      public const string TS_MASK_FORMAT = "{0:yyyyMMdd-HHmmss-ffffzzz}";
      [System.ComponentModel.DataAnnotations.Display( AutoGenerateField = false )]
      [System.Xml.Serialization.XmlIgnore]
      public static string TS_STR
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return string.Format( TS_MASK_FORMAT, System.DateTime.Now );
         }
      }
      #endregion






      public const string REFERENCED_OBJECT_FIELDNAME = "ReferencedObject";
      public const string REFERENCED_OBJECT_DISPLAYNAME = "TK Object";
      [System.Xml.Serialization.XmlElement( "ro" )]
      public string ReferencedObject
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string REFERENCED_OBJECT_NAME_FIELDNAME = "ReferencedObjectName";
      public const string REFERENCED_OBJECT_NAME_DISPLAYNAME = "TK Object Name";
      [System.Xml.Serialization.XmlElement( "ron" )]
      public string ReferencedObjectName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string REFERENCED_FIELDS_COUNT_FIELDNAME = "ReferencedFieldsCount";
      public const string REFERENCED_FIELDS_COUNT_DISPLAYNAME = "TK Fields Count";
      [System.Xml.Serialization.XmlElement( "rfc" )]
      public int ReferencedFieldsCount
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string REFERENCED_FIELDS_FIELDNAME = "ReferencedFields";
      public const string REFERENCED_FIELDS_DISPLAYNAME = "TK Fields";
      [System.Xml.Serialization.XmlElement( "rf" )]
      public string ReferencedFields
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string SERVER_FIELDNAME = "Server";
      [System.Xml.Serialization.XmlElement( "svr" )]
      public string Server
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string DATABASE_FIELDNAME = "Database";
      [System.Xml.Serialization.XmlElement( "db" )]
      public string Database
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string SCHEMA_FIELDNAME = "Schema";
      [System.Xml.Serialization.XmlElement( "sch" )]
      public string Schema
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string OBJECT_FIELDNAME = "ObjectName";
      public const string OBJECT_DISPLAYNAME = "Parent Name";
      [System.Xml.Serialization.XmlElement( "on" )]
      public string ObjectName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string NAMEFULLQUALIFIED_FIELDNAME = "NameFullQualified";
      public const string NAMEFULLQUALIFIED_DISPLAYNAME = "Name Full Qualified";
      [System.Xml.Serialization.XmlElement( "nfq" )]
      public string NameFullQualified
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string NAMEQUOTED_FIELDNAME = "NameQuoted";
      [System.Xml.Serialization.XmlElement( "nq" )]
      public string NameQuoted
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string ALTNAME_FIELDNAME = "AltName";
      [System.Xml.Serialization.XmlElement( "an" )]
      public string AltName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string FIELD_FIELDNAME = "Field";
      public const string FIELD_DISPLAYNAME = "Name";
      [System.Xml.Serialization.XmlElement( "fld" )]
      public string Field
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlAttribute]
      public bool HasDefault
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string EXPRESSION_FIELDNAME = "Expression";
      [System.Xml.Serialization.XmlElement( "xpr" )]
      public string Expression
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string FIELD_TYPE_FIELDNAME = "FieldType";
      public const string FIELD_TYPE_DISPLAYNAME = ".Net Type Name";
      [System.Xml.Serialization.XmlElement( "ft" )]
      public string FieldType
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string FIELD_TYPE_NAME_FIELDNAME = "FieldTypeName";
      public const string FIELD_TYPE_NAME_DISPLAYNAME = "Database Type Name";
      [System.Xml.Serialization.XmlElement( "ftn" )]
      public string FieldTypeName
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlAttribute]
      public bool IsNullable
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlElement( "prec" )]
      public int Precision
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlElement( "sc" )]
      public int Scale
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      [System.Xml.Serialization.XmlElement( "sz" )]
      public long Size
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string IS_PK_FIELDNAME = "IsPK";
      [System.Xml.Serialization.XmlAttribute]
      public bool IsPK
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string IS_READONLY_FIELDNAME = "IsRO";
      [System.Xml.Serialization.XmlAttribute]
      public bool IsRO
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string DESCRIPTION_FIELDNAME = "Description";
      [System.Xml.Serialization.XmlElement( "dscr" )]
      public string Description
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string TAG_FIELDNAME = "Tag";
      public object Tag
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

      public const string USERDATA_FIELDNAME = "UserData";
      [System.Xml.Serialization.XmlElement( "ud" )]
      public string UserData
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }

*/
