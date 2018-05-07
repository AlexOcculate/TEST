using System;
using System.Data;
using System.Linq;

namespace AQBConnection_Test.Model
{
   public class MetadataItemPropsFK : MetadataItemProps
   {
      public MetadataItemPropsFK(DataRow row)
         : base(row)
      {
      }
   }
}
