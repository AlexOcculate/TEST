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
    public class MailMessageList : List<MailMessage>
    {
        public MailMessageList()
        {
            InitializeList();
        }
        void InitializeList()
        {
            AddRange(new MailMessage[] {
                new MailMessage() {
                    MsgDate = DateTime.Today,
                    Subject = "RE: Web Design Tip: How-To Add jQuery Yellow Fade Effect to ASP.NET GridView",
                    Sender = "Mehul Harry (DevExpress)",
                    Text = "M.Brekhof,",
                    IsRead = false
                },
                new MailMessage() {
                    MsgDate = DateTime.Today.AddDays(-1),
                    Subject = "RE: Multitasking (Message from the CTO, newsletter 49)",
                    Sender = "Pietro Allegretti",
                    Text = "Let me thank you Julian. You make me discover Pomodoro Technique...",
                    IsRead = false
                },
                new MailMessage() {
                    MsgDate = DateTime.Today.AddDays(-2),
                    Subject = "Advanced CodeRush Plug-ins: Converting an Object Initializer into a Constructor",
                    Sender = "Mark Miller (DevExpress)",
                    Text = "Today Rory Backer and I presented an Advanced CodeRush Plug-ins session, showing how to cr",
                    IsRead = true
                },
                new MailMessage() {
                    MsgDate = DateTime.Today.AddDays(-3),
                    Subject = "Multitasking (Message from the CTO, newsletter 49)",
                    Sender = "Julian Bucknall (DevExpress)",
                    Text = "For one reason or another, Jeff and I ran out of pre-videoed messages this time, so this on",
                    IsRead = true
                },
            });
        }
    }

    public class MailMessage
    {
        public MailMessage()
        {
        }
        public bool IsRead { get; set; }
        public DateTime MsgDate { get; set; }
        public string Subject { get; set; }
        public string Sender { get; set; }
        public string Text { get; set; }
    }
}
