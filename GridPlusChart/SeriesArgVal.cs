using System;

namespace GridPlusChart
{
   public partial class Form1
   {
      public class SeriesArgVal
      {
         public SeriesArgVal(string argument, int value)
         {
            this.Argument = argument ?? throw new ArgumentNullException(nameof(argument));
            this.Value = value;
         }

         public string Argument
         {
            get; set;
         }

         public int Value
         {
            get; set;
         }
      }
   }
}
