using System;
using System.Linq;

namespace GridXtraUserControl
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         this.InitializeComponent();
      }

      private void sysCSXtraUserControl1_FocusedSysCSChangedEvent(object sender, GridDataPhilosophiae.Events.SysCS.FocusedSysCSChangedEventArgs ea)
      {
         this.labelBarStaticItem.Caption = ""+ ea.FocusedSysCS;
      }
   }
}
