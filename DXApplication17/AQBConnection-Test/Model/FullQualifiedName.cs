using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQBConnection_Test
{
   public class FullQualifiedName
   {
      public string DatabaseName
      {
         get{ return "db"; } set{ }
      }
      public string SchemaName
      {
         get { return "scm"; }
         set{ }
      }
      public string ObjectName
      {
         get { return "o"; }
         set{ }
      }
      public string FieldName
      {
         get { return "fld"; }
         set
         {
         }
      }
   }
}
