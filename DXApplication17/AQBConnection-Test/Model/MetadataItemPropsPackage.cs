using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsPackage : MetadataItemProps
   {
      public MetadataItemPropsPackage(DataRow row)
         : base(row)
      {
      }
   }
}
