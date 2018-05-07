namespace UrlShortening
{
    partial class DataLayoutControlSample
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.salesDataSet = new UrlShortening.SalesDataSet();
            this.dataStoreModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataStoreModelTableAdapter = new UrlShortening.SalesDataSetTableAdapters.DataStoreModelTableAdapter();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.OIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForOID = new DevExpress.XtraLayout.LayoutControlItem();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SyntaxProviderTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OptimisticLockFieldTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForOptimisticLockField = new DevExpress.XtraLayout.LayoutControlItem();
            this.GCRecordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForGCRecord = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ConnectionStringMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForConnectionString = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSyntaxProvider = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStoreModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SyntaxProviderTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptimisticLockFieldTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOptimisticLockField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCRecordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGCRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionStringMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConnectionString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSyntaxProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.dataNavigator1);
            this.dataLayoutControl1.Controls.Add(this.OIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SyntaxProviderTextEdit);
            this.dataLayoutControl1.Controls.Add(this.OptimisticLockFieldTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GCRecordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ConnectionStringMemoEdit);
            this.dataLayoutControl1.CustomizationMode = DevExpress.XtraLayout.CustomizationModes.Quick;
            this.dataLayoutControl1.DataSource = this.dataStoreModelBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1792, 221, 450, 400);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(864, 287);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(864, 287);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "SalesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataStoreModelBindingSource
            // 
            this.dataStoreModelBindingSource.DataMember = "DataStoreModel";
            this.dataStoreModelBindingSource.DataSource = this.salesDataSet;
            // 
            // dataStoreModelTableAdapter
            // 
            this.dataStoreModelTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForOID,
            this.layoutControlGroup3,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.tabbedControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(844, 267);
            // 
            // OIDTextEdit
            // 
            this.OIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dataStoreModelBindingSource, "OID", true));
            this.OIDTextEdit.Location = new System.Drawing.Point(111, 12);
            this.OIDTextEdit.Name = "OIDTextEdit";
            this.OIDTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.OIDTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.OIDTextEdit.Properties.Mask.EditMask = "N0";
            this.OIDTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.OIDTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.OIDTextEdit.Size = new System.Drawing.Size(741, 20);
            this.OIDTextEdit.StyleController = this.dataLayoutControl1;
            this.OIDTextEdit.TabIndex = 4;
            // 
            // ItemForOID
            // 
            this.ItemForOID.Control = this.OIDTextEdit;
            this.ItemForOID.Location = new System.Drawing.Point(0, 0);
            this.ItemForOID.Name = "ItemForOID";
            this.ItemForOID.Size = new System.Drawing.Size(844, 24);
            this.ItemForOID.Text = "OID";
            this.ItemForOID.TextSize = new System.Drawing.Size(95, 13);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataStoreModelBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(123, 70);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(308, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // SyntaxProviderTextEdit
            // 
            this.SyntaxProviderTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataStoreModelBindingSource, "SyntaxProvider", true));
            this.SyntaxProviderTextEdit.Location = new System.Drawing.Point(534, 70);
            this.SyntaxProviderTextEdit.Name = "SyntaxProviderTextEdit";
            this.SyntaxProviderTextEdit.Size = new System.Drawing.Size(306, 20);
            this.SyntaxProviderTextEdit.StyleController = this.dataLayoutControl1;
            this.SyntaxProviderTextEdit.TabIndex = 6;
            // 
            // OptimisticLockFieldTextEdit
            // 
            this.OptimisticLockFieldTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataStoreModelBindingSource, "OptimisticLockField", true));
            this.OptimisticLockFieldTextEdit.Location = new System.Drawing.Point(123, 187);
            this.OptimisticLockFieldTextEdit.Name = "OptimisticLockFieldTextEdit";
            this.OptimisticLockFieldTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.OptimisticLockFieldTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.OptimisticLockFieldTextEdit.Properties.Mask.EditMask = "N0";
            this.OptimisticLockFieldTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.OptimisticLockFieldTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.OptimisticLockFieldTextEdit.Size = new System.Drawing.Size(308, 20);
            this.OptimisticLockFieldTextEdit.StyleController = this.dataLayoutControl1;
            this.OptimisticLockFieldTextEdit.TabIndex = 8;
            // 
            // ItemForOptimisticLockField
            // 
            this.ItemForOptimisticLockField.Control = this.OptimisticLockFieldTextEdit;
            this.ItemForOptimisticLockField.Location = new System.Drawing.Point(0, 0);
            this.ItemForOptimisticLockField.Name = "ItemForOptimisticLockField";
            this.ItemForOptimisticLockField.Size = new System.Drawing.Size(411, 24);
            this.ItemForOptimisticLockField.Text = "Optimistic Lock Field";
            this.ItemForOptimisticLockField.TextSize = new System.Drawing.Size(95, 13);
            // 
            // GCRecordTextEdit
            // 
            this.GCRecordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataStoreModelBindingSource, "GCRecord", true));
            this.GCRecordTextEdit.Location = new System.Drawing.Point(534, 187);
            this.GCRecordTextEdit.Name = "GCRecordTextEdit";
            this.GCRecordTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.GCRecordTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GCRecordTextEdit.Properties.Mask.EditMask = "N0";
            this.GCRecordTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.GCRecordTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.GCRecordTextEdit.Size = new System.Drawing.Size(306, 20);
            this.GCRecordTextEdit.StyleController = this.dataLayoutControl1;
            this.GCRecordTextEdit.TabIndex = 9;
            // 
            // ItemForGCRecord
            // 
            this.ItemForGCRecord.Control = this.GCRecordTextEdit;
            this.ItemForGCRecord.Location = new System.Drawing.Point(411, 0);
            this.ItemForGCRecord.Name = "ItemForGCRecord";
            this.ItemForGCRecord.Size = new System.Drawing.Size(409, 24);
            this.ItemForGCRecord.Text = "GC Record";
            this.ItemForGCRecord.TextSize = new System.Drawing.Size(95, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 211);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(844, 35);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForOptimisticLockField,
            this.ItemForGCRecord});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 145);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(844, 66);
            this.layoutControlGroup3.Text = "Esse e um grupo:";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dataNavigator1.DataSource = this.dataStoreModelBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(12, 258);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(228, 17);
            this.dataNavigator1.StyleController = this.dataLayoutControl1;
            this.dataNavigator1.TabIndex = 10;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.dataNavigator1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 246);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(844, 21);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ConnectionStringMemoEdit
            // 
            this.ConnectionStringMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.dataStoreModelBindingSource, "ConnectionString", true));
            this.ConnectionStringMemoEdit.Location = new System.Drawing.Point(123, 94);
            this.ConnectionStringMemoEdit.Name = "ConnectionStringMemoEdit";
            this.ConnectionStringMemoEdit.Size = new System.Drawing.Size(717, 47);
            this.ConnectionStringMemoEdit.StyleController = this.dataLayoutControl1;
            this.ConnectionStringMemoEdit.TabIndex = 11;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 24);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup4;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(844, 121);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup5});
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForConnectionString,
            this.ItemForSyntaxProvider});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Size = new System.Drawing.Size(820, 75);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(411, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(95, 13);
            // 
            // ItemForConnectionString
            // 
            this.ItemForConnectionString.Control = this.ConnectionStringMemoEdit;
            this.ItemForConnectionString.Location = new System.Drawing.Point(0, 24);
            this.ItemForConnectionString.Name = "ItemForConnectionString";
            this.ItemForConnectionString.Size = new System.Drawing.Size(820, 51);
            this.ItemForConnectionString.Text = "Connection String";
            this.ItemForConnectionString.TextSize = new System.Drawing.Size(95, 13);
            // 
            // ItemForSyntaxProvider
            // 
            this.ItemForSyntaxProvider.Control = this.SyntaxProviderTextEdit;
            this.ItemForSyntaxProvider.Location = new System.Drawing.Point(411, 0);
            this.ItemForSyntaxProvider.Name = "ItemForSyntaxProvider";
            this.ItemForSyntaxProvider.Size = new System.Drawing.Size(409, 24);
            this.ItemForSyntaxProvider.Text = "Syntax Provider";
            this.ItemForSyntaxProvider.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Size = new System.Drawing.Size(820, 75);
            // 
            // DataLayoutControlSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 287);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "DataLayoutControlSample";
            this.Text = "DataLayoutControlSample";
            this.Load += new System.EventHandler(this.DataLayoutControlSample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStoreModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SyntaxProviderTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptimisticLockFieldTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOptimisticLockField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCRecordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGCRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionStringMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConnectionString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSyntaxProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private SalesDataSet salesDataSet;
        private System.Windows.Forms.BindingSource dataStoreModelBindingSource;
        private SalesDataSetTableAdapters.DataStoreModelTableAdapter dataStoreModelTableAdapter;
        private DevExpress.XtraEditors.TextEdit OIDTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit SyntaxProviderTextEdit;
        private DevExpress.XtraEditors.TextEdit OptimisticLockFieldTextEdit;
        private DevExpress.XtraEditors.TextEdit GCRecordTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOptimisticLockField;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGCRecord;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit ConnectionStringMemoEdit;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForConnectionString;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSyntaxProvider;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
    }
}