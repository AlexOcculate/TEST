[TOC]

------
------
------

# How to use DevExpress controls UI in AQB 2 WinForms Edition?

To use DevExpress controls, you should add a reference to the ActiveQueryBuilder.DevExpressControlFactory.dll file to your project, or you can put this assembly next to your executable file. In the Main() function of your application, before any form creation, set up the DevExpress usage and turn on the **QueryBuilder.UseDevExpressControls** static property:

```C#
      DevExpress.Skins.SkinManager.EnableFormSkins();
      ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder.UseDevExpressControls = true;
```

Additionally, you can define the **QueryBuilder.OverrideDevExpressThemeColors** static property to True to use colors settings of the component instead of using colors from the current DevExpress theme.

Working with Visual Basic, you should use the **My.Application.Startup** event.

Your project must refer to the following assemblies:

-  **DevExpress.Data.* **


-  **DevExpress.Utils.* **
-  **DevExpress.XtraEditors.* **
-  **DevExpress.XtraGrid.* **


-  **DevExpress.XtraTreeList.* **

and the following DLL:

-  **ActiveDatabaseSoftware.DevExpressControlFactory2.dll**.

If you have the "*Failed to call GetCustomTreeView() method from DevExpressControlFactory*" error, please check the following:

1. Make sure that you have the same DevExpress controls version as referred by the DevExpressControlFactory assembly. We strive to refer to the latest DevExpress version, but there could be a small gap between the latest and the referred version. If you have a newer version of DevExpress controls, you can override version binding as described in this article: [How to configure assembly binding redirection?](https://support.activequerybuilder.com/hc/en-us/articles/115001835825-How-to-configure-assembly-binding-redirection-)
2. If you refer to the same version of DevExpress assemblies, but still have this problem, please set the "Copy Local" property of referred DevExpress and Active Query Builder assemblies to True.
   Note that the Professional .NET Subscription is shipped with the source code of DevExpress controls factory assembly, even if you didn't purchase the Full Source Code option, so you can recompile it with any DevExpress controls version that you have, considering that no changes were made in the DevExpress controls API since that time.

------
#How to configure assembly binding redirection?

> I am getting the following error:
> "Could not load file or assembly 'xxx' or one of its dependencies. The located assembly's manifest definition does not match the assembly reference."
> Do I have to use that specific version?
> I would like to use a new version!

To use any other version of dependent assembly you must override the version binding using the following `app.config` file (add it to your project):

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="VistaDB.NET20"
          publicKeyToken="dfc935afe2125461"
          culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-65535.65535.65535.65535" newVersion="3.3.1.52" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
```

Change the name, publicKeyToken and newVersion attributes to the required values.

More information can be found in the following MSDN articles:

-  [Configuring Assembly Binding Redirection](http://msdn.microsoft.com/en-us/library/433ysdt1(v=vs.80).aspx),
-  [assemblyIdentity Element for runtime](https://msdn.microsoft.com/en-us/library/b0yt6ck0(v=vs.110).aspx).

P.S. Look in inside the `DevExpressGeneralDemo.csproj`:

```xml
...
<Reference Include="ActiveQueryBuilder.View.WinForms.DevExpress, Version=3.1.0.1014, Culture=neutral, PublicKeyToken=3cbcbcc9bf57ecde, processorArchitecture=MSIL">
      <SpecificVersion>False</SpecificVersion>
    </Reference>
    <Reference Include="DevExpress.Utils.v17.1, Version=17.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a, processorArchitecture=MSIL" />
...
```

And put inside the `app.config`, for example from Or from **DevExpress.Uitil.v17.1 Version=17.1.0.0.** to **Version=17.1.6.0**

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <startup>
    <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/>
    <supportedRuntime version="v4.5" sku=".NETFramework,Version=v4.5"/>
  </startup>

  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="DevExpress.Utils.v17.1"
          publicKeyToken="b88d1754d700e49a"
          culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-65535.65535.65535.65535" newVersion="17.1.6.0" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>

</configuration>
```
Or from **System.Data.SQLite Version=1.0.104.0** to **Version=1.0.108.0**

```c#
System.Data.SQLite, Version=1.0.104.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139
```

to

```c#
System.Data.SQLite, Version=1.0.108.0
```



```xml
   <runtime>
      <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
         <dependentAssembly>
            <assemblyIdentity name="System.Data.SQLite"
              publicKeyToken="db937bc2d44ff139"
              culture="neutral" />
            <bindingRedirect oldVersion="0.0.0.0-65535.65535.65535.65535" newVersion="1.0.108.0" />
         </dependentAssembly>
      </assemblyBinding>
   </runtime>

```



------
------

# Getting started with AQB.NET 3 WinForms and WPF Editions

There are two ways to embed the third version of Active Query Builder into your project.

-  The first way is suitable for most use cases and *available in both the Standard and Professional subscriptions*. This way is described below.
-  The second way provides greater freedom in organizing the user interface. It is *available in the Professional subscription only*. It lets re-organize the controls inside the QueryBuilder object in a non-standard way. For example, to place the Design Area and the Query Column List on separate tabs, to place the Database Schema Tree on a different form, etc. You can read about it [here](https://support.activequerybuilder.com/hc/en-us/articles/115001055349-Getting-started-with-AQB-NET-3-in-the-Separated-Controls-UI-or-Non-visual-mode).

There are two or three components you need to use to get started with Active Query Builder: a *syntax provider* that suits your database server, a *metadata provider* that suits your DB connection and the *QueryBuilder component* that encapsulates all visual controls in a single visual control and has everything that user needs to build a query.

![Active Query Builder 3 architecture - standard mode](https://support.activequerybuilder.com/hc/article_attachments/115002227965/aqb-architecture-standard.png)

-  **QueryBuilder **is a main visual component. It unites all visual controls along with SQL query building logic controllers, SQL query object model, SQL parsing and generation functionality in a single object.
-  **Metadata Provider** is a non-visual object to get connected to the database and extract the needed information about database schema. There are special metadata providers for various .NET DB providers. This object is only needed if you work with the live database connection.
-  **Syntax Provider** is a non-visual object that determines syntax rules to build correct queries for different SQL dialects. There are lots of supported SQL syntaxes for most popular database servers today, as well as for generic ANSI-compatible SQL language. *This object is necessary.*

You can read more about Metadata and Syntax Providers [here](https://support.activequerybuilder.com/hc/en-us/articles/115001063445-What-are-the-Syntax-and-Metadata-providers-for-).

Follow the steps below to add Active Query Builder to your application.

1. Place the QueryBuilder component on the form.

   ```C#
   using ActiveQueryBuilder.Core;
   using ActiveQueryBuilder.View.WPF; // or ActiveQueryBuilder.View.WinForms for WinForms Edition
   // ...

   var queryBuilder1 = new QueryBuilder();
   ```

2. Put the needed metadata and syntax provider components on the form or create them by code. Define a proper database connection object for the metadata provider.

   ```C#
   var connection = new OleDbConnection();
   connection.ConnectionString = "<your connection string here>";

   var metadataProvider = new OLEDBMetadataProvider();
   metadataProvider.Connection = connection;

   var syntaxProvider = new GenericSyntaxProvider();
   ```

   Connection string examples can be found [here](http://www.connectionstrings.com/).

3. Link the components above to the QueryBuilder by setting MetadataProvider and SyntaxProvider properties

   ```C#
   queryBuilder1.MetadataProvider = metadataProvider;
   queryBuilder1.SyntaxProvider = syntaxProvider;
   ```

4. Add SQLTextEditor, TextBox, or any other text editing control to a form if you want to allow for direct SQL text editing by end-users.

5. Establish a connection between the QueryBuilder and the TextBox components.
   Set the following code for the Validate event of TextBox control:

   ```C#
   private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
   {
       try
       {

           // Update the query builder with manually edited query text:
           queryBuilder1.SQL = textBox1.Text;

       }
       catch (SQLParsingException ex)
       {
           e.Cancel = true;

           // Set caret to error position
           textBox1.SelectionStart = ex.ErrorPos.pos;

           // Report error
           MessageBox.Show(ex.Message, "Parsing error");
       }
   }
   ```

   Add the following handler for the QueryBuilder.SQLUpdated event:

   ```C#
   textBox1.Text = queryBuilder1.FormattedSQL;
   ```

6. Call the following method to activate Active Query Builder's database schema tree:

   ​

   ```C#
   queryBuilder1.InitiaClizeDatabaseSchemaTree();
   ```

7. That's all! Now you can run your application.

What to read next?

-  [Learn how to work with Active Query Builder in non-visual mode or to split the component's UI to separate visual controls](https://support.activequerybuilder.com/hc/en-us/articles/115001055349-Getting-started-with-AQB-NET-3-in-the-Separated-Controls-UI-or-Non-visual-mode).
-  [Learn more about Metadata and Syntax providers and how to choose the right one](https://support.activequerybuilder.com/hc/en-us/articles/115001063445-What-are-the-Syntax-and-Metadata-providers-for-).
-  [Learn how to save the query and load it back to the query builder](https://support.activequerybuilder.com/hc/en-us/articles/115001063465).

------

# Getting started with AQB.NET 3 in the Separated Controls UI or Non-visual mode

This article describes the advanced way of setting up the component. It is more complex but provides more freedom in organizing the user interface. *It is available in the Professional subscription only.*

We recommend you to get started with [the simple Quick Start Guide for AQB.NET 3](https://support.activequerybuilder.com/hc/en-us/articles/115001055329-Getting-started-with-AQB-NET-3-WinForms-and-WPF-Editions) before reading this article. This article provides more details about the architecture of Active Query Builder 3.

### The internal query objects structure

After Active Query Builder parses a query, it becomes available for the programmer in two ways: low-level representation in the form of tokens tree. (We call this level "AST": abstract syntax tree. The high-level object structure consists of sub-queries, datasources, output query columns, etc. The high-level object structure internally holds the low-level representation. The object form is available via the SQLQuery.**QueryRoot** reference.

The high-level query object form is a tree-like structure of sub-queries (unions, derived tables, common table expressions). It starts with the **Query** object of SubQuery class that has the SubQueries indexed property holding nested sub-queries. A **SubQuery** may consist of several SELECT statements joined with the UNION, EXCEPT or INTERSECT keywords. Thus the SubQuery class is a collection of single SELECT queries, containing at least one item. The **UnionSubQuery** object represents a single SELECT query.

### The non-visual components

The **SQLQuery **object is a query building logic controller that provides the necessary means to operate with the query objects, and that's the object to which visual controls refer to perform manipulations with query objects. The internal query objects structure can be accessed via the SQLQuery.**QueryRoot **property.

The SQLQuery object must be created in a context of specific SQL syntax rules and connection to a database. The **SQLContext** object is responsible for holding the definition of these things. It refers to metadata and syntax providers and contains the **MetadataContainer** and **MetadataStructure** objects to store information about database schema, and it's visual presentation in a tree-like form.

### The visual controls

The Active Query Builder user interface has the **QueryNavigationBar **control to deal with the tree-like structure of sub-queries. Visual controls for editing of single SELECT query parts, such as the **DesignPaneControl **and the **QueryColumnsListControl**, must be placed inside the **QueryView **panel that holds a reference to the currently active union sub-query (QueryView.**ActiveUnionSubQuery**). The Query Navigation Bar refers to the QueryView object to change the currently visible sub-query.

This diagram can help you to find the needed objects to work with Active Query Builder in non-visual mode, or to build the custom combination of visual controls, or may be to create your visual controls to deal with specific parts of the query and add them to Active Query Builder UI.

![Architecture of Active Query Builder 3 - separated controls mode](https://support.activequerybuilder.com/hc/article_attachments/115002227925/aqb-architecture-separated-controls.png) 

Below is the source code of initialization of Active Query Builder components that will help you to link them with each other.

```C#
// Non-visual objects
_sqlContext = new SQLContext
{
    SyntaxProvider = new MSSQLSyntaxProvider {ServerVersion = MSSQLServerVersion.MSSQL2012},
    MetadataProvider = new OLEDBMetadataProvider 
    {
        Connection = new OleDbConnection() {ConnectionString = ""}
    }
};

_sqlQuery = new SQLQuery(_sqlContext);

// Visual controls
queryView1.Query = _sqlQuery;

navBar1.Query = _sqlQuery;
navBar1.QueryView = queryView1;

databaseSchemaView1.SQLContext = _sqlContext;
databaseSchemaView1.QueryView = queryView1;

// Linking visual query builder with text editor
sqlTextEditor.QueryProvider = _sqlQuery;
_sqlQuery.SQLUpdated += sqlQuery_SQLUpdated;

// Initialization
databaseSchemaView1.InitializeDatabaseSchemaTree();
_sqlQuery.SQL = "SELECT * FROM dbo.Customers";
```

 

### Customizable layout of user interface controls

The **Dock Manager** control lets hold any controls to the left, right or beneath its workspace as hideable panels.

The code samples of the programmatic addition of sidebar panels to the DockManager control can be found here: [WinForms](https://support.activequerybuilder.com/hc/en-us/articles/115001063625-WinForms-Using-the-Dock-Manager-to-setup-layout-of-the-query-building-area), [WPF](https://support.activequerybuilder.com/hc/en-us/articles/115001063645-WPF-Using-the-Dock-Manager-to-setup-layout-of-the-query-building-area).

### Learn more

-  [**How to get formatted SQL text and setup formatting options?**](https://support.activequerybuilder.com/hc/en-us/articles/115001063385-How-to-get-formatted-SQL-text-and-setup-formatting-options-)

------

# What are the Syntax and Metadata providers for?

The **`QueryBuilder`** component has **`SyntaxProvider`** and **`MetadataProvider`** properties. They must be set to the instances of appropriate objects to work properly. This article describes the purpose of these objects.

**Syntax Providers** define the rules of *SQL query parsing and generation* for a particular database server. It also determines the *queries to retrieve metadata from a particular database server using system tables*. <u>The component cannot work without a syntax provider.</u> Also, there are few *generic syntax providers* for different **ANSI SQL standards** that can be used with any database server that's compatible with the appropriate standard.

You can use the **`AutoSyntaxProvider`** if you don't know to which database server the user will be connected. This syntax provider will send a series of server specific queries to detect the underlying database server. After successful detection it will act as *appropriate database server syntax provider*; otherwise, it will act as *Universal syntax provider*.

The **`GenericSyntaxProvider`** is recommended to work with *those database servers only for which Active Query Builder does not have an exclusive syntax provider*. The Generic syntax provider supports only *ANSI SQL/92 syntax* and additionally implements the way to retrieve metadata from all the supported database servers. It was originally made for the Free Edition of Active Query Builder which lacks the support of today database server SQL syntax extensions.

**Metadata Providers** are intended to link Active Query Builder to specific data access components. Their primary task is to execute the *metadata retrieval queries* sent by the component. The Metadata provider does not create database connectivity objects, but an instance of appropriate database connection object should be assigned to the **`Connection` property** of the metadata provider.

The *OLE DB, ODBC, and some other metadata providers* also can retrieve metadata information using the **`GetSchema`** or other methods of appropriate data access components. *If Active Query Builder fails to load metadata using the **server-specific queries**, it tries to load this information using **metadata provider** .*

*Universal metadata provider* is suitable for all types of database connections as it accepts **`System.Data.Common.DbConnection`** object which is a common ancestor of all .NET DB connections, but this provider not always the best choice as it lacks the support for specific DB connection ways to retrieve metadata. I recommend you to use it only if there's no specific metadata provider for your DB connection.

The **`EventMetadataProvider`** provides the way to get connected to DB connections that aren't inherited from the **`DbConnection`** object. It might be suitable for a *three-tier connection or a web service*.

The component can work without a metadata provider. In this case, it will not be able to execute the metadata retrieval queries. Thus this information must be loaded in some other ways and the **`QueryBuilder.OfflineMode`** property should be set to `True` to avoid run-time exceptions.

Below is the list of supported **`DbConnection`** namespaces and appropriate metadata providers for **Active Query Builder for .NET**.

| **Namespace**                       | **Metadata Provider**        |
| ----------------------------------- | ---------------------------- |
| System.Data.Common                  | UniversalMetadataProvider    |
| System.Data.OleDb                   | OLEDBMetadataProvider        |
| System.Data.Odbc                    | ODBCMetadataProvider         |
| System.Data.SqlClient               | MSSQLMetadataProvider        |
| System.Data.SqlServerCe             | MSSQLCEMetadataProvider      |
| System.Data.OracleClient (obsolete) | OracleMetadataProvider       |
| Oracle.ManagedDataAccess            | OracleNativeMetadataProvider |
| MySql.Data                          | MySQLMetadataProvider        |
| Npgsql                              | PostgreSQLMetadataProvider   |
| FirebirdSql.Data.FirebirdClient     | FirebirdMetadataProvider     |
| iAnywhere.Data.SQLAnywhere          | SybaseMetadataProvider       |
| IBM.Data.Informix                   | InformixMetadataProvider     |
| IBM.Data.DB2                        | DB2MetadataProvider          |
| Advantage.Data.Provider             | AdvantageMetadataProvider    |
| VistaDB.5.NET40                     | VistaDB5MetadataProvider     |
| -                                   | EventMetadataProvider        |

------

# Database server autodetection (SQL syntax)

Use the **`AutoSyntaxProvider`** to detect database syntax automatically. The **`AutoSyntaxProvider`** detects database server using a live database connection, by sending server-specific queries and analysing the result. It is not possible to find out for what database server a particular query has been written.

By setting the **`AutoSyntaxProvider`** object as a syntax provider for the query builder component, it detects the SQL syntax on retrieving metadata from a database.

You do not have to change the syntax provider after detection. **`AutoSyntaxProvider`** will act as particular syntax provider which has been detected. You can get the result of this detection by examining the **`DetectedSyntaxProvider`** property.

To detect a database syntax without the metadata retrieval, use the following code:

```C#
autoSyntaxProvider1.DetectSyntaxProvider(queryBuilder1.SQLContext);
```

For the ActiveX Edition, use the `SQLSyntax = xsAuto` setting and examine the **`UsedSQLSyntax`** property afterward.

------

# Getting common information about the query (used objects, fields)

Database objects usage and other information about the currently loaded SQL query are instantly available through the **QueryBuilder.QueryStatistics** set of collections.

1. Used database objects: QueryBuilder.QueryStatistics.**UsedDatabaseObjects** collection.

   Each item of this collection has a link to the MetadataObject object to retrieve detailed information about this database object. Please note that this link might be set to null if such object can not be found in the Metadata Container.

2. Used database object fields: QueryBuilder.QueryStatistics.**UsedDatabaseObjectColumns** collection.

   Each item of this collection has a name and type of the field. It also has links to the MetadataField and MetadataObject objects to retrieve detailed information about this field and the database object to which it belongs. The **Selected** property indicates if this field is used in some of the output columns in the query.

   Please note that this collection does not contain fields that were used in the query without table alias prefix. This because it is impossible to determine the correspondence of this field to a table uniquely.

3. Output query columns: QueryBuilder.QueryStatistics.**OutputColumns** collection.

   This collection lists output columns of the query. Each item of this collection has the Expression and ExpressionAlias properties to retrieve SQL expression, and it's alias (if defined). If SQL expression is a simple database object field, additional information for it is available: field type, object name, links to MetadataField and MetadataObject objects, etc.

------

# How to change sorting, add filters, limits and aggregations to the query?

There's a special component intended to change SQL queries according to the end-user data browsing needs: **QueryTransformer**. It was made to meet the needs of programmers who want to let the end-users to transfigure data while browsing query result set in the grid. The component lets change data sorting and filtration while browsing the query result data in the grid, apply limits to the result set, and calculate totals by columns.

It needs to be linked to the QueryBuilder and SQLBuilder objects to get the initial query columns and produce the modified query text in the result.

Follow the simple steps below to change the query the way you need:

1. Find the column you need in the QueryTransformer.Columns collection:

   ```C#
       column = queryTransformer.Columns.ColumnByName("OrderDate")
   ```

2. Create an object that defines the necessary modification:

   ```C#
       sorting = column.Ascending()
       filter = column.NotLess("31/12/2012")
       aggregate = column.Max("DateMax")
   ```

3. Apply these objects to the query:

   ```C#
       queryTransformer.OrderBy(sorting)
       queryTransformer.Where(filter)
       queryTransformer.Select(aggregate)
   ```

4. Apply limits to the query:

   ```C#
       If queryTransformer.IsSupportLimitCount() Then
           queryTransformer.Take("50")
       End If
   ```

5. Get the modified query from the QueryTransformer.SQL property:

   ```C#
       MessageBox.Show(queryTransformer.SQL)
   ```

   OR save the component state for future use with the QueryTransformer.StateXML property:

   ```C#
       savedState = queryTransformer.StateXML
       queryBuilder.SQL = updatedSql
       queryTransformer.StateXML = savedState
   ```

Read the [QueryTransformer and accompanying classes reference](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.QueryTransformer.QueryTransformer.html) for details.

Below are the object relationship diagram and code samples for different languages.

![img](http://www.activequerybuilder.com/scr/transformer_diagram.png)

#### Code samples

```C#
queryTransform.BeginUpdate;
try

       // filter
       queryTransform.Filters.Clear; // gets back the WHERE clause to initial state 

       queryTransform //adds conditions to the WHERE clause, conjunctioning it with conditions from initial query
           .Where(queryTransform.Columns[1].Not_Equal('100'))
           .Where(queryTransform.Columns[2].In_('(''Value1'',''Value2'',''Value3'')'))
           .Where(queryTransform.Columns.ColumnByName('OrderId').Condition('> 100'))
           .Where('OrderDate is not null')
           .Where(TacFilterFactory.Or_()
               .Add(queryTransform.Columns[1].Not_Equal('100'))
               .Add(queryTransform.Columns[1].Not_Equal('200')));

       // ordering
       queryTransform.Sortings.Clear; // gets back the ORDER BY clause to initial state 

       queryTransform // removes the ORDER BY clause of initial query and defines alternate ordering for a query
           .OrderBy(queryTransform.Columns[1])
           .OrderBy(queryTransform.Columns[2], false)
           .OrderBy(queryTransform.Columns.ColumnByName('OrderId'))
           .OrderBy('OrderDate');

       // offset
       queryTransform // applies the offset clauses to the query according to specific database server SQL syntax
           .Skip('100')
           .Take('50');

    // aggregations
    queryTransform.Aggregations.Clear;  // removes wrapping of the query in a sub-query

    queryTransform  // wraps the query in a sub-query and defines output columns for the outer query
    .SelectRecordsCount('recordsCount')
    .Select(queryTransform.Columns[1].Count, 'column1Count')
    .Select(queryTransform.Columns[1].Sum, 'column1Sum')
    .Select(queryTransform.Columns[1].Avg, 'column1Avg')
    .Select(queryTransform.Columns[1].Min, 'column1Min')
    .Select(queryTransform.Columns[1].Max, 'column1Max')
    ;

finally
       queryTransform.EndUpdate;
end;
```

------

# How database schema information stored in the Metadata Container?

#### Initialization of the Database Schema Tree

Active Query Builder doesn't require the preliminary metadata loading.

All you need to do is to initialize the Database Schema Tree using the **`QueryBuilder.InitializeDatabaseSchemaTree`** method in WinForms and WPF Editions. Use the **`QueryBuilder.MetadataStructure.Refresh`** method in the ASP.NET Edition.

The component will load the root node of the tree and automatically expand it to the level determined by the **`QueryBuilder.DatabaseSchemaTreeOptions.DefaultExpandLevel`** property. Deeper expansion may take more time to initialize the component depending on the size of your database schema and the tree grouping mode. 

#### Structure of the Metadata Container

**Metadata Container** is a tree-like structure that allows for reflection of any modern database server schema structure without any distortion. **Metadata Container** acts as a cache of the underlying *server's metadata catalog*, and it uses the *same naming rules as the underlying server*.

There are three types of elements of this structure: namespaces, objects, and sub-object items. **Namespace** nodes reflect object grouping in the database server. They can represent linked servers, databases, schemas and packages. **Objects** can be tables, views, synonyms, stored procedures or functions (only those procedures and functions that return dataset and can be used as data sources in the SELECT queries). Currently, the component deals with three types of **sub-object** items: **fields**, **parameters**, and **foreign keys**, as they are needed by the component to build queries and to represent them visually.

**`MetadataContainer`** is the root node of the tree. It stores the **`MetadataLoadingOptions`** set of properties, has the **`OfflineMode`** property, provides *methods to save and load metadata to XML format and events to handle items loading*.

**`MetadataItem`** is the base type for all metadata items. The following classes are derived from it: **`MetadataContainer`**, **`MetadataNamespace`**, **`MetadataObject`**, **`MetadataField`**, **`MetadataParameter`**, and **`MetadataForeignKey`**. The **`Type`** property determines the exact type of object for the **`MetadataNamespace`** and **`MetadataObject`** classes.

#### Metadata loading process

**Metadata Container** loads objects from the current database (according to the *connection settings*) by default and hides objects from other databases and linked servers. *If you want to show all available databases as well as from linked servers (if any)*, you can set the **`QueryBuilder.MetadataLoadingOptions.LoadDefaultDatabaseOnly`** property to false.

If you want to show metadata from specific databases or linked servers only or you want to limit the schemas visible to the end-user, you can instruct the component to do this using a few simple calls that described in this article "How to show metadata from several databases or database servers?".

Fine-tuning adjustment of the object's visibility can be achieved with the help of the [Metadata Structure](https://support.activequerybuilder.com/hc/en-us/articles/115001055289-Customizing-Database-Schema-Tree-structure) or [Metadata Filters](https://support.activequerybuilder.com/hc/en-us/articles/115001055509-Metadata-filtration-hiding-unwanted-objects-from-the-tree). Also, you can [add the necessary objects programmatically](https://support.activequerybuilder.com/hc/en-us/articles/115001063785-How-to-add-objects-to-the-Metadata-Container-programmatically-).

For *MS SQL Server*, the default structure of **Metadata Container** can look as follows.

```tiki wiki
Metadata Container (root)
`-- Database (default)
  |-- schema1
  | `-- database objects
  `-- schema2
    `--
```

For *MS SQL Server* with the **`LoadDefaultDatabaseOnly`** property set to `false`, the structure can look as follows.

```tiki wiki
Metadata Container (root)
|-- Linked Server (if any)
| `-- Database(s) 
|   `-- schema(s)
|     `-- database objects
|-- Database (default)
| |-- schema1
| | `-- database objects
| `-- schema2
|   `-- database objects
`-- Database(s) 
  |-- schema1
  | `-- database objects
  `-- schema2
    `-- database objects
```

For *MS Access* that does not support any namespaces, it will look as follows.

```tiki wiki
Metadata Container (root)
`-- database objects
```

The algorithm of filling child nodes of **Metadata Container** root node is the following:

-  If the server supports **linked servers**:
   \- trying to find linked servers; 
   \- adding them to the **Metadata Container**.
-  If the server supports **multiple databases**: 
   \- retrieving the list of databases; 
   \- adding them to the **Metadata Container**.
-  If the server **doesn't support databases but supports schemas**: 
   \- retrieving the list of schemas; 
   \- adding them to the **Metadata Container**.
-  If the server **doesn't support databases and schemas**: 
   \- retrieving the list of database objects; 
   \- adding them to the **Metadata Container**.

**Metadata Container** loads metadata from the database **by demand**. The loading starts when the user expands a node of the Database Schema Tree, when a database object is added to the query and when the component maps objects in the parsed query to objects in the database. Learn more: [Possible reasons for delays on loading metadata](https://support.activequerybuilder.com/hc/en-us/articles/115001055569-Possible-reasons-of-slow-loading-of-the-component).

Metadata Container (as well as any other metadata item) can be forced to load all child items with the **`LoadAll`** method. It has the **`withFields`** parameter that determines whether to load fields or not as loading fields may take a long time in case of the large database schema.

#### Methods and events of the Metadata Container

**`MetadataItem`** holds the list of child item within the `Items` property of the **`MetadataList`** class. It has the necessary methods (**`Find`**) to find objects and to load them if they aren't loaded yet in the child items hierarchy. If you want to make searching for the loaded items only, you can get the list of loaded items of the particular type using the **`Items.Find`**, **`Items.GetItems`** and **`Items.GetItemsRecursive`** methods. Read more about them in [this article](https://support.activequerybuilder.com/hc/en-us/articles/115001063785-How-to-add-objects-to-the-Metadata-Container-programmatically-).

The **`ItemMetadataLoading`** and **`ItemMetadataLoaded`** events of the **`MetadataContainer`** allow to perform pre- and post-processing when child metadata items are requested to load from the database. For example, you can override loading of fields or foreign keys for database objects or change their properties when loading is finished. You can find sample handlers of these events [here](https://support.activequerybuilder.com/hc/en-us/articles/115001055529-Adding-fields-and-changing-objects-loaded-in-the-Metadata-Container).

#### Saving and loading the content of Metadata Container to XML

Saving the content of the **Metadata Container** to *XML file or string* allows for *building queries without the necessity to be connected to the database directly*. Call the **`LoadAll`** and **`ExportToXML`** methods of the **`MetadataContainer`** object to save the content of **Metadata Container** in full. The **`LoadAll`** method has the **`withFields`** Boolean parameter which determines the necessity of database objects fields load.

```C#
MetadataContainer.LoadAll(<true or false>); // with or without fields
MetadataContainer.ExportToXML(<filename or stream>); // to file or to stream
```

To load metadata back from XML file or string use the **`MetadataContainer.ImportFromXML`** method.

*There's a GUI tool to edit the content of metadata container*. You can download it [here](http://www.activequerybuilder.com/files/metadata_editor2.zip), or you can call it from your WinForms application using the **`QueryBuilder.EditMetadataContainer`** static method.

If you have already prepared XML file with metadata for the previous version, you can convert it into a new format using the command-line utility `XmlConverter.exe` that is shipped with the component.

------

# How to show metadata from several databases or database servers?

To instruct Active Query Builder to show metadata from some other databases or linked servers, you just need to add few lines of code before initializing the Database Schema Tree.

To add a database:

```C#
MetadataItem database = queryBuilder1.MetadataContainer.AddDatabase("DbName");
```

To add a linked server and all its databases:

```C#
MetadataItem server = queryBuilder1.MetadataContainer.AddServer("ServerName");
```

To add a database from linked server:

```C#
MetadataItem server = queryBuilder1.MetadataContainer.AddServer("ServerName");
MetadataItem database = server.AddDatabase("DbName");
```

Note that **adding a database or a server using this helper method prevents loading of other databases or servers from the parent node**. In the same way, you can prevent loading of additional schemas from a database. It's quite simple for Oracle database server which does not support multiple databases:

```
MetadataItem schema = queryBuilder1.MetadataContainer.AddSchema("SchemaName");
```

For those database servers that support multiple databases, use the following code:

```C#
// load the first level of the Metadata Container which should have the default database
queryBuilder1.MetadataContainer.Items.Load(MetadataType.Database, false);

// get list of loaded databases
IList databases = queryBuilder1.MetadataContainer.Items.GetList(MetadataType.Database);

// find the default database in the list
foreach (MetadataItem database in databases)
{
    if (database.Default)
    {
        MetadataItem schema = database.AddSchema("SchemaName");
    }
}
```

**Executing the code snippets above won't load metadata, but only add the root nodes for further loading on demand.** After adding the necessary items, you can initialize the Database Schema Tree as usual:

```
queryBuilder1.InitializeDatabaseSchemaTree();
```

During the initialization process, the tree will be expanded according to the **`QueryBuilder.DatabaseSchemaTreeOptions.DefaultExpandLevel`** property. Note that increasing of this property value will lead to increased initialization time as metadata loading is performed on the expansion of the Database Schema Tree nodes.

------

Some users want to load metadata from different servers that are not linked to each other. Although it is possible to do this, and the component will be able to build a query using objects from different servers, note that there will be no way to execute such queries until you use a custom query execution engine. If this doesn't stop you, follow the steps below.

1. Set the right syntax and metadata providers for the first database server and connect to it.
2. Load Metadata by calling the **`MetadataContainer.LoadAll(true)`** method. (The **`withFields`** parameter set to **`true`** instructs to load fields for each database object that may take a long time for the large database schema, so please be patient.)
3. Set the right syntax and metadata providers for the next database server and connect to it.
4. Add new database (or server) as described above.
5. Load Metadata from the database by calling the **`Metadataitem.LoadAll(true)`** method, where **`MetadataItem`** is the newly added database object.

Repeat steps 3-5 for all following databases and servers from which you want to load metadata. After that, you can save all metadata to the **XML file** and use it afterward.

------

# (*)How to get list of all databases (servers, schemas, objects, etc) from database server?

To get the list of databases, schemas, objects **without loading them to the Metadata Container**, use the following code:

```C#
using (var sqlContext = new SQLContext())
{
    sqlContext.Assign(queryBuilder1.SQLContext);
 
    // load all databases, not only default
    sqlContext.MetadataContainer.LoadingOptions.LoadDefaultDatabaseOnly = false;
    // load system databases if needed
    sqlContext.MetadataContainer.LoadingOptions.LoadSystemObjects = true;
 
    using (var databasesList = new MetadataList(sqlContext.MetadataContainer))
    {
        // load databases from the root level (sqlContext.MetadataContainer)
        databasesList.Load(MetadataType.Database, false);

        foreach (var db in databasesList) 
        {
        
            using (var schemasList = new MetadataList(db)) 
            {
                // load schemas for each database (db)
                schemasList.Load(MetadataType.Schema, false);

                // process schemasList.Items
            }
        }
    }
}
```

Or, if you don't need a list of databases, but a list of schemas from all databases, you can simplify this sample as follows:

```C#
using (var sqlContext = new SQLContext())
{
    sqlContext.Assign(queryBuilder1.SQLContext);
 
    // load all databases, not only default
    sqlContext.MetadataContainer.LoadingOptions.LoadDefaultDatabaseOnly = false;
    // load system objects if needed
    sqlContext.MetadataContainer.LoadingOptions.LoadSystemObjects = true;
 
    using (var schemasList = new MetadataList(sqlContext.MetadataContainer))
    {
        // set the Recursive parameter to true to load items from lower levels
        schemasList.Load(MetadataType.Schema, true); 

        foreach (var schema in schemasList) 
        {
            // process each schema
        }
    }
}
```

That's it.

------

# How to add objects to the Metadata Container programmatically?

This is the second article about working with the Metadata Container. Read the first article to learn the basics: [How database schema information stored in the Metadata Container?](https://support.activequerybuilder.com/hc/en-us/articles/115001055549-How-database-schema-information-stored-in-the-Metadata-Container-).

This article describes, methods, properties, and tools to manipulate objects in the Metadata Container.

#### Why one may want to modify the content of Metadata Container?

Below are the reasons why one may want to modify the Metadata Container:

-  to delete unwanted objects from the user's field of view,
-  to add descriptions or [alternate names](https://support.activequerybuilder.com/hc/en-us/articles/115001063565-User-friendly-database-object-and-field-names) for objects and fields,
-  to add [virtual objects and fields](https://support.activequerybuilder.com/hc/en-us/articles/115001055269-Virtual-objects-and-calculated-fields),
-  to add missing relationships between objects, so the component will be able to join them automatically on adding to the Design Pane.



-  It's incorrect to rearrange objects, having placed them in databases, packages, and schemas irrelevant to real ones. In the case of such changes, the incorrect query text will be generated for these objects. Also, it'll be impossible to load the fields list dynamically for displaying on the Design Pane. (But there's a way out: you can use the new MetadataStructure object which has a wide range of possibilities for [customization of the Database Schema Tree](https://support.activequerybuilder.com/hc/en-us/articles/115001055289-Customizing-Database-Schema-Tree-structure/))

#### Metadata Container Editor

The Metadata Editor tool lets quickly delete and add objects, add descriptions, alternate names, etc. To call the Metadata Editor programmatically use the following code:

```C#
QueryBuilder.EditMetadataContainer(
   queryBuilder1.MetadataContainer, 
   queryBuilder1.MetadataStructure, 
   queryBuilder1.MetadataLoadingOptions
);
```

It is also available as a standalone application for editing metadata XML files ([download](http://www.activequerybuilder.com/files/metadata_editor2.zip)).

#### How to add new objects to the empty Metadata Container?

All objects in the Metadata Container must reside in appropriate namespaces to match names being used in the query text to real database objects and to generate proper object names in the result query text.

For example, the "Northwind.dbo.Orders" table of **MS SQL Server** should be represented as the "Orders" metadata object, which resides in the "dbo" schema, which in turn resides in the "Northwind" database, which finally resides in the Metadata Container root namespace:

```C#
MetadataItem database = queryBuilder1.MetadataContainer.AddDatabase("Northwind");
database.Default = true; // set to omit database name in query text
MetadataItem schema = database.AddSchema("dbo");
MetadataObject table = schema.AddTable("Orders");
```

For those database servers that don't provide support for multiple databases, like **Oracle**, the "HR.JOBS" table should be represented as the "JOBS" metadata object, which resides in the "HR" schema, which resides in Metadata Container root namespace:

```C#
MetadataItem schema = queryBuilder1.MetadataContainer.AddSchema("HR");
MetadataObject table = schema.AddTable("JOBS");
```

For servers like **MySQL **which can host multiple databases, but has no schemas, tables should be added directly to database nodes:

```C#
MetadataItem database = queryBuilder1.MetadataContainer.AddDatabase("sakila");
MetadataObject table = database.AddTable("films");
```

For databases like **SQLite **and **MS Access** that don't support any namespaces, all objects should be placed directly in the root of Metadata Container:

```C#
MetadataObject table = queryBuilder1.MetadataContainer.AddTable("Customers");
```

**To add case-sensitive object names to the Metadata Container, you must quote them according to the quotation rules of your database server.**

Note that it's incorrect to rearrange objects, having placed them in databases, packages, and schemas irrelevant to real ones for the above reasons. Instead, you can use the new MetadataStructure object which has a wide range of possibilities for [customization of the Database Schema Tree](https://support.activequerybuilder.com/hc/en-us/articles/115001055289-Customizing-Database-Schema-Tree-structure).

#### How to add new objects to already filled Metadata Container?

The following code sample tries to find items that are already loaded into the Metadata Container, load them if necessary, and add them manually if they aren't found/exist. It also adds the found (or the newly added) table to the root of Database Schema Tree.

```C#
// find or add database item
var northwind = metadataContainer.FindItem("Northwind", MetadataType.Database) ??
    metadataContainer.AddDatabase("Northwind");

// find or add schema item
var dbo = northwind.FindItem("dbo", MetadataType.Schema) ?? 
    northwind.AddSchema("dbo");

// find object or add view
var myView = dbo.FindItem("myView", MetadataType.Objects /* accept any object types: views, tables, synonyms, stored procs */) ??
    dbo.AddObject("myView", MetadataType.View);

// create new MetadataStructureItem for myView
var metadataStructureItem = new MetadataStructureItem {MetadataItem = myView};
queryBuilder1.MetadataStructure.Items.Add(metadataStructureItem);
```

Note that if a node of Metadata Container is already filled with some object, the component will not try to load other objects of this type on calling the FindItem method, as it thinks that such objects are already loaded.

#### How to edit objects being loaded from the database or already existing in the Metadata Container?

First, you can use the sample above to find or add the needed objects, then edit them according to your needs.Second, you can use the **ItemMetadataLoading **and **ItemMetadataLoaded **events of the MetadataContainer. They are fired before and after loading child metadata items for an item (in the case of loading fields for a table node, or tables for a schema node, etc.). See the usage sample in this article: [Adding fields and changing objects loaded in the Metadata Container](https://support.activequerybuilder.com/hc/en-us/articles/115001055529-Adding-fields-and-changing-objects-loaded-in-the-Metadata-Container).

#### How to load only needed objects from database schema?

To load all objects from the database schema to the Metadata Container (taking into account limitations specified by Metadata Filters), use [the **MetadataContainer.LoadAll** method](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataItem~LoadAll.html). The *withFields parameter*instructs whether to load fields for objects or not. Fields loading is the longest operation (separate query is executed for every database object), so the *LoadAll(true)* call might work very long on large databases. If you fill the metadata container with objects without fields, the fields will be loaded on demand when you add an object to a query.

Metadata Container is a tree-like structure, which groups database objects by namespaces in a tree-like structure (servers, databases, schemas, packages - each level can be omitted if it's not applicable to the particular database server). To load only one level of this hierarchy, or objects of the specifiс type, use [the **MetadataItem.Items.Load** method](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataList~Load(MetadataType,Boolean).html). For example the *MetadataContainer.Items.Load(Database|Schema, true)* call will load all database and schema levels of the metadata container.

The other methods allow iterating items that are already loaded into the MetadataContainer and load them from the database.

-  The **MetadataList.Find\*** methods search for and return matching metadata items or their indices (without loading them from the database).
-  The **MetadataList.GetItems** and **MetadataList.GetItemsRecursive** methods return items from the list (and child items lists) without loading them from the database.
-  The **MetadataItem.Find\*** methods recursively load items of child hierarchy from the database, and return matching ones.
-  The **MetadataStructure.GetAllMetadataItems** method loads and returns all metadata items that might be visible in the Database Schema Tree (according to the current Metadata Structure).

#### How to delete objects from Metadata Container?

To delete a object from the Metadata Container, you should remove it from the list of parent metadata items:

```C#
    metadataItem.Parent.Items.Remove(metadataItem);
```

------

# How to omit database name or schema in query text or deny this?

Active Query Builder can skip default namespace prefixes for database objects. This helps to make SQL query text clearer. Active Query Builder detects default namespaces during the metadata loading process and omits them in the query text by default. This behavior can be altered by changing the **ObjectPrefixSkipping** property in the *QueryBuilder.SQLGenerationOptions* and the *QueryBuilder.SQLFormattingOptions* groups. The QueryBuilder.SQLGenerationOptions group affects the output of QueryBuilder.SQL property (unformatted SQL) while the QueryBuilder.SQLFormattingOptions group affects the output of QueryBuilder.FormattedSQL property.

MetadataItem objects for namespaces which can be omitted are marked in the Metadata Container as default using the **MetadataItem.Default** property. Note that *a query with omitted object prefixes could be successfully executed only against a connection with appropriate database user credentials*.

If you [load metadata programmatically](https://support.activequerybuilder.com/hc/en-us/articles/115001063785-How-to-add-objects-to-the-Metadata-Container-programmatically-) (add items to the metadata container with code), setting the Default property is trivial. But if you load metadata from live database connection and want to change this property for some of the loaded metadata items, you must handle the **MetadataContainer.ItemMetadataLoaded**event as follows:

```C#
// add handler
queryBuilder1.MetadataContainer.ItemMetadataLoaded += MetadataContainerOnItemMetadataLoaded;

// set database "HIVE" and schema "Default" as default
private void MetadataContainerOnItemMetadataLoaded(object sender, MetadataItem item, MetadataType loadTypes)
{
    foreach (var childItem in item.Items)
    {
        if (childItem.Type == MetadataType.Database && childItem.Name == "HIVE" ||
            childItem.Type == MetadataType.Schema && childItem.Name == "Default")
        {
            childItem.Default = true;
        }
    }
}
```

*To get the default database and schema names* from the underlying database server use appropriate static methods of the MetadataNamesFetcher object: **GetDefaultDatabaseName**, **GetDefaultSchemaNames**.

*To find the default namespace objects* in the Metadata Container use the following code:

```C#
// load the first level of the Metadata Container which should have the default database 
// in case of connecting to the database server that supports multiple databases
queryBuilder1.MetadataContainer.Items.Load(MetadataType.Database, false);

// get list of loaded databases
List databases = queryBuilder1.MetadataContainer.Items.GetItems (MetadataType.Database);

// find the default database in the list
foreach (MetadataNamespace database in databases)
{
    if (database.Default)
    {
        database.Items.Load(MetadataType.Schema, false);

        List schemas = database.Items.GetItems (MetadataType.Schema);

        foreach (MetadataNamespace schema in schemas)
        {
            if (schema.Default)
            {
                MetadataObject table = schema.AddTable("Demo Table");
                // ...
            }
        }
    }
}
```

 

------

# Adding fields and changing objects being loaded to the Metadata Container

Below are the sample handlers of the **`MetadataContainer.ItemMetadataAdding`** and the **`MetadataContainer.ItemMetadataAdded`** events that perform pre- and post-processing on requesting child metadata for a Table metadata item.

### Adding new objects programmatically

Note that this will prevent automatic loading of child objects of that type.

```c#
void MetadataContainer_ItemMetadataLoading(object sender, MetadataItem item, MetadataType loadTypes)
{
	if (item.Type == MetadataType.Table && item.Name == "Demo Table")
	{
		MetadataField pk = item.AddField("Field 1");
		pk.FieldTypeName = "int";
		pk.PrimaryKey = true;

		MetadataField f2 = item.AddField("Field 2");
		f2.FieldTypeName = "nvarchar";
		f2.Size = 30;

		item.AddField("Field 3").FieldTypeName = "datetime";
	}
}
```

### Modifying properties of automatically loaded child objects

Note that in this event handler you must modify no the item itself, but its child items. For example, here you can define [user-friendly names for objects](https://support.activequerybuilder.com/hc/en-us/articles/115001063565-User-friendly-database-object-and-field-names) to display in the tree.

```c#
private void MetadataContainer_ItemMetadataLoaded(object sender, MetadataItem item, MetadataType loadtypes)
{
    if (item.Type == MetadataType.Table && item.Name == "Demo Table")
    {
        foreach (MetadataField field in item.Items.Fields)
        {
            field.Name = field.Name.ToUpper();
        }
    }
}
```

------

# Methods to load, search and remove objects from the Metadata Container

To load all objects from the database schema to the **Metadata Container** (taking into account limitations specified by **Metadata Filters**), use **`MetadataContainer.LoadAll`** method. The **`withFields`** parameter instructs whether to load fields for objects or not. ==Fields loading is the longest operation (separate query is executed for every database object), so the **`LoadAll(true)`** call might work very long on large databases. If you fill the metadata container with objects without fields, the fields will be loaded on demand when you add an object to a query.==

>  Metadata Container is a tree-like structure, which groups its objects by namespaces in a tree-like structure (servers, databases, schemas, packages - each level can be omitted if it's not applicable to the particular database server). To load only one level of this hierarchy, or objects of the specific type, use the **`MetadataItem.Items.Load`** method. For example the **`MetadataContainer.Items.Load(Database|Schema, true)`** call will load all database and schema levels of the metadata container.

The other methods allow iterating items that are already loaded into the **`MetadataContainer`**.

-  The **`MetadataList.Find\*`** methods find and return matching metadata items or their indices (without loading them from the database).
-  The **`MetadataList.GetItems`** and **`MetadataList.GetItemsRecursive`** methods return items from the list (and child items lists) without loading them from the database.
-  The **`MetadataItem.Find\*`** methods recursively load items of child hierarchy from the database, and return matching ones.
-  The **`MetadataStructure.GetAllMetadataItems`** method loads and returns all metadata items that might be visible in the Database Schema Tree (according to the current Metadata Structure).

To remove an object from the Metadata Container, you should remove it from the list of parent metadata items:

```C#
    metadataItem.Parent.Items.Remove(metadataItem);
```
------

# (*)Metadata filtration, hiding unwanted objects from the tree
There are several ways to exclude unwanted objects from the Database Schema View. You can define filters to exclude objects by the name or mask. Another way is to use the Metadata Editor tool to remove unwanted objects from the Metadata Container explicitly. 

The Metadata Editor tool can be downloaded from [the download page](http://www.activequerybuilder.com/download.html) (in the "Additional Downloads" section). When editing is finished, you can save the result to an XML file and then [load metadata from this XML file](https://support.activequerybuilder.com/hc/en-us/articles/115001055549-How-database-schema-information-stored-in-the-Metadata-Container-#xml) instead of working with the live database connection. Loading metadata from XML file will also reduce a load on your database and web servers (in the case of the ASP.NET Edition).

The third way is to keep the Metadata Container untouched, but use the Metadata Structure presentation layer to [customize the Database Schema Tree](https://support.activequerybuilder.com/hc/en-us/articles/115001055289-Customizing-Database-Schema-Tree-structure), but this way you can only hide objects from the tree, not to remove them from the Metadata Container.

### Metadata filtration

Using metadata filters, you can prevent loading of objects with specific names or load objects with specific names only. You can also display only objects of certain types or from specified databases/schemas.

Note that you can also specify metadata filter for a node of the Metadata Structure ([MetadataStructureItem.MetadataFilter](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataStructureItem~MetadataFilter.html)). You can read more about defining custom metadata structure in this article: [Customizing Database Schema Tree structure](https://support.activequerybuilder.com/hc/en-us/articles/115001055289-Customizing-the-Database-Schema-Tree-structure).

You can specify metadata filters in two ways. It's easier to setup filters in a first way, but using the second way you can create more complex filters.

#### The simple way to define filters

The [QueryBuilder.MetadataLoadingOptions.IncludeFilter](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataLoadingOptions~IncludeFilter.html) lets define a set of visible objects (only the objects which satisfy it will be visible) and the [QueryBuilder.MetadataLoadingOptions.ExcludeFilter](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataLoadingOptions~ExcludeFilter.html) allows defining a set of objects which should not be visible (the objects that satisfy it will be hidden). You can define both properties, and they will work together just fine.

Both properties are of the SimpleMetadataFilter class which has Names, Schemas and Types fields. Using them you can specify masks for database object and schema names (read the rules of mask definition below), set types of objects to display or hide.

For example, in the result of the following statements execution, the user will see all views from the database, except those which reside in the "dbo" schema.

```C#
queryBuilder1.MetadataLoadingOptions.IncludeFilter.Types = [View];
queryBuilder1.MetadataLoadingOptions.ExcludeFilter.Schemas.Add("dbo");
queryBuilder1.InitializeDatabaseSchemaTree();
```

#### The advanced way to define filters

([QueryBuilder.MetadataLoadingOptions.MetadataFilter](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataLoadingOptions~MetadataFilter.html))

Metadata Filter is a set of filtration rules. Each rule in the list is represented by the [MetadataFilterItem object](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataFilterItem.html). An item can define objects to be set excluded or included in the result set according to the [Exclude property](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataFilterItem~Exclude.html). Metadata Filter can have multiple exclusion and inclusion items (rules). If Metadata Filter has no inclusion items, the exclusion items will be applied to the whole database schema. If Metadata Filter has some inclusion items, they will constitute a subset of the database schema, to which the exclusion items will be applied.

Each Metadata Filter Item has a mask for each type of metadata items: Server, Database, Schema, Package, Object, and Field. Each mask determines a subset of objects which names match this mask. Those masks act similar to the "LIKE" SQL operator: you can use the percent character (%) to represent any sequence of characters; use the underscore character (_) to represent any single character. The [CaseSensitive property](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataFilterItem~CaseSensitive.html) determines case sensitivity of masks. The [ObjectTypes property](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataFilterItem~ObjectTypes.html) determines which object types (Table, View, Synonym, Procedure or Function) will be included or excluded.

You may treat those rules as SQL conditions combined with OR operators in WHERE clause of the SELECT statement that retrieves the list of objects to be loaded to the Metadata Container. Conditions marked with the Exclude flag are prefixed with the NOT operator. The result SQL WHERE clause will look like the following: "([inculsion rule] OR [inclusion rule] OR ...) AND NOT ([exculsion rule] OR [exclusion rule] OR ...)". Masks of one rule are combined with the AND operator.

The following example adds new filter item that excludes objects with names starting with "pre_":

```C#
MetadataFilterItem mfi = queryBuilder1.MetadataLoadingOptions.MetadataFilter.Add();
mfi.Exclude = true;
mfi.Object = "pre_%";
mfi.CaseSensitive = true;
```

And the following example adds new filter item that excludes all schemas except the "schema":

```C#
MetadataFilterItem mfi = queryBuilder1.MetadataLoadingOptions.MetadataFilter.Add();
mfi.Exclude = false;
mfi.Schema = "dbo";
```

The following sample demonstrates filtration by object type:

```C#
MetadataFilterItem metadataFilterItem = queryBuilder1.MetadataLoadingOptions.MetadataFilter.Add();
metadataFilterItem.Exclude = false;

metadataFilterItem.ObjectTypes = MetadataType.Table | MetadataType.View;
metadataFilterItem.FlagSystem = false;
metadataFilterItem.FlagUser = true;

queryBuilder1.MetadataContainer.Items.Clear();
queryBuilder1.InitializeDatabaseSchemaTree();
```
------



# Customizing the Database Schema Tree structure

### Introduction

Metadata Structure was introduced at the instance of many users wishing to have a possibility to define objects grouping in the Database Schema Tree independently from the physical database schema, by subject areas or with some other characteristics. Other users wanted to keep objects grouped by physical database structure, but to add the special folder for saving frequently used objects or sub-queries there (in the form of [virtual objects](https://support.activequerybuilder.com/hc/en-us/articles/115001055269-Virtual-objects-and-calculated-fields)). 

The Metadata Structure object can be accessed via the [QueryBuilder.MetadataStructure property](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder~MetadataStructure.html). By default, it's responsible for grouping of objects in the tree. **You can adjust database objects grouping in the Database Schema Tree using the QueryBuilder.MetadataStructureOptions group of properties.** However, you can easily re-arrange objects in this structure programmatically or use the Metadata Editor tool.

### Constitution

Metadata Structure is a tree-like structure consisting of [MetadataStructureItem](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataStructureItem.html) nodes, which can be *static*or *dynamic*.

**Static node** is represented by a single node at the current level of the Database Schema Tree. A static node can represent a definite object of the Metadata Container (by referring to it via the MetadataStructureItem.MetadataItem property), or it can be a folder (a node for grouping other items) if MetadataItem property is null.

The referred object can be not only a database object but also a namespace (a database, a schema, etc. ). A namespace node will generate child nodes automatically to reflect the underlying objects or namespaces (unless it's AllowChildAutoItems property is set to false). For example, you can add Database or Schema node to the Metadata Structure, and the user will be able to expand the appropriate node in the Database Schema Tree to browse objects of the appropriate namespace.

**Dynamic node** is a node which holds a Metadata Filter. The addition of dynamic node into the Metadata Structure leads to inclusion of all objects (meeting the filter conditions) from the Metadata Container into the appropriate level of the Database Schema Tree.

### Metadata Editor

The Metadata Editor lets add three types of nodes: a folder, an object, and a filter. The first two types are static nodes which mainly differ from each other by the icon. The Filter is a dynamic node. You can learn more about metadata filters [here](https://support.activequerybuilder.com/hc/en-us/articles/115001055509-Metadata-filtration-hiding-unwanted-objects-from-the-tree).

### Customization

There are two scenarios of filling Metadata Structure node programmatically:

1. set the AllowChildAutoItems property of the particular node to false and populate it with child items by yourself;
2. set the AllowChildAutoItems property to true and link it with the specific item of Metadata Container (MetadataStructureItem.MetadataItem property) to let it be populated with child items automatically.

Anyway, there should be some static nodes below the root, then dynamic or namespace nodes on lower levels. To add a static node *below* the dynamic one, use the MetadataStructure.ItemAdded event for this purpose (for example, to add the "Favorite" node to each database or schema).

### Code samples

#### Creating a folder that corresponds to the namespace (database, schema, etc.):

```C#
    MetadataStructureItem msi = new MetadataStructureItem();
    msi.MetadataName = "Database2"; // AQB will search for this name in child items of the Metadata Item
                                    // referred in the parent Metadata Structure Item  
    msi.AllowChildAutoItems = false; // deny automatic fill for this node to add specific objects further
    queryBuilder.MetadataStructure.Items.Add(msi);
```

#### Creating a custom folder:

```C#
    MetadataStructureItem folder = new MetadataStructureItem();
    folder.Caption = "Favorites"; 
    queryBuilder.MetadataStructure.Items.Add(folder);
```

#### Creating a folder with metadata filter:

```C#
    MetadataStructureItem viewsItem = new MetadataStructureItem();
    viewsItem.Caption = "Views"; 
    var filter = viewsItem.MetadataFilter.Add();
    filter.ObjectTypes = MetadataType.View;
    queryBuilder.MetadataStructure.Items.Add(viewsItem);
```

#### Adding a particular database object:

```C#
    MetadataStructureItem tableItem = new MetadataStructureItem();
    tableItem.MetadataName = "Northwind.dbo.Orders"; // AQB will search for this full-qualified name in the entire Metadata Container 
    queryBuilder.MetadataStructure.Items.Add(tableItem);
```

The new Metadata Structure demo project provides the necessary code samples of building custom metadata structure. All available properties and methods of metadata structure objects are documented in detail.

------

# Possible reasons of slow loading of the component

Despite the fact that full load of the Database Schema Tree is not necessary since the second version of the component, and can be completed in a separate thread, loading the query diagram may take a long time if you have large database schema. The slowness can arise due to several reasons.

1. Loading of database objects to the Database Schema Tree.

First reason is the value of the **QueryBuilder.DatabaseSchemaTreeOptions.DefaultExpandLevel**property that's greater than zero. This property determines the level of initial node expansion in the Database Schema View. Decreasing this property value will lead to faster loading. Also please note that turning off all of the QueryBuilder.MetadataStructureOptions.GroupBy* properties will result in a plain list of database objects without any grouping node levels, so all objects would have to be loaded on the zero level.

Please consider [loading metadata from XML file](https://support.activequerybuilder.com/hc/en-us/articles/115001055549-How-database-schema-information-stored-in-the-Metadata-Container-#xml) if delays are notable in any way.

2. Loading of objects that were found in the query to the Metadata Container.

The second reason for delays might be because the component is inquiring object lists from all schemes that explicitly mentioned in the query text and from schemas marked as default for the current database user. It's needed to determine the correspondence of objects pointed in the query with objects of the currently connected database schema. The process is necessary to retrieve the supplementary information about objects used in the query, such as data field types and foreign keys. This information isn't essential for the component's operability, but it lets increase informational content of the query diagram and makes query building process easier.

If the delay is considerable and users are ready to refuse informational contents for productivity, you may turn off loading of this information by setting the [**QueryBuilder.MetadataLoadingOptions.DisableAutomaticMetadataLoading**](http://www.activequerybuilder.com/documentation/ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.MetadataLoadingOptions~DisableAutomaticMetadataLoading.html) property to True.

We don't recommend to set this property without any necessity, but in some cases setting of this property can be justified. These are the cases when structure analysis of existing queries is of higher priority than ease of visual query building, and also in the case of a large database schema.

------

# Virtual objects and calculated fields

Virtual Fields and Objects lets simplify visual building of queries in the case when same derived tables, correlated sub-queries or SQL expressions are frequently used in other queries. Active Query Builder allows representing such entities as Virtual Objects and Fields. Virtual entities don't differ from ordinary database objects and fields; the end-user works with them as if they were real objects and fields.

Substitution of virtual entities for containing expressions is performed seamlessly same way as [alternate names](https://support.activequerybuilder.com/hc/en-us/articles/115001063565-User-friendly-database-object-and-field-names).

Virtual Object acts as a database view. It holds a **`SELECT`** query inside, so the Virtual Object name is substituted for containing query and becomes a derived table when executing such query against the database server.

The virtual (calculated) field can represent complex SQL expressions, and correlated subqueries may be. For example, one can add the "Customer" virtual field to the "Orders" table containing the following SQL expression: **`(SELECT c.Customer_Name FROM Customers c WHERE c.Customer_Id = Orders.Customer_Id)`**. When this field is selected in a query, the user will get the name of the customer in the query result set.

To work with this feature, you must use two instances of the PlainTextSQLBuilder object: one to get the query text for editing by the end-user and another to get the query for execution against the database server, having set the **ExpandVirtualFields** and **ExpandVirtualObjects** properties to True. As opposed to the alternate names feature, where real names in the query could be converted into the alternate ones, and vice versa, the inverse conversion of SQL expressions into virtual objects and fields is impossible.

You can add virtual objects and fields to the Metadata Container the same way as ordinary objects and fields, additionally assigning SQL expression text to the **Expression** property of MetadataField and MetadataObject objects.

------

# User-friendly database object and field names

The Alternate Names feature for both database objects and their fields lets completely substitute real names of objects for clearer descriptive names. User-friendly names let simplify understanding of database structure by end-users. 'Complete substitution' means replacement of objects names in both user interface, SQL expressions as well as in the query text which can be edited by end user together with visual query building. Active Query Builder lets assign an alternate name to every object and field loaded to the Metadata Container.

You can get the SQL query text either with real or alternate names at any time. The **UseAltNames**property of PlainTextSQLBuilder component determines which names to use. Whereas several PlainTextSQLBuilder components might be connected to one QueryBuilder component, you can get both variants of the query text simultaneously: one for the end-user and another for executing a query against the database server. On parsing a query, the component can recognize both real and alternate names of fields, so the user can read and edit both variants of the query.

The same-named property of the QueryBuilder component is responsible for displaying of real or alternate names in the query building user interface.

Some customers even use this peculiarity for refactoring of database structure by passing the suite of existing queries through the component and getting queries with new names of fields and objects in the result.

Alternate names can be assigned in several ways.

1. You can set them via the "alt_name" tag of fields and objects in the saved metadata XML file (manually using the or with the help of the metadata editor).
2. You can set them when an object is added to the Metadata Container by handling the appropriate events. For example, you can use object descriptions loaded from the database as alternate names.
   **VCL and Java Editions**: Use the QueryBuilder.MetadataContainer **MetadataObjectLoaded **(for objects) and **ObjectMetadataLoaded **(for fields) events during their load to the Metadata Container.
   **All .NET Editions**: Use the QueryBuilder.MetadataContainer.**ItemMetadataLoaded** to change properties of newly added child items of the given item. See this event handler sample here: [Adding fields and changing objects loaded in the Metadata Container](https://support.activequerybuilder.com/hc/en-us/articles/115001055529-Adding-fields-and-changing-objects-loaded-in-the-Metadata-Container).

------

# Modification of sub-query text separately from the entire query

Active Query Builder lets modify the text of sub-query independently of the main query. The **UnionSubQuery.SQL** and **SubQuery.SQL** properties can be used to read and write sub-query SQL text.

When working in the sub-query editing mode, the programmer must assign the user edited query text to the **PlainTextSQLBuilder.SQL** property as it's always mapped to the active sub-query. He must use the **PlainTextSQLBuilder.SQLUpdated** event to update the text editor as this event is fired not only on changing of the query in the Query Builder but also on switching of the active sub-query.

Another option is to let the PlainTextSQLBuilder retrieve the formatted text of the currently active sub-query. In this mode, the user sees and edits the currently active sub-query as an independent query.  He can easily get back from this mode when needed.

There are two variants of sub-query editing mode: editing single union sub-queries or editing sets of sub-queries with unions. In other words, if a subquery contains unions, the user can separately edit each union sub-query, or he can modify the whole set of union sub-queries. 

Below are the possible values of the **PlainTextSQLBuilder.TargetQueryPart** property that turns this mode on are the following:

-  Query (default) – instructs to generate SQL text for the whole query;
-  SubQuery – instructs to generate SQL text for the currently active sub-query with unions;
-  UnionSubQuery – instructs to generate SQL text for the currently active union sub-query.

The "SubQuery Text Editing" demo project illustrates this functionality.

------
# Saving queries for further use as data sources in new queries (Reusable queries)

The Professional version of Active Query Builder provides the unique ability to save end-user queries for using them as views in subsequent queries. The user can save a query as Reusable Query via the special snippet in the lower right corner of the component. After that, he can start building a new query and then use the saved query in a new one. The Reusable Query will appear the same way as an ordinary database object in the component's UI as well as in the SQL query text, but it will be substituted for containing SQL text upon execution against the database server. Reusable Queries are linked, not embedded, so the substitution is performed right before the execution against a database server. This means that if Reusable Query is changed, the related query gets the latest SQL query text of Reusable Query. This way the user can create multi-level nested queries, and work with each query independently from related queries.

You can try this feature and get code samples using the Full-featured demo project in Professional and Trial versions. The QueryBuilder.PanesConfigurationOptions.**UserQueriesPaneVisible** property switches the Reusable Queries snippet on and off.

To save Reusable Queries between work sessions, the programmer has to save the Reusable Queries repository using the **QueryBuilder.ReusableQueries** import/export methods.

This feature was implemented by the well-proven mechanism of [Virtual Objects](https://support.activequerybuilder.com/hc/en-us/articles/115001055269-Virtual-objects-and-calculated-fields). Reusable Queries are stored in the Metadata Container as objects of the new type MetadataType.UserQuery, so they can be accessed programmatically. Nothing stops the programmer from implementing a custom user interface to work with reusable queries instead of the embedded snippet.

------

# How to get formatted SQL text and setup formatting options?

### Active Query Builder for .NET 3.0

#### Standard way of getting SQL query text

Using the QueryBuilder visual control, you can setup SQL text formatting using the **QueryBuilder.SQLFormattingOptions** property group and read SQL text from the **QueryBuilder.FormattedSQL** property.

 

#### Alternate way of getting SQL query text

The **SQLBuilder** or **FormattedSQLBuilder** objects must be used when you need to get SQL query text. The **GetSQL **static method of these objects accepts the SubQuery and SQLGenerationOptions/SQLFormattingOptions objects and returns SQL text in the result. The **SQLFormattingOptions** class is inherited from the **SQLGenerationOptions** class. Both are used to store SQL generation options, such as the need for quotation all identifiers in query text, the need for fully qualified notation of database object and field names, etc. The SQLFormattingOptions object additionally holds properties to tune formatting of SQL query text (line breaks, indents, word wrapping).

```C#
sqlTextEditor1.Text = FormattedSQLBuilder.GetSQL(sqlQuery1.QueryRoot, sqlFormattingOptions1);
```

 

### Other editions

In version 2.x and lower, to get the formatted SQL text, you should create an instance of the **PlainTextSQLBuilder **object and assign a QueryBuilder object to the PlainTextSQLBuilder.**QueryBuilder**property. After that, you can handle the PlainTextSQLBuilder.**SQLUpdated **event to get the formatted SQL text.

The links below point to the lists of available properties of AQB.NET 2.0 to set up the formatting:

[PlainTextSQLBuilder](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.PlainTextSQLBuilder_members.html) inherits [BaseSQLBuilder](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.BaseSQLBuilder_members.html) which has separate sets of properties for the [Main query](http://www.activequerybuilder.com/documentation/ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.BaseSQLBuilder~MainQueryFormat.html), [expression subqueries](http://www.activequerybuilder.com/documentation/ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.BaseSQLBuilder~ExpressionSubqueryFormat.html), [derived tables](http://www.activequerybuilder.com/documentation/ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.BaseSQLBuilder~DerivedQueryFormat.html) and [Common Table Expressions](http://www.activequerybuilder.com/documentation/ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.BaseSQLBuilder~CTESubQueryFormat.html).

A set of formatting options for a single query is represented by the [SQLBuilderSelectFormat class](http://www.activequerybuilder.com/documentation/webframe.html#ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.SQLBuilderSelectFormat.html).

------

# How to validate an SQL query? (SQL syntax analysis only)

To validate a query against specific SQL syntax with Active Query Builder .NET Edition, use the **ValidateQuery()** method of appropriate syntax provider:

```C#
MSSQLSyntaxProvider syntax = new MSSQLSyntaxProvider();
string errorInfo = "";

if (!syntax.ValidateQuery("select * from Orders", ref errorInfo))
{
   MessageBox.Show(errorInfo);
}
```

Having VCL or ActiveX Edition of Active Query Builder, you may assign SQL query text to the QueryBuilder.SyncSQL property in a try-except (try-catch) block.

```C#
try
  acQueryBuilder.SQL:='select * from Orders';
except
  on e:EacSQLError do
    ShowMessage('Unexpected token "'+e.ErrorTokenValue+'" in line '+IntToStr(e.ErrorPos.line);
end;
```

Please note that Active Query Builder does not perform validation against specific database context, i.e. presence of table fields, function parameters, constants, etc. We believe that the best and only possible validator is the database server itself.

The fastest way to do that is to execute the query without data retrieval by calling the following method:

```C#
SqlCommand.ExecuteReader(CommandBehavior.SchemaOnly).
```

Of course, you can check if such database objects and fields are present in the database (using the **QueryBuilder.QueryStatistics** set of collections), but still, there are many things we can recognize regarding the correctness of a query for execution against a particular database.

You can instruct the component to generate parsing error for queries with unknown database objects using the **QueryBuilder.ParsingErrorOnUnknownObjects** property

Active Query Builder can parse SELECT statements only. For the rest of statements, it switches to the Sleep Mode. You may deny switching to this mode by setting the **QueryBuilder.AllowSleepMode** to false. Also, you can set the **SleepModeChanged** event handler to take additional actions.

------
# How to detect incorrect/unknown object and field names in the query?

On parsing a query, the component gets objects listed in the FROM clause of the query and tries to find corresponding objects in the Metadata Container. Of course, the Metadata Container should be duly filled with database objects to find a correspondence. You can fill it by connecting Active Query Builder to live database connection or you can pre-load the Metadata Container from the XML file.

Two collections list objects and fields in the query: QueryBuilder.QueryStatistics.[UsedDatabaseObjects](http://www.activequerybuilder.com/documentation/ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.QueryStatistics~UsedDatabaseObjects.html) and QueryBuilder.QueryStatistics.[UsedDatabaseObjectFields](http://www.activequerybuilder.com/documentation/ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.QueryStatistics~UsedDatabaseObjectFields.html). Each item in these collections has the MetadataObject property that refers to the MetadataItem object contained in the MetadataContainer. If an item has the null reference in the MetadataObject property, this may indicate that this object does not exist in the database.

Another reason of failure might be that objects the query are typed with omitted database or schema names, while the appropriate database and schema objects are incorrectly marked as default in the Metadata Container. Incorrect omission usually arises when the query has been written on behalf of another database user. In this case, the database server itself will fail to execute such a query.

For some reasons, you may want to deny parsing of queries with incorrect object names by setting the [QueryBuilder.BehaviorOptions.ParsingErrorOnUnknownObjects](http://www.activequerybuilder.com/documentation/ActiveDatabaseSoftware.ActiveQueryBuilder2~ActiveDatabaseSoftware.ActiveQueryBuilder.BehaviorOptions~ParsingErrorOnUnknownObjects.html) property to True.

------

# Working with parameters

It is possible to include parameters in the following notations to the query:

**= :param** (named notation)

**= ?** (unnamed notation)

**= @Param** (for MS SQL only)

Active Query Builder does not execute SQL queries, but it provides all necessary information about parameters that were used in the query. You should examine the QueryBuilder.Parameters collection before query execution and display a dialog prompt for parameter values based on the information from this collection. An example of such usage is provided in the sample projects that included in the installation package.

Note: Some of the data access components **may lack the support of some of the mentioned parameter notations**; please refer to the documentation for your data access components for details.

Note: *The Parameters collection is not available in the Free version*. Use the Trial or Standard version to work with parameters.

------

# How to suppress SqlParsingException for unsupported SQL statements? (Sleep mode)

The Sleep Mode is made to allow the end-users to write SQL statements that are not supported by Active Query Builder (DML, DDL) in the text editor.

This mode is enabled by default, but it might be disabled by setting the **QueryBuilder.AllowSleepMode**property to False. Switching to this mode is done automatically on assigning a not supported SQL query to the query builder. During this assignment, no parsing exceptions are thrown, but the **QueryBuilder.SleepModeChanged** event is fired.

The component in the "sleep mode" shows empty diagram pane and query columns grid. It switches this mode off on assigning a SELECT statement or when end-user starts to build a new query visually. In the second case, the **QueryBuilder.QueryAwake** event is fired. By handling this event, you may ensure that the user really wants to start building a new query, as this action will replace the previous non-supported SQL statement with a new one. You can deny this to prevent the loss.

------
# How to check if a query contains specific tables and they are joined correctly?

Suppose that we need a query always having the Orders and Customers tables and a join between these tables. The following example demonstrates programmatic query modification of a query to suit our requirement.

```C#
private void button1_Click(object sender, EventArgs e)
{
    string q;
    UnionSubQuery usq;
    DatasourceGroup fc;
    ArrayList ordersTables, customersTables;
    int iOrders, iCustomers;
    SQLQualifiedName OrdersName, CustomersName;
    SQLQualifiedName joinFieldName;
    DataSource o, c;

    // initial query
    string q = "select * from (Orders o inner join [Order details] od on o.OrderId = od.OrderId) inner join Products p On p.ProductID = od.ProductID";

    // create parsed names of tables we need to work with
    SQLQualifiedName ordersQualifiedName = queryBuilder1.SQLContext.ParseQualifiedName("Orders");
    SQLQualifiedName customersQualifiedName = queryBuilder1.SQLContext.ParseQualifiedName("Customers");
    string joinFieldName = "CustomerID";

    // synchronously load the query in the Query Builder
    queryBuilder1.SQL = q;

    // get reference to the UnionSubQuery
    UnionSubQuery unionSubQuery = queryBuilder1.ActiveUnionSubQuery;

    // get reference to the FromClause
    DataSourceGroup fromClause = unionSubQuery.FromClause;

    List<DataSourceObject> ordersTables = new List<DataSourceObject>();

    // try to find Orders table
    fromClause.FindTablesByDbName(ordersQualifiedName, ordersTables);

    if (ordersTables.Count == 0)
    {
        // Orders table not found - add it
        ordersTables.Add((DataSourceObject) queryBuilder1.SQLQuery.AddObject(unionSubQuery, ordersQualifiedName, null));
    }

    List<DataSourceObject> customersTables = new List<DataSourceObject>();

    // try to find Customers table
    fromClause.FindTablesByDbName(customersQualifiedName, customersTables);

    if (customersTables.Count == 0)
    {
        // Customers table not found - add it
        customersTables.Add((DataSourceObject) queryBuilder1.SQLQuery.AddObject(unionSubQuery, customersQualifiedName, null));
    }

    // check existence of link between each Orders and each Customers
    for (int iOrders = 0; iOrders < ordersTables.Count; iOrders++)
    {
        DataSource ordersDataSource = ordersTables[iOrders];

        for (int iCustomers = 0; iCustomers < customersTables.Count; iCustomers++)
        {
            DataSource customersDataSource = customersTables[iCustomers];

            if (fromClause.FindLink(ordersDataSource, joinFieldName, customersDataSource, joinFieldName) == null &&
                fromClause.FindLink(customersDataSource, joinFieldName, ordersDataSource, joinFieldName) == null)
            {
                queryBuilder1.SQLQuery.AddLink(ordersDataSource, joinFieldName, customersDataSource, joinFieldName);
            }
        }
    }
}
```

------

# How to add or modify TOP, LIMIT, FETCH FIRST clauses or ROWNUM condition programmatically?

This article provides source code samples of adding or modifying server-specific row limiting clauses in the query.

Please note that there is a better way to cope with this task in general, especially if you want to implement pagination of result data in your application: [QueryTransformer API](https://support.activequerybuilder.com/hc/en-us/articles/115001063925-How-to-change-sorting-add-filters-limits-and-aggregations-to-the-query-).

The following samples apply to all SQL syntax providers.

Read current limit and offset values:

```C#
if (syntaxProvider.IsSupportLimitCount() ||
    syntaxProvider.IsSupportLimitOffset())
{
    var queryAst = sqlQuery.QueryRoot.ResultQueryAST;
        // for old AQB 2.x use the queryBuilder.ResultQueryAST property instead

    string offset;
    string count;

    if (syntaxProvider.GetQueryLimits(queryAst, out offset, out count))
    {
        MessageBox.Show("Offset:" + offset + "\nCount: " + count);
    }
}
```

Apply new values:

```C#
string offset = "10";
string count = "20";

if (syntaxProvider.IsSupportLimitCount() ||
    syntaxProvider.IsSupportLimitOffset())
{
    var queryAst = sqlQuery.QueryRoot.ResultQueryAST;

    var newQuery = syntaxProvider.TransformQueryLimits(queryAst, offset, count);

    var newQuerySql = newQuery.GetSQL();
    MessageBox.Show(newQuerySql);
}
```

------

# How to join an object that has just been added by the user with existing objects in the query?

**The DatasourceAdded event** is fired right after an object is added to the query. Use it to take additional actions, like adding joins or setting datasource alias. 

**The DatasourceAdding event** lets deny the addition of object by the user.

```C#
private void queryBuilder1_DataSourceAdded(SQLQuery query, DataSource addedObject)
{
    List<DataSource> dataSources = new List<DataSource>();
    addedObject.ParentUnionSubQuery.FromClause.GetDatasources(dataSources);
 
    // enumerate data source links
    foreach (MetadataField currentTableField in addedObject.Metadata.Fields)
    {
        // if field is primary key then search for same-named fields in other datasources and create links.
        if (currentTableField.PrimaryKey)
        {
            string keyFieldName = currentTableField.Name;
 
            foreach (DataSource otherDataSource in dataSources)
            {
                // avoid self-linking
                if (otherDataSource.MetadataObject != null &&
                    otherDataSource != addedObject &&
                    otherDataSource.MetadataObject != addedObject.MetadataObject)
                {
                    foreach (MetadataField otherTableField in otherDataSource.Metadata.Fields)
                    {
                        // if names are equal...
                        if (otherTableField.Name == keyFieldName && otherTableField.FieldType == currentTableField.FieldType)
                        {
                            // check link does not already exist
                            if (addedObject.ParentUnionSubQuery.FindLink(addedObject, currentTableField.Name, otherDataSource, otherTableField.Name) == null)
                            {
                                // add link
                                query.AddLink(addedObject, currentTableField.Name, otherDataSource, otherTableField.Name);
                            }
                        }
                    }
                }
            }
        }
        else // field is not primary key.
        // search other datasources for same named primary key fields and link them.
        {
            string childFieldName = currentTableField.Name;
 
            foreach (DataSource otherDataSource in dataSources)
            {
                // avoid self-linking
                if (otherDataSource.MetadataObject != null &&
                    otherDataSource != addedObject &&
                    otherDataSource.MetadataObject != addedObject.MetadataObject)
                {
                    foreach (MetadataField otherTableField in otherDataSource.Metadata.Fields)
                    {
                        // if names are equal...
                        if (otherTableField.Name == childFieldName && otherTableField.FieldType == currentTableField.FieldType)
                        {
                            // ... and it's primary key
                            if (otherTableField.PrimaryKey)
                            {
                                // check link does not already exist
                                if (otherDataSource.ParentUnionSubQuery.FindLink(otherDataSource, otherTableField.Name, addedObject, currentTableField.Name) == null)
                                {
                                    // add link
                                    query.AddLink(otherDataSource, otherTableField.Name, addedObject, currentTableField.Name);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
```

------
# How to take additional actions when user adds an object to the Design Pane?

Active Query Builder allows customizing objects added to the Design Pane via the QueryBuilder.DatasourceAdded event.

The following code checks all fields of the newly added datasource. The next sample illustrates adding of alias for a newly added datasource.

```C#
private void queryBuilder1_DataSourceAdded(SQLQuery sender, DataSource addedObject)
{
    // Select all fields
    QueryColumnList queryColumnList = addedObject.ParentUnionSubQuery.QueryColumnList;
    queryColumnList.BeginUpdate();

    try
    {
        MetadataSelection<MetadataField> fields = addedObject.Metadata.Fields;

        foreach (MetadataField field in fields)
        {
            QueryColumnListItem queryColumn = queryColumnList.FindField(addedObject, field.Name);

            if (queryColumn == null)
                queryColumn = queryColumnList.AddField(addedObject, field.Name);

            queryColumn.Selected = true;

        }
    }
    finally
    {
        queryColumnList.EndUpdate();
    }
}
```

 

```C#
private void queryBuilder1_DataSourceAdded(SQLQuery sender, DataSource addedObject)
{
    if (addedObject.MetadataObject != null)
    {
        using (AstTokenIdentifier alias = sender.CreateUniqueAlias(addedObject.ParentUnionSubQuery, addedObject.MetadataObject.Name))
        {
            addedObject.Alias = alias.Token;
        }
    }
}
```

------

# How to add objects and joins to the query programmatically?

The following methods of the IQueryController interface (implemented in the SQLQuery class) are intended to add new objects to the query and link them to existing query objects:

-  **AddObject** - adds a database object (table, view or synonym) to the query.
-  **AddObjectFromExpression** - adds a datasource represented by SQL expression (a derived table) to the query.
-  **AddStoredProcedure** - adds a stored procedure to the query (those that can be used in the FROM clause of SELECT statements).
-  **AddLink** - creates a join between two datasources in the query.
-  **AddObjectUI** - adds a database object to the query and creates links as prescribed by the **CreateLinksFromForeignKeys**, **CreateLinksByIdenticalFieldNames** and **AddLinkedObjects **properties.
-  **AddForeignKeyLinksForObject** and **AddIdenticalFieldsLinksForObject** methods add links to the given object from other objects that exist in the query according to the foreign key relationships or by identical field names.

Example:

```C#
public void CreateQuery()
{
    UnionSubQuery unionSubQuery = _query.QueryRoot.FirstSelect();

    // add data source objects into the query
    DataSource ds1 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Customers", "c");
    DataSource ds2 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Orders", "o");
    DataSource ds3 = _query.AddObject(unionSubQuery, "MyDB.MySchema.Resellers", "r");

    // manually create relation between 'Resellers' and 'Orders'
    _query.AddLink(ds3, "ResellerID", ds2, "ResellerID");
}
```

The complete code sample of programmatic SQL query creation can be found in the Non-visual Demo project that's included in the installation package (see the CreateQuery procedure).

------

# How to add the DISTINCT keyword to the query programmatically?

Use the following code to insert the DISTINCT keyword into a query:

 

```C#
SQLSubQuerySelectExpression selexpr = queryBuilder1.ActiveSubQuery.ActiveUnionSubquery.QueryAST;
selexpr.SelectMode = new SQLSubQuerySelectModeDistinct(queryBuilder1.SQLContext);
queryBuilder1.ActiveSubQuery.ActiveUnionSubquery.NotifySQLUpdated();
```

------
# How to rename a table in the query (replace all occurrences) programmatically?

To rename a table in the query, you can iterate through the query datasources and change the name for those of them which refer to this table. The fine point is that you should call the QueryBuilder.Query.**NotifySQLUpdatedRecursive()** method to apply your changes to the query text. The code sample is provided below.

You can learn the basics in the "[Analyzing complex SQL query structure](https://support.activequerybuilder.com/hc/en-us/articles/115001063885-Analyzing-complex-SQL-query-structure-with-unions-and-sub-queries-)" and "[Enumeration of data sources and joins in a sub-query](https://support.activequerybuilder.com/hc/en-us/articles/115001055629-Enumeration-of-data-sources-and-joins-in-a-sub-query)" articles.

```C#
Dictionary renamedDataSources = new Dictionary();
renamedDataSources.Add("old", "new");

queryBuilder1.BeginUpdate();
try
{
	UnionSubQuery firstSelect = queryBuilder1.SQLQuery.QueryRoot.FirstSelect();
	List dataSources = new List();

	firstSelect.FromClause.GetDatasources(dataSources);
	for (int i = 0; i < dataSources.Count; i++)
	{
		DataSourceObject dataSourceObject = dataSources[i] as DataSourceObject;
		if (dataSourceObject != null)
		{
			SQLDatabaseObject databaseObject = dataSourceObject.DatabaseObject;
			string originalDataSourceName = databaseObject.QualifiedName;

			if (renamedDataSources.ContainsKey(originalDataSourceName))
			{
				databaseObject.RemoveLastName();
				databaseObject.AddName(renamedDataSources[originalDataSourceName]);
			}
		}
	}

	queryBuilder1.SQLQuery.NotifyUpdatedRecursive();
}
finally
{
	queryBuilder1.EndUpdate();
}
```

------

# How to change aliases for query output columns programmatically?

The following example adds aliases for the fields of the main query in case an alternate name is defined for a field and its alias is empty.

```C#
UnionSubQuery unionSubQuery = queryBuilder1.SQLQuery.QueryRoot.FirstSelect();

unionSubQuery.BeginUpdate();

try
{
	for (int i = 0; i < unionSubQuery.QueryColumnList.Count; i++)
	{
		QueryColumnListItem ci = unionSubQuery.QueryColumnList[i];

		if (ci.ExpressionField != null) // the criteria item is bound to a metadata field
		{
			if (ci.AliasString.Length == 0 && ci.ExpressionField.AltName.Length > 0)
			{
				ci.AliasString = ci.ExpressionField.AltName;
			}
		}
	}
}
finally
{
	unionSubQuery.EndUpdate();
}
```

------

# Analysing complex SQL query structure (with unions and sub-queries)

Each query or subquery in the query is represented by the **SubQuery** object in Active Query Builder; The main query can be accessed via the **QueryBuilder.SqlQuery.QueryRoot** property.

Each sub-query may be either a single SELECT statement or a set of SELECT statements joined with the UNION, EXCEPT, INTERSECT and other keywords. Each single SELECT statement is represented via the **UnionSubQuery** object.

The UnionSubQuery object holds datasources, their links (**UnionSubQuery.FromClause**), expressions and criteria (**UnionSubQuery.QueryColumnList**) of the single SELECT statement.

There are few useful helpers you can use in your project:

-  The **SubQuery.FirstSelect()** method returns link to the UnionSubQuery object representing the first single SELECT statement in the query.
-  The **QueryBuilder.ActiveUnionSubQuery** property gets the single SELECT statement currently visible to the end-user. The QueryBuilder.ActiveUnionSubQueryChanged event is fired when the user switches to another statement.

The following code collects all SubQuery and UnionSubQuery objects in a query:

```C#
// collect all Sub-queries
var allSubQueries = queryBuilder1.SQLQuery.QueryRoot.GetChildrenRecursive<SubQuery>(true);

// insert the main Query to the beginning of the list
allSubQueries.Insert(0, queryBuilder1.SQLQuery.QueryRoot);

// collect all Union Sub-queries
var allUnionSubQueries = queryBuilder1.SQLQuery.QueryRoot.GetChildrenRecursive<UnionSubQuery>(true);

// collect unions of the main query only
var unionSubQueries = queryBuilder1.SQLQuery.QueryRoot.GetChildrenRecursive<UnionSubQuery>(false);
```

The **Query Structure Demo project** that is shipped together with the full and trial installation packages provides sample code for analyzing query structure and dumping it into a text file.

------
# Enumeration of output columns in a (sub)query

The **UnionSubQuery.QueryColumnsList** collection contains information about SQL query expressions, their properties, and criteria. Each element of this collection has all the necessary properties to read and modify the text of expression, and its alias, ordering, grouping, aggregate function and criteria for this expression. The **QueryColumnListItem.Select** property determines whether an expression is listed in the SELECT list of output expressions.

The ExpressionField and ExpressionDatasource properties refer to the MetadataField and Datasource objects if the expression is a single database object field.

Below are the fragments of the QueryStructureDemo project that included in the installation package. You may review it for more details.

```C#
public void DumpSelectedExpressionsInfoFromUnionSubQuery(StringBuilder stringBuilder, UnionSubQuery unionSubQuery)
{
    // get list of QueryColumnListItems
    QueryColumnList columnsList = unionSubQuery.QueryColumnList;

    // dump all items
    for (int i = 0; i < columnsList.Count; i++)
    {
        QueryColumnListItem columnItem = columnsList[i];

        // only items with the Select property set to True go to SELECT list
        if (!columnItem.Select)
        {
            continue;
        }
        DumpSelectedExpressionInfo(stringBuilder, columnItem);
    }
}

private void DumpSelectedExpressionInfo(StringBuilder stringBuilder, QueryColumnListItem selectedExpression)
{
    // write full sql fragment of selected expression
    stringBuilder.AppendLine(selectedExpression.ExpressionString);

    // write alias
    if (!String.IsNullOrEmpty(selectedExpression.AliasString))
    {
        stringBuilder.AppendLine("  alias: " + selectedExpression.AliasString);
    }

    // write datasource reference (if any)
    if (selectedExpression.ExpressionDatasource != null)
    {
        stringBuilder.AppendLine("  datasource: " + selectedExpression.ExpressionDatasource.GetResultSQL());
    }

    // write metadata information (if any)
    if (selectedExpression.ExpressionField != null)
    {
        MetadataField field = selectedExpression.ExpressionField;
        stringBuilder.AppendLine("  field name: " + field.NameStr);
        string s = Enum.GetName(typeof(DbType), field.FieldType);
        stringBuilder.AppendLine("  field type: " + s);
    }
}
```

------

# Enumeration of data sources and joins in a (sub)query

The **UnionSubQuery.FromClause** object holds the list of SELECT statement datasources and their links.

Below are the fragments of the QueryStructureDemo project that included in the installation package. You may review it for more details.

#### 1. Enumeration of all datasources in a single SELECT statement.

You can get the plain list of datasources using the **GetDatasourceByClass()** method. There are DataSourceObject and DataSourceQuery classes representing database objects and derived tables correspondingly. The DataSourceQuery has the Query property to get access to SubQuery object representing this derived table. The DataSorceObject has MetadataObject property to get access to the database object details.

```C#
public void DumpDataSourcesInfoFromUnionSubQuery(StringBuilder stringBuilder, UnionSubQuery unionSubQuery)
{
    DumpDataSourcesInfo(stringBuilder, GetDataSourceList(unionSubQuery));
}

private void DumpDataSourcesInfo(StringBuilder stringBuilder, ArrayList dataSources)
{
    for (int i = 0; i < dataSources.Count; i++)
    {
        if (stringBuilder.Length > 0)
        {
            stringBuilder.AppendLine();
        }
        DumpDataSourceInfo(stringBuilder, (DataSource)dataSources[i]);
    }
}

private void DumpDataSourceInfo(StringBuilder stringBuilder, DataSource dataSource)
{
    // write full sql fragment
    stringBuilder.AppendLine(dataSource.GetResultSQL());

    // write alias
    stringBuilder.AppendLine("  alias: " + dataSource.Alias);

    // write referenced MetadataObject (if any)
    if (dataSource.MetadataObject != null)
    {
        stringBuilder.AppendLine("  ref: " + dataSource.MetadataObject.FullNameStr);
    }

    // write subquery (if datasource is actually a derived table)
    if (dataSource is DataSourceQuery)
    {
        stringBuilder.AppendLine("  subquery sql: " + ((DataSourceQuery) dataSource).Query.GetResultSQL());
    }

    // write fields
    string fields = String.Empty;
    for (int i = 0; i < dataSource.Fields.Count; i++)
    {
        if (fields.Length > 0)
        {
            fields += ", ";
        }
        fields += dataSource.Fields[i].NameStr;
    }
    stringBuilder.AppendLine("  fields (" + dataSource.Fields.Count.ToString() + "): " + fields);
}

private ArrayList GetDataSourceList(UnionSubQuery unionSubQuery)
{
    ArrayList list = new ArrayList();
    unionSubQuery.FromClause.GetDatasourceByClass(typeof(DataSource), list);
    return list;
}
```

#### 2. Enumeration of all links in a single SELECT statement.

You may get the list of links using the **GetLinksRecursive()** method. Each Link object has references to it's left and right datasources (LeftDatasource, RightDatasource), linked fields (LeftField, RightField) and has properties to read and change it's join type (LeftType, RightType). Link expression is available trough the LinkExpression property.

```C#
public void DumpLinksInfoFromUnionSubQuery(StringBuilder stringBuilder, UnionSubQuery unionSubQuery)
{
    DumpLinksInfo(stringBuilder, GetLinkList(unionSubQuery));
}

private void DumpLinksInfo(StringBuilder stringBuilder, ArrayList links)
{
    for (int i = 0; i < links.Count; i++)
    {
        if (stringBuilder.Length > 0)
        {
            stringBuilder.AppendLine();
        }
        DumpLinkInfo(stringBuilder, (Link) links[i]);
    }
}

private void DumpLinkInfo(StringBuilder stringBuilder, Link link)
{
    // write full sql fragment of link expression
    stringBuilder.AppendLine(link.LinkExpression.SimpleSQL(link.SQLContext.SQLBuilderExpression));

    // write information about left side of link
    stringBuilder.AppendLine("  left datasource: " + link.LeftDatasource.GetResultSQL());
    if (link.LeftType == LinkSideType.Inner)
    {
        stringBuilder.AppendLine("  left type: Inner");
    }
    else
    {
        stringBuilder.AppendLine("  left type: Outer");
    }

    // write information about right side of link
    stringBuilder.AppendLine("  right datasource: " + link.RightDatasource.GetResultSQL());
    if (link.RightType == LinkSideType.Inner)
    {
        stringBuilder.AppendLine("  lerightft type: Inner");
    }
    else
    {
        stringBuilder.AppendLine("  right type: Outer");
    }
}

private ArrayList GetLinkList(UnionSubQuery unionSubQuery)
{
    ArrayList links = new ArrayList();
    unionSubQuery.FromClause.GetLinksRecursive(links);
    return links;
}
```

------

# Determination of presence of the INTO clause in a query

The **SyntaxProvider.DenyIntoClause** property set to true prescribes Active Query Builder to raise an exception on parsing a query with the INTO clause. But sometimes you may want to determine if such clause is present in a query instead of raising an exception. Use the following code to determine it's presence.

```C#
var hasInto = false;

// MySql
if (queryBuilder1.SyntaxProvider is MySQLSyntaxProvider)
{
    var usqList = queryBuilder1.GetUnionSubQueryList();

    foreach (var unionSubQuery in usqList)
    {
        var extender = (MySQLSubQuerySelectExpressionExtender) unionSubQuery.QueryAST.Extender;

        hasInto = extender.IntoFile != null;
        if (hasInto) break;
    }
}

// Access
else if (queryBuilder1.SyntaxProvider is MSAccessSyntaxProvider)
{
    var usqList = queryBuilder1.GetUnionSubQueryList();

    foreach (var unionSubQuery in usqList)
    {
        var extender = (AccessSubQuerySelectExpressionExtender) unionSubQuery.QueryAST.Extender;

        hasInto = extender.Into != null;
        if (hasInto) break;
    }
}

// MS SQL Server
else if (queryBuilder1.SyntaxProvider is MSSQLSyntaxProvider)
{
    var usqList = queryBuilder1.GetUnionSubQueryList();

    foreach (var unionSubQuery in usqList)
    {
        var extender = (MSSQLSubQuerySelectExpressionExtender)unionSubQuery.QueryAST.Extender;

        hasInto = extender.Into != null;
        if (hasInto) break;
    }
}

// PostgreSql
else if (queryBuilder1.SyntaxProvider is PostgreSQLSyntaxProvider)
{
    var usqList = queryBuilder1.GetUnionSubQueryList();

    foreach (var unionSubQuery in usqList)
    {
        var extender = (PostgreSQLSubQuerySelectExpressionExtender)unionSubQuery.QueryAST.Extender;

        hasInto = extender.IntoClause != null;
        if (hasInto) break;
    }
}

MessageBox.Show(hasInto ? "INTO Clause is found" : "INTO Clause isn't found");
```

------

# How to drag an object from the database schema tree to external control?

```C#
private void listBox1_DragOver(object sender, DragEventArgs e)
{
    if (e.Data.GetDataPresent(typeof(DataSourceFieldList)))
    {
        e.Effect = DragDropEffects.Link;
    }
}

private void listBox1_DragDrop(object sender, DragEventArgs e)
{
    if (e.Data.GetDataPresent(typeof(DataSourceFieldList)))
    {
        e.Effect = DragDropEffects.Link;

	DataSourceFieldList fieldListControl = (DataSourceFieldList) e.Data.GetData(typeof(DataSourceFieldList));

        if (fieldListControl.SelectedItem != null)
        {
            if (((TextAndObject) fieldListControl.SelectedItem).obj != null)
            {
                MetadataField field = (MetadataField) ((TextAndObject) fieldListControl.SelectedItem).obj;

                int x = listBox1.Items.Add(field.NameStr + " [" + field.FieldTypeName + "]");

                listBox1.SelectedIndex = x;
            }
        }
    }
}
```

------

# How to add object to the query by dragging from an external control to the query builder?

```c#
private void queryBuilder1_DragOver(object sender, DragEventArgs e)
{
    e.Effect = DragDropEffects.Copy;
}


private void queryBuilder1_DragDrop(object sender, DragEventArgs e)
{
    if (e.Data != null && e.Data.GetDataPresent(typeof(String)))
    {
        String objectName = (String) e.Data.GetData(typeof(String));
        queryBuilder1.ActiveSubQuery.ActiveUnionSubquery.AddObjectWithFKAt(objectName, new Point(e.X, e.Y), "");
    }
}
```

------

# How to add user-defined functions to completion lists of Expression editor and SQL Text editor?

Handle the CustomizeFunctions event and add new functions in the following way:

```C#
   void expressionEditor1_CustomizeFunctions(Dictionary<string, AdvancedKeywordInfo> functions)
   {
       functions.Add(
           "customfunction1", // dictionary key for hashing (lowercase!)
           new AdvancedKeywordInfo(
           // Function display name
               "CustomFunction1",
           // Function template that will be inserted into the text editor cursor position. 
           // May contain %CURSOR% macro to specify new cursor position.
               "CustomFunction1(%CURSOR%)",
           // Function description (displayed in tooltips). Use \n character to split lines up.
        "CustomFunction1(param1, param2)\nFunction description.\nBla Bla..."
        ));

       functions.Add(
           "customfunction2",
           new AdvancedKeywordInfo(
               "CustomFunction2",
               "CustomFunction2(%CURSOR%)",
               "CustomFunction2(param1, param2)\nFunction description.\nBla Bla..."
        ));
   }
```

------

# How to use ErrorProvider with the SQL Text Editor (WinForms)?



```C#
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        queryBuilder1.SyntaxProvider = new MSSQLSyntaxProvider();

        queryBuilder1.MetadataContainer.LoadFromXMLFile("Northwind.xml");
    }

    private void plainTextSQLBuilder1_SQLUpdated(object sender, EventArgs e)
    {
        sqlTextEditor1.Text = plainTextSQLBuilder1.SQL;
    }

    private void sqlTextEditor1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        try
        {
            queryBuilder1.SQL = sqlTextEditor1.Text;
        }
        catch (SQLError exception)
        {
            e.Cancel = true;
            sqlTextEditor1.SetSelection(exception.ErrorPos.pos, exception.ErrorTokenValue.Length);
            errorProvider1.SetError(sqlTextEditor1, exception.Message);
        }
    }

    private void sqlTextEditor1_Validated(object sender, EventArgs e)
    {
        errorProvider1.SetError(sqlTextEditor1, "");
    }
}
```

------

# How to add or remove some of the context menu items? (Winforms Edition 2.0)

To modify the component's context popup menus, you must handle the **ValidateContextMenu** event. The following example demonstrates the addition of a custom menu item in the context menu of data source object.

```C#
using ActiveDatabaseSoftware.ActiveQueryBuilder2;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
        this.queryBuilder1.ValidateContextMenu += new PopupMenuEventHandler(this.ValidateContextMenu);
    }

    private void ValidateContextMenu(Control control, ControlOwner owner, ICustomContextMenu menu)
    {
        // check the menu is from the datasource object
        if (control is DataSourceControl && owner is DataSourceObject)
        {
            // Here you can freely modify the menu adding or removing menu items.
            MenuItem mi = menu.MenuItems.Add("Custom Menu Item", new EventHandler(MenuItem_Click));
            mi.Tag = owner;
        }
    }

    void MenuItem_Click(object sender, EventArgs e)
    {
        DataSourceObject dso = (DataSourceObject)((MenuItem)sender).Tag;
        if (dso.MetadataObject != null)
        {
            MessageBox.Show(dso.MetadataObject.FullNameStr);
        }
    }
}
```

The controlOwner parameter refers to the query object for which the context menu is called. The control parameter refers to the control representing this query object. The following combinations are possible:

-  controlOwner is **Link**; control is LinkControl.
-  controlOwner is **DataSourceObject **or **DataSourceQuery**; control is **DataSourceControl**.
-  controlOwner is **QueryColumnListItem**; control is **QueryColumnListControl**.
-  controlOwner is **UnionSubQuery**; control is **DesignPane**: design pane context menu.
-  controlOwner is **UnionSubQuery**; control is **UnionButton**: context menu of the union button ("Q" button on the navigation bar).
-  controlOwner is **UnionSubQuery**; control is **UnionOperator**: context menu of the union operator (union type symbol on the navigation bar).
-  controlOwner is **UnionGroup**; control is **LeftBracket**: context menu of the left bracket ("(" symbol on the navigation bar).
-  controlOwner is **UnionGroup**; control is **RightBracket**: context menu of the right bracket (")" symbol on the navigation bar).

------

# How to implement custom sorting of the fields inside datasources? (Winforms Edition 2.0)

The following code implements custom sorting of fields by description, having fields without descriptions at the bottom.

```C#
private void queryBuilder1_CustomizeDatasourceFieldList(QueryBuilder queryBuilder, DataSource datasource, MetadataFieldList fieldList)
{
       fieldList.Sort(new SortFieldsByDescriptionComparer());
}

private class SortFieldsByDescriptionComparer: IComparer
{
       int IComparer.Compare(MetadataCollectionItemBase qn1, MetadataCollectionItemBase qn2)
       {
               MetadataField f1 = (MetadataField) qn1;
               MetadataField f2 = (MetadataField) qn2;

               int result = String.Compare(f1.ShortDescription, f2.ShortDescription, true);

               if (result == 0)
               {
                       result = String.Compare(f1.AltName, f2.AltName, true);

                       if (result == 0)
                       {
                               result = String.Compare(f1.NameStr, f2.NameStr, true);
                       }
               }
               return result;
       }
}
```

------

# How to implement custom drawing of the fields inside datasources? (Winforms Edition 2.0)

The following code implements custom drawing of the fields inside datasources. It instructs to display field's alternate name if it's not empty; otherwise to display field name.

```C#
void queryBuilder1_FieldListDrawItem(Graphics g, Rectangle rect, DrawItemState state, MetadataField field, ref bool handled)
{
       Brush bgBrush;
       Color textColor;
       String s = String.Empty;

       if ((state & DrawItemState.Selected) == DrawItemState.Selected)
       {
               bgBrush = SystemBrushes.Highlight;
               textColor = SystemColors.HighlightText;
       }
       else
       {
               bgBrush = new SolidBrush(Color.LightYellow);
               textColor = Color.MediumSeaGreen;
       }

       rect.X -= rect.Height;
       rect.Width += rect.Height;

       g.FillRectangle(bgBrush, rect);

       if (field != null)
       {
               if (!String.IsNullOrEmpty(field.AltName) && queryBuilder1.UseAltNames)
               {
                       s = field.AltName;
               }
               else
               {
                       s = field.Name.QualifiedNameWithoutQuotes;
               }
       }
       else
       {
               s = "*";
       }

       TextRenderer.DrawText(g, s, new Font("Arial", 8, FontStyle.Bold), rect.Location, textColor);

       if ((state & DrawItemState.Focus) == DrawItemState.Focus)
       {
               ControlPaint.DrawFocusRectangle(g, rect);
       }
       handled = true;
}
```

------

# How to trap the KeyDown and KeyPress events for the SqlTextEditor?

Handle the **PreProcessKey **and **PostProcessKey **events instead.
Use the PreProcessKey if you need to override the default key behavior; use the PostProcessKey if you just need to perform an additional action on pressing some key.

------

# Active Query Builder for .NET 3.3 release notes

We are glad to announce the new version of Active Query Builder for .NET!

With the possibility of decomposition of the user interface, which has been added in the version 3.0, it is possible to build a composite user interface. For example, you can separate the database schema browsing UI from the SQL query building UI. Or you can combine the SQL text editor with the visual query building UI, giving the user the ability to edit the text of each sub-query apart from the entire query. This release is dedicated to the rethinking of the old features in a new way.

1. Improvements in the User Queries API.

   Previously, to edit the text of the saved user query, the user had to abandon the currently edited query, and the programmer could not keep track of this transition.

   -  Now when the user selects the query editing command, the **UserQueriesView.EditUserQuery**event is triggered, in which the developer can save the current query before opening the new one, or he can open the user query in a new window, the way it's done in the updated Full-featured demo project. Also, the events are now fired on deleting, renaming and moving user queries between the folders. You can review all API changes in the release notes article.
   -  The new helper class **Core.UserQueries** that consists of static methods has been added to perform various manipulations with user queries, such as adding, saving, moving, renaming them. It also has the means to save and load user queries serialized in XML format.
   -  The updated Professional Full-Featured demo project illustrates the new functionality.

2. Editing Sub-query text apart from the entire query is possible now.

   The component's API has allowed editing the text of a subquery long ago. The problem is that the text of the query modified by the user may have syntax errors, and the component lets switch to another subquery at any time. The erroneous text can not be saved, as it has to be parsed and translated into an object representation. In order not to lose the user changes when switching between subqueries, the component must be able to block this switch to inform the user of the error and offer ways out of the situation.

   -  The new **ActiveUnionSubQueryChanging** event has been added to the QueryView and QueryBuilder components. The programmer can deny switching between sub-queries in this event handler by setting the e.Abort parameter to true.
   -  The new SubQueryBreadcrumbsBar control has been made to display path from the main query to the currently active sub-query. It helps quickly switch to parent sub-queries.
   -  The new Sub-Query Text Editing demo project has been added to illustrate the new functionality.

3. Miscellaneous improvements.

   -  The data browsing UI is improved in the Full-featured demo project. It now uses the Query Transformer API to modify SQL queries.
   -  The new **MetadataLoadingOptions.AllowRecursiveVirtualObjects** property allows specifying the mode of working with virtual objects. By default, referring to other virtual objects in the text of a virtual object is allowed. Such reference lets build a chain of objects to break complex queries in a series of simple ones. However, in this mode, you can't use the same-named physical object in a virtual object because of the emerging recursion. Setting this property to false prohibits creation chains of virtual objects, but allows to create virtual objects that substitute physical database objects.
   -  Query Statistics: The UsedDatabaseObjects and UsedDatabaseObjectFields collections now include invalid objects and fields being used in the query. They differ from valid objects by the absence of MetadataObject (for objects) and MetadataField (for fields) references. Such inclusion lets [detect incorrect objects and fields in the query](https://support.activequerybuilder.com/hc/en-us/articles/115001055249). 
   -  Usability of the Expression Editor is improved now with the new dockable panels.
   -  SQL Text Editor with syntax highlighting is used now to edit joining expression in the Properties bar and dialog.
   -  Now it's possible to select multiple rows and drag them to reorder columns in the SELECT list.
   -  WinForms DevExpress UI: Query Columns Grid has been remade with DevExpress controls.
   -  The new SQLite metadata provider has been added.
   -  The Query Structure demo project has been refactored.
   -  Removal of unused objects from the query when the QueryBuilder.BehaviorOptions.DeleteUnusedObjects property is turned to True has been fixed.

4. SQL syntax improvements.

   -  IBM DB2: The ListAgg function is supported now.
   -  PostgreSQL: Support of materialized view, TOAST tables and foreign tables has been made.
   -  Oracle: Support of the "AT TIME ZONE" clause has been added.
   -  Firebird: Column name definition after alias in the FROM clause is supported now.

5. API changes and improvements.

   The new


   ActiveUnionSubQueryChanging 

   event has been added to the QueryBuilder and QueryView controls:

   ```C#
   // Fired when active union sub-query is about to be changed. Changing can be canceled by setting the e.Abort parameter to True.
   SubQueryChangingEventHandler ActiveUnionSubQueryChanging 

   SubQueryChangingEventHandler(object sender, SubQueryChangingEventArgs e)
       SubQueryChangingEventArgs : EventArgs
       {
           public object Tag
           public bool Abort
           public UnionSubQuery OldSubQuery
           public UnionSubQuery NewSubQuery
       }
   ```

   The new

​    

   AllowRecursiveVirtualObjects 

   property has been added to the MetadataLoadingOptions group:

   ```C#
   // Lets use virtual object names in SQL expressions of other virtual entities.
   bool AllowRecursiveVirtualObjects
   ```

   The new **UserQueries **helper class with low-level static methods to handle user queries has been added to the Core assembly:

   ```C#
   // Lets determine if an item is a folder or not.
   bool IsFolder (MetadataStructureItem item) 

   // Adds new user query.
   MetadataStructureItem AddUserQuery (MetadataContainer metadataContainer, MetadataStructureItem parentFolder, string name, string query, int imageIndex = -1, string layout = null) 
   // Adds new folder.
   MetadataStructureItem AddFolder (MetadataStructureItem parentFolder, string name, int imageIndex = -1) 
   // Replaces the user query content with the new SQL string and layout.
   void SaveUserQuery (MetadataContainer metadataContainer, MetadataStructureItem userQuery, string query, string layout = null)

   // Moves the query to the specified folder.
   MetadataStructureItem MoveUserQuery (MetadataStructureItem userQuery, MetadataStructureItem destinationFolder) 
   // Moves the folder into another folder as a subfolder.
   MetadataStructureItem MoveFolder (MetadataStructureItem folder, MetadataStructureItem destinationFolder) 

   // Sets the given name for the query.
   void RenameUserQuery (MetadataContainer metadataContainer, MetadataStructureItem userQuery, string newName)
   // Sets the given name for the folder.
   void RenameFolder (MetadataStructureItem folder, string newName) 
   // Deletes the query.
   MetadataObject RemoveUserQuery (MetadataContainer metadataContainer, MetadataStructureItem userQuery) 
   // Deletes the folder and all of it's queries and subfolders.
   void RemoveFolder (MetadataContainer metadataContainer, MetadataStructureItem folder) 

   // Saves the queries and their tree structure to file identified by the fileName parameter.
   void ExportToXML (MetadataContainer metadataContainer, MetadataStructure metadataStructure, string fileName) 
   // Saves the queries and their tree structure to the stream.
   void ExportToXML (MetadataContainer metadataContainer, MetadataStructure metadataStructure, stream stream) 

   // Loads the queries and their tree structure from file identified by the fileName parameter.
   void ImportFromXML (MetadataContainer metadataContainer, MetadataStructure metadataStructure, string fileName) 
   // Loads the queries and their tree structure from the stream.
   void ImportFromXML (MetadataContainer metadataContainer, MetadataStructure metadataStructure, stream stream)
   ```

   DatabaseSchemaView

   :

   ```C#
   // Instructs to expand and scroll the view to display the given item
   void BringIntoItem (MetadataStructureItem item) 
   // Turns the view into edit mode to change caption of the given item.
   void EditItem (MetadataStructureItem item)  
   // Returns the tree view control node of the given metadata structure item.
   TreeViewItem GetItemNode (MetadataStructureItem item) 

   // Fired when the item caption is about to be edited. Editing can be denied by setting the args.Abort parameter to True.
   TreeViewStructureItemAcknowledgement BeforeItemCaptionEdit 
   // Fired when editing of the item caption is about to be finished. Editing can be continued by setting the args.Abort parameter to True.
   TreeViewStructureItemAcknowledgement AfterItemCaptionEdit 
   // Fired when the item caption has been changed.
   TreeViewStructureItemNotification ItemCaptionChanged 

   // Fired when selected item has been changed.
   TreeViewStructureItemNotification SelectedItemChanged 
   // Fired when the item context menu is about to be displayed.
   TreeViewStructureItemContextMenuValidation ValidateItemContextMenu
   ```

   **UserQueriesView**:

   ```C#
   // Holds the caption string in the view header.
   string Title 
   // Indicates the currently selected item in the view.
   MetadataStructureItem SelectedItem 

   // Gets the reference to the MetadataStructure object which keeps the tree structure of items in the view.
   MetadataStructure MetadataStructure 
   // Gets or sets the reference to the query view control to which a query will be added on double clicking on it in this view.
   QueryView QueryView 

   // Determines whether the user can rename queries and folders in the view.
   bool AllowEditUserQueries 
   // Determines the visibility of buttons to save the currently edited query in the query view as a new or existing query.
   bool DisplaySaveButtons

   // Expands the item and scrolls the view to make it visible.
   void BringIntoItem ( MetadataStructureItem item ) 

   // Fired when the user selects the Edit Query command from the toolbar or the context menu.
   event TreeViewStructureItemNotification EditUserQuery 

   // Fired when the user has renamed a query or a folder in the view.
   event TreeViewStructureItemNotification UserQueryItemRenamed 

   // Fired when the user is about to delete an item from the view. Removal can be canceled by setting the args.Abort parameter to True.
   event TreeViewStructureAcknowledgement UserQueryItemRemoving 

   // Fired when the user has removed a query or folder in the view.
   event TreeViewStructureItemNotification UserQueryItemRemoved 

   // Fired when the user drops an item (query or folder) to a folder to reorganize the tree. Action can be canceled by setting the args.Abort parameter to True.
   event TreeViewStructureDragDropAcknowledgement UserQueryItemDragDrop 

   // Fired when the view is about to show the error message. By handling this event, you take responsibility for displaying error messages.
   event ErrorNotificationEventHandler ErrorMessage 

   // Fired when the context menu is about to be shown for the item. You can change this menu by altering the referred menu object.
   event TreeViewStructureItemContextMenuValidation ValidateItemContextMenu 

   // Saves the queries and their tree structure to file identified by the fileName parameter.
   void ExportToXML (string fileName) 
   // Saves the queries and their tree structure to the stream.
   void ExportToXML (stream stream) 
   // Loads the queries and their tree structure from the file identified by the fileName parameter.
   void ImportFromXML (string fileName) 
   // Loads the queries and their tree structure from the stream.
   void ImportFromXML (stream stream)
   ```

   Event types:

   ```C#
   ErrorNotificationEventHandler (object sender, Exception exception)

   TreeViewStructureItemNotification (object sender, MetadataStructureItem item)

   TreeViewStructureItemContextMenuValidation (object sender, MetadataStructureItem item, ICustomContextMenu& menu)

   TreeViewStructureItemAcknowledgement (object sender, EditItemCaptionArgs args)
       public class EditItemCaptionArgs: EventArgs
       {
           public MetadataStructureItem Item
           public string OldCaption
           public string NewCaption
           public bool Abort
       }

   TreeViewStructureDragDropAcknowledgement (object sender, TreeViewStructureDragDropArgs args);
       public class TreeViewStructureDragDropArgs : EventArgs
       {
           public MetadataStructureItem DraggedItem
           public MetadataStructureItem TargetItem
           public bool Abort
       }
   ```

------

# WinForms: Using the Dock Manager to setup layout of the query building area

It's easy to manage dock panels right from the Visual Studio form designer. Just add the **DockManager **control on a form and click the Tasks button in the top-right corner of the control:

![dock1.png](https://support.activequerybuilder.com/hc/article_attachments/115002325105/dock1.png)

The new **DockPanel **will be added and displayed on the side strip as a tab. You can click on the tab to expand the panel. After that, you can place any control on the panel.

![dock2.png](https://support.activequerybuilder.com/hc/article_attachments/115002325125/dock2.png)

Set the **AutoHide **and **Position **properties of DockPanel to tune its initial state.

You can add as many side panels as you wish:

![dock3.png](https://support.activequerybuilder.com/hc/article_attachments/115002325165/dock3.png)

To delete a panel, click on its header and press the Del key.

The user will be able to change panels state, i.e. to pin a panel or to drag it to another docking position. Read and write the DockManager.**DockPanelsLayoutXML **property to save and load the current panels state to keep it between work sessions.

 

The code sample below creates the SQLText Editor control as a hideable bottom dock panel beneath the Design Pane.

```C#
using ActiveQueryBuilder.View.WinForms;using ActiveQueryBuilder.View.WinForms.DockPanels;
using ActiveQueryBuilder.View.WinForms.QueryView;

DockManager dockManager = new DockManager();

dockManager.Controls.Add(new DesignPaneControl());

DockPanel dockPanel = new DockPanel();

dockPanel.Text = "SQL";
dockPanel.Docking = Docking.Bottom;
dockPanel.AutoHide = false;
dockPanel.Controls.Add(this.sqlTextEditor1);

dockManager.DockPanels.Add(dockPanel);
```

------

# Active Query Builder 3 migration guide

Installation of the Active Query Builder 3 .NET Edition does not affect on the installation of the previous major version so that they can be installed simultaneously.

Active Query Builder 3 Professional Edition lets create your visual query building environment in two ways. The first way is to use the all-in-one QueryBuilder control that has all the necessary means to build SQL queries visually. This way is identical to what we had in the version 2.x, and hopefully, it is suitable for the majority of the users. Those users who want to customize visual query building interface deeper should have a look at the separated controls mode, described in [another article](https://support.activequerybuilder.com/hc/en-us/articles/115001055349-Getting-started-with-AQB-NET-3-in-the-Separated-Controls-UI-or-Non-visual-mode). This article describes the main changes in code that you need to take care of while migrating from AQB 2.x to AQB 3 in standard mode.

#### Assemblies

The "ActiveDatabaseSoftware." assembly prefix has been removed, all Active Query Builder assembly names now start with the "ActiveQueryBuilder." prefix.

The ActiveDatabaseSoftware.ActiveQueryBuilder2.dll assembly doesn't exist anymore. It has been split into three parts: ActiveQueryBuilder.Core.dll (non-visual SQL query engine), ActiveQueryBuilder.View.dll (UI controllers) and separate libraries for each platform and UI controls library: ActiveQueryBuilder.View.Winforms.dll, ActiveQueryBuilder.View.Wpf.dll (there will be more assemblies of this family there: for DevExpress controls, may be for some of the Mono GUI toolkits, etc.).

#### New Non-visual components

There are two new non-visual components you should use if you don't need to build SQL queries visually, but only need to parse, analyze and modify SQL queries. They also must be created to work in the Separated controls UI mode.

The new **SqlContext** component implements the SQL parsing, and SQL text generation logic holds the link to Syntax Provider object that determines SQL syntax rules of specific SQL dialect. It also contains the MetadataContainer and MetadataStructure objects to store information about database schema and holds the link to Metadata Provider object that establishes a connection to the database.

The new **SqlQuery** component implements SQL query building logic and contains the internal object representation of a query.

The SqlContext object could be shared among multiple SqlQuery objects which may be connected to different instances of visual query building UI controls in their turn. This way the programmer can quickly implement a multi-document interface to build several SQL queries in separate windows.

#### PlainTextSQLBuilder

The **PlainTextSQLBuilder** component has been deleted. Its functionality has been embedded in the QueryBuilder component. The new QueryBuilder.**SQLFormattingOptions** group of properties has been added to setup the rules of result SQL query text formatting. The new QueryBuilder **FormattedSQL**property returns formatted SQL query text.

If you need more than one set of SQL generation and formatting properties (in the case of using Alternate Names or Virtual Objects), you can create a separate instance of SqlFormattingOptions or SqlGenerationObjects and get SQL text as described in [this article](https://support.activequerybuilder.com/hc/en-us/articles/115001063385-How-to-get-formatted-SQL-text-and-setup-formatting-options-).

#### QueryBuilder

-  The **OfflineMode** property has been moved to the QueryBuilder.MetadataLoadingOptions group.
-  The **QueryStructureTreeOptions** property has been temporarily deleted as the Query Structure Tree is not implemented yet in the current beta version of AQB 3.
-  The **AddObjectFormOptions** property has been renamed to **AddObjectDialogOptions**.
-  The **DatabaseSchemaTreeOptions** has been renamed to **DatabaseSchemaViewOptions**.
-  The SQLGenerationOptions.**QuoteAllIdentifiers** boolean property has been replaced by the SQLGenerationOptions.**QuoteIdentifiers** that accepts three values: None, All and IfNeeded (default).

##### QueryBuilder.PanesConfigurationOptions

-  The **LeftTreePaneVisible**, **RightTreePaneVisible** and **SwapTrees** properties have been deleted.
-  The **UnionNavBarVisible** property has been deleted. The functionality of the Union Navigation Bar is moved to the Query Navigation Bar.
-  The **QueryNavigationBarVisible** has replaced the **SubQueryTabsVisible** property.

#### QueryTransformer

The **QueryProvider** property has replaced the **QueryBuilder** and **SqlBuilder** properties. You can assign an instance of the QueryBuilder or SqlQuery object to this property.

#### SqlTextEditor

The **QueryProvider** property has replaced the **QueryBuilder** and **SyntaxProvider** properties. You can assign an instance of the QueryBuilder or SqlQuery object to this property.

------

