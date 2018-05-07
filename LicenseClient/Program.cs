using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace LicenseClient
{
   static partial class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles( );
         Application.SetCompatibleTextRenderingDefault( false );

         BonusSkins.Register( );
         SkinManager.EnableFormSkins( );
         Application.Run( new Form1( ) );
      }
   }
}
