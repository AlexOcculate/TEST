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

namespace PropertyGridControlTest
{
   public partial class PropertyXtraUserControl : DevExpress.XtraEditors.XtraUserControl
   {
      public PropertyXtraUserControl()
      {
         InitializeComponent( );
         {
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;

         }
      }
   }
}
