using System;
using System.Linq;

namespace DataGridSwapViews
{
   public class SeriesArgVal
   {
      public SeriesArgVal( string argument, int value )
      {
         this.Argument = argument ?? throw new ArgumentNullException( nameof( argument ) );
         this.Value = value;
      }

      public const string ARG_COLUMNNAME = "Argument";
      public string Argument
      {
         get; set;
      }

      public const string VAL_COLUMNNAME = "Value";
      public int Value
      {
         get; set;
      }
   }
}
