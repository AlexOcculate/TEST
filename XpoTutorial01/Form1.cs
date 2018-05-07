using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpoTutorial01.DataModel;

namespace XpoTutorial01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (xpCollection1.Count == 0)
            {
                var customer1 = new Customer(session1);
                customer1.Name = "John";
                customer1.Age = 21;
                customer1.Save();
                xpCollection1.Add(customer1);
                var customer2 = new Customer(session1);
                customer2.Name = "Bob";
                customer2.Age = 37;
                customer2.Save();
                xpCollection1.Add(customer2);
            }
        }
    }
}
