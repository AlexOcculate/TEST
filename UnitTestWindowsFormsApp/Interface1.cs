using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestWindowsFormsApp
{
   interface Interface1
   {
      int id { get; set; }
      void xpto();
      bool M();
   }

   static class Interface1Helper
   {
      public static bool MDefault(this Interface1 o)
      {
         return true;
      }
   }
}
