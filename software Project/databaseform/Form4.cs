using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseform
{
    public partial class Form4 : Form
    {
        UsersCartsReport CartsRep;
        UsersOrdersReport OrdersRep;

        public Form4()
        {
            InitializeComponent();
        }

  
        private void Form4_Load(object sender, EventArgs e)
        {
            CartsRep = new UsersCartsReport();
            OrdersRep = new UsersOrdersReport();
        }

        private void UsersCartRepButton_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CartsRep;
        }

        private void OrderRepButton_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = OrdersRep;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 formopen = new Form1();
            formopen.Show();
            this.Hide();
        }
    }
}
