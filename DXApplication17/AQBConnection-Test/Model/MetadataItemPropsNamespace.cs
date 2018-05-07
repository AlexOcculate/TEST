using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsNamespace : MetadataItemProps
   {
      public MetadataItemPropsNamespace(DataRow row)
         : base(row)
      {
      }
   }
}
