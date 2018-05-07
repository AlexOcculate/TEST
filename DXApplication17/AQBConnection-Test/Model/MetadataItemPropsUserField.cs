using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsUserField : MetadataItemProps
   {
      public MetadataItemPropsUserField(DataRow row)
         : base(row)
      {
      }
   }
}
