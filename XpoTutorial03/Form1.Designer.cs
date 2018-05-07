namespace XpoTutorial03
{
    partial class Form1
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsFolder = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSyntaxProvider = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colMetadataProvider = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.colConnectionString = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Appearance.BandPanel.Options.UseImage = true;
            this.treeList1.Caption = "Data Stores";
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colId,
            this.colParentId,
            this.colIsFolder,
            this.colName,
            this.colSyntaxProvider,
            this.colMetadataProvider,
            this.colDescription,
            this.colConnectionString});
            this.treeList1.DataSource = this.xpCollection1;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.ReadOnly = true;
            this.treeList1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsView.ShowAutoFilterRow = true;
            this.treeList1.OptionsView.ShowCaption = true;
            this.treeList1.ParentFieldName = "ParentId";
            this.treeList1.PreviewFieldName = "Description";
            this.treeList1.RootValue = -1;
            this.treeList1.Size = new System.Drawing.Size(632, 278);
            this.treeList1.TabIndex = 0;
            this.treeList1.StateImageList = ImagesHelper.DataStoreTreeNodeImagesColletion;
            this.treeList1.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.treeList1_GetStateImage);
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
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
            this.colName.MinWidth = 34;
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
            // xpCollection1
            // 
            this.xpCollection1.CriteriaString = "[Name] <> \'ROOT\'";
            this.xpCollection1.ObjectType = typeof(XpoTutorial03.DataStoreTreeNode);
            // 
            // colConnectionString
            // 
            this.colConnectionString.FieldName = "ConnectionString";
            this.colConnectionString.Name = "colConnectionString";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsFolder;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescription;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSyntaxProvider;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMetadataProvider;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colConnectionString;
    }
}

