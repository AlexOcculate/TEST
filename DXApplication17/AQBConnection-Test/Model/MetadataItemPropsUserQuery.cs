using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsUserQuery : MetadataItemProps
   {
      public MetadataItemPropsUserQuery(DataRow row)
         : base(row)
      {
      }
   }
}
