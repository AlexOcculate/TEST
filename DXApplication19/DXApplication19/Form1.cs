using AQBMetadata;
using AQBMetadata.ORMDataModel;
using System;
using System.Linq;

namespace DXApplication19
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         this.InitializeComponent();
      }

      private MetadataItem x;

      private void f()
      {
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // Cross-Platform Core Libraries > DevExpress ORM Tool > Getting Started > Tutorial 1 - Your First Data-Aware Application with XPO
         if( this.xpCollection1.Count == 0)
         {
            int i = 0;
            {
               MetadataItemXpObject o = new MetadataItemXpObject( this.session1 );
               o.ID = i++.ToString();
               o.ParentID = "0";
               o.DataStoreName = $"DS.{o.ParentID}.{o.ID}";
               o.Save( );
               this.xpCollection1.Add( o );
            }
            {
               MetadataItemXpObject o = new MetadataItemXpObject( this.session1 );
               o.ID = i++.ToString( );
               o.ParentID = "0";
               o.DataStoreName = $"DS.{o.ParentID}.{o.ID}";
               o.Save( );
               this.xpCollection1.Add( o );
            }
         }
      }
   }
}
