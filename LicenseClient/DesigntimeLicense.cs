namespace LicenseClient
{
   internal class DesigntimeLicense : System.ComponentModel.License
   {
      public override string LicenseKey => throw new System.NotImplementedException( );

      public override void Dispose()
      {
         // throw new System.NotImplementedException( );
      }
   }
}