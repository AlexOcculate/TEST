using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsAggregate : MetadataItemProps
   {
      public MetadataItemPropsAggregate(DataRow row)
         : base(row)
      {
      }
   }
}
