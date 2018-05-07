using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsProcedure : MetadataItemProps
   {
      public MetadataItemPropsProcedure(DataRow row)
         : base(row)
      {
      }
   }
}
