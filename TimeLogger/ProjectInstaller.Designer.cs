namespace TimeLogger
{
   partial class ProjectInstaller
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if( disposing && (components != null) )
         {
            components.Dispose( );
         }
         base.Dispose( disposing );
      }

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.ArcaneTimeLoggerServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
         this.ArcaneTimeLoggerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
         // 
         // ArcaneTimeLoggerServiceProcessInstaller
         // 
         this.ArcaneTimeLoggerServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
         this.ArcaneTimeLoggerServiceProcessInstaller.Password = null;
         this.ArcaneTimeLoggerServiceProcessInstaller.Username = null;
         // 
         // ArcaneTimeLoggerServiceInstaller
         // 
         this.ArcaneTimeLoggerServiceInstaller.Description = "The Arcane Code Time Logging Service";
         this.ArcaneTimeLoggerServiceInstaller.DisplayName = "Arcane Code Time Logger";
         this.ArcaneTimeLoggerServiceInstaller.ServiceName = "ArcaneTimeLogger";
         // 
         // ProjectInstaller
         // 
         this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ArcaneTimeLoggerServiceProcessInstaller,
            this.ArcaneTimeLoggerServiceInstaller});

      }

      #endregion

      private System.ServiceProcess.ServiceProcessInstaller ArcaneTimeLoggerServiceProcessInstaller;
      private System.ServiceProcess.ServiceInstaller ArcaneTimeLoggerServiceInstaller;
   }
}