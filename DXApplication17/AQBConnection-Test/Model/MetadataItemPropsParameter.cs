using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsParameter : MetadataItemProps
   {
      public MetadataItemPropsParameter(DataRow row)
         : base(row)
      {
      }
   }
}
