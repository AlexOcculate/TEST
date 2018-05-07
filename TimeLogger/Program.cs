using System.ServiceProcess;

namespace TimeLogger
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      static void Main()
      {
         ServiceBase[ ] ServicesToRun;
         ServicesToRun = new ServiceBase[ ]
         {
                new TimeLoggerService()
         };
#if DEBUG
         ((TimeLoggerService) ServicesToRun[ 0 ]).OnDebug( );
         System.Threading.Thread.Sleep( System.Threading.Timeout.Infinite );
#else
         ServiceBase.Run( ServicesToRun );
#endif
      }
   }
}
