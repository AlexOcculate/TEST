using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsObjectMetadata : MetadataItemProps
   {
      public MetadataItemPropsObjectMetadata(DataRow row)
         : base(row)
      {
      }
   }
}
