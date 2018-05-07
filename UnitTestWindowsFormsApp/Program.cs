using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTestWindowsFormsApp
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles( );
         Application.SetCompatibleTextRenderingDefault( false );
         Class1 class1 = new Class1( );
         //
         bool rtn = class1.stub01( true );
         //
         Application.Run( new Form1( ) );
      }
   }
}
