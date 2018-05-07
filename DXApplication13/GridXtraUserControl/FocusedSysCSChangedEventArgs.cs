using DataPhilosophiae.Exceptions.SysCS;
using System;
using System.Linq;

namespace GridDataPhilosophiae.Events.SysCS
{
   public class FocusedSysCSChangedEventArgs : System.EventArgs
   {
      public bool Cancel
      {
         get; set;
      }

      public object FocusedSysCS
      {
         get; set;
      }

      public FocusedSysCSChangedException Exception
      {
         get; set;
      }

      public bool wasCanceled
      {
         get
         {
            return this.Cancel;
         }
      }

      public bool hasException
      {
         get
         {
            return this.Exception != null;
         }
      }

      public bool isOk
      {
         get
         {
            return !this.wasCanceled && !this.hasException;
         }
      }
   }
}
