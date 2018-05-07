using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MyRibbonBarTest
{
   public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      private QueryBuilder _qb;
      private BaseSyntaxProvider _syntaxProvider = null;
      private BindingList<ColumnQN> _colQnBindingList;
      private string _connectionString;

      public Form1()
      {
         this.InitializeComponent();
         this.gridView1.OptionsMenu.ShowConditionalFormattingItem = true;
      }

      public Form1(string connectionString, string filename, bool loadDefaultDatabaseOnly, bool loadSystemObjects, bool withFields)
      {
         this._connectionString = connectionString;
         this.InitializeComponent();
         this.createQueryBuilder(connectionString, loadDefaultDatabaseOnly, loadSystemObjects, withFields);
         this.buildBindingList(loadDefaultDatabaseOnly, loadSystemObjects, withFields);

         this.ConfigureMetadataGrid();
         //            _colQnBindingList[0].Serialize(@"C:\temp\MetadataContainerIndex.xml");
         //
         {
            //                var list = new ColumnQnList(_colQnBindingList);
            //                list.Serialize(@"C:\TEMP\MetadataContainerIndexes.xml");
         }
         //            QueryBuilder.ShowMetadataContainerLoadWizard(qb.MetadataContainer, qb.MetadataLoadingOptions);
         //            MetadataEditorOptions o = MetadataEditorOptions.HideLoadDatabaseButton;
         //           QueryBuilder.EditMetadataContainer(qb.MetadataContainer, qb.MetadataStructure, qb.MetadataLoadingOptions  );       
      }

      //
      private void ConfigureMetadataGrid()
      {
         this.gridControl1.DataSource = this._colQnBindingList;
         {
            #region  --- Hide Columns --- 
            this.gridView1.Columns["ServerName"].Visible = false;
            this.gridView1.Columns["ServerAltName"].Visible = false;
            this.gridView1.Columns["ServerNameFull"].Visible = false;
            this.gridView1.Columns["ServerNameQuoted"].Visible = false;
            //
            this.gridView1.Columns["DatabaseAltName"].Visible = false;
            this.gridView1.Columns["DatabaseNameFull"].Visible = false;
            this.gridView1.Columns["DatabaseNameQuoted"].Visible = false;
            //
            this.gridView1.Columns["SchemaAltName"].Visible = false;
            this.gridView1.Columns["SchemaNameFull"].Visible = false;
            this.gridView1.Columns["SchemaNameQuoted"].Visible = false;
            //
            this.gridView1.Columns["ParentAltName"].Visible = false;
            this.gridView1.Columns["ParentNameFull"].Visible = false;
            this.gridView1.Columns["ParentNameQuoted"].Visible = false;
            //
            this.gridView1.Columns["AltName"].Visible = false;
            this.gridView1.Columns["NameFull"].Visible = false;
            this.gridView1.Columns["NameQuoted"].Visible = false;
            //
            this.gridView1.Columns["Remarks"].Visible = false;
            this.gridView1.Columns["Expression"].Visible = false;
            #endregion

            #region --- Grouping ---
            this.gridView1.OptionsView.ShowGroupedColumns = false;
            this.gridView1.OptionsView.ShowGroupPanel = true;
            this.gridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = true;
            this.gridView1.Columns["ParentType"].GroupIndex = 0;
            // Make the group footers always visible. 
            this.gridView1.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
            // Create and setup the first summary item. 
            GridGroupSummaryItem item = new GridGroupSummaryItem();
            item.FieldName = "ObjectType";
            item.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.gridView1.GroupSummary.Add(item);
            // Create and setup the second summary item. 
            //GridGroupSummaryItem item1 = new GridGroupSummaryItem();
            //item1.FieldName = "UnitPrice";
            //item1.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            //item1.DisplayFormat = "Total {0:c2}";
            //item1.ShowInGroupColumnFooter = gridView1.Columns["UnitPrice"];
            //gridView1.GroupSummary.Add(item1);
            #endregion
         }
         this.gridControl1.UseEmbeddedNavigator = true;
         {
            {
               this.gridView1.ShowCustomization();
               this.gridView1.CustomizationForm.Text = "Customize Box";
               this.gridView1.CustomizationForm.Opacity = 0.7;
               this.gridView1.CustomizationForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
               // To set the form's location and size, use the GridView.CustomizationFormBounds property.
               // gridView1.CustomizationForm.OptionsCustomization = true;
               this.gridView1.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            }
            {
               this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
               this.gridView1.CalcPreviewText += new DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(this.gridView1_CalcPreviewText);
            }

            this.gridView1.OptionsFind.AllowFindPanel = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.HighlightFindResults = true;
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowPreview = true;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Esta e a View Principal";
            this.gridView1.OptionsView.ShowFooter = true;

            this.gridView1.OptionsFilter.AllowMRUFilterList = true;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = true;
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFilter.AllowFilterEditor = true;
            this.gridView1.OptionsFilter.AllowFilterIncrementalSearch = true;
            this.gridView1.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = true;
            this.gridView1.ViewCaptionHeight = -1;
         }
         this.gridView1.BestFitColumns(true);
      }


      private void Form1_Load(object sender, EventArgs e)
      {
         //            CreateDataStorageTreeList();
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         // serializeQueryBuilder("C:\\temp\\MetadataContainer_FormClosing.xml");
         // Save the layout to an XML file 
         //gridControl1.MainView.SaveLayoutToXml(fileName);
      }

      private void Form1_FormClosed(object sender, FormClosedEventArgs e)
      {
         //serializeQueryBuilder("C:\\temp\\MetadataContainer_FormClosed.xml");
         this.treeList1.ExportToXml(((DataStoreTreeList) this.treeList1).filename);
      }

      private void dataStoreDockPanel_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
      {
         if(e.Button == this.dataStoreDockPanel.CustomHeaderButtons[0]) // Add
         {
            return;
         }
         if(e.Button == this.dataStoreDockPanel.CustomHeaderButtons[1]) // Clone
         {
            return;
         }
         if(e.Button == this.dataStoreDockPanel.CustomHeaderButtons[2]) // Remove
         {
            return;
         }
         if(e.Button == this.dataStoreDockPanel.CustomHeaderButtons[3]) // Load
         {
            this.toastNotificationsManager1.ShowNotification(this.toastNotificationsManager1.Notifications[0]);
            return;
         }
         if(e.Button == this.dataStoreDockPanel.CustomHeaderButtons[4]) // Save
         {
            string caption = "This is a Caption";
            string text = "This is the text\nregion\nwith\n5 (five)\n lines in total";
            AlertInfo alertInfo = new AlertInfo(caption, text);
            {
               alertInfo.AutoCloseFormOnClick = true;
               alertInfo.HotTrackedText = "this is the hot tracked test";
               alertInfo.Tag = null;
            }
            this.alertControl1.Show(this, alertInfo);
            return;
         }
         return;
      }

      // --------------------------------------------------------------------------------------
      internal void createQueryBuilder(string connectionString, bool loadDefaultDatabaseOnly, bool loadSystemObjects, bool withFields)
      {
         this._qb = new QueryBuilder()
         {
            SyntaxProvider = new MSSQLSyntaxProvider(),
            MetadataProvider = new MSSQLMetadataProvider()
         };
         this._qb.MetadataProvider.Connection = new SqlConnection(connectionString);
         {
            MetadataLoadingOptions loadingOptions = this._qb.SQLContext.MetadataContainer.LoadingOptions;
            loadingOptions.LoadDefaultDatabaseOnly = loadDefaultDatabaseOnly;
            loadingOptions.LoadSystemObjects = loadSystemObjects;
            //loadingOptions.IncludeFilter.Types = MetadataType.Field;
            //loadingOptions.ExcludeFilter.Schemas.Add("dbo");
         }
         //qb.InitializeDatabaseSchemaTree();
         this._qb.MetadataContainer.LoadAll(withFields);
      } // createQueryBuilder(...)

        //
      internal void buildBindingList(bool loadDefaultDatabaseOnly, bool loadSystemObjects, bool withFields)
      {
         this._colQnBindingList = new BindingList<ColumnQN>();
         using(SQLContext sqlContext = new SQLContext())
         {
            sqlContext.Assign(this._qb.SQLContext);
            sqlContext.MetadataContainer.LoadingOptions.LoadDefaultDatabaseOnly = loadDefaultDatabaseOnly;
            sqlContext.MetadataContainer.LoadingOptions.LoadSystemObjects = loadSystemObjects;

            using(MetadataList xList = new MetadataList(sqlContext.MetadataContainer))
            {
               xList.Load(MetadataType.Server, false);
               foreach(MetadataItem srv in xList)
               {
               }
               xList.Load(MetadataType.Database, false);
               foreach(MetadataItem db in xList)
               {
                  using(MetadataList schemasList = new MetadataList(db))
                  {
                     schemasList.Load(MetadataType.Schema, false);
                     foreach(MetadataItem sch in schemasList)
                     {
                        using(MetadataList tablesList = new MetadataList(sch))
                        {
                           tablesList.Load(MetadataType.Table, false);
                           foreach(MetadataItem tbl in tablesList)
                           {
                              using(MetadataList columnsList = new MetadataList(tbl))
                              {
                                 columnsList.Load(MetadataType.Field, false);

                                 foreach(MetadataItem col in columnsList)
                                 {
                                    MetadataItem mdi = col;
                                    this.TreatField(mdi);
                                 }
                              }
                           }
                        }
                     }
                  }
               }
            }
         }
      } // buildBindingList(...)

      private void TreatField(MetadataItem mdi)
      {
         MetadataField mdf = mdi as MetadataField;
         if(mdf == null)
         {
            return;
         }
         //
         ColumnQN colQN = new ColumnQN();
         colQN.IsSystem = mdi.System;
         colQN.IsDefault = mdi.Default;
         colQN.ObjectType = Enum.GetName(typeof(MetadataType), mdi.Type);
         if(mdi.Parent != null)
         {
            colQN.ParentType = Enum.GetName(typeof(MetadataType), mdi.Parent.Type);
         }
         colQN.Remarks = mdf.Description;

         #region --- Server.Database.Schema.Object.Column Names ---
         if(mdf.Server != null)
         {
            MetadataNamespace srv = mdf.Server;
            colQN.ServerAltName = srv.AltName;
            colQN.ServerName = srv.Name;
            colQN.ServerNameFull = srv.NameFull;
            colQN.ServerNameQuoted = srv.NameQuoted;
         }
         if(mdf.Database != null)
         {
            MetadataNamespace database = mdf.Database;
            colQN.DatabaseAltName = database.AltName;
            colQN.DatabaseName = database.Name;
            colQN.DatabaseNameFull = database.NameFull;
            colQN.DatabaseNameQuoted = database.NameQuoted;
         }
         if(mdf.Schema != null)
         {
            MetadataNamespace schema = mdf.Schema;
            colQN.SchemaAltName = schema.AltName;
            colQN.SchemaName = schema.Name;
            colQN.SchemaNameFull = schema.NameFull;
            colQN.SchemaNameQuoted = schema.NameQuoted;
         }
         if(mdf.Object != null)
         {
            MetadataObject obj = mdf.Object;
            colQN.ParentAltName = obj.AltName;
            colQN.ParentName = obj.Name;
            colQN.ParentNameFull = obj.NameFull;
            colQN.ParentNameQuoted = obj.NameQuoted;
         }
         {
            colQN.AltName = mdf.AltName;
            colQN.Name = mdf.Name;
            colQN.NameFull = mdf.NameFull;
            colQN.NameQuoted = mdf.NameQuoted;
         }
         #endregion

         string idescription = mdi.Description;
         object itag = mdi.Tag;
         string iuserData = mdi.UserData;

         MetadataNamespace package = mdf.Package;
         //string writeXMLNode = WriteXMLNode(mdf);
         //
         {
            colQN.DatabaseTypeName = mdf.FieldTypeName;
            colQN.StorageTypeName = Enum.GetName(typeof(DbType), mdf.FieldType);
            colQN.Size = mdf.Size;
            colQN.Precision = mdf.Precision;
            colQN.Scale = mdf.Scale;
            colQN.IsPrimaryKey = mdf.PrimaryKey;
            colQN.IsNullable = mdf.Nullable;
            colQN.IsReadOnly = mdf.ReadOnly;
            {
               colQN.IsVirtual = mdf.IsVirtual();
               colQN.Expression = mdf.Expression;
            }
            //                string writeXMLNode = WriteXMLNode(mdf);
         }
         //
         //            colQN.Serialize(@"D:\TEMP\CS\QWERTY.XML");
         //
         this._colQnBindingList.Add(colQN);
      }

      // --------------------------------------------------------------------------------------
      private string fileName = "XtraGrid_SaveLayoutToXML.xml";

      private void gridView1_CalcPreviewText(object sender, DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventArgs e)
      {
         e.PreviewText = this.CalculateMyPreviewText(e.RowHandle);
      }

      private string CalculateMyPreviewText(int rowHandle)
      {
         if(rowHandle == int.MinValue || rowHandle == -2147483646)
         {
            return string.Empty;
         }

         int dataSourceRowIndex = this.gridView1.GetDataSourceRowIndex(rowHandle);
         BindingList<ColumnQN> dsList = this.gridView1.DataSource as BindingList<ColumnQN>;
         if(dsList == null)
         {
            return string.Empty;
         }

         ColumnQN col = dsList[rowHandle];
         if(string.IsNullOrEmpty(col.Remarks))
         {
            return $"{col}";
         }
         return col.Remarks;
      }

      private void gridView1_CustomDrawRowPreview(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
      {
         //GridView view = sender as GridView;
         //if (view == null) return;
         //int dx = 5;
         //// A rectangle for displaying text. 
         //Rectangle r = e.Bounds;
         //r.X += e.Bounds.Height + dx * 2;
         //r.Width -= (e.Bounds.Height + dx * 3);
         //// Draw an image from the "Photo" column. 
         //e.Graphics.DrawImage(
         //    DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray( (byte[])view.GetDataRow(e.RowHandle)["Photo"]),
         //    e.Bounds.X + dx,
         //    e.Bounds.Y,
         //    e.Bounds.Height,
         //    e.Bounds.Height
         //    );
         //// Draw the text. 
         //e.Appearance.DrawString(e.Cache, view.GetRowPreviewDisplayText(e.RowHandle), r);
         //// No default painting is required 
         //e.Handled = true;
      }

      private void changeTreeListColumnValue(object sender)
      {
         TreeList tl = sender as TreeList;
         TreeListNode tn = tl.FocusedNode; //.GetValue("Syntax"); // GetDisplayText(columnID2);
         ((DataStoreTreeList) this.treeList1).SelecteMetadataProvider(tn, this._qb);
      }

      private void treeList1_CellValueChanged(object sender, CellValueChangedEventArgs e)
      {
         this.changeTreeListColumnValue(sender);
      }
   }
}

/*
        //private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        //{
        //}
        //private void gridControl1_Click(object sender, System.EventArgs e)
        //{
        //}
        //private void gridControl1_Load(object sender, EventArgs e)
        //{
        //}
        //private void treeList1_NodeChanged(object sender, NodeChangedEventArgs e)
        //{
        //}
        //        private void treeList1_ValidateNode(object sender, ValidateNodeEventArgs e)
        //        {
        ////            changeTreeListColumnValue(sender);
        //        }


ActiveQueryBuilder.Core.AdvantageSyntaxProvider : BaseSyntaxProvider

public override string GetSyntaxProviderDescription()

protected override Type GetParserClass()
protected override Type GetScannerClass()

public override IdentCaseSensitivity IdentCaseSens
		
public override bool IsFixedSizeType(String type)
public override SyntaxSupportsConectedServer IsSupportConectedServer(BaseMetadataProvider metadataProvider)
public override string GetQueryToLoadFieldsForObject(string fieldName, string objectExpression)
public override void GetBuiltinFunctionNames(SQLQualifiedNameList names)
public override bool GetUseObjectNamesAsDefaultAliases()
public override bool IsSupportLimitOffset()
public override bool IsSupportLimitCount()
public override bool IsSupportDatabases()
public override bool IsSupportSchemas()
public override string GetQuoteEnd()
public override string GetQuoteBegin()
public override void GetComparisonOperators(IList<string> list)
public override void GetPrefixed1ParamAggregateNames(SQLQualifiedNameList names)
public override void Get1ParamAggregateNames(SQLQualifiedNameList names)
public override void GetStarAggregateNames(SQLQualifiedNameList names)

 */
