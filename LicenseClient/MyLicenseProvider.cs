using System;

namespace LicenseClient
{
   public class MyLicenseProvider : System.ComponentModel.LicenseProvider
   {
      public override System.ComponentModel.License GetLicense( System.ComponentModel.LicenseContext context, Type type, object instance, bool allowExceptions )
      {
         if( context.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime )
         {
            // Creating a special DesigntimeLicense will able you to design your
            // control without breaking Visual Studio in the process
            return new DesigntimeLicense( );
         }
         /*
                  byte[ ] existingSerialKey = getExistingSerial( );
                  // Algorithm can be SHA1CryptoServiceProvider for instance
                  byte[ ] data = System.Security.Cryptography.HashAlgorithm.Create( ).ComputeHash(
                      username,
                      dateRequested,
                      validUntilDate,
                      // any other data you would like to validate
                  );
                  // todo: also check if licensing period is over here. ;-)
                  for( int i = 0; i < existingSerialKey.Length; ++i )
                  {
                     if( existingSerialKey[ i ] != data[ i ] )
                     {
                        if( allowExceptions )
                        {
                           throw new LicenseException( type, instance, "License is invalid" );
                        }
                        return null;
                     }
                  }
         */
         // RuntimeLicense can be anything inheriting from License
         return new RuntimeLicense( );
      }
   }
}
