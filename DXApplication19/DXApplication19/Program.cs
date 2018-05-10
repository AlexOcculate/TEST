using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using AQBMetadata.ORMDataModel;
using DevExpress.Xpo.DB;

namespace DXApplication19
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         // Cross-Platform Core Libraries > DevExpress ORM Tool > Getting Started > Tutorial 1 - Your First Data-Aware Application with XPO
         ConnectionHelper.Connect( AutoCreateOption.DatabaseAndSchema );

         Application.EnableVisualStyles( );
         Application.SetCompatibleTextRenderingDefault( false );

         BonusSkins.Register( );
         SkinManager.EnableFormSkins( );
         Application.Run( new Form1( ) );
      }
   }
}
