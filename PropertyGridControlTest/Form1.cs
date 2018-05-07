using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGridControlTest
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent( );
         
         f( Z( ) );
      }

      private DataSet Z()
      {
         DataSet s = new DataSet("X");
         {
            DataTable dt = new DataTable( "Alex" );
            dt.Columns.Add( "a", typeof( int ) );
            dt.Columns.Add( "b", typeof( DateTime ) );
            dt.Columns.Add( "c", typeof( bool ) );
            s.Tables.Add( dt );
            {
               DataRow r = dt.NewRow( );
               r[ "a" ] = 23;
               r[ "b" ] = DateTime.UtcNow;
               r[ "c" ] = true;
               dt.Rows.Add( r );
            }
         }
         return s;
      }

      private void f( DataSet ds )
      {
         // Create a repository item which represents an in-place CheckEdit control. 
         RepositoryItemCheckEdit riCheckEdit = new RepositoryItemCheckEdit( );
         // Represent check boxes as radio buttons. 
         riCheckEdit.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
         // Associate the Boolean data type with the created repository item. 
         this.propertyGridControl1.DefaultEditors.Add( typeof( Boolean ), riCheckEdit );

         this.propertyGridControl1.SelectedObject = ds.Tables[ "Alex" ]; //this.propertyGridControl1;

         this.completePropertyControl1.SetSelectedObjetc( ds.Tables[ "Alex" ] ); //this.propertyGridControl1;

         this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
         this.vGridControl1.DataSource = ds.Tables["Alex"];
      }

      private void propertyGridControl1_Click( object sender, EventArgs e )
      {

      }
   }
}
