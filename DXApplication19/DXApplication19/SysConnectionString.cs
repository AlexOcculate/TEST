using System;
using System.Linq;

namespace DataPhilosophiae.Model
{
   public class SysConnectionString
   {
      public bool IsSys
      {
         get; set;
      }

      public string Name
      {
         get; set;
      }

      public string ProviderName
      {
         get; set;
      }

      public string ConnectionString
      {
         get; set;
      }
   }
}
