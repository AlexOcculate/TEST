namespace DXApplication19
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
      protected override void Dispose( bool disposing )
      {
         if( disposing && (components != null) )
         {
            components.Dispose( );
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
         this.bar1 = new DevExpress.XtraBars.Bar();
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
         this.session1 = new DevExpress.Xpo.Session(this.components);
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colID = new DevExpress.XtraGrid.Columns.GridColumn();  
         this.colParentID = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDataStoreName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colSnapshotName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colLastWriteTimeUtc = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMetadataProvider = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colSyntaxProvider = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colIsSystem = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colServer = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDatabase = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colSchema = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colParentType = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colObjectName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNameFullQualified = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colCardinality = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colFieldsCount = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colFkFields = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colReferencedCardinality = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colReferencedObject = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colReferencedObjectName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colReferencedFieldsCount = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colReferencedFields = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNameQuoted = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colAltName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colHasDefault = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colExpression = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDotNetDatatype = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDatabaseDatatype = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colIsNullable = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colPrecision = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colScale = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colIsPK = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colIsRO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTag = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colUserData = new DevExpress.XtraGrid.Columns.GridColumn();
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // barManager1
         // 
         this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
         this.barManager1.DockControls.Add(this.barDockControlTop);
         this.barManager1.DockControls.Add(this.barDockControlBottom);
         this.barManager1.DockControls.Add(this.barDockControlLeft);
         this.barManager1.DockControls.Add(this.barDockControlRight);
         this.barManager1.Form = this;
         this.barManager1.MainMenu = this.bar2;
         this.barManager1.MaxItemId = 0;
         this.barManager1.StatusBar = this.bar3;
         // 
         // bar1
         // 
         this.bar1.BarName = "Tools";
         this.bar1.DockCol = 0;
         this.bar1.DockRow = 1;
         this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar1.Text = "Tools";
         // 
         // bar2
         // 
         this.bar2.BarName = "Main menu";
         this.bar2.DockCol = 0;
         this.bar2.DockRow = 0;
         this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // bar3
         // 
         this.bar3.BarName = "Status bar";
         this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         this.bar3.DockCol = 0;
         this.bar3.DockRow = 0;
         this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         this.bar3.OptionsBar.AllowQuickCustomization = false;
         this.bar3.OptionsBar.DrawDragBorder = false;
         this.bar3.OptionsBar.UseWholeRow = true;
         this.bar3.Text = "Status bar";
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.barManager1;
         this.barDockControlTop.Size = new System.Drawing.Size(1171, 46);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
         this.barDockControlBottom.Manager = this.barManager1;
         this.barDockControlBottom.Size = new System.Drawing.Size(1171, 18);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 46);
         this.barDockControlLeft.Manager = this.barManager1;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 542);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(1171, 46);
         this.barDockControlRight.Manager = this.barManager1;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 542);
         // 
         // xpCollection1
         // 
         this.xpCollection1.ObjectType = typeof(AQBMetadata.ORMDataModel.MetadataItemXpObject);
         this.xpCollection1.Session = this.session1;
         // 
         // session1
         // 
         this.session1.IsObjectModifiedOnNonPersistentPropertyChange = null;
         this.session1.TrackPropertiesModifications = false;
         // 
         // gridControl1
         // 
         this.gridControl1.DataSource = this.xpCollection1;
         this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControl1.Location = new System.Drawing.Point(0, 46);
         this.gridControl1.MainView = this.gridView1;
         this.gridControl1.MenuManager = this.barManager1;
         this.gridControl1.Name = "gridControl1";
         this.gridControl1.Size = new System.Drawing.Size(1171, 542);
         this.gridControl1.TabIndex = 4;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colID,
            this.colParentID,
            this.colDataStoreName,
            this.colSnapshotName,
            this.colLastWriteTimeUtc,
            this.colMetadataProvider,
            this.colSyntaxProvider,
            this.colIsSystem,
            this.colServer,
            this.colDatabase,
            this.colSchema,
            this.colType,
            this.colParentType,
            this.colObjectName,
            this.colNameFullQualified,
            this.colCardinality,
            this.colFieldsCount,
            this.colFkFields,
            this.colReferencedCardinality,
            this.colReferencedObject,
            this.colReferencedObjectName,
            this.colReferencedFieldsCount,
            this.colReferencedFields,
            this.colNameQuoted,
            this.colAltName,
            this.colName,
            this.colHasDefault,
            this.colExpression,
            this.colDotNetDatatype,
            this.colDatabaseDatatype,
            this.colIsNullable,
            this.colPrecision,
            this.colScale,
            this.colSize,
            this.colIsPK,
            this.colIsRO,
            this.colDescription,
            this.colTag,
            this.colUserData});
         this.gridView1.GridControl = this.gridControl1;
         this.gridView1.Name = "gridView1";
         this.gridView1.OptionsDetail.ShowEmbeddedDetailIndent = DevExpress.Utils.DefaultBoolean.True;
         this.gridView1.OptionsView.ShowFooter = true;
         // 
         // colOid
         // 
         this.colOid.FieldName = "Oid";
         this.colOid.Name = "colOid";
         this.colOid.Visible = true;
         this.colOid.VisibleIndex = 0;
         // 
         // colID
         // 
         this.colID.FieldName = "ID";
         this.colID.Name = "colID";
         this.colID.Visible = true;
         this.colID.VisibleIndex = 1;
         // 
         // colParentID
         // 
         this.colParentID.FieldName = "ParentID";
         this.colParentID.Name = "colParentID";
         this.colParentID.Visible = true;
         this.colParentID.VisibleIndex = 2;
         // 
         // colDataStoreName
         // 
         this.colDataStoreName.FieldName = "DataStoreName";
         this.colDataStoreName.Name = "colDataStoreName";
         this.colDataStoreName.Visible = true;
         this.colDataStoreName.VisibleIndex = 3;
         // 
         // colSnapshotName
         // 
         this.colSnapshotName.FieldName = "SnapshotName";
         this.colSnapshotName.Name = "colSnapshotName";
         this.colSnapshotName.Visible = true;
         this.colSnapshotName.VisibleIndex = 4;
         // 
         // colLastWriteTimeUtc
         // 
         this.colLastWriteTimeUtc.FieldName = "LastWriteTimeUtc";
         this.colLastWriteTimeUtc.Name = "colLastWriteTimeUtc";
         this.colLastWriteTimeUtc.Visible = true;
         this.colLastWriteTimeUtc.VisibleIndex = 5;
         // 
         // colMetadataProvider
         // 
         this.colMetadataProvider.FieldName = "MetadataProvider";
         this.colMetadataProvider.Name = "colMetadataProvider";
         this.colMetadataProvider.Visible = true;
         this.colMetadataProvider.VisibleIndex = 6;
         // 
         // colSyntaxProvider
         // 
         this.colSyntaxProvider.FieldName = "SyntaxProvider";
         this.colSyntaxProvider.Name = "colSyntaxProvider";
         this.colSyntaxProvider.Visible = true;
         this.colSyntaxProvider.VisibleIndex = 7;
         // 
         // colIsSystem
         // 
         this.colIsSystem.FieldName = "IsSystem";
         this.colIsSystem.Name = "colIsSystem";
         this.colIsSystem.Visible = true;
         this.colIsSystem.VisibleIndex = 8;
         // 
         // colServer
         // 
         this.colServer.FieldName = "Server";
         this.colServer.Name = "colServer";
         this.colServer.Visible = true;
         this.colServer.VisibleIndex = 9;
         // 
         // colDatabase
         // 
         this.colDatabase.FieldName = "Database";
         this.colDatabase.Name = "colDatabase";
         this.colDatabase.Visible = true;
         this.colDatabase.VisibleIndex = 10;
         // 
         // colSchema
         // 
         this.colSchema.FieldName = "Schema";
         this.colSchema.Name = "colSchema";
         this.colSchema.Visible = true;
         this.colSchema.VisibleIndex = 11;
         // 
         // colType
         // 
         this.colType.FieldName = "Type";
         this.colType.Name = "colType";
         this.colType.Visible = true;
         this.colType.VisibleIndex = 12;
         // 
         // colParentType
         // 
         this.colParentType.FieldName = "ParentType";
         this.colParentType.Name = "colParentType";
         this.colParentType.Visible = true;
         this.colParentType.VisibleIndex = 13;
         // 
         // colObjectName
         // 
         this.colObjectName.FieldName = "ObjectName";
         this.colObjectName.Name = "colObjectName";
         this.colObjectName.Visible = true;
         this.colObjectName.VisibleIndex = 14;
         // 
         // colNameFullQualified
         // 
         this.colNameFullQualified.FieldName = "NameFullQualified";
         this.colNameFullQualified.Name = "colNameFullQualified";
         this.colNameFullQualified.Visible = true;
         this.colNameFullQualified.VisibleIndex = 15;
         // 
         // colCardinality
         // 
         this.colCardinality.FieldName = "Cardinality";
         this.colCardinality.Name = "colCardinality";
         this.colCardinality.Visible = true;
         this.colCardinality.VisibleIndex = 16;
         // 
         // colFieldsCount
         // 
         this.colFieldsCount.FieldName = "FieldsCount";
         this.colFieldsCount.Name = "colFieldsCount";
         this.colFieldsCount.Visible = true;
         this.colFieldsCount.VisibleIndex = 17;
         // 
         // colFkFields
         // 
         this.colFkFields.FieldName = "FkFields";
         this.colFkFields.Name = "colFkFields";
         this.colFkFields.Visible = true;
         this.colFkFields.VisibleIndex = 18;
         // 
         // colReferencedCardinality
         // 
         this.colReferencedCardinality.FieldName = "ReferencedCardinality";
         this.colReferencedCardinality.Name = "colReferencedCardinality";
         this.colReferencedCardinality.Visible = true;
         this.colReferencedCardinality.VisibleIndex = 19;
         // 
         // colReferencedObject
         // 
         this.colReferencedObject.FieldName = "ReferencedObject";
         this.colReferencedObject.Name = "colReferencedObject";
         this.colReferencedObject.Visible = true;
         this.colReferencedObject.VisibleIndex = 20;
         // 
         // colReferencedObjectName
         // 
         this.colReferencedObjectName.FieldName = "ReferencedObjectName";
         this.colReferencedObjectName.Name = "colReferencedObjectName";
         this.colReferencedObjectName.Visible = true;
         this.colReferencedObjectName.VisibleIndex = 21;
         // 
         // colReferencedFieldsCount
         // 
         this.colReferencedFieldsCount.FieldName = "ReferencedFieldsCount";
         this.colReferencedFieldsCount.Name = "colReferencedFieldsCount";
         this.colReferencedFieldsCount.Visible = true;
         this.colReferencedFieldsCount.VisibleIndex = 22;
         // 
         // colReferencedFields
         // 
         this.colReferencedFields.FieldName = "ReferencedFields";
         this.colReferencedFields.Name = "colReferencedFields";
         this.colReferencedFields.Visible = true;
         this.colReferencedFields.VisibleIndex = 23;
         // 
         // colNameQuoted
         // 
         this.colNameQuoted.FieldName = "NameQuoted";
         this.colNameQuoted.Name = "colNameQuoted";
         this.colNameQuoted.Visible = true;
         this.colNameQuoted.VisibleIndex = 24;
         // 
         // colAltName
         // 
         this.colAltName.FieldName = "AltName";
         this.colAltName.Name = "colAltName";
         this.colAltName.Visible = true;
         this.colAltName.VisibleIndex = 25;
         // 
         // colName
         // 
         this.colName.FieldName = "Name";
         this.colName.Name = "colName";
         this.colName.Visible = true;
         this.colName.VisibleIndex = 26;
         // 
         // colHasDefault
         // 
         this.colHasDefault.FieldName = "HasDefault";
         this.colHasDefault.Name = "colHasDefault";
         this.colHasDefault.Visible = true;
         this.colHasDefault.VisibleIndex = 27;
         // 
         // colExpression
         // 
         this.colExpression.FieldName = "Expression";
         this.colExpression.Name = "colExpression";
         this.colExpression.Visible = true;
         this.colExpression.VisibleIndex = 28;
         // 
         // colDotNetDatatype
         // 
         this.colDotNetDatatype.FieldName = "DotNetDatatype";
         this.colDotNetDatatype.Name = "colDotNetDatatype";
         this.colDotNetDatatype.Visible = true;
         this.colDotNetDatatype.VisibleIndex = 29;
         // 
         // colDatabaseDatatype
         // 
         this.colDatabaseDatatype.FieldName = "DatabaseDatatype";
         this.colDatabaseDatatype.Name = "colDatabaseDatatype";
         this.colDatabaseDatatype.Visible = true;
         this.colDatabaseDatatype.VisibleIndex = 30;
         // 
         // colIsNullable
         // 
         this.colIsNullable.FieldName = "IsNullable";
         this.colIsNullable.Name = "colIsNullable";
         this.colIsNullable.Visible = true;
         this.colIsNullable.VisibleIndex = 31;
         // 
         // colPrecision
         // 
         this.colPrecision.FieldName = "Precision";
         this.colPrecision.Name = "colPrecision";
         this.colPrecision.Visible = true;
         this.colPrecision.VisibleIndex = 32;
         // 
         // colScale
         // 
         this.colScale.FieldName = "Scale";
         this.colScale.Name = "colScale";
         this.colScale.Visible = true;
         this.colScale.VisibleIndex = 33;
         // 
         // colSize
         // 
         this.colSize.FieldName = "Size";
         this.colSize.Name = "colSize";
         this.colSize.Visible = true;
         this.colSize.VisibleIndex = 34;
         // 
         // colIsPK
         // 
         this.colIsPK.FieldName = "IsPK";
         this.colIsPK.Name = "colIsPK";
         this.colIsPK.Visible = true;
         this.colIsPK.VisibleIndex = 35;
         // 
         // colIsRO
         // 
         this.colIsRO.FieldName = "IsRO";
         this.colIsRO.Name = "colIsRO";
         this.colIsRO.Visible = true;
         this.colIsRO.VisibleIndex = 36;
         // 
         // colDescription
         // 
         this.colDescription.FieldName = "Description";
         this.colDescription.Name = "colDescription";
         this.colDescription.Visible = true;
         this.colDescription.VisibleIndex = 37;
         // 
         // colTag
         // 
         this.colTag.FieldName = "Tag";
         this.colTag.Name = "colTag";
         this.colTag.Visible = true;
         this.colTag.VisibleIndex = 38;
         // 
         // colUserData
         // 
         this.colUserData.FieldName = "UserData";
         this.colUserData.Name = "colUserData";
         this.colUserData.Visible = true;
         this.colUserData.VisibleIndex = 39;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1171, 606);
         this.Controls.Add(this.gridControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager barManager1;
      private DevExpress.XtraBars.Bar bar1;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.Xpo.XPCollection xpCollection1;
      private DevExpress.Xpo.Session session1;
      private DevExpress.XtraGrid.GridControl gridControl1;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraGrid.Columns.GridColumn colOid;
      private DevExpress.XtraGrid.Columns.GridColumn colID;
      private DevExpress.XtraGrid.Columns.GridColumn colParentID;
      private DevExpress.XtraGrid.Columns.GridColumn colDataStoreName;
      private DevExpress.XtraGrid.Columns.GridColumn colSnapshotName;
      private DevExpress.XtraGrid.Columns.GridColumn colLastWriteTimeUtc;
      private DevExpress.XtraGrid.Columns.GridColumn colMetadataProvider;
      private DevExpress.XtraGrid.Columns.GridColumn colSyntaxProvider;
      private DevExpress.XtraGrid.Columns.GridColumn colIsSystem;
      private DevExpress.XtraGrid.Columns.GridColumn colServer;
      private DevExpress.XtraGrid.Columns.GridColumn colDatabase;
      private DevExpress.XtraGrid.Columns.GridColumn colSchema;
      private DevExpress.XtraGrid.Columns.GridColumn colType;
      private DevExpress.XtraGrid.Columns.GridColumn colParentType;
      private DevExpress.XtraGrid.Columns.GridColumn colObjectName;
      private DevExpress.XtraGrid.Columns.GridColumn colNameFullQualified;
      private DevExpress.XtraGrid.Columns.GridColumn colCardinality;
      private DevExpress.XtraGrid.Columns.GridColumn colFieldsCount;
      private DevExpress.XtraGrid.Columns.GridColumn colFkFields;
      private DevExpress.XtraGrid.Columns.GridColumn colReferencedCardinality;
      private DevExpress.XtraGrid.Columns.GridColumn colReferencedObject;
      private DevExpress.XtraGrid.Columns.GridColumn colReferencedObjectName;
      private DevExpress.XtraGrid.Columns.GridColumn colReferencedFieldsCount;
      private DevExpress.XtraGrid.Columns.GridColumn colReferencedFields;
      private DevExpress.XtraGrid.Columns.GridColumn colNameQuoted;
      private DevExpress.XtraGrid.Columns.GridColumn colAltName;
      private DevExpress.XtraGrid.Columns.GridColumn colName;
      private DevExpress.XtraGrid.Columns.GridColumn colHasDefault;
      private DevExpress.XtraGrid.Columns.GridColumn colExpression;
      private DevExpress.XtraGrid.Columns.GridColumn colDotNetDatatype;
      private DevExpress.XtraGrid.Columns.GridColumn colDatabaseDatatype;
      private DevExpress.XtraGrid.Columns.GridColumn colIsNullable;
      private DevExpress.XtraGrid.Columns.GridColumn colPrecision;
      private DevExpress.XtraGrid.Columns.GridColumn colScale;
      private DevExpress.XtraGrid.Columns.GridColumn colSize;
      private DevExpress.XtraGrid.Columns.GridColumn colIsPK;
      private DevExpress.XtraGrid.Columns.GridColumn colIsRO;
      private DevExpress.XtraGrid.Columns.GridColumn colDescription;
      private DevExpress.XtraGrid.Columns.GridColumn colTag;
      private DevExpress.XtraGrid.Columns.GridColumn colUserData;
   }
}

