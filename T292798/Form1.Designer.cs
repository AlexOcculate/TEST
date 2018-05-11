namespace T292798 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
         this.components = new System.ComponentModel.Container();
         DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
         DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
         DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.gridControl1 = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colSupplierID = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colQuantityPerUnit = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colUnitsOnOrder = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colReorderLevel = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDiscontinued = new DevExpress.XtraGrid.Columns.GridColumn();
         this.btConfigureConnection = new System.Windows.Forms.Button();
         this.btEditQuery = new System.Windows.Forms.Button();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // sqlDataSource1
         // 
         this.sqlDataSource1.ConnectionName = "QWERTY";
         this.sqlDataSource1.Name = "sqlDataSource1";
         columnExpression1.ColumnName = "ProductID";
         table1.Name = "Products";
         columnExpression1.Table = table1;
         column1.Expression = columnExpression1;
         columnExpression2.ColumnName = "ProductName";
         columnExpression2.Table = table1;
         column2.Expression = columnExpression2;
         columnExpression3.ColumnName = "SupplierID";
         columnExpression3.Table = table1;
         column3.Expression = columnExpression3;
         columnExpression4.ColumnName = "CategoryID";
         columnExpression4.Table = table1;
         column4.Expression = columnExpression4;
         columnExpression5.ColumnName = "QuantityPerUnit";
         columnExpression5.Table = table1;
         column5.Expression = columnExpression5;
         columnExpression6.ColumnName = "UnitPrice";
         columnExpression6.Table = table1;
         column6.Expression = columnExpression6;
         columnExpression7.ColumnName = "UnitsInStock";
         columnExpression7.Table = table1;
         column7.Expression = columnExpression7;
         columnExpression8.ColumnName = "UnitsOnOrder";
         columnExpression8.Table = table1;
         column8.Expression = columnExpression8;
         columnExpression9.ColumnName = "ReorderLevel";
         columnExpression9.Table = table1;
         column9.Expression = columnExpression9;
         columnExpression10.ColumnName = "Discontinued";
         columnExpression10.Table = table1;
         column10.Expression = columnExpression10;
         selectQuery1.Columns.Add(column1);
         selectQuery1.Columns.Add(column2);
         selectQuery1.Columns.Add(column3);
         selectQuery1.Columns.Add(column4);
         selectQuery1.Columns.Add(column5);
         selectQuery1.Columns.Add(column6);
         selectQuery1.Columns.Add(column7);
         selectQuery1.Columns.Add(column8);
         selectQuery1.Columns.Add(column9);
         selectQuery1.Columns.Add(column10);
         selectQuery1.Name = "DefaultQuery";
         selectQuery1.Tables.Add(table1);
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.btConfigureConnection, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.btEditQuery, 1, 1);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 3;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 424);
         this.tableLayoutPanel1.TabIndex = 1;
         // 
         // gridControl1
         // 
         this.gridControl1.DataMember = "DefaultQuery";
         this.gridControl1.DataSource = this.sqlDataSource1;
         this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControl1.Location = new System.Drawing.Point(3, 3);
         this.gridControl1.MainView = this.gridView1;
         this.gridControl1.Name = "gridControl1";
         this.tableLayoutPanel1.SetRowSpan(this.gridControl1, 3);
         this.gridControl1.Size = new System.Drawing.Size(650, 418);
         this.gridControl1.TabIndex = 0;
         this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colProductName,
            this.colSupplierID,
            this.colCategoryID,
            this.colQuantityPerUnit,
            this.colUnitPrice,
            this.colUnitsInStock,
            this.colUnitsOnOrder,
            this.colReorderLevel,
            this.colDiscontinued});
         this.gridView1.GridControl = this.gridControl1;
         this.gridView1.Name = "gridView1";
         // 
         // colProductID
         // 
         this.colProductID.FieldName = "ProductID";
         this.colProductID.Name = "colProductID";
         this.colProductID.Visible = true;
         this.colProductID.VisibleIndex = 0;
         // 
         // colProductName
         // 
         this.colProductName.FieldName = "ProductName";
         this.colProductName.Name = "colProductName";
         this.colProductName.Visible = true;
         this.colProductName.VisibleIndex = 1;
         // 
         // colSupplierID
         // 
         this.colSupplierID.FieldName = "SupplierID";
         this.colSupplierID.Name = "colSupplierID";
         this.colSupplierID.Visible = true;
         this.colSupplierID.VisibleIndex = 2;
         // 
         // colCategoryID
         // 
         this.colCategoryID.FieldName = "CategoryID";
         this.colCategoryID.Name = "colCategoryID";
         this.colCategoryID.Visible = true;
         this.colCategoryID.VisibleIndex = 3;
         // 
         // colQuantityPerUnit
         // 
         this.colQuantityPerUnit.FieldName = "QuantityPerUnit";
         this.colQuantityPerUnit.Name = "colQuantityPerUnit";
         this.colQuantityPerUnit.Visible = true;
         this.colQuantityPerUnit.VisibleIndex = 4;
         // 
         // colUnitPrice
         // 
         this.colUnitPrice.FieldName = "UnitPrice";
         this.colUnitPrice.Name = "colUnitPrice";
         this.colUnitPrice.Visible = true;
         this.colUnitPrice.VisibleIndex = 5;
         // 
         // colUnitsInStock
         // 
         this.colUnitsInStock.FieldName = "UnitsInStock";
         this.colUnitsInStock.Name = "colUnitsInStock";
         this.colUnitsInStock.Visible = true;
         this.colUnitsInStock.VisibleIndex = 6;
         // 
         // colUnitsOnOrder
         // 
         this.colUnitsOnOrder.FieldName = "UnitsOnOrder";
         this.colUnitsOnOrder.Name = "colUnitsOnOrder";
         this.colUnitsOnOrder.Visible = true;
         this.colUnitsOnOrder.VisibleIndex = 7;
         // 
         // colReorderLevel
         // 
         this.colReorderLevel.FieldName = "ReorderLevel";
         this.colReorderLevel.Name = "colReorderLevel";
         this.colReorderLevel.Visible = true;
         this.colReorderLevel.VisibleIndex = 8;
         // 
         // colDiscontinued
         // 
         this.colDiscontinued.FieldName = "Discontinued";
         this.colDiscontinued.Name = "colDiscontinued";
         this.colDiscontinued.Visible = true;
         this.colDiscontinued.VisibleIndex = 9;
         // 
         // btConfigureConnection
         // 
         this.btConfigureConnection.Location = new System.Drawing.Point(659, 3);
         this.btConfigureConnection.Name = "btConfigureConnection";
         this.btConfigureConnection.Size = new System.Drawing.Size(125, 23);
         this.btConfigureConnection.TabIndex = 1;
         this.btConfigureConnection.Text = "Configure Connection";
         this.btConfigureConnection.UseVisualStyleBackColor = true;
         this.btConfigureConnection.Click += new System.EventHandler(this.btConfigureConnection_Click);
         // 
         // btEditQuery
         // 
         this.btEditQuery.AutoSize = true;
         this.btEditQuery.Location = new System.Drawing.Point(659, 32);
         this.btEditQuery.Name = "btEditQuery";
         this.btEditQuery.Size = new System.Drawing.Size(125, 23);
         this.btEditQuery.TabIndex = 2;
         this.btEditQuery.Text = "Edit Query";
         this.btEditQuery.UseVisualStyleBackColor = true;
         this.btEditQuery.Click += new System.EventHandler(this.btEditQuery_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(787, 424);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btConfigureConnection;
        private System.Windows.Forms.Button btEditQuery;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierID;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPerUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsOnOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colReorderLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscontinued;

    }
}

