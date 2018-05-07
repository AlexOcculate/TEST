using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsSchema : MetadataItemProps
   {
      public MetadataItemPropsSchema(DataRow row)
         : base(row)
      {
      }
   }
}
