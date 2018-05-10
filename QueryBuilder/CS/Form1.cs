using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.UI.Sql;
using DevExpress.XtraEditors;
using System;

namespace StandaloneQueryBuilderSample
{
   public partial class Form1 : XtraForm
   {
      public Form1()
      {
         this.InitializeComponent();
         this.sqlDataSource1.Queries.Clear();
      }

      private void runQBButton_Click(object sender, EventArgs e)
      {
         if(this.sqlDataSource1.Queries.Count == 0)
         {
            this.sqlDataSource1.AddQueryWithQueryBuilder(new QueryBuilderEditQueryContext(), this.CreateQueryBuilderRunner);
         } else
         {
            this.sqlDataSource1.Queries[ 0 ].EditQueryWithQueryBuilder( new QueryBuilderEditQueryContext( ), this.CreateQueryBuilderRunner );
         }
      }

      private QueryBuilderRunner CreateQueryBuilderRunner(DBSchema dbSchema, SqlDataConnection sqlDataConnection, QueryBuilderEditQueryContext context)
      {
         return this.cbHidePreview.Checked
            ? new NoPreviewQueryBuilderRunner(dbSchema, sqlDataConnection, context)
            : new QueryBuilderRunner(dbSchema, sqlDataConnection, context);
      }

      private void fillButton_Click(object sender, EventArgs e)
      {
         this.gridControl1.DataSource = null;
         this.gridControl1.DataMember = null;
         this.gridView1.Columns.Clear();

         this.sqlDataSource1.Fill();

         this.gridControl1.DataSource = this.sqlDataSource1;
         this.gridControl1.DataMember = this.sqlDataSource1.Queries[0].Name;
      }
   }
}
