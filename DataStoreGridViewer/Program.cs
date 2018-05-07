namespace DataStoreGridViewer
{
   static class Program
   {
      [System.STAThread]
      static void Main()
      {
         System.Windows.Forms.Application.EnableVisualStyles( );
         System.Windows.Forms.Application.SetCompatibleTextRenderingDefault( false );

         DevExpress.UserSkins.BonusSkins.Register( );
         DevExpress.Skins.SkinManager.EnableFormSkins( );

         //dsColl = AQBTest.DataStoreCollection.Load( AQBTest.Global.DataStoreCollectionFilePathName );
         dsColl = new AQBTest.DataStoreCollection();
         {
            AQBTest.DataStoreXtraForm o = new AQBTest.DataStoreXtraForm( dsColl );
            System.Windows.Forms.Application.Run( o );
         }
         dsColl.Save( TS_STR + '.' + AQBTest.Global.DataStoreCollectionFileName );
         CreateToastNotificationsManager( );
         PullRemotely( dsColl );
      }

      private static AQBTest.DataStoreCollection dsColl;
      private static string TS_STR = @"D:\TEMP\SQLite\" + AQBTest.DataStore.TS_STR.Replace( ":", "" );
      public static void PullRemotely( AQBTest.DataStoreCollection dsColl )
      {
         dsColl = dsColl ?? throw new System.ArgumentNullException( nameof( dsColl ) );
         for( int i = 0; i < dsColl.List.Count; i++ )
         {
            AQBTest.DataStore ds = dsColl.List[ i ];
            if( !ds.IsActive )
            {
               continue;
            }
            if( ds.IsToPullRemotely )
            {
               #region --- ??? ---
               TS_STR = @"D:\TEMP\SQLite\" + AQBTest.DataStore.TS_STR.Replace( ":", "" );
               if( ds.NotificationWhenStarted )
               {
                  DevExpress.XtraBars.ToastNotifications.ToastNotification tn = CreateToastNotification( ds );
                  tn.Header = "Starting: " + ds.Name;
                  tn.Body = ds.AqbQbFilename;
                  tn.Body2 = ds.MiFqnFilename;
                  tnm.ShowNotification( tn );
               }
               switch( (AQBTest.DataStore.SyntaxProviderEnum) ds.SyntaxProvider )
               {
                  case AQBTest.DataStore.SyntaxProviderEnum.SQLITE:
                     DumpSQLite( ds );
                     break;
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_SQL_SERVER_2014:
                     DumpMSSQL( ds );
                     break;
                  case AQBTest.DataStore.SyntaxProviderEnum.AUTO:
                  case AQBTest.DataStore.SyntaxProviderEnum.GENERIC:
                  case AQBTest.DataStore.SyntaxProviderEnum.ANSI_SQL_2003:
                  case AQBTest.DataStore.SyntaxProviderEnum.ANSI_SQL_89:
                  case AQBTest.DataStore.SyntaxProviderEnum.ANSI_SQL_92:
                  case AQBTest.DataStore.SyntaxProviderEnum.FIREBIRD_1_0:
                  case AQBTest.DataStore.SyntaxProviderEnum.FIREBIRD_1_5:
                  case AQBTest.DataStore.SyntaxProviderEnum.FIREBIRD_2_0:
                  case AQBTest.DataStore.SyntaxProviderEnum.FIREBIRD_2_5:
                  case AQBTest.DataStore.SyntaxProviderEnum.IBM_DB2:
                  case AQBTest.DataStore.SyntaxProviderEnum.IBM_INFORMIX_10:
                  case AQBTest.DataStore.SyntaxProviderEnum.IBM_INFORMIX_8:
                  case AQBTest.DataStore.SyntaxProviderEnum.IBM_INFORMIX_9:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_ACCESS_2000_:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_ACCESS_2003_:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_ACCESS_97_:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_ACCESS_XP_:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_SQL_SERVER_2000:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_SQL_SERVER_2005:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_SQL_SERVER_2008:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_SQL_SERVER_2012:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_SQL_SERVER_7:
                  case AQBTest.DataStore.SyntaxProviderEnum.MS_SQL_SERVER_COMPACT_EDITION:
                  case AQBTest.DataStore.SyntaxProviderEnum.MYSQL_3_XX:
                  case AQBTest.DataStore.SyntaxProviderEnum.MYSQL_4_0:
                  case AQBTest.DataStore.SyntaxProviderEnum.MYSQL_4_1:
                  case AQBTest.DataStore.SyntaxProviderEnum.MYSQL_5_0:
                  case AQBTest.DataStore.SyntaxProviderEnum.ORACLE_10:
                  case AQBTest.DataStore.SyntaxProviderEnum.ORACLE_11:
                  case AQBTest.DataStore.SyntaxProviderEnum.ORACLE_7:
                  case AQBTest.DataStore.SyntaxProviderEnum.ORACLE_8:
                  case AQBTest.DataStore.SyntaxProviderEnum.ORACLE_9:
                  case AQBTest.DataStore.SyntaxProviderEnum.POSTGRESQL:
                  case AQBTest.DataStore.SyntaxProviderEnum.SYBASE_ASE:
                  case AQBTest.DataStore.SyntaxProviderEnum.SYBASE_SQL_ANYWHERE:
                  case AQBTest.DataStore.SyntaxProviderEnum.TERADATA:
                  case AQBTest.DataStore.SyntaxProviderEnum.VISTADB:
                  default:
                     break;
               } // switch(...) ...
               if( ds.NotificationWhenFinished )
               {
                  DevExpress.XtraBars.ToastNotifications.ToastNotification tn = CreateToastNotification( ds );
                  tn.Header = "Finished: " + ds.Name;
                  tn.Body = ds.AqbQbFilename;
                  tn.Body2 = ds.MiFqnFilename;
                  tnm.ShowNotification( tn );
               }
               #endregion
            } // if( ... ) ...
         } // for( ;; ) ...
      }

      #region --- MSSQL... ---
      private static ActiveQueryBuilder.View.WinForms.QueryBuilder DumpMSSQL( AQBTest.DataStore ds )
      {
         ActiveQueryBuilder.View.WinForms.QueryBuilder qb = CreateQueryBuilderMSSQL( ds );
         Dump( qb, ds );
         return qb;
      }

      private static ActiveQueryBuilder.View.WinForms.QueryBuilder CreateQueryBuilderMSSQL( AQBTest.DataStore ds )
      {
         return CreateQueryBuilderMSSQL( ds.ConnectionString, ds.LoadDefaultDatabaseOnly, ds.LoadSystemObjects, ds.WithFields );
      }

      public static ActiveQueryBuilder.View.WinForms.QueryBuilder CreateQueryBuilderMSSQL(
         string connectionString,
         bool loadDefaultDatabaseOnly,
         bool loadSystemObjects,
         bool withFields
      )
      {
         ActiveQueryBuilder.View.WinForms.QueryBuilder qb = new ActiveQueryBuilder.View.WinForms.QueryBuilder( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.MSSQLMetadataProvider( )
         };
         qb.MetadataProvider.Connection = new System.Data.SqlClient.SqlConnection( connectionString );
         {
            ActiveQueryBuilder.Core.MetadataLoadingOptions loadingOptions = qb.SQLContext.MetadataContainer.LoadingOptions;
            loadingOptions.LoadDefaultDatabaseOnly = loadDefaultDatabaseOnly;
            loadingOptions.LoadSystemObjects = loadSystemObjects;
            //loadingOptions.IncludeFilter.Types = MetadataType.Field;
            //loadingOptions.ExcludeFilter.Schemas.Add("dbo");
         }
         //qb.InitializeDatabaseSchemaTree();
         //qb.MetadataContainer.LoadAll(withFields);
         return qb;
      } // createQueryBuilder(...)
      #endregion

      #region --- SQLite... ---
      private static ActiveQueryBuilder.View.WinForms.QueryBuilder DumpSQLite( AQBTest.DataStore ds )
      {
         ActiveQueryBuilder.View.WinForms.QueryBuilder qb = CreateQueryBuilderSQLite( ds );
         Dump( qb, ds );
         return qb;
      }

      private static ActiveQueryBuilder.View.WinForms.QueryBuilder CreateQueryBuilderSQLite( AQBTest.DataStore ds )
      {
         return CreateQueryBuilderSQLite( ds.ConnectionString, ds.LoadDefaultDatabaseOnly, ds.LoadSystemObjects, ds.WithFields );
      }

      public static ActiveQueryBuilder.View.WinForms.QueryBuilder CreateQueryBuilderSQLite(
         string connectionString,
         bool loadDefaultDatabaseOnly,
         bool loadSystemObjects,
         bool withFields
      )
      {
         ActiveQueryBuilder.View.WinForms.QueryBuilder qb = new ActiveQueryBuilder.View.WinForms.QueryBuilder( )
         {
            SyntaxProvider = new ActiveQueryBuilder.Core.SQLiteSyntaxProvider( ),
            MetadataProvider = new ActiveQueryBuilder.Core.SQLiteMetadataProvider( )
         };
         qb.MetadataProvider.Connection = new System.Data.SQLite.SQLiteConnection( connectionString );
         {
            ActiveQueryBuilder.Core.MetadataLoadingOptions loadingOptions = qb.SQLContext.MetadataContainer.LoadingOptions;
            loadingOptions.LoadDefaultDatabaseOnly = loadDefaultDatabaseOnly;
            loadingOptions.LoadSystemObjects = loadSystemObjects;
            //loadingOptions.IncludeFilter.Types = MetadataType.Field;
            //loadingOptions.ExcludeFilter.Schemas.Add("dbo");
         }
         qb.InitializeDatabaseSchemaTree( );
         qb.MetadataContainer.LoadAll( withFields );
         return qb;
      } // createQueryBuilder(...)
      #endregion

      private static void Dump( ActiveQueryBuilder.View.WinForms.QueryBuilder qb, AQBTest.DataStore ds )
      {
         string fnAqbQbFilename = TS_STR + "." + ds.AqbQbFilename;
         string fnMiFqnFilename = TS_STR + "." + ds.MiFqnFilename;
         {
            // Export AQB's Query Builder XML Structures...
            //string xmlStr = qb.MetadataContainer.XML;
            qb.MetadataContainer.ExportToXML( fnAqbQbFilename );
            // qb.MetadataContainer.ImportFromXML( filename );
         }
         {
            // Export MetadataItem FQN Collection...
            AQBTest.MetadataItemFQNCollection o = new AQBTest.MetadataItemFQNCollection( );
            o.List = BuildBindingList( qb );
            o.Save( fnMiFqnFilename );
         }
      }

      #region --- EXTRACT METADATA VALUES ---
      private class StackItem
      {
         public ActiveQueryBuilder.Core.MetadataList list;
         public int index;
         public int parentID;
         public int grandParentID;
      }
      private static System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> BuildBindingList(
         ActiveQueryBuilder.View.WinForms.QueryBuilder qb
         )
      {
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list = new System.ComponentModel.BindingList<AQBTest.MetadataItemFQN>( );
         using( var sqlContext = new ActiveQueryBuilder.Core.SQLContext( ) )
         {
            sqlContext.Assign( qb.SQLContext );
            //sqlContext.MetadataContainer.LoadingOptions.LoadDefaultDatabaseOnly = false;
            //sqlContext.MetadataContainer.LoadingOptions.LoadSystemObjects = false;

            using( ActiveQueryBuilder.Core.MetadataList miList = new ActiveQueryBuilder.Core.MetadataList( sqlContext.MetadataContainer ) )
            {
               miList.Load( ActiveQueryBuilder.Core.MetadataType.All, true );
               System.Collections.Generic.Stack<StackItem> stack = new System.Collections.Generic.Stack<StackItem>( );
               stack.Push( new StackItem { list = miList, index = 0, parentID = -1, grandParentID = -1 } );
               do
               {
                  StackItem si = stack.Pop( );
                  ActiveQueryBuilder.Core.MetadataList actualMIList = si.list;
                  int actualIndex = si.index;
                  int actualParentID = si.grandParentID; // IMPORTANT!!!
                  {
                     for( ; actualIndex < actualMIList.Count; actualIndex++ )
                     {
                        ExtractMetadataItem( list, actualMIList[ actualIndex ], actualParentID );
                        if( actualMIList[ actualIndex ].Items.Count > 0 ) // branch...
                        {
                           // Push the "next" Item...
                           stack.Push( new StackItem
                           {
                              list = actualMIList,
                              index = actualIndex + 1,
                              parentID = list[ list.Count - 1 ].ID,
                              grandParentID = actualParentID
                           } );
                           // Reset the loop to process the "actual" Item...
                           actualParentID = list[ list.Count - 1 ].ID;
                           actualMIList = actualMIList[ actualIndex ].Items;
                           actualIndex = -1;
                        }
                     } // for(;;)...
                  }
               } while( stack.Count > 0 );
            } // using()...
         } // using()...
         return list;
      } // buildBindingList(...)

      private static void ExtractMetadataItem(
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list,
         ActiveQueryBuilder.Core.MetadataItem mi,
         int parentID
         )
      {
         if( mi == null ) return;
         switch( mi.Type )
         {
            case ActiveQueryBuilder.Core.MetadataType.Root:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Server:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Database:
               ExtractNamespace( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Schema:
               ExtractNamespace( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Package:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Namespaces:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Table:
               ExtractTable( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.View:
               ExtractTable( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Procedure:
               ExtractProcedure( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Synonym:
               ExtractSynonym( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Objects:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Aggregate:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Parameter:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.Field:
               ExtractField( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.ForeignKey:
               ExtractForeignKey( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.ObjectMetadata:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.UserQuery:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.UserField:
               ExtractItem( list, mi, parentID );
               break;
            case ActiveQueryBuilder.Core.MetadataType.All:
               ExtractItem( list, mi, parentID );
               break;
            default:
               ExtractItem( list, mi, parentID );
               break;
         } // switch()...
      }
      private static void ExtractProcedure(
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list,
         ActiveQueryBuilder.Core.MetadataItem mi,
         int parentID
         )
      {
         if( mi == null ) return;
         var o = ExtractItem( list, mi, parentID );
         {
            ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
         }
      }
      private static void ExtractSynonym(
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list,
         ActiveQueryBuilder.Core.MetadataItem mi,
         int parentID
         )
      {
         if( mi == null ) return;
         var o = ExtractItem( list, mi, parentID );
         {
            ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
            o.ReferencedObject = m.ReferencedObject?.NameFull;
            //
            for( int i = 0; i < m.ReferencedObjectName.Count; i++ )
            {
               ActiveQueryBuilder.Core.MetadataQualifiedNamePart x = m.ReferencedObjectName[ i ];
               o.ReferencedObjectName += "["
               + System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), x.Type )
               + ":"
               + x.Name
               + "]"
            ;
            }
         }
      }
      private static void ExtractNamespace(
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list,
         ActiveQueryBuilder.Core.MetadataItem mi,
         int parentID
         )
      {
         if( mi == null ) return;
         var o = ExtractItem( list, mi, parentID );
         {
            ActiveQueryBuilder.Core.MetadataNamespace m = mi as ActiveQueryBuilder.Core.MetadataNamespace;
         }
      }
      private static void ExtractTable(
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list,
         ActiveQueryBuilder.Core.MetadataItem mi,
         int parentID
         )
      {
         if( mi == null ) return;
         var o = ExtractItem( list, mi, parentID );
         {
            ActiveQueryBuilder.Core.MetadataObject m = mi as ActiveQueryBuilder.Core.MetadataObject;
         }
      }
      private static void ExtractForeignKey(
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list,
         ActiveQueryBuilder.Core.MetadataItem mi,
         int parentID
         )
      {
         if( mi == null ) return;
         var o = ExtractItem( list, mi, parentID );
         o.FieldType = null;
         {
            ActiveQueryBuilder.Core.MetadataForeignKey m = mi as ActiveQueryBuilder.Core.MetadataForeignKey;
            o.ReferencedObject = m.ReferencedObject.NameFull;
            //
            for( int i = 0; i < m.ReferencedObjectName.Count; i++ )
            {
               ActiveQueryBuilder.Core.MetadataQualifiedNamePart x = m.ReferencedObjectName[ i ];
               o.ReferencedObjectName += "["
               + System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), x.Type )
               + ":"
               + x.Name
               + "]"
            ;
            }
            //
            o.ReferencedFieldsCount = m.ReferencedFields.Count;
            for( int i = 0; i < m.ReferencedFields.Count; i++ )
            {
               o.ReferencedFields += "[" + m.ReferencedFields[ i ] + "]"
            ;
            }
            //
            o.ReferencedCardinality = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataForeignKeyCardinality ), m.ReferencedCardinality );
            //
            o.FieldsCount = m.Fields.Count;
            for( int i = 0; i < m.Fields.Count; i++ )
            {
               o.Fields += "[" + m.Fields[ i ] + "]"
            ;
            }
            //
            o.Cardinality = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataForeignKeyCardinality ), m.Cardinality );
         }
      }
      private static void ExtractField(
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list,
         ActiveQueryBuilder.Core.MetadataItem mi,
         int parentID
         )
      {
         if( mi == null ) return;
         var o = ExtractItem( list, mi, parentID );
         {
            ActiveQueryBuilder.Core.MetadataField m = mi as ActiveQueryBuilder.Core.MetadataField;
            o.Expression = m.Expression;
            o.FieldType = System.Enum.GetName( typeof( System.Data.DbType ), m.FieldType );
            o.FieldTypeName = m.FieldTypeName;
            o.IsNullable = m.Nullable;
            o.Precision = m.Precision;
            o.Scale = m.Scale;
            o.Size = m.Size;
            o.IsPK = m.PrimaryKey;
            o.IsRO = m.ReadOnly;
         }
      }
      private static AQBTest.MetadataItemFQN ExtractItem(
         System.ComponentModel.BindingList<AQBTest.MetadataItemFQN> list,
         ActiveQueryBuilder.Core.MetadataItem mi,
         int parentID
         )
      {
         var o = new AQBTest.MetadataItemFQN( );
         {
            o.MetadataProvider = mi.SQLContext?.MetadataProvider.Description;
            o.SyntaxProvider = mi.SQLContext?.SyntaxProvider.Description;
            o.ID = list.Count;
            o.ParentID = parentID;
            if( mi.Parent != null )
            {
               o.ParentType = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), mi.Parent.Type );
            }
            o.Type = System.Enum.GetName( typeof( ActiveQueryBuilder.Core.MetadataType ), mi.Type );
            o.IsSystem = mi.System;
            //
            // o.RootName = item.Root?.Name;
            o.Server = mi.Server?.Name;
            o.Database = mi.Database?.Name;
            o.Schema = mi.Schema?.Name;
            o.ObjectName = mi.Object?.Name;
            //
            o.NameFullQualified = mi.NameFull;
            o.NameFullQualified += mi.NameFull.EndsWith( "." ) ? "<?>" : "";
            o.NameQuoted = mi.NameQuoted;
            o.AltName = mi.AltName;
            o.Field = mi.Name != null ? mi.Name : "<?>";
            //
            //
            o.HasDefault = mi.Default;
            o.Description = mi.Description;
            o.Tag = mi.Tag;
            o.UserData = mi.UserData;
         }
         list.Add( o );
         return o;
      }
      #endregion

      #region --- TOAST NOTIFICATION ---
      private static DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager tnm;
      private static void CreateToastNotificationsManager()
      {
         tnm = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager( );
         ((System.ComponentModel.ISupportInitialize) (tnm)).BeginInit( );
         {
            //tnm.Activated += Tnm_Activated;
            //tnm.Dropped += Tnm_Dropped;
            //tnm.Hidden += Tnm_Hidden;
            //tnm.TimedOut += Tnm_TimedOut;
            //tnm.UserCancelled += Tnm_UserCancelled;
            tnm.ApplicationIconPath = null;
            tnm.ApplicationId = "74fdcbed-8893-48df-8872-10569d072e21";
            tnm.ApplicationName = "AQBTest";
            //tnm.Notifications.AddRange( new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[ ] {} );
            tnm.CreateApplicationShortcut = DevExpress.Utils.DefaultBoolean.Default;
         }
         ((System.ComponentModel.ISupportInitialize) (tnm)).EndInit( );
      }
      private static DevExpress.XtraBars.ToastNotifications.ToastNotification CreateToastNotification( AQBTest.DataStore ds )
      {
         DevExpress.XtraBars.ToastNotifications.ToastNotification tn = new DevExpress.XtraBars.ToastNotifications.ToastNotification( );
         tn.ID = "cf47cb4e-394e-4ac9-a978-111715c1fc56";
         tn.Image = null;
         tn.Header = "Starting: " + ds.Name;
         tn.Body = TS_STR;
         tn.Body2 = TS_STR;
         tn.Template = DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text04;
         tn.Duration = DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Long;
         return tn;
      }

      private static void Tnm_UserCancelled( object sender, DevExpress.XtraBars.ToastNotifications.ToastNotificationEventArgs e )
      {
         throw new System.NotImplementedException( );
      }

      private static void Tnm_TimedOut( object sender, DevExpress.XtraBars.ToastNotifications.ToastNotificationEventArgs e )
      {
         throw new System.NotImplementedException( );
      }

      private static void Tnm_Hidden( object sender, DevExpress.XtraBars.ToastNotifications.ToastNotificationEventArgs e )
      {
         throw new System.NotImplementedException( );
      }

      private static void Tnm_Dropped( object sender, DevExpress.XtraBars.ToastNotifications.ToastNotificationEventArgs e )
      {
         throw new System.NotImplementedException( );
      }

      private static void Tnm_Activated( object sender, DevExpress.XtraBars.ToastNotifications.ToastNotificationEventArgs e )
      {
      }
      #endregion
   }
}
