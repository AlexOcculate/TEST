using DevExpress.DataAccess.UI.Sql;
using System;
using System.Linq;

namespace T292798
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         this.InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {
        // this.sqlDataSource1.Fill();
      }

      private void btConfigureConnection_Click(object sender, EventArgs e)
      {
         SqlDataSourceUIHelper.ConfigureConnection(this.sqlDataSource1);
      }

      private void btEditQuery_Click(object sender, EventArgs e)
      {
         SqlDataSourceUIHelper.EditQuery(this.sqlDataSource1.Queries["DefaultQuery"]);

         this.sqlDataSource1.Fill();

         this.gridView1.PopulateColumns();
      }
   }
}
