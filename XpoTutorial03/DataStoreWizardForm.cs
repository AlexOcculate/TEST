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
using DevExpress.XtraTreeList;
using DevExpress.XtraWizard;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;
using DevExpress.Utils;
using System.Collections;
using DevExpress.Xpo.Generators;
using DevExpress.Xpo.Metadata;

namespace XpoTutorial03
{
    public partial class DataStoreWizardForm : DevExpress.XtraEditors.XtraForm
    {
        public DataStoreWizardForm()
        {
            StartConnection();
            //            CreateBuiltinDataValues();
            InitializeComponent();
        }
        private void StartConnection()
        {
            // Retrieve the Data Store specific connection string.
            string connectionString = MSSqlConnectionProvider.GetConnectionString(@"DBSRV\QWERTY", @"user02", @"8a0IucJ@Nx1Qy5HfFrX0Ob3m", @"Sales");
            string connectionString1 = SQLiteConnectionProvider.GetConnectionString(@"D:\TEMP\SQLite\SQLITEDB1.db3");
            //
            IDataLayer dataLayer = XpoDefault.GetDataLayer(connectionString1, AutoCreateOption.DatabaseAndSchema);
            XpoDefault.DataLayer = dataLayer;
            //Session session = new Session();
        }
        public static void CreateBuiltinDataValues()
        {
            DataStoreTreeNode ds0 = new DataStoreTreeNode();
            {
                ds0.Id = 11;
                ds0.ParentId = -1;
                ds0.IsFolder = true;
                ds0.Name = "ROOT";
                ds0.Save();
            }
            DataStoreTreeNode ds1 = new DataStoreTreeNode();
            {
                ds1.Id = 1;
                ds1.ParentId = ds0.Id;
                ds1.IsFolder = false;
                ds1.Name = "alex";
                ds1.SyntaxProvider = "Oracle 12";
                ds1.MetadataProvider = "#$%^";
                ds1.Save();
            }
            DataStoreTreeNode ds2 = new DataStoreTreeNode();
            {
                ds2.Id = 2;
                ds2.ParentId = ds0.Id;
                ds2.IsFolder = true;
                ds2.Name = "simone";
                ds2.Save();
            }
            DataStoreTreeNode ds3 = new DataStoreTreeNode();
            {
                ds3.Id = 3;
                ds3.ParentId = ds2.Id;
                ds3.IsFolder = false;
                ds3.Name = "simone occulate";
                ds3.SyntaxProvider = "Oracle adfa12";
                ds3.MetadataProvider = "12345";
                ds3.Save();
            }
            DataStoreTreeNode ds4 = new DataStoreTreeNode();
            {
                ds4.Id = 4;
                ds4.ParentId = ds2.Id;
                ds4.IsFolder = false;
                ds4.Name = "Alex occulate";
                ds4.SyntaxProvider = "SQL Server";
                ds4.MetadataProvider = "12345";
                ds4.Save();
            }
            DataStoreTreeNode ds5 = new DataStoreTreeNode();
            {
                ds5.Id = 5;
                ds5.ParentId = ds2.Id;
                ds5.IsFolder = true;
                ds5.Name = "folder";
                ds5.Save();
            }

        }

        #region --- Wizard Control Events ---
        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.PrevPage == createNewDataStoreWizardPage && e.Direction == Direction.Forward)
            {
                string dataSourceParentName = this.parentTreeListLookUpEdit.Text;
                object dataSourceParentId = this.parentTreeListLookUpEdit.EditValue;
                string dataSourceName = this.nameTextEdit.Text;
                string criteriaString = this.xpCollection1.CriteriaString;
                bool isItFolder = isItFolderCheckEdit.Checked;
                bool isNewNodeValid = newDataStoreTreeNodeIsValid(dataSourceParentId, dataSourceName, isItFolder);
                if (!isNewNodeValid)
                {
                    nameValidationHint.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Indeterminate;
                    parentValidationHint.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Indeterminate;
                    isFolderValidationHint.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Invalid;
                    string s;
                    if (isItFolder)
                    {
                        s = @"[Folder";
                    }
                    else
                    {
                        s = @"[Data Store";
                    }
                    this.isFolderValidationHint.Properties.InvalidState.Text = s + @"'s Name] must be unique inside any parent!";

                    const string msg = ""
                        + "<b>[Data Store Name]</b> must be <b>unique</b> inside its <b>[Parents Node]</b>"
                        + "\n"
                        + "<b>[Folder Name]</b> must be <b>unique</b> inside its <b>[Parent Node]</b>"
                        ;
                    const string title = @"Data Store Wizard Warning";
                    XtraMessageBox.Show(this, msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning, DefaultBoolean.True);

                    e.Cancel = true;
                }
                else
                {
                    nameValidationHint.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Valid;
                    parentValidationHint.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Valid;
                    isFolderValidationHint.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Valid;
                    if (isItFolder)
                    {
                        string text = dataSourceParentName + "/" + dataSourceName;
                        this.completionWizardPage1.FinishText = ""
                            + "You have successfully completed the wizard"
                            + "\n\n\n"
                            + "A new folder will be created after you click [Finish]!"
                            + "\n\n\n"
                            + text
                            ;
                        e.Page = this.completionWizardPage1;
                    }
                    else
                    {
                        e.Page = this.createNewDataStoreNodeWizardPage;
                        this.parentNameNodeTextEdit.Text = dataSourceParentName;
                        this.nameNodeTextEdit.Text = dataSourceName;
                    }
                }
            }
            else if (e.PrevPage == createNewDataStoreWizardPage && e.Direction == Direction.Forward)
            {

            }
            else if (e.PrevPage == createNewDataStoreNodeWizardPage && e.Direction == Direction.Forward)
            {
                string text = this.parentTreeListLookUpEdit.Text + "/" + this.nameTextEdit.Text
                    + "\n"
                + this.syntaxProviderComboBoxEdit.SelectedItem as string
                    + "\n"
                + this.connectionStringMemoEdit.Text;
                ;

                this.completionWizardPage1.FinishText = ""
                    + "You have successfully completed the wizard"
                    + "\n\n\n"
                    + "A new [node] will be created after you click [Finish]!"
                    + "\n\n\n"
                    + text
                    ;
                e.Page = this.completionWizardPage1;
            }
        }

        private bool newDataStoreTreeNodeIsValid(object dataSourceParentId, string dataSourceName, bool isItFolder)
        {
            BinaryOperator fc0 = new BinaryOperator("IsFolder", isItFolder, BinaryOperatorType.Equal);
            BinaryOperator fc1 = new BinaryOperator("ParentId", dataSourceParentId, BinaryOperatorType.Equal);
            BinaryOperator fc2 = new BinaryOperator("Name", dataSourceName, BinaryOperatorType.Equal);
            BinaryOperator[] fcArray = new BinaryOperator[] { fc0, fc1, fc2 };
            GroupOperator fc = new GroupOperator(GroupOperatorType.And, fcArray);
            XPCollection<DataStoreTreeNode> xpDS = new XPCollection<DataStoreTreeNode>();
            xpDS.Criteria = fc;
            xpDS.Load();
            return xpDS.Count == 0;
        }

        private void wizardControl1_SelectedPageChanged(object sender, DevExpress.XtraWizard.WizardPageChangedEventArgs e)
        {
        }

        private void wizardControl1_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
        }

        private void wizardControl1_PrevClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            FinishClicked = true;
            {
                ParentName = this.parentTreeListLookUpEdit.Text;
                {
                    //Session session = new Session();
                    //session.ConnectionString = XpoDefault.ConnectionString;

                    // Obtain the persistent object class info required by the GetObjects method 
                    XPClassInfo dstnClass = XpoDefault.Session.GetClassInfo(typeof(DataStoreTreeNode));

                    // Create criteria to get objects 
                    CriteriaOperator criteria;
                    criteria = null; // new BinaryOperator("Discontinued", true);

                    // Create a sort list if objects must be processed in a specific order 
                    SortingCollection sortProps = null; // new SortingCollection(null);
                    // sortProps.Add(new SortProperty("Price", DevExpress.Xpo.DB.SortingDirection.Ascending));

                    // Create criteria patcher to filter out the objects marked as "deleted"  
                    // and to support loading of inherited objects of a given base persistent class 
                    CollectionCriteriaPatcher patcher = new DevExpress.Xpo.Generators.CollectionCriteriaPatcher(false, XpoDefault.Session.TypesManager);
                    // Call GetObjects 
                    ICollection collection = XpoDefault.Session.GetObjects(dstnClass, criteria, sortProps, 0, patcher, true);

                    int max = int.MinValue;
                    // Do processing 
                    foreach (DataStoreTreeNode dstn in collection)
                    {
                        max = Math.Max(max, dstn.Id);
                    }
                    NewDataStoreTreeNode = new DataStoreTreeNode();
                    {
                        NewDataStoreTreeNode.Id = max + 1;
                        NewDataStoreTreeNode.ParentId = (int)this.parentTreeListLookUpEdit.EditValue;
                        NewDataStoreTreeNode.IsFolder = isItFolderCheckEdit.Checked;
                        NewDataStoreTreeNode.Name = this.nameTextEdit.Text;
                        NewDataStoreTreeNode.SyntaxProvider = this.syntaxProviderComboBoxEdit.SelectedItem as string;
                        NewDataStoreTreeNode.ConnectionString = this.connectionStringMemoEdit.Text;
                        NewDataStoreTreeNode.Description = this.descriptionNodeMemoEdit.Text;
                        NewDataStoreTreeNode.Save();
                    }
                }
            }
            this.Close();
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e)
        {
            this.Close();
        }

        private void wizardControl1_HelpClick(object sender, DevExpress.XtraWizard.WizardButtonClickEventArgs e)
        {
        }
        #endregion

        #region --- Wizar Page Events ---
        private void welcomeWizardPage1_Click(object sender, EventArgs e)
        {
        }

        private void wizardPage1_PageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
        {
        }

        private void wizardPage1_PageCommit(object sender, EventArgs e)
        {
        }

        private void wizardPage1_PageInit(object sender, EventArgs e)
        {
        }

        private void wizardPage1_PageRollback(object sender, EventArgs e)
        {
        }
        #endregion

        private void DataStoreWizardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ValidateChildren())
            {
                int i = 10 + 1;
            }
            if (FinishClicked)
            {
                return;
            }
            const string msg = @"Do you want to exit the Wizard?";
            const string title = @"Data Store Wizard";
            DialogResult dialogResult = XtraMessageBox.Show(this, msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                e.Cancel = true;
        }

        private void nameTextEdit_Validating(object sender, CancelEventArgs e)
        {
            string value = nameTextEdit.Text.Trim();
            if (string.IsNullOrWhiteSpace(value))
            {
                e.Cancel = true;
            }
            nameTextEdit.Text = value;
        }

        private void parentTreeListLookUpEdit_Validating(object sender, CancelEventArgs e)
        {

        }

        private void isItFolderCheckEdit_Validating(object sender, CancelEventArgs e)
        {

        }

        private void parentTreeListLookUpEdit_Properties_Validating(object sender, CancelEventArgs e)
        {
        }
        //
        public bool FinishClicked = false;
        public string ParentName = null;
        public DataStoreTreeNode NewDataStoreTreeNode;

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }
    }
}