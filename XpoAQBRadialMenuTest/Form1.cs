using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyRibbonBarTest
{
   public partial class Form1 : Form
   {
      //        internal QueryBuilder qb;

      public Form1()
      {
         this.InitializeComponent();
      }

      public Form1(string connectionString, string filename, bool loadDefaultDatabaseOnly, bool loadSystemObjects, bool withFields)
      {
         this.InitializeComponent();
         //            qb = createQueryBuilder(connectionString, loadDefaultDatabaseOnly, loadSystemObjects, withFields);
         //            BindingList<ColumnQN> colQnBindingList = buildBindingList(qb, loadDefaultDatabaseOnly, loadSystemObjects, withFields);
         this.createQueryBuilder(connectionString, loadDefaultDatabaseOnly, loadSystemObjects, withFields);
         this.buildBindingList(loadDefaultDatabaseOnly, loadSystemObjects, withFields);

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
      internal QueryBuilder _qb;
      internal BindingList<ColumnQN> _colQnBindingList;

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

      private void Form1_Load(object sender, EventArgs e)
      {
         //gridControl1.ForceInitialize();
         //// Restore the previously saved layout 
         //if (File.Exists(fileName))
         //{
         //    gridControl1.MainView.RestoreLayoutFromXml(fileName);
         //}
      }

      private void Form1_FormClosed(object sender, FormClosedEventArgs e)
      {
         //            serializeQueryBuilder("C:\\temp\\MetadataContainer_FormClosed.xml");
      }

      private void Form1_FormClosing(object sender, FormClosingEventArgs e)
      {
         // serializeQueryBuilder("C:\\temp\\MetadataContainer_FormClosing.xml");
         // Save the layout to an XML file 
         //gridControl1.MainView.SaveLayoutToXml(fileName);
      }

      private void gridControl1_Click(object sender, System.EventArgs e)
      {
      }

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

      private void gridControl1_Load(object sender, EventArgs e)
      {
      }
   }
}

/*
        internal QueryBuilder createQueryBuilder(string connectionString, bool loadDefaultDatabaseOnly, bool loadSystemObjects, bool withFields)
        {
            QueryBuilder qb = new QueryBuilder()
            {
                SyntaxProvider = new MSSQLSyntaxProvider(),
                MetadataProvider = new MSSQLMetadataProvider()
            };
            qb.MetadataProvider.Connection = new SqlConnection(connectionString);
            {
                MetadataLoadingOptions loadingOptions = qb.SQLContext.MetadataContainer.LoadingOptions;
                loadingOptions.LoadDefaultDatabaseOnly = loadDefaultDatabaseOnly;
                loadingOptions.LoadSystemObjects = loadSystemObjects;
                //loadingOptions.IncludeFilter.Types = MetadataType.Field;
                //loadingOptions.ExcludeFilter.Schemas.Add("dbo");
            }
            //qb.InitializeDatabaseSchemaTree();
            qb.MetadataContainer.LoadAll(withFields);
            return qb;
        } // createQueryBuilder(...)
        //
        internal BindingList<ColumnQN> buildBindingList(QueryBuilder qb, bool loadDefaultDatabaseOnly, bool loadSystemObjects, bool withFields)
        {
            BindingList<ColumnQN> listDataSource = new BindingList<ColumnQN>();
            using (var sqlContext = new SQLContext())
            {
                sqlContext.Assign(qb.SQLContext);
                sqlContext.MetadataContainer.LoadingOptions.LoadDefaultDatabaseOnly = loadDefaultDatabaseOnly;
                sqlContext.MetadataContainer.LoadingOptions.LoadSystemObjects = loadSystemObjects;

                using (var databasesList = new MetadataList(sqlContext.MetadataContainer))
                {
                    databasesList.Load(MetadataType.Database, false);
                    foreach (var db in databasesList)
                    {
                        using (var schemasList = new MetadataList(db))
                        {
                            schemasList.Load(MetadataType.Schema, false);
                            foreach (var sch in schemasList)
                            {
                                using (var tablesList = new MetadataList(sch))
                                {
                                    tablesList.Load(MetadataType.Table, false);
                                    foreach (var tbl in tablesList)
                                    {
                                        using (var columnsList = new MetadataList(tbl))
                                        {
                                            columnsList.Load(MetadataType.Field, false);
                                            foreach (var col in columnsList)
                                            {
                                                var colQN = new ColumnQN(db.Name, sch.Name, tbl.Name, col.Name);
                                                listDataSource.Add(colQN);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return listDataSource;
        } // buildBindingList(...)
        //
        internal void serializeQueryBuilder(string filename)
        {
            {
                string xML = qb.MetadataContainer.XML;
            }
            {
                qb.MetadataContainer.ExportToXML(filename);
            }
            {
                qb.MetadataContainer.ImportFromXML(filename);
            }
        }

 */
