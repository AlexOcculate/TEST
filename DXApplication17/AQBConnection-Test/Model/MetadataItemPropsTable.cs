using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsTable : MetadataItemProps
   {
      public MetadataItemPropsTable(DataRow row)
         : base(row)
      {
      }
   }
}
