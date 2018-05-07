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

namespace UrlShortening
{
    public partial class DataLayoutControlSample : DevExpress.XtraEditors.XtraForm
    {
        public DataLayoutControlSample()
        {
            InitializeComponent();
        }

        private void DataLayoutControlSample_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDataSet.DataStoreModel' table. You can move, or remove it, as needed.
            this.dataStoreModelTableAdapter.Fill(this.salesDataSet.DataStoreModel);

        }
    }
}