using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Tile;

namespace GridBasedUIOffice365TEST
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            this.gridControl1.DataSource = new MailMessageList();
        }
        Color UnreadTextColor = Color.FromArgb(248, 124, 50);
        private void tileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            object readColumnValue = tileView1.GetRowCellValue(e.RowHandle, columnRead);
            if (readColumnValue is bool)
            {
                bool isRead = (bool)readColumnValue;
                if (!isRead)
                {
                    e.Item["IsRead"].Appearance.Normal.BackColor = UnreadTextColor;
                    e.Item["MsgDate"].Appearance.Normal.ForeColor = UnreadTextColor;
                    e.Item["Subject"].Appearance.Normal.ForeColor = UnreadTextColor;
                    e.Item["Subject"].Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                }
            }
        }
    }
}
