using System.ComponentModel;
namespace LicenseClient
{
   [System.ComponentModel.LicenseProvider( typeof( MyLicenseProvider ) )]
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      // Creates a new, null license. 
      private License license = null;

      public Form1()
      {
         this.license = LicenseManager.Validate( typeof( Form1 ), this );
         InitializeComponent( );
      }
   }
}
