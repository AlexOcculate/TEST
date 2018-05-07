using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;

namespace UIReadyTabbedMDINavContainerAppTEST
{
    public partial class UIReadyTabbedMDINavContainerForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraUserControl employeesUserControl;
        XtraUserControl customersUserControl;
        XtraUserControl tmdiBocUiReadyXuc;
        public UIReadyTabbedMDINavContainerForm()
        {
            InitializeComponent();
            employeesUserControl = CreateUserControl("Employees");
            customersUserControl = CreateUserControl("Customers");
            tmdiBocUiReadyXuc = CreateUserControl2("TMDI_BOC_UIReady_XUC");
            accordionControl.SelectedElement = employeesAccordionControlElement;
        }
        XtraUserControl CreateUserControl2(string text)
        {
            XtraUserControl result = new TMDI_BOC_UIReady_XUC();
            result.Name = text.ToLower() + "TMDI_BOC_UIReady_XUC";
            result.Text = text;
            LabelControl label = new LabelControl();
            label.Parent = result;
            label.Appearance.Font = new Font("Tahoma", 25.25F);
            label.Appearance.ForeColor = Color.Gray;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Text = text;
            return result;
        }
        XtraUserControl CreateUserControl(string text)
        {
            XtraUserControl result = new XtraUserControl();
            result.Name = text.ToLower() + "UserControl";
            result.Text = text;
            LabelControl label = new LabelControl();
            label.Parent = result;
            label.Appearance.Font = new Font("Tahoma", 25.25F);
            label.Appearance.ForeColor = Color.Gray;
            label.Dock = System.Windows.Forms.DockStyle.Fill;
            label.AutoSizeMode = LabelAutoSizeMode.None;
            label.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            label.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            label.Text = text;
            return result;
        }
        void accordionControl_SelectedElementChanged(object sender, SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;
            XtraUserControl userControl;
            switch(e.Element.Text)
            {
                default:
                case "Employees":
                    userControl = employeesUserControl;
                    break;
                case "Customers":
                    userControl = customersUserControl;
                    break;
                case "TMDI_BOC_UIReady_XUC":
                    userControl = tmdiBocUiReadyXuc;
                    break;
            }
            tabbedView.AddDocument(userControl);
            tabbedView.ActivateDocument(userControl);
        }
        void barButtonNavigation_ItemClick(object sender, ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            accordionControl.SelectedElement = mainAccordionGroup.Elements[barItemIndex];
        }
        void tabbedView_DocumentClosed(object sender, DocumentEventArgs e)
        {
            RecreateUserControls(e);
            SetAccordionSelectedElement(e);
        }
        void SetAccordionSelectedElement(DocumentEventArgs e)
        {
            if (tabbedView.Documents.Count != 0)
            {
//                if (e.Document.Caption == "Employees") accordionControl.SelectedElement = customersAccordionControlElement;
//                else accordionControl.SelectedElement = employeesAccordionControlElement;
                switch (e.Document.Caption)
                {
                    default:
                    case "Employees":
                        accordionControl.SelectedElement = customersAccordionControlElement;
                        break;
                    case "Customers":
                        accordionControl.SelectedElement = employeesAccordionControlElement;
                        break;
                    case "TMDI_BOC_UIReady_XUC":
                        accordionControl.SelectedElement = xucAccordionControlElement;
                        break;
                }
            }
            else
            {
                accordionControl.SelectedElement = null;
            }
        }
        void RecreateUserControls(DocumentEventArgs e)
        {
            switch (e.Document.Caption)
            {
                default:
                case "Employees":
                    employeesUserControl = CreateUserControl("Employees");
                    break;
                case "Customers":
                    customersUserControl = CreateUserControl("Customers");
                    break;
                case "TMDI_BOC_UIReady_XUC":
                    tmdiBocUiReadyXuc = CreateUserControl2("TMDI_BOC_UIReady_XUC");
                    break;
            }
        }
    }
}