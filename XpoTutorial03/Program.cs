using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;

namespace XpoTutorial03
{
    static class Program
    {
        //public const string ConnectionString = @"XpoProvider=MSSqlServer;data source=DBSRV\QWERTY;user id=user02;password=8a0IucJ@Nx1Qy5HfFrX0Ob3m;";
        //public const string ConnectionString = @"Data Source=DBSRV\QWERTY;Database=Sales;User Id=user02;Password=8a0IucJ@Nx1Qy5HfFrX0Ob3m;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            //
            //NewMethod();
            Application.Run(new Form1());
//            Application.Run(new DataStoreWizardForm());
        }

        private static void NewMethod()
        {
            // Retrieve the Data Store specific connection string.
            string connectionString = MSSqlConnectionProvider.GetConnectionString(@"DBSRV\QWERTY", @"user02", @"8a0IucJ@Nx1Qy5HfFrX0Ob3m", @"Sales");
            string connectionString1 = SQLiteConnectionProvider.GetConnectionString(@"D:\TEMP\SQLite\SQLITEDB1.db3");
            //
            IDataLayer dataLayer = XpoDefault.GetDataLayer(connectionString1, AutoCreateOption.DatabaseAndSchema);
            XpoDefault.DataLayer = dataLayer;
            Session session = new Session();
            //
            XPCollection collection = new XPCollection(typeof(DataStoreModel));

            //
            DataStoreModel ds = new DataStoreModel();
            ds.Name = "alex";
            ds.SyntaxProvider = "Oracle 12";
            ds.ConnectionString = "#$%^";
            ds.Save();
           
        }
    }
}
