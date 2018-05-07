using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XpoTutorial03
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            setConnection();
            InitializeComponent();
            //CreateBuiltinDataValues();
        }

        private void dataStoreModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void setConnection()
        {
            // Retrieve the Data Store specific connection string.
//            string connectionString = MSSqlConnectionProvider.GetConnectionString(@"DBSRV\QWERTY", @"user02", @"8a0IucJ@Nx1Qy5HfFrX0Ob3m", @"Sales");
            string connectionString1 = SQLiteConnectionProvider.GetConnectionString(@"D:\TEMP\SQLite\SQLITEDB1.db3");
            //
            IDataLayer dataLayer = XpoDefault.GetDataLayer(connectionString1, AutoCreateOption.DatabaseAndSchema);
            XpoDefault.DataLayer = dataLayer;
            //Session session = new Session();
        }
        public static void CreateBuiltinDataValues()
        {
            DataStoreTreeNode ds0 = new DataStoreTreeNode();
            {
                ds0.Id = 11;
                ds0.ParentId = -1;
                ds0.IsFolder = true;
                ds0.Name = "ROOT";
                ds0.Save();
            }
            DataStoreTreeNode ds1 = new DataStoreTreeNode();
            {
                ds1.Id = 1;
                ds1.ParentId = ds0.Id;
                ds1.IsFolder = false;
                ds1.Name = "alex";
                ds1.SyntaxProvider = "Oracle 12";
                ds1.MetadataProvider = "#$%^";
                ds1.Save();
            }
            DataStoreTreeNode ds2 = new DataStoreTreeNode();
            {
                ds2.Id = 2;
                ds2.ParentId = ds0.Id;
                ds2.IsFolder = true;
                ds2.Name = "simone";
                ds2.Save();
            }
            DataStoreTreeNode ds3 = new DataStoreTreeNode();
            {
                ds3.Id = 3;
                ds3.ParentId = ds2.Id;
                ds3.IsFolder = false;
                ds3.Name = "simone occulate";
                ds3.SyntaxProvider = "Oracle adfa12";
                ds3.MetadataProvider = "12345";
                ds3.Save();
            }
            DataStoreTreeNode ds4 = new DataStoreTreeNode();
            {
                ds4.Id = 4;
                ds4.ParentId = ds2.Id;
                ds4.IsFolder = false;
                ds4.Name = "Alex occulate";
                ds4.SyntaxProvider = "SQL Server";
                ds4.MetadataProvider = "12345";
                ds4.Save();
            }
            DataStoreTreeNode ds5 = new DataStoreTreeNode();
            {
                ds5.Id = 5;
                ds5.ParentId = ds2.Id;
                ds5.IsFolder = true;
                ds5.Name = "folder";
                ds5.Save();
            }

        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            DataStoreWizardForm wizard = new DataStoreWizardForm();
            wizard.ShowDialog(this);
            this.xpCollection1.Reload();
        }

        private void treeList1_GetStateImage(object sender, DevExpress.XtraTreeList.GetStateImageEventArgs e)
        {
            // DataStoreTreeNode dstn = (DataStoreTreeNode) e.Node;
            if (bool.Equals(e.Node["IsFolder"], true))
                e.NodeImageIndex = 0;
            else
                e.NodeImageIndex = 2;
        }
    }
}
