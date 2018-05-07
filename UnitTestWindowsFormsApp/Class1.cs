using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestWindowsFormsApp
{
   public class Class1 : Interface1
   {
      public int id { get => throw new NotImplementedException( ); set => throw new NotImplementedException( ); }

      public bool M()
      {
         return this.MDefault( );
      }

      public bool stub01( bool value )
      {
         return value;
      }
      public bool stub02( bool value )
      {
         return !value;
      }
      public bool stub03( bool value )
      {
         throw new IllegalOperation("A");
      }

      public void xpto()
      {
         throw new NotImplementedException( );
      }
   }
}
