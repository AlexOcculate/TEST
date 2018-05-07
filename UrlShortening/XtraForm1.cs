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
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace UrlShortening
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public string googleAPIKey = @"AIzaSyAJN72qxJxJJXYc_FQJWiWchkfyrm_70As";
        public XtraForm1()
        {
            InitializeComponent();
            this.googleApiKeyTextEdit.Text = googleAPIKey;
            this.linkWhatsAppTextEdit.Text = @"https://chat.whatsapp.com/JX2bHG50tG5Cggkv8DCdAm";
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(
                @"https://www.googleapis.com/urlshortener/v1/url?key=" + googleAPIKey
            );
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            string json = string.Format("{{\"longUrl\":\"{0}\"}}", this.longUrlMemoEdit.Text.Trim());

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                Console.WriteLine(json);
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();
                string finalURL = Regex.Match(responseText, "\"id\": ?\"(?<id>.+)\"").Groups["id"].Value;
                this.shortUrlTextEdit.Text = finalURL;
                Console.WriteLine(responseText);
            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToClipboard()
        {
            string s = "";
            if( this.shortUrlCheckButton.Checked)
            {
                s += this.shortUrlTextEdit.Text.Trim();
            }
            if( this.headerCheckButton.Checked)
            {
                s += "\n" + this.headerMemoEdit.Text.Trim();
            }
            if (this.bodyCheckButton.Checked)
            {
                s+= "\n" + this.bodyMemoEdit.Text.Trim();
            }
            if (this.footerCheckButton.Checked)
            {
                s +=  "\n\n" + this.footerMemoEdit.Text.Trim();
            }
            else
            {
                s += ""
                    + "\n"
                    + "[Leia, Veja ou Ouca mais no link acima]"
                    + "\n"
                    + "\n"
                    + @"📢🔴 BreakingNews 🔴📡"
                    ;
            }
            if (this.linkWhatsAppCheckButton.Checked)
            {
                s += "\n"
                  + this.linkWhatsAppTextEdit.Text.Trim()
                  + "\n"
                  + "O link acima esta disponivel por pouco tempo!";
            }
            if (this.longUrlCheckButton.Checked)
            {
                s += "\n"
                  + "\n"
                  + this.longUrlMemoEdit.Text.Trim();
            }
            Clipboard.SetText(s);
        }

        private void copyToClipboardButton_Click(object sender, EventArgs e)
        {
            this.copyToClipboard();
        }
    }
}