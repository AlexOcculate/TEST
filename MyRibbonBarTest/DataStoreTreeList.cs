using ActiveQueryBuilder.View.WinForms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.IO;
using System.Linq;

namespace MyRibbonBarTest
{
   public class DataStoreTreeList : TreeList
   {
      private const string PROVIDER_COLNAME = "Provider";                    // Name
      private const string SYNTAX_COLNAME = "Syntax";                        // Syntax Provider
      private const string METADATA_COLNAME = "Metadata";                    // Metadata Provider
      private const string SERVER_VERSION_COLNAME = "Server Version";        // NOPE
      private const string SENSITIVITY_COLNAME = "Case Sensitivity";         // NOPE
      private const string START_COLNAME = "Start";                          // NOPE
      private const string END_COLNAME = "End";                              // NOPE
      private const string CONNECTION_STRING_COLNAME = "Connection String";  // Connection String
                                                                             //
      public string filename = @"DataStoresTreeList.xml";
      //
      private ActiveQueryBuilder.Core.BaseSyntaxProvider _syntaxProvider = null;
      private string _connectionString;
      //
      private RepositoryItemComboBox _spCB;

      public DataStoreTreeList(string filename = null)
      {
         this.loadSpCB();
         //
         if(!string.IsNullOrWhiteSpace(filename))
         {
            this.filename = filename;
         }
         if(File.Exists(this.filename))
         {
            this.ImportFromXml(this.filename);
            if(this.Columns.Count > 0)
            {
               return;
            }
         }
         this.createDefaultColumns();
         this.createDefaultRows();
         // this.ExportToXml();
      }

      //
      private void createDefaultColumns()
      {
         TreeListColumn idCol = this.Columns.Add();
         idCol.Caption = PROVIDER_COLNAME;
         idCol.VisibleIndex = 0;
         //
         TreeListColumn syntaxCol = this.Columns.Add();
         syntaxCol.Caption = SYNTAX_COLNAME;
         syntaxCol.VisibleIndex = 1;
         syntaxCol.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
         // Handle this event to assign editors to individual cells
         this.CustomNodeCellEdit += (s, e) =>
         {
            if(e.Column == syntaxCol)
            {
               e.RepositoryItem = this._spCB;
            }
         };
         //
         TreeListColumn metadataCol = this.Columns.Add();
         metadataCol.Caption = METADATA_COLNAME;
         metadataCol.VisibleIndex = 2;
         //
         TreeListColumn serverVersionCol = this.Columns.Add();
         serverVersionCol.Caption = SERVER_VERSION_COLNAME;
         serverVersionCol.VisibleIndex = 3;
         //
         TreeListColumn identCaseSens = this.Columns.Add();
         identCaseSens.Caption = SENSITIVITY_COLNAME;
         identCaseSens.VisibleIndex = 4;
         //
         TreeListColumn quoteBeginCol = this.Columns.Add();
         quoteBeginCol.Caption = START_COLNAME;
         quoteBeginCol.VisibleIndex = 5;
         //
         TreeListColumn quoteEndCol = this.Columns.Add();
         quoteEndCol.Caption = END_COLNAME;
         quoteEndCol.VisibleIndex = 6;
         //
         TreeListColumn connecStringCol = this.Columns.Add();
         quoteEndCol.Caption = CONNECTION_STRING_COLNAME;
         quoteEndCol.VisibleIndex = 7;
      }

      //
      private void createDefaultRows()
      {
         this.BeginUnboundLoad();
         {
            this.AppendNode(new object[ ]
            { "DS0001", "ANSI SQL-92", "Advantage", true, string.Empty, string.Empty, null, this._connectionString }, null);
            this.AppendNode(new object[ ]
            { "DS0001", "ANSI SQL-92", "Advantage", true, string.Empty, string.Empty, null, null }, null);
            this.AppendNode(new object[ ]
            { "DS0001", "ANSI SQL-92", "Advantage", true, string.Empty, string.Empty, null, null }, null);
            TreeListNode appendNode = this.AppendNode(new object[ ]
            { "Folder", null, null, null, null, null, null }, null);
            this.AppendNode(new object[ ]
            { "DS0001", "ANSI SQL-92", "Advantage", true, string.Empty, string.Empty, null, null }, appendNode);
            this.AppendNode(new object[ ]
            { "DS0001", "ANSI SQL-92", "Advantage", true, string.Empty, string.Empty, null, null }, appendNode);
            this.AppendNode(new object[ ]
            { "DS0001", "ANSI SQL-92", "Advantage", true, string.Empty, string.Empty, null, null }, appendNode);
         }
         this.EndUnboundLoad();
      }

      //
      private void loadSpCB()
      {
         this._spCB = new RepositoryItemComboBox();
         this._spCB.Items.Add("Auto");
         this._spCB.Items.Add("Generic");
         this._spCB.Items.Add("ANSI SQL-2003");
         this._spCB.Items.Add("ANSI SQL-89");
         this._spCB.Items.Add("ANSI SQL-92");
         this._spCB.Items.Add("Firebird 1.0");
         this._spCB.Items.Add("Firebird 1.5");
         this._spCB.Items.Add("Firebird 2.0");
         this._spCB.Items.Add("Firebird 2.5");
         this._spCB.Items.Add("IBM DB2");
         this._spCB.Items.Add("IBM Informix 8");
         this._spCB.Items.Add("IBM Informix 9");
         this._spCB.Items.Add("IBM Informix 10");
         this._spCB.Items.Add("MS Access 97 (MS Jet 3.0)");
         this._spCB.Items.Add("MS Access 2000 (MS Jet 4.0)");
         this._spCB.Items.Add("MS Access XP (MS Jet 4.0)");
         this._spCB.Items.Add("MS Access 2003 (MS Jet 4.0)");
         this._spCB.Items.Add("MS SQL Server 7");
         this._spCB.Items.Add("MS SQL Server 2000");
         this._spCB.Items.Add("MS SQL Server 2005");
         this._spCB.Items.Add("MS SQL Server 2008");
         this._spCB.Items.Add("MS SQL Server 2012");
         this._spCB.Items.Add("MS SQL Server 2014");
         this._spCB.Items.Add("MS SQL Server Compact Edition");
         this._spCB.Items.Add("MySQL 3.xx");
         this._spCB.Items.Add("MySQL 4.0");
         this._spCB.Items.Add("MySQL 4.1");
         this._spCB.Items.Add("MySQL 5.0");
         this._spCB.Items.Add("Oracle 7");
         this._spCB.Items.Add("Oracle 8");
         this._spCB.Items.Add("Oracle 9");
         this._spCB.Items.Add("Oracle 10");
         this._spCB.Items.Add("Oracle 11");
         this._spCB.Items.Add("PostgreSQL");
         this._spCB.Items.Add("SQLite");
         this._spCB.Items.Add("Sybase ASE");
         this._spCB.Items.Add("Sybase SQL Anywhere");
         this._spCB.Items.Add("Teradata");
         this._spCB.Items.Add("VistaDB");
      }

      //
      public void SelecteMetadataProvider(TreeListNode tn, QueryBuilder qb)
      {
         string syntaxProviderName = tn.GetValue(SYNTAX_COLNAME) as string;
         switch(syntaxProviderName)
         {
            default:
            //
            #region --- Generic and Auto Flavors ---
            case "Generic":
               this._syntaxProvider = new ActiveQueryBuilder.Core.GenericSyntaxProvider();
               ((ActiveQueryBuilder.Core.GenericSyntaxProvider) this._syntaxProvider).RedetectServer(qb.SQLContext);
               break;
            //
            case "Auto":
               this._syntaxProvider = new ActiveQueryBuilder.Core.AutoSyntaxProvider();
               break;
            #endregion
            //
            #region --- ANSI SQL Flavros ---
            case "ANSI SQL-92":
               this._syntaxProvider = new ActiveQueryBuilder.Core.SQL92SyntaxProvider();
               break;
            case "ANSI SQL-89":
               this._syntaxProvider = new ActiveQueryBuilder.Core.SQL89SyntaxProvider();
               break;
            case "ANSI SQL-2003":
               this._syntaxProvider = new ActiveQueryBuilder.Core.SQL2003SyntaxProvider();
               break;
            #endregion
            //
            #region --- Firebird Flavors ---
            case "Firebird 1.0":
               this._syntaxProvider = new ActiveQueryBuilder.Core.FirebirdSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.FirebirdSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.FirebirdVersion.Firebird10;
               break;

            case "Firebird 1.5":
               this._syntaxProvider = new ActiveQueryBuilder.Core.FirebirdSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.FirebirdSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.FirebirdVersion.Firebird15;
               break;

            case "Firebird 2.0":
               this._syntaxProvider = new ActiveQueryBuilder.Core.FirebirdSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.FirebirdSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.FirebirdVersion.Firebird20;
               break;

            case "Firebird 2.5":
               this._syntaxProvider = new ActiveQueryBuilder.Core.FirebirdSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.FirebirdSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.FirebirdVersion.Firebird25;
               break;
            #endregion
            //
            #region --- IBM DB2 Flavors ---
            case "IBM DB2":
               this._syntaxProvider = new ActiveQueryBuilder.Core.DB2SyntaxProvider();
               break;
            #endregion
            //
            #region --- IBM Informix Flavors ---
            case "IBM Informix 8":
               this._syntaxProvider = new ActiveQueryBuilder.Core.InformixSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.InformixSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.InformixVersion.DS8;
               break;

            case "IBM Informix 9":
               this._syntaxProvider = new ActiveQueryBuilder.Core.InformixSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.InformixSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.InformixVersion.DS9;
               break;

            case "IBM Informix 10":
               this._syntaxProvider = new ActiveQueryBuilder.Core.InformixSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.InformixSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.InformixVersion.DS10;
               break;
            #endregion
            //
            #region --- MS Acess Flavors ---
            case "MS Access 97 (MS Jet 3.0)":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSAccessSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSAccessSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSAccessServerVersion.MSJET3;
               break;

            case "MS Access 2000 (MS Jet 4.0)":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSAccessSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSAccessSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSAccessServerVersion.MSJET3;
               break;

            case "MS Access XP (MS Jet 4.0)":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSAccessSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSAccessSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSAccessServerVersion.MSJET3;
               break;

            case "MS Access 2003 (MS Jet 4.0)":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSAccessSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSAccessSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSAccessServerVersion.MSJET4;
               break;
            #endregion
            //
            #region --- MS SQL Server Flavors ---
            case "MS SQL Server 7":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSSQLSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSSQLServerVersion.MSSQL7;
               break;

            case "MS SQL Server 2000":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSSQLSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSSQLServerVersion.MSSQL2000;
               break;

            case "MS SQL Server 2005":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSSQLSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSSQLServerVersion.MSSQL2005;
               break;

            case "MS SQL Server 2008":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSSQLSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSSQLServerVersion.MSSQL2008;
               break;

            case "MS SQL Server 2012":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSSQLSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSSQLServerVersion.MSSQL2012;
               break;

            case "MS SQL Server 2014":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MSSQLSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.MSSQLServerVersion.MSSQL2014;
               break;
            #endregion
            //
            #region --- MS SQL Server Compact Flavors ---
            case "MS SQL Server Compact Edition":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider();
               break;
            #endregion
            //
            #region --- MySQL Flavors ---
            case "MySQL 3.xx":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MySQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MySQLSyntaxProvider).ServerVersionInt = 39999;
               break;

            case "MySQL 4.0":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MySQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MySQLSyntaxProvider).ServerVersionInt = 40099;
               break;

            case "MySQL 4.1":
               this._syntaxProvider = new ActiveQueryBuilder.Core.MySQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MySQLSyntaxProvider).ServerVersionInt = 49999;
               break;

            case "MySQL 5.0":
               tn.SetValue(METADATA_COLNAME, "MySQL");
               this._syntaxProvider = new ActiveQueryBuilder.Core.MySQLSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.MySQLSyntaxProvider).ServerVersionInt = 50000;
               break;
            #endregion
            //
            #region --- Oracle Flavors ---
            case "Oracle 7":
               this._syntaxProvider = new ActiveQueryBuilder.Core.OracleSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.OracleSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle7;
               break;

            case "Oracle 8":
               this._syntaxProvider = new ActiveQueryBuilder.Core.OracleSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.OracleSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle8;

               break;

            case "Oracle 9":
               this._syntaxProvider = new ActiveQueryBuilder.Core.OracleSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.OracleSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle9;
               break;

            case "Oracle 10":
               this._syntaxProvider = new ActiveQueryBuilder.Core.OracleSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.OracleSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle10;
               break;

            case "Oracle 11":
               this._syntaxProvider = new ActiveQueryBuilder.Core.OracleSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.OracleSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle11;
               break;
            #endregion
            //
            #region --- PostgreSQL ---
            case "PostgreSQL":
               this._syntaxProvider = new ActiveQueryBuilder.Core.PostgreSQLSyntaxProvider();
               break;
            #endregion
            //
            #region --- SQLite Flavors ---
            case "SQLite":
               this._syntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider();
               break;
            #endregion
            //
            #region --- Sybase ---
            case "Sybase ASE":
               this._syntaxProvider = new ActiveQueryBuilder.Core.SybaseSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.SybaseSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.SybaseServerVersion.SybaseASE;
               break;

            case "Sybase SQL Anywhere":
               this._syntaxProvider = new ActiveQueryBuilder.Core.SybaseSyntaxProvider();
               (this._syntaxProvider as ActiveQueryBuilder.Core.SybaseSyntaxProvider).ServerVersion = ActiveQueryBuilder.Core.SybaseServerVersion.SybaseASA;
               break;
            #endregion
            //
            #region --- Teradata Flavors ---
            case "Teradata":
               this._syntaxProvider = new ActiveQueryBuilder.Core.TeradataSyntaxProvider();
               break;
            #endregion
            //
            #region --- VistaDB Flavors ---
            case "VistaDB":
               this._syntaxProvider = new ActiveQueryBuilder.Core.VistaDBSyntaxProvider();
               break;
               #endregion
         }
         tn.SetValue(SERVER_VERSION_COLNAME, syntaxProviderName);
         tn.SetValue(METADATA_COLNAME, syntaxProviderName);
         tn.SetValue(SENSITIVITY_COLNAME, (int) this._syntaxProvider.IdentCaseSens);
         tn.SetValue(START_COLNAME, this._syntaxProvider.QuoteBegin);
         tn.SetValue(END_COLNAME, this._syntaxProvider.QuoteEnd);
         tn.SetValue(CONNECTION_STRING_COLNAME, this._connectionString);
         //this.Modified = true;
      }
      //
   }
}
