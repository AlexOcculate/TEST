namespace OfficeInspiredUI
{
   public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public Form1()
      {
         InitializeComponent( );
      }
      void navBarControl_ActiveGroupChanged( object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e )
      {
         navigationFrame.SelectedPageIndex = navBarControl.Groups.IndexOf( e.Group );
      }
      void barButtonNavigation_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
      {
         int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf( e.Link );
         navBarControl.ActiveGroup = navBarControl.Groups[ barItemIndex ];
      }
   }
}