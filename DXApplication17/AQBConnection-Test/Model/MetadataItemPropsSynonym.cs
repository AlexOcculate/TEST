using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsSynonym : MetadataItemProps
   {
      public MetadataItemPropsSynonym(DataRow row)
         : base(row)
      {
      }
   }
}
