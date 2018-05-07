namespace LicenseClient
{
   internal class RuntimeLicense : System.ComponentModel.License
   {
      public override string LicenseKey => throw new System.NotImplementedException( );

      public override void Dispose()
      {
         // throw new System.NotImplementedException( );
      }
   }
}