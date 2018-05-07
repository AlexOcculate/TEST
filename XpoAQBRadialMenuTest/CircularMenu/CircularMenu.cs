using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace MyRibbonBarTest
{
   public partial class CircularMenuForm : Form
   {
      public CircularMenuForm()
      {
         this.InitializeComponent();

         this.barManager = this.barManager1;
         this.barManager.ItemClick += new ItemClickEventHandler(this.barManager_ItemClick);
         // Create Radial Menu 
         this.radialMenu = new RadialMenu(this.barManager);
         this.radialMenu.AddItems(this.GetRadialMenuItems(this.barManager));
      }

      private BarManager barManager;
      private RadialMenu radialMenu;

      private void btnShowRadialMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         // Display Radial Menu 
         if(this.radialMenu == null)
         {
            return;
         }

         Point pt = this.Location;
         pt.Offset(this.Width / 2, this.Height / 2);
         this.radialMenu.ShowPopup(pt);
      }

      private BarItem[ ] GetRadialMenuItems(BarManager barManager)
      {
         // Create bar items to display in Radial Menu 
         BarItem btnCopy = new BarButtonItem(barManager, "Copy");
         btnCopy.ImageOptions.ImageUri.Uri = "Copy;Size16x16";

         BarItem btnCut = new BarButtonItem(barManager, "Cut");
         btnCut.ImageOptions.ImageUri.Uri = "Cut;Size16x16";

         BarItem btnDelete = new BarButtonItem(barManager, "Delete");
         btnDelete.ImageOptions.ImageUri.Uri = "Delete;Size16x16";

         BarItem btnPaste = new BarButtonItem(barManager, "Paste");
         btnPaste.ImageOptions.ImageUri.Uri = "Paste;Size16x16";

         // Sub-menu with 3 check buttons 
         BarSubItem btnMenuFormat = new BarSubItem(barManager, "Format");
         BarCheckItem btnCheckBold = new BarCheckItem(barManager, false);
         btnCheckBold.Caption = "Bold";
         btnCheckBold.ImageOptions.ImageUri.Uri = "Bold;Size16x16";

         BarCheckItem btnCheckItalic = new BarCheckItem(barManager, true);
         btnCheckItalic.Caption = "Italic";
         btnCheckItalic.ImageOptions.ImageUri.Uri = "Italic;Size16x16";

         BarCheckItem btnCheckUnderline = new BarCheckItem(barManager, false);
         btnCheckUnderline.Caption = "Underline";
         btnCheckUnderline.ImageOptions.ImageUri.Uri = "Underline;Size16x16";

         BarItem[ ] subMenuItems = new BarItem[ ] { btnCheckBold, btnCheckItalic, btnCheckUnderline };
         btnMenuFormat.AddItems(subMenuItems);

         BarItem btnFind = new BarButtonItem(barManager, "Find");
         btnFind.ImageOptions.ImageUri.Uri = "Find;Size16x16";

         BarItem btnUndo = new BarButtonItem(barManager, "Undo");
         btnUndo.ImageOptions.ImageUri.Uri = "Undo;Size16x16";

         BarItem btnRedo = new BarButtonItem(barManager, "Redo");
         btnRedo.ImageOptions.ImageUri.Uri = "Redo;Size16x16";

         return new BarItem[ ] { btnCopy, btnCut, btnDelete, btnPaste, btnMenuFormat, btnFind, btnUndo, btnRedo };
      }

      private void barManager_ItemClick(object sender, ItemClickEventArgs e)
      {
         //... 
         Text = "Item clicked: " + e.Item.Caption;
      }

      private void button1_MouseDown(object sender, MouseEventArgs e)
      {
         // Display Radial Menu 
         if(this.radialMenu == null)
         {
            return;
         }

         Point pt = this.Location;
         pt.Offset(this.Width / 2, this.Height / 2);
         this.radialMenu.ShowPopup(pt);
      }
   }
}
