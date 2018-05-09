using System;
using System.Collections.Specialized;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.Xpo.DB;

namespace DashboardDeisgnerTEST
{
   public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public DesignerForm1()
      {
         this.InitializeComponent( );
         this.PostInitializeComponent( );
//         this.dashboardDesigner.ShowDataSourceWizard( );
         this.dashboardDesigner.LoadDashboard( @"..\..\Dashboards\dashboard1.xml" );
      }

      /*
      Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Register Default Data Connections
      
      To add a predefined data connection, register it in the
      application's configuration file by adding a corresponding
      connection string to the connectionStrings section. For instance,
      the following connection string allows end-users to establish
      a connection to the Northwind database deployed on a
      local MS SQL server (SQL Data Source).
      
      <connectionStrings>
      <add name="nwindConnection"
      connectionString="XpoProvider=MSSqlServer; data source=localhost; initial catalog=Northwind; integrated security=SSPI;" 
      />
      </connectionStrings>
      */
      private void PostInitializeComponent()
      {
         /*
         Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Register Default Data Connections
         
         By default, the Data Source wizard does not show this page.
         */
         this.dashboardDesigner.DataSourceWizard.ShowConnectionsFromAppConfig = true;
         /*
Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Dialogs and Wizards > Data Source Wizard > How to Customize the Data Source Wizard

Note that you can disable the creation of new connections in the Data Source Wizard using 
SqlWizardSettings.DisableNewConnections property. In this case, end-users can only select the
data connection specified in the application configuration file.

You can customize the list of available data providers using the SqlWizardSettings.AvailableDataProviders property.

Note that the Data Source Wizard and Query Builder do not allow end-users to specify SQL queries manually by default. To enable this capability, set the SqlWizardSettings.EnableCustomSql property to true.

Note that the Data Source Wizard and Query Builder do not allow end-users to specify SQL queries manually by default. To enable this capability, set the SqlWizardSettings.EnableCustomSql property to true.

Important
The use of custom SQL queries may lead to inadvertent or unauthorized modifications to your data/database structure. Make sure that you follow best practices and implement the appropriate end-user read/write privileges at the database level.

If necessary, you can supply users with the capability to choose a custom assembly providing a required data context. To do this, enable the EFWizardSettings.ShowBrowseButton flag to add the Browse button to this page. Then, handle the EFDataSource.BeforeLoadCustomAssemblyGlobal event to manage custom assembly loading.

Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Dialogs and Wizards > Query Builder
Reporting > Creating Reports in Visual Studio > Detailed Guide to Visual Studio Report Designer > Report Wizard > Query Builder
         */
         this.dashboardDesigner.DataSourceWizard.ShowDataSourceNamePage = true;
         this.dashboardDesigner.DataSourceWizard.SqlWizardSettings.DisableNewConnections = false;
         // this.dashboardDesigner.DataSourceWizard.SqlWizardSettings.AvailableDataProviders
         this.dashboardDesigner.DataSourceWizard.SqlWizardSettings.DatabaseCredentialsSavingBehavior = DevExpress.DataAccess.Wizard.SensitiveInfoSavingBehavior.Prompt;
         this.dashboardDesigner.DataSourceWizard.SqlWizardSettings.EnableCustomSql = true;
         //this.dashboardDesigner.DataSourceWizard.EFWizardSettings.ShowBrowseButton = true;
         this.dashboardDesigner.DataSourceWizard.SqlWizardSettings.QueryBuilderDiagramView = true;
         this.dashboardDesigner.DataSourceWizard.SqlWizardSettings.QueryBuilderLight = false;
         this.dashboardDesigner.ConfigureDataConnection += this.DashboardDesigner_ConfigureDataConnection;

         /*
Dashboard > Examples > WinForms Designer - Examples > How to: Customize a Data Store Schema for SQL Data Sources
         */
         // this.dashboardDesigner.CustomDBSchemaProviderEx = new CustomDBSchemaProvider( );

         /*
Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Manage Printing and Exporting Capabilities

The WinForms Designer provides end-users with the capability
to print or export an entire dashboard and individual items.
You can also use an API to perform the export, customize
printing/exporting settings, etc.

API  Description

[DashboardDesigner.AllowPrintDashboard] - Gets or sets whether end-users can print or export a dashboard. 
[DashboardDesigner.AllowPrintDashboardItems] - Gets or sets whether end-users can print or export dashboard items. 
[DashboardDesigner.PrintPreviewOptions] - Provides access to options related to printing a dashboard/dashboard item. 
[DashboardDesigner.PdfExportOptions] - Provides access to options related to exporting a dashboard/dashboard item to the PDF format. 
[DashboardDesigner.ImageExportOptions] - Provides access to options related to exporting a dashboard/dashboard item to an image. 
[DashboardDesigner.ExcelExportOptions] - Provides access to options related to exporting a dashboard item to the Excel format. 
[DashboardDesigner.PrintPreviewType] - Gets or sets the type of Print Preview used to preview dashboard items or the entire dashboard. 
[DashboardDesigner.ShowPrintPreview] - Invokes the Print Preview, which shows the print preview of the dashboard. 
[DashboardDesigner.ShowRibbonPrintPreview] - Invokes the Ribbon Print Preview Form, which shows the print preview of the dashboard. 
[DashboardDesigner.ShowExportDashboardDialog] - Invokes the dialog that allows end-users to export the entire dashboard to the specified format. 
[DashboardDesigner.ShowExportDashboardItemDialog] - Invokes the dialog that allows end-users to export the dashboard item to the specified format. 
[DashboardDesigner.PrintPreviewShowing] - Allows you to customize the Print Preview window at runtime. 
[DashboardDesigner.ExportToPdf] - Exports a dashboard to the specified file in PDF format using the specified PDF-specific options. 
[DashboardDesigner.ExportToImage] - Exports a dashboard to the specified file in Image format. 
[DashboardDesigner.ExportToExcel] - Exports dashboard data to the specified stream in Excel format. 
[DashboardDesigner.ExportDashboardItemToPdf] - Exports the dashboard item to the specified stream in PDF format using the specified PDF-specific options. 
[DashboardDesigner.ExportDashboardItemToImage] - Exports the dashboard item to the specified stream in Image format. 
[DashboardDesigner.ExportDashboardItemToExcel] - Exports the dashboard item to the specified stream in Excel format. 
[DashboardDesigner.ExportFormShowing] - Occurs when the Export Form is about to be displayed, and allows you to cancel the action. 
[DashboardDesigner.BeforeExportDocument] - Allows you to hide specific dashboard items when printing or exporting the entire dashboard. 
[DashboardDesigner.CustomExport] - Allows you to customize the exported document. 
         */
         this.dashboardDesigner.AllowPrintDashboard = true;
         this.dashboardDesigner.AllowPrintDashboardItems = true;
         // this.dashboardDesigner.PrintPreviewOptions
         //this.dashboardDesigner.PdfExportOptions
         //this.dashboardDesigner.ImageExportOptions
         //this.dashboardDesigner.ExcelExportOptions
         //this.dashboardDesigner.PrintPreviewType = DevExpress.DashboardWin.DashboardPrintPreviewType.StandardPreview;
         //this.dashboardDesigner.ShowPrintPreview();
         //this.dashboardDesigner.ShowRibbonPrintPreview();
         //this.dashboardDesigner.ShowExportDashboardDialog(DevExpress.DashboardCommon.DashboardExportFormat.Excel);
         //this.dashboardDesigner.ShowExportDashboardItemDialog("", DevExpress.DashboardCommon.DashboardExportFormat.Excel);
         this.dashboardDesigner.PrintPreviewShowing += this.DashboardDesigner_PrintPreviewShowing;
         //this.dashboardDesigner.ExportToPdf();
         //this.dashboardDesigner.ExportToImage();
         //this.dashboardDesigner.ExportToExcel();
         //this.dashboardDesigner.ExportDashboardItemToPdf();
         //this.dashboardDesigner.ExportDashboardItemToImage();
         //this.dashboardDesigner.ExportDashboardItemToExcel();
         this.dashboardDesigner.ExportFormShowing += this.DashboardDesigner_ExportFormShowing;
         this.dashboardDesigner.BeforeExportDocument += this.DashboardDesigner_BeforeExportDocument;
         //
         /*
Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Security Considerations
Dashboard > DevExpress.DashboardWin > DashboardDesigner > ConfigureDataConnection

The ConfigureDataConnection event is raised before the connection to a data store is established and allows you to customize connection settings. This event is raised when the dashboard is supplied with data using one of the following data source types:

- DashboardSqlDataSource 
- DashboardOlapDataSource 
- DashboardExcelDataSource 
- DashboardExtractDataSource

If the dashboard is supplied with data using the DashboardObjectDataSource data source, the DataLoading event is fired instead.

This dialog allows end-users to select whether to trust the object data sources available in the application. You can change this default logic using the DataSourceOptionsContainer.ObjectDataSourceLoadingBehavior property. For instance, you can allow loading any object data sources, or you can load object data sources in a safe mode when their data member and data source settings are cleared. To obtain the DataSourceOptionsContainer object (that exposes DataSourceOptionsContainer.ObjectDataSourceLoadingBehavior), use the DataSourceOptions properties exposed by the DashboardDesigner and DashboardViewer controls.

You can also provide a custom data source validation by handling the ObjectDataSource.BeforeFill event for the specified data source. The corresponding static ObjectDataSource.BeforeFillGlobal event allows you to validate all object data sources in your application.


         */
         this.dashboardDesigner.CustomExport += this.DashboardDesigner_CustomExport;
         this.dashboardDesigner.DataLoading += this.DashboardDesigner_DataLoading;
         this.dashboardDesigner.CustomAssemblyLoading += this.DashboardDesigner_CustomAssemblyLoading;
         this.dashboardDesigner.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.Prompt;
         //
         /*
Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Ribbon, Bars and Menu > Ribbon UI
Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Ribbon, Bars and Menu > Toolbar UI
Dashboard > Building the Designer and Viewer Applications > WinForms Designer > Ribbon, Bars and Menu > Popup Menus
         */
         //RibbonControl ribbon = this.dashboardDesigner.MenuManager as RibbonControl;
         //BarManager barManager = this.dashboardDesigner.MenuManager as BarManager;
         this.dashboardDesigner.PopupMenuShowing += this.DashboardDesigner_PopupMenuShowing;

         //
         {
            /*
Dashboard > Creating Dashboards > Creating Dashboards in the WinForms Designer > Providing Data > Extract Data Source > Creating Data Extracts
            */
            // DashboardSqlDataSource sqlDataSource = new DashboardSqlDataSource( "Data Source 1", msSqlParams );
            // SelectQuery selectQuery = SelectQueryFluentBuilder
            //     .AddTable( "SalesPerson" )
            //     .SelectColumns( "CategoryName", "Extended Price" )
            //     .Build( "Query 1" );
            // sqlDataSource.Queries.Add( selectQuery );

            // // ... 

            // DashboardExtractDataSource extractDataSource = new DashboardExtractDataSource( );
            // extractDataSource.ExtractSourceOptions.DataSource = sqlDataSource;
            // extractDataSource.ExtractSourceOptions.DataMember = "Query 1";
            // extractDataSource.FileName = @"C:\temp\SalesPersonExtract.dat";
            // extractDataSource.UpdateExtractFile( );

            //this.dashboardDesigner.DataSources.Add( extractDataSource );
         }
         {
            /*
Dashboard > Creating Dashboards > Creating Dashboards in the WinForms Designer > Providing Data > Calculated Fields
            */
            //CalculatedField priceWithDiscount = new CalculatedField( "[UnitPrice] * (1 - [Discount])" );
            //priceWithDiscount.DataMember = "SalesPerson";
            //priceWithDiscount.Name = "Price with discount";
            //sqlDataSource.CalculatedFields.Add( priceWithDiscount );
         }
         {
            /*
Dashboard > Creating Dashboards > Creating Dashboards in the WinForms Designer > Adding Dashboard Items
            */
         }
         //
      }

      private void DashboardDesigner_CustomAssemblyLoading( object sender, DevExpress.DashboardCommon.DashboardCustomAssemblyLoadingEventArgs e )
      {
      }

      private void DashboardDesigner_DataLoading( object sender, DevExpress.DashboardCommon.DataLoadingEventArgs e )
      {
      }

      private void DashboardDesigner_ConfigureDataConnection( object sender, DevExpress.DashboardCommon.DashboardConfigureDataConnectionEventArgs e )
      {
         // Checks the name of the connection for which the event has been raised. 
         if( e.DataSourceName == "SQL Data Source 1" )
         {

            // Gets the connection parameters used to establish a connection to the database. 
            Access97ConnectionParameters parameters =
                (Access97ConnectionParameters) e.ConnectionParameters;

            // Specifies the user name used to access the database file.  
            parameters.UserName = "Admin";

            // Specifies the password used to access the database file. 
            parameters.Password = "password";
         }
      }

      private void DashboardDesigner_PrintPreviewShowing( object sender, DevExpress.DashboardWin.PrintPreviewShowingEventArgs e )
      {
      }

      private void DashboardDesigner_ExportFormShowing( object sender, DevExpress.DashboardWin.DashboardExportFormShowingEventArgs e )
      {
      }

      private void DashboardDesigner_BeforeExportDocument( object sender, DevExpress.DashboardCommon.BeforeExportDocumentEventArgs e )
      {
      }

      private void DashboardDesigner_CustomExport( object sender, DevExpress.DashboardCommon.CustomExportEventArgs e )
      {
      }

      private void DashboardDesigner_PopupMenuShowing( object sender, DevExpress.DashboardWin.DashboardPopupMenuShowingEventArgs e )
      {
      }

      #region --- CustomDBSchemaProvider : IDBSchemaProviderEx ---
      // Creates a new class that defines a custom data store schema by implementing the  
      // IDBSchemaProvider interface. 
      public class CustomDBSchemaProvider : IDBSchemaProviderEx
      {
         DBTable[ ] tables;
         public void LoadColumns( SqlDataConnection connection, params DBTable[ ] tables )
         {
            foreach( DBTable table in tables )
            {
               if( table.Name == "Categories" && table.Columns.Count == 0 )
               {
                  DBColumn categoryIdColumn = new DBColumn { Name = "CategoryID" };
                  table.AddColumn( categoryIdColumn );
                  DBColumn categoryNameColumn = new DBColumn { Name = "CategoryName" };
                  table.AddColumn( categoryNameColumn );
               }
               if( table.Name == "Products" && table.Columns.Count == 0 )
               {
                  DBColumn categoryIdColumn = new DBColumn { Name = "CategoryID" };
                  table.AddColumn( categoryIdColumn );
                  DBColumn productNameColumn = new DBColumn { Name = "ProductName" };
                  table.AddColumn( productNameColumn );

                  DBForeignKey foreignKey = new DBForeignKey(
                      new[ ] { categoryIdColumn },
                      "Categories",
                      CustomDBSchemaProvider.CreatePrimaryKeys( "CategoryID" ) );
                  table.ForeignKeys.Add( foreignKey );
               }
            }
         }

         public static StringCollection CreatePrimaryKeys( params string[ ] names )
         {
            StringCollection collection = new StringCollection( );
            collection.AddRange( names );
            return collection;
         }

         public DBTable[ ] GetTables( SqlDataConnection connection, params string[ ] tableList )
         {
            var cp = connection.ConnectionParameters as Access97ConnectionParameters;
            if( cp != null && cp.FileName == @"..\..\Data\nwind.mdb" )
            {
               if( this.tables != null )
               {
                  return this.tables;
               }
               this.tables = new DBTable[ 2 ];

               DBTable categoriesTable = new DBTable( "Categories" );
               this.tables[ 0 ] = categoriesTable;

               DBTable productsTable = new DBTable( "Products" );
               this.tables[ 1 ] = productsTable;
            }
            else
               this.tables = new DBTable[ 0 ];
            return this.tables;
         }

         public DBTable[ ] GetViews( SqlDataConnection connection, params string[ ] viewList )
         {
            DBTable[ ] views = new DBTable[ 0 ];
            return views;
         }

         public DBStoredProcedure[ ] GetProcedures( SqlDataConnection connection, params string[ ] procedureList )
         {
            DBStoredProcedure[ ] storedProcedures = new DBStoredProcedure[ 0 ];
            return storedProcedures;
         }
      }
      #endregion

   }
}
