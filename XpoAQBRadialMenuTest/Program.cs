using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRibbonBarTest
{
    static class Program
    {
        //public const string ConnectionString = @"XpoProvider=MSSqlServer;data source=DBSRV\QWERTY;user id=user02;password=8a0IucJ@Nx1Qy5HfFrX0Ob3m;";
        //public const string ConnectionString = @"Data Source=DBSRV\QWERTY;Database=Sales;User Id=user02;Password=8a0IucJ@Nx1Qy5HfFrX0Ob3m;";
      public const string ConnectionString = @"Data Source=DBSRV\QWERTY;Database=Sales;User Id=user02;Password=user02;";
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(ConnectionString, "MetadataTestWithFields.xml", false, false, true));
            Application.Run(new CircularMenuForm());
        }
    }
}
