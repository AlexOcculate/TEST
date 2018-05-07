namespace XpoTutorial03
{
    partial class DataStoreWizardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataStoreWizardForm));
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSyntaxProvider = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMetadataProvider = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.createNewDataStoreFolferWizardControl = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.createNewDataStoreWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameNodeLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.parentTreeListLookUpEdit = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.isItFolderCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.createNewDataStoreNodeWizardPage = new DevExpress.XtraWizard.WizardPage();
            this.csDescrTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.connectionStringTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.connectionStringMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.descriptionTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.descriptionNodeMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.nameNodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.parentNameNodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.syntaxProviderComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.syntaxControlLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.nameLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.parentNameNodeLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager(this.components);
            this.nameValidationHint = new DevExpress.Utils.VisualEffects.ValidationHint();
            this.isFolderValidationHint = new DevExpress.Utils.VisualEffects.ValidationHint();
            this.parentValidationHint = new DevExpress.Utils.VisualEffects.ValidationHint();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.createNewDataStoreFolferWizardControl)).BeginInit();
            this.createNewDataStoreFolferWizardControl.SuspendLayout();
            this.createNewDataStoreWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentTreeListLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isItFolderCheckEdit.Properties)).BeginInit();
            this.createNewDataStoreNodeWizardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csDescrTabControl)).BeginInit();
            this.csDescrTabControl.SuspendLayout();
            this.connectionStringTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStringMemoEdit.Properties)).BeginInit();
            this.descriptionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionNodeMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameNodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentNameNodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syntaxProviderComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            // 
            // colIsFolder
            // 
            this.colIsFolder.FieldName = "IsFolder";
            this.colIsFolder.Name = "colIsFolder";
            this.colIsFolder.Width = 68;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 68;
            // 
            // colSyntaxProvider
            // 
            this.colSyntaxProvider.FieldName = "SyntaxProvider";
            this.colSyntaxProvider.Name = "colSyntaxProvider";
            this.colSyntaxProvider.Width = 69;
            // 
            // colMetadataProvider
            // 
            this.colMetadataProvider.FieldName = "MetadataProvider";
            this.colMetadataProvider.Name = "colMetadataProvider";
            this.colMetadataProvider.Width = 69;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 68;
            // 
            // createNewDataStoreFolferWizardControl
            // 
            this.createNewDataStoreFolferWizardControl.Controls.Add(this.welcomeWizardPage1);
            this.createNewDataStoreFolferWizardControl.Controls.Add(this.createNewDataStoreWizardPage);
            this.createNewDataStoreFolferWizardControl.Controls.Add(this.completionWizardPage1);
            this.createNewDataStoreFolferWizardControl.Controls.Add(this.createNewDataStoreNodeWizardPage);
            this.createNewDataStoreFolferWizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createNewDataStoreFolferWizardControl.Location = new System.Drawing.Point(0, 0);
            this.createNewDataStoreFolferWizardControl.Name = "createNewDataStoreFolferWizardControl";
            this.createNewDataStoreFolferWizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.createNewDataStoreWizardPage,
            this.createNewDataStoreNodeWizardPage,
            this.completionWizardPage1});
            this.createNewDataStoreFolferWizardControl.Size = new System.Drawing.Size(677, 432);
            this.createNewDataStoreFolferWizardControl.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl1_SelectedPageChanged);
            this.createNewDataStoreFolferWizardControl.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            this.createNewDataStoreFolferWizardControl.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.createNewDataStoreFolferWizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.createNewDataStoreFolferWizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_NextClick);
            this.createNewDataStoreFolferWizardControl.PrevClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_PrevClick);
            this.createNewDataStoreFolferWizardControl.HelpClick += new DevExpress.XtraWizard.WizardButtonClickEventHandler(this.wizardControl1_HelpClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.IntroductionText = "This wizard simplifies the creation of a new [Data Store] or [Folder] in the [Dat" +
    "a Store Outline] by guiding the user through a series of simple steps.";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(460, 276);
            this.welcomeWizardPage1.Text = "Welcome to the [Data Store] Node Creation Wizard";
            this.welcomeWizardPage1.Click += new System.EventHandler(this.welcomeWizardPage1_Click);
            // 
            // createNewDataStoreWizardPage
            // 
            this.createNewDataStoreWizardPage.Controls.Add(this.nameTextEdit);
            this.createNewDataStoreWizardPage.Controls.Add(this.nameNodeLabelControl);
            this.createNewDataStoreWizardPage.Controls.Add(this.labelControl1);
            this.createNewDataStoreWizardPage.Controls.Add(this.parentTreeListLookUpEdit);
            this.createNewDataStoreWizardPage.Controls.Add(this.isItFolderCheckEdit);
            this.createNewDataStoreWizardPage.DescriptionText = "Describe the [Data Store Outline]\'s [New Node] attributes.";
            this.createNewDataStoreWizardPage.Name = "createNewDataStoreWizardPage";
            this.createNewDataStoreWizardPage.Size = new System.Drawing.Size(645, 287);
            this.createNewDataStoreWizardPage.Text = "Create a new [Data Store] Page";
            this.createNewDataStoreWizardPage.PageValidating += new DevExpress.XtraWizard.WizardPageValidatingEventHandler(this.wizardPage1_PageValidating);
            this.createNewDataStoreWizardPage.PageCommit += new System.EventHandler(this.wizardPage1_PageCommit);
            this.createNewDataStoreWizardPage.PageRollback += new System.EventHandler(this.wizardPage1_PageRollback);
            this.createNewDataStoreWizardPage.PageInit += new System.EventHandler(this.wizardPage1_PageInit);
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.Location = new System.Drawing.Point(72, 39);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(544, 20);
            this.nameTextEdit.TabIndex = 0;
            this.nameTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextEdit_Validating);
            // 
            // nameNodeLabelControl
            // 
            this.nameNodeLabelControl.Location = new System.Drawing.Point(35, 42);
            this.nameNodeLabelControl.Name = "nameNodeLabelControl";
            this.nameNodeLabelControl.Size = new System.Drawing.Size(31, 13);
            this.nameNodeLabelControl.TabIndex = 3;
            this.nameNodeLabelControl.Text = "Name:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Parent:";
            // 
            // parentTreeListLookUpEdit
            // 
            this.parentTreeListLookUpEdit.EditValue = 11;
            this.parentTreeListLookUpEdit.Location = new System.Drawing.Point(72, 83);
            this.parentTreeListLookUpEdit.Name = "parentTreeListLookUpEdit";
            this.parentTreeListLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.parentTreeListLookUpEdit.Properties.DataSource = this.xpCollection1;
            this.parentTreeListLookUpEdit.Properties.DisplayMember = "Name";
            this.parentTreeListLookUpEdit.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.parentTreeListLookUpEdit.Properties.ValueMember = "Id";
            this.parentTreeListLookUpEdit.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.parentTreeListLookUpEdit_Properties_Validating);
            this.parentTreeListLookUpEdit.Size = new System.Drawing.Size(544, 20);
            this.parentTreeListLookUpEdit.TabIndex = 1;
            this.parentTreeListLookUpEdit.Validating += new System.ComponentModel.CancelEventHandler(this.parentTreeListLookUpEdit_Validating);
            // 
            // xpCollection1
            // 
            this.xpCollection1.CriteriaString = "[IsFolder] = True";
            this.xpCollection1.ObjectType = typeof(XpoTutorial03.DataStoreTreeNode);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Caption = "Data Store Folders";
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colParentId,
            this.colIsFolder,
            this.colName,
            this.colSyntaxProvider,
            this.colMetadataProvider,
            this.colDescription});
            this.treeListLookUpEdit1TreeList.DataSource = this.xpCollection1;
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsBehavior.ReadOnly = true;
            this.treeListLookUpEdit1TreeList.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowAutoFilterRow = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowCaption = true;
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.treeListLookUpEdit1TreeList.PreviewFieldName = "Description";
            this.treeListLookUpEdit1TreeList.RootValue = -1;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 1;
            // 
            // isItFolderCheckEdit
            // 
            this.isItFolderCheckEdit.Location = new System.Drawing.Point(72, 126);
            this.isItFolderCheckEdit.Name = "isItFolderCheckEdit";
            this.isItFolderCheckEdit.Properties.Caption = "Is it a Folder?";
            this.isItFolderCheckEdit.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.isItFolderCheckEdit.Size = new System.Drawing.Size(90, 19);
            this.isItFolderCheckEdit.TabIndex = 2;
            this.isItFolderCheckEdit.Validating += new System.ComponentModel.CancelEventHandler(this.isItFolderCheckEdit_Validating);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(460, 299);
            // 
            // createNewDataStoreNodeWizardPage
            // 
            this.createNewDataStoreNodeWizardPage.Controls.Add(this.csDescrTabControl);
            this.createNewDataStoreNodeWizardPage.Controls.Add(this.nameNodeTextEdit);
            this.createNewDataStoreNodeWizardPage.Controls.Add(this.parentNameNodeTextEdit);
            this.createNewDataStoreNodeWizardPage.Controls.Add(this.syntaxProviderComboBoxEdit);
            this.createNewDataStoreNodeWizardPage.Controls.Add(this.syntaxControlLabelControl);
            this.createNewDataStoreNodeWizardPage.Controls.Add(this.nameLabelControl);
            this.createNewDataStoreNodeWizardPage.Controls.Add(this.parentNameNodeLabelControl);
            this.createNewDataStoreNodeWizardPage.Name = "createNewDataStoreNodeWizardPage";
            this.createNewDataStoreNodeWizardPage.Size = new System.Drawing.Size(645, 287);
            // 
            // csDescrTabControl
            // 
            this.csDescrTabControl.Location = new System.Drawing.Point(30, 116);
            this.csDescrTabControl.Name = "csDescrTabControl";
            this.csDescrTabControl.SelectedTabPage = this.connectionStringTabPage;
            this.csDescrTabControl.Size = new System.Drawing.Size(573, 159);
            this.csDescrTabControl.TabIndex = 9;
            this.csDescrTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.connectionStringTabPage,
            this.descriptionTabPage});
            // 
            // connectionStringTabPage
            // 
            this.connectionStringTabPage.Controls.Add(this.connectionStringMemoEdit);
            this.connectionStringTabPage.Name = "connectionStringTabPage";
            this.connectionStringTabPage.Size = new System.Drawing.Size(571, 134);
            this.connectionStringTabPage.Text = "Connection String";
            // 
            // connectionStringMemoEdit
            // 
            this.connectionStringMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionStringMemoEdit.Location = new System.Drawing.Point(0, 0);
            this.connectionStringMemoEdit.Name = "connectionStringMemoEdit";
            this.connectionStringMemoEdit.Size = new System.Drawing.Size(571, 134);
            this.connectionStringMemoEdit.TabIndex = 0;
            // 
            // descriptionTabPage
            // 
            this.descriptionTabPage.Controls.Add(this.descriptionNodeMemoEdit);
            this.descriptionTabPage.Name = "descriptionTabPage";
            this.descriptionTabPage.Size = new System.Drawing.Size(567, 131);
            this.descriptionTabPage.Text = "Description";
            // 
            // descriptionNodeMemoEdit
            // 
            this.descriptionNodeMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionNodeMemoEdit.Location = new System.Drawing.Point(0, 0);
            this.descriptionNodeMemoEdit.Name = "descriptionNodeMemoEdit";
            this.descriptionNodeMemoEdit.Size = new System.Drawing.Size(567, 131);
            this.descriptionNodeMemoEdit.TabIndex = 0;
            // 
            // nameNodeTextEdit
            // 
            this.nameNodeTextEdit.Location = new System.Drawing.Point(118, 46);
            this.nameNodeTextEdit.Name = "nameNodeTextEdit";
            this.nameNodeTextEdit.Properties.ReadOnly = true;
            this.nameNodeTextEdit.Size = new System.Drawing.Size(485, 20);
            this.nameNodeTextEdit.TabIndex = 8;
            // 
            // parentNameNodeTextEdit
            // 
            this.parentNameNodeTextEdit.Location = new System.Drawing.Point(118, 17);
            this.parentNameNodeTextEdit.Name = "parentNameNodeTextEdit";
            this.parentNameNodeTextEdit.Properties.ReadOnly = true;
            this.parentNameNodeTextEdit.Size = new System.Drawing.Size(485, 20);
            this.parentNameNodeTextEdit.TabIndex = 7;
            // 
            // syntaxProviderComboBoxEdit
            // 
            this.syntaxProviderComboBoxEdit.Location = new System.Drawing.Point(118, 79);
            this.syntaxProviderComboBoxEdit.Name = "syntaxProviderComboBoxEdit";
            this.syntaxProviderComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.syntaxProviderComboBoxEdit.Properties.Items.AddRange(new object[] {
            "ANSI SQL-2003",
            "ANSI SQL-89",
            "ANSI SQL-92",
            "Auto",
            "Firebird 1.0",
            "Firebird 1.5",
            "Firebird 2.0",
            "Firebird 2.5",
            "Generic",
            "IBM DB2",
            "IBM Informix 10",
            "IBM Informix 8",
            "IBM Informix 9",
            "MS Access 2000 (MS Jet 4.0)",
            "MS Access 2003 (MS Jet 4.0)",
            "MS Access 97 (MS Jet 3.0)",
            "MS Access XP (MS Jet 4.0)",
            "MS SQL Server 2000",
            "MS SQL Server 2005",
            "MS SQL Server 2008",
            "MS SQL Server 2012",
            "MS SQL Server 2014",
            "MS SQL Server 7",
            "MS SQL Server Compact Edition",
            "MySQL 3.xx",
            "MySQL 4.0",
            "MySQL 4.1",
            "MySQL 5.0",
            "Oracle 10",
            "Oracle 11",
            "Oracle 7",
            "Oracle 8",
            "Oracle 9",
            "PostgreSQL",
            "SQLite",
            "Sybase ASE",
            "Sybase SQL Anywhere",
            "Teradata",
            "VistaDB"});
            this.syntaxProviderComboBoxEdit.Properties.Sorted = true;
            this.syntaxProviderComboBoxEdit.Size = new System.Drawing.Size(485, 20);
            this.syntaxProviderComboBoxEdit.TabIndex = 6;
            // 
            // syntaxControlLabelControl
            // 
            this.syntaxControlLabelControl.Location = new System.Drawing.Point(30, 83);
            this.syntaxControlLabelControl.Name = "syntaxControlLabelControl";
            this.syntaxControlLabelControl.Size = new System.Drawing.Size(81, 13);
            this.syntaxControlLabelControl.TabIndex = 2;
            this.syntaxControlLabelControl.Text = "Syntax Provider:";
            // 
            // nameLabelControl
            // 
            this.nameLabelControl.Location = new System.Drawing.Point(80, 50);
            this.nameLabelControl.Name = "nameLabelControl";
            this.nameLabelControl.Size = new System.Drawing.Size(31, 13);
            this.nameLabelControl.TabIndex = 1;
            this.nameLabelControl.Text = "Name:";
            // 
            // parentNameNodeLabelControl
            // 
            this.parentNameNodeLabelControl.Location = new System.Drawing.Point(45, 21);
            this.parentNameNodeLabelControl.Name = "parentNameNodeLabelControl";
            this.parentNameNodeLabelControl.Size = new System.Drawing.Size(66, 13);
            this.parentNameNodeLabelControl.TabIndex = 0;
            this.parentNameNodeLabelControl.Text = "Parent Name:";
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Elements.Add(this.nameValidationHint);
            this.adornerUIManager1.Elements.Add(this.isFolderValidationHint);
            this.adornerUIManager1.Elements.Add(this.parentValidationHint);
            this.adornerUIManager1.Owner = this;
            // 
            // nameValidationHint
            // 
            this.nameValidationHint.Properties.IndeterminateState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Default;
            this.nameValidationHint.Properties.IndeterminateState.Icon = ((System.Drawing.Image)(resources.GetObject("nameValidationHint.Properties.IndeterminateState.Icon")));
            this.nameValidationHint.Properties.IndeterminateState.ShowBorder = DevExpress.Utils.DefaultBoolean.True;
            this.nameValidationHint.Properties.IndeterminateState.ShowHint = DevExpress.Utils.DefaultBoolean.True;
            this.nameValidationHint.Properties.IndeterminateState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.nameValidationHint.Properties.InvalidState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Top;
            this.nameValidationHint.Properties.InvalidState.Icon = ((System.Drawing.Image)(resources.GetObject("nameValidationHint.Properties.InvalidState.Icon")));
            this.nameValidationHint.Properties.InvalidState.ShowBorder = DevExpress.Utils.DefaultBoolean.True;
            this.nameValidationHint.Properties.InvalidState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.nameValidationHint.Properties.InvalidState.Text = "[Name] must be different of NULL, empty, or whitespaces!";
            this.nameValidationHint.Properties.ValidState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Default;
            this.nameValidationHint.Properties.ValidState.Icon = ((System.Drawing.Image)(resources.GetObject("nameValidationHint.Properties.ValidState.Icon")));
            this.nameValidationHint.Properties.ValidState.ShowBorder = DevExpress.Utils.DefaultBoolean.True;
            this.nameValidationHint.Properties.ValidState.ShowHint = DevExpress.Utils.DefaultBoolean.True;
            this.nameValidationHint.Properties.ValidState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.nameValidationHint.Properties.ValidState.Text = "Valid!";
            this.nameValidationHint.TargetElement = this.nameTextEdit;
            // 
            // isFolderValidationHint
            // 
            this.isFolderValidationHint.Properties.IndeterminateState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Default;
            this.isFolderValidationHint.Properties.IndeterminateState.Icon = ((System.Drawing.Image)(resources.GetObject("isFolderValidationHint.Properties.IndeterminateState.Icon")));
            this.isFolderValidationHint.Properties.IndeterminateState.ShowBorder = DevExpress.Utils.DefaultBoolean.False;
            this.isFolderValidationHint.Properties.IndeterminateState.ShowHint = DevExpress.Utils.DefaultBoolean.True;
            this.isFolderValidationHint.Properties.IndeterminateState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.isFolderValidationHint.Properties.InvalidState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Right;
            this.isFolderValidationHint.Properties.InvalidState.Icon = ((System.Drawing.Image)(resources.GetObject("isFolderValidationHint.Properties.InvalidState.Icon")));
            this.isFolderValidationHint.Properties.InvalidState.ShowBorder = DevExpress.Utils.DefaultBoolean.True;
            this.isFolderValidationHint.Properties.InvalidState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.isFolderValidationHint.Properties.InvalidState.Text = "[Name] must be unique inside any parent!";
            this.isFolderValidationHint.Properties.ValidState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Default;
            this.isFolderValidationHint.Properties.ValidState.Icon = ((System.Drawing.Image)(resources.GetObject("isFolderValidationHint.Properties.ValidState.Icon")));
            this.isFolderValidationHint.Properties.ValidState.ShowBorder = DevExpress.Utils.DefaultBoolean.False;
            this.isFolderValidationHint.Properties.ValidState.ShowHint = DevExpress.Utils.DefaultBoolean.True;
            this.isFolderValidationHint.Properties.ValidState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.isFolderValidationHint.TargetElement = this.isItFolderCheckEdit;
            // 
            // parentValidationHint
            // 
            this.parentValidationHint.Properties.IndeterminateState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Default;
            this.parentValidationHint.Properties.IndeterminateState.Icon = ((System.Drawing.Image)(resources.GetObject("parentValidationHint.Properties.IndeterminateState.Icon")));
            this.parentValidationHint.Properties.IndeterminateState.ShowBorder = DevExpress.Utils.DefaultBoolean.True;
            this.parentValidationHint.Properties.IndeterminateState.ShowHint = DevExpress.Utils.DefaultBoolean.True;
            this.parentValidationHint.Properties.IndeterminateState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.parentValidationHint.Properties.InvalidState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Top;
            this.parentValidationHint.Properties.InvalidState.Icon = ((System.Drawing.Image)(resources.GetObject("parentValidationHint.Properties.InvalidState.Icon")));
            this.parentValidationHint.Properties.InvalidState.ShowBorder = DevExpress.Utils.DefaultBoolean.True;
            this.parentValidationHint.Properties.InvalidState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.parentValidationHint.Properties.InvalidState.Text = "[Parent Node] must be different of NULL, empty, or whitespaces!";
            this.parentValidationHint.Properties.ValidState.HintLocation = DevExpress.Utils.VisualEffects.ValidationHintLocation.Default;
            this.parentValidationHint.Properties.ValidState.Icon = ((System.Drawing.Image)(resources.GetObject("parentValidationHint.Properties.ValidState.Icon")));
            this.parentValidationHint.Properties.ValidState.ShowBorder = DevExpress.Utils.DefaultBoolean.True;
            this.parentValidationHint.Properties.ValidState.ShowHint = DevExpress.Utils.DefaultBoolean.True;
            this.parentValidationHint.Properties.ValidState.ShowIcon = DevExpress.Utils.DefaultBoolean.True;
            this.parentValidationHint.Properties.ValidState.Text = "Valid!";
            this.parentValidationHint.TargetElement = this.parentTreeListLookUpEdit;
            // 
            // DataStoreWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.createNewDataStoreFolferWizardControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataStoreWizardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataStoreWizardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataStoreWizardForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.createNewDataStoreFolferWizardControl)).EndInit();
            this.createNewDataStoreFolferWizardControl.ResumeLayout(false);
            this.createNewDataStoreWizardPage.ResumeLayout(false);
            this.createNewDataStoreWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentTreeListLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isItFolderCheckEdit.Properties)).EndInit();
            this.createNewDataStoreNodeWizardPage.ResumeLayout(false);
            this.createNewDataStoreNodeWizardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csDescrTabControl)).EndInit();
            this.csDescrTabControl.ResumeLayout(false);
            this.connectionStringTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionStringMemoEdit.Properties)).EndInit();
            this.descriptionTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionNodeMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameNodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentNameNodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syntaxProviderComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraWizard.WizardPage createNewDataStoreWizardPage;
        private DevExpress.XtraWizard.WizardPage createNewDataStoreNodeWizardPage;
        private DevExpress.XtraWizard.WizardControl createNewDataStoreFolferWizardControl;
        private DevExpress.XtraEditors.CheckEdit isItFolderCheckEdit;
        private DevExpress.XtraEditors.TreeListLookUpEdit parentTreeListLookUpEdit;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMetadataProvider;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSyntaxProvider;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LabelControl nameNodeLabelControl;
        private DevExpress.Utils.VisualEffects.AdornerUIManager adornerUIManager1;
        private DevExpress.Utils.VisualEffects.ValidationHint nameValidationHint;
        private DevExpress.Utils.VisualEffects.ValidationHint isFolderValidationHint;
        private DevExpress.Utils.VisualEffects.ValidationHint parentValidationHint;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl syntaxControlLabelControl;
        private DevExpress.XtraEditors.LabelControl nameLabelControl;
        private DevExpress.XtraEditors.LabelControl parentNameNodeLabelControl;
        private DevExpress.XtraEditors.ComboBoxEdit syntaxProviderComboBoxEdit;
        private DevExpress.XtraTab.XtraTabControl csDescrTabControl;
        private DevExpress.XtraTab.XtraTabPage connectionStringTabPage;
        private DevExpress.XtraTab.XtraTabPage descriptionTabPage;
        private DevExpress.XtraEditors.TextEdit nameNodeTextEdit;
        private DevExpress.XtraEditors.TextEdit parentNameNodeTextEdit;
        private DevExpress.XtraEditors.MemoEdit connectionStringMemoEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionNodeMemoEdit;
    }
}