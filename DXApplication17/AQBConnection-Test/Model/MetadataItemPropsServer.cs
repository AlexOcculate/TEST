using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsServer : MetadataItemProps
   {
      public MetadataItemPropsServer(DataRow row)
         : base(row)
      {
      }
   }
}
