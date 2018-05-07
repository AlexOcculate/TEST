using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsField : MetadataItemProps
   {
      public MetadataItemPropsField(DataRow row)
         : base(row)
      {
      }
   }
}
