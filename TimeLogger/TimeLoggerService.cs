using System.ServiceProcess;

namespace TimeLogger
{
   public partial class TimeLoggerService : ServiceBase
   {
      private System.Timers.Timer _timer = null;

      public TimeLoggerService()
      {
         InitializeComponent( );
         // Set the timer to fire every sixty seconds
         // (remember the timer is in millisecond resolution,
         //  so 1000 = 1 second. )
         this._timer = new System.Timers.Timer( 60000 );
         // Now tell the timer when the timer fires
         // (the Elapsed event) call the _timer_Elapsed
         // method in our code
         this._timer.Elapsed += new
         System.Timers.ElapsedEventHandler( _timer_Elapsed );
      }

      public void OnDebug()
      {
         OnStart( null );
      }

      protected override void OnStart( string[ ] args )
      {
         this._timer.Start( );
         string x = System.Environment.CurrentDirectory + "OnStart.txt";
         string y = System.AppDomain.CurrentDomain.BaseDirectory + "OnStart.txt";
         System.IO.File.Create( y );
      }

      protected override void OnStop()
      {
         this._timer.Stop( );
         string x = System.Environment.CurrentDirectory + "OnStop.txt";
         string y = System.AppDomain.CurrentDomain.BaseDirectory + "OnStop.txt";
         System.IO.File.Create( y );
      }

      protected override void OnContinue()
      {
         base.OnContinue( );
         this._timer.Start( );
      }

      protected override void OnPause()
      {
         base.OnPause( );
         this._timer.Stop( );
      }

      protected override void OnShutdown()
      {
         base.OnShutdown( );
         this._timer.Stop( );
      }

      // This method is called when the timer fires
      // it’s elapsed event. It will write the time
      // to the event log.
      protected void _timer_Elapsed( object sender, System.Timers.ElapsedEventArgs e )

      {
         System.Diagnostics.EventLog evt = new System.Diagnostics.EventLog( "ArcaneTimeLogger" );
         string message = "Arcane Time:"
         + System.DateTime.Now.ToShortDateString( ) + " "
         + System.DateTime.Now.ToShortTimeString( )
         ;
         evt.Source = "ArcaneTimeLoggerService";
         evt.WriteEntry( message, System.Diagnostics.EventLogEntryType.Information );
      }
   }
}
