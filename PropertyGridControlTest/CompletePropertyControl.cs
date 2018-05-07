using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;

namespace PropertyGridControlTest
{
   public partial class CompletePropertyControl : DevExpress.XtraEditors.XtraUserControl
   {
      public CompletePropertyControl()
      {
         InitializeComponent( );
      }
      public void SetSelectedObjetc( object o )
      {
         this.propertyGridControl1.SelectedObject = o;
      }

      private void categoryBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.propertyGridControl1.OptionsView.ShowRootCategories = true;
         this.categorySortBarButtonItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
         this.categorySortBarButtonItem.Enabled = false;
         this.alphabeticSortBarButtonItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.alphabeticSortBarButtonItem.Enabled = true;
         NewMethod( );
      }

      private void alphabeticSortBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.propertyGridControl1.OptionsView.ShowRootCategories = false;
         this.categorySortBarButtonItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.categorySortBarButtonItem.Enabled = true;
         this.alphabeticSortBarButtonItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
         this.alphabeticSortBarButtonItem.Enabled = false;
         this.expandBarButtonItem.Enabled = false;
         this.collapseBarButtonItem.Enabled = false;
      }

      private void propertyGridControl1_FocusedRowChanged( object sender, DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventArgs e )
      {
         if( e.Row == null )
            return;
         NewMethod( );
      }

      private void NewMethod()
      {
         BaseRow focusedRow = this.propertyGridControl1.FocusedRow;
         bool isExpanded = focusedRow.Expanded;
         bool isCategoryRow = this.propertyGridControl1.IsCategoryRow( focusedRow );
         if( isCategoryRow )
         {
            this.expandBarButtonItem.Enabled = !isExpanded;
            this.collapseBarButtonItem.Enabled = isExpanded;
         }
         else
         {
            this.expandBarButtonItem.Enabled = false;
            this.collapseBarButtonItem.Enabled = false;
         }
      }

      private void collapseBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.propertyGridControl1.FocusedRow.Expanded = false;
         NewMethod( );
      }

      private void expandBarButtonItem_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         this.propertyGridControl1.FocusedRow.Expanded = true;
         NewMethod( );
      }
   }
}
