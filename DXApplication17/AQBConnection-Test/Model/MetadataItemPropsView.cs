using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsView : MetadataItemProps
   {
      public MetadataItemPropsView(DataRow row)
         : base(row)
      {
      }
   }
}
