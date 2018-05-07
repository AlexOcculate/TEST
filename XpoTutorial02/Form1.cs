using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpoTutorial02;

namespace XpoTutorial02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // CriteriaOperator criteria = new BinaryOperator("Age", 30, BinaryOperatorType.Greater);
            // CriteriaOperator criteria = CriteriaOperator.Parse("Age > 30");
            // xpCollection1.Criteria = criteria; // Server-Side Filter...
            // xpCollection1.Filter = criteria; // Client-Side Filter...
            if (xpCollection1.Count == 0)
            {
                CreateBootstrapData();
            }
        }

        private void CreateBootstrapData()
        {
            {
                var c = new Customer(session1)
                {
                    Name = "John",
                    Age = 21
                };
                c.Orders.Add(new Order(session1)
                {
                    ProductName = "Chai",
                    OrderDate = new DateTime(2013, 3, 11)
                });
                c.Orders.Add(new Order(session1)
                {
                    ProductName = "Konbu",
                    OrderDate = new DateTime(2013, 1, 23)
                });
                c.Save();
                xpCollection1.Add(c);
            }
            {
                var c = new Customer(session1)
                {
                    Name = "Bob",
                    Age = 37
                };
                c.Orders.Add(new Order(session1)
                {
                    ProductName = "Queso Cabrales",
                    OrderDate = new DateTime(2013, 2, 9)
                });
                c.Save();
                xpCollection1.Add(c);
            }
            {
                var c = new Customer(session1)
                {
                    Name = "Mark Jolly",
                    Age = 33
                };
                c.Orders.Add(new Order(session1)
                {
                    ProductName = "XYZ",
                    OrderDate = new DateTime(2017, 1, 1)
                });
                c.Save();
                xpCollection1.Add(c);
            }
            {
                var c = new Customer(session1)
                {
                    Name = "Bobby",
                    Age = 67
                };
                c.Orders.Add(new Order(session1)
                {
                    ProductName = "Cabrales",
                    OrderDate = new DateTime(2011, 12, 31)
                });
                c.Save();
                xpCollection1.Add(c);
            }
        }
    }
}
