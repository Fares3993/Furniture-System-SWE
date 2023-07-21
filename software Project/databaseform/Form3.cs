using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace databaseform
{
    public partial class Form3 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder commandBuilder;
        DataSet ds;
        string constr = "Data Source=orcl; User Id=scott;Password=tiger;";
        string cmdstr = "";
        public Form3()
        {
            InitializeComponent();
        }



        private void back_btn_Click(object sender, EventArgs e)
        {
            Form1 formopen = new Form1();
            formopen.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Users_radio.Checked = true;
            cmdstr = "select * from users";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            
            if(Users_radio.Checked)
            {
                cmdstr = "select * from users";
            }
            else if (product_radio.Checked)
            {
                cmdstr = "select * from products";
            }
            else if (cart_radio.Checked)
            {
                cmdstr = "select * from CARTEDATA";
            }
            adapter = new OracleDataAdapter(cmdstr,constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            cmdstr = @"SELECT pay.invoicenumber, pay.paymentname , od.address , od.datetime
                    from users us, payment pay , orderdata od
                    where us.userid = pay.userid 
                    and od.userid = us.userid
                    and us.username =:name";
            adapter=new OracleDataAdapter(cmdstr,constr);
            adapter.SelectCommand.Parameters.Add("name", name_txt.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource=ds.Tables[0];
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            commandBuilder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
