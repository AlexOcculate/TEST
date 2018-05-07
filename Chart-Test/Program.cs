using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace Chart_Test
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

         BonusSkins.Register( );
         SkinManager.EnableFormSkins( );
         //Application.Run( new Form1( ) );
         //Application.Run( new BindIndividualChartSeriesToDataRuntime( ) );
         //Application.Run( new BindUsingTemplatesRuntime( ) );
         Application.Run( new ValueDataMembers( ) );
         

      }
   }
}
