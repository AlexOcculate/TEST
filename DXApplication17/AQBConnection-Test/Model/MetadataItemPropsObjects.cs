using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsObjects : MetadataItemProps
   {
      public MetadataItemPropsObjects(DataRow row)
         : base(row)
      {
      }
   }
}
