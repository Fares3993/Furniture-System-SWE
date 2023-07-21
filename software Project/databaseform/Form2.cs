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
    public partial class Form2 : Form
    {
        string ordb = "Data Source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
            password_txt.PasswordChar = '*';
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            conn = new OracleConnection(ordb);
            conn.Open();
            //select user id
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "select USERID FROM USERS";
            cmd1.CommandType = CommandType.Text;
            OracleDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                comboBox2.Items.Add(dr[0]);
            }
            dr.Close();

            //select 
            OracleCommand procedureCommand = new OracleCommand();
            procedureCommand.Connection = conn;
            procedureCommand.CommandText = "GetproductID";
            procedureCommand.CommandType = CommandType.StoredProcedure;
            procedureCommand.Parameters.Add("id",OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader ProcedureDR = procedureCommand.ExecuteReader();
            while(ProcedureDR.Read())
            {
                productID_cmb.Items.Add(ProcedureDR[0]);
            }
            ProcedureDR.Close();
        }

       



        private void Back_click(object sender, EventArgs e)
        {
            Form1 formopen = new Form1();
            formopen.Show();
            this.Hide();
        }

        private void select_click(object sender, EventArgs e)
        {
            
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = @"select USERNAME,USEREMAIL,
                                 PHONENUMBER,ADDRESS FROM USERS
                                  where userid=:id";
            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.Add("id",comboBox1.SelectedItem.ToString());
            OracleDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                name_txt.Text = dr[0].ToString();
                mail_txt.Text = dr[1].ToString();
                phone_txt.Text = dr[2].ToString();
                address_txt.Text = dr[3].ToString();
            }
            dr.Close();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;
            cmd3.CommandText = @"INSERT into users
                                values (:id,:name,:mail,
                                :password,:phone,:address)";
            cmd3.Parameters.Add("id",comboBox1.Text);
            cmd3.Parameters.Add("name",name_txt.Text);
            cmd3.Parameters.Add("mail", mail_txt.Text);
            cmd3.Parameters.Add("password", password_txt.Text);
            cmd3.Parameters.Add("phone", phone_txt.Text);
            cmd3.Parameters.Add("address", address_txt.Text);
            int r = cmd3.ExecuteNonQuery();
            if(r != -1)
            {
                comboBox1.Items.Add(comboBox1.Text);
                MessageBox.Show("New User is Added.");
                comboBox1.Text = "";
                name_txt.Text = "";
                mail_txt.Text = "";
                phone_txt.Text = "";
                address_txt.Text = "";
                password_txt.Text = "";
            }
        }
        private void selectP_btn_Click(object sender, EventArgs e)
        {
            OracleCommand procedure_cmd = new OracleCommand();
            procedure_cmd.Connection = conn;
            procedure_cmd.CommandText = "getProductQuantity";
            procedure_cmd.CommandType = CommandType.StoredProcedure;
            procedure_cmd.Parameters.Add("productID", Convert.ToInt32(productID_cmb.Text));
            procedure_cmd.Parameters.Add("userID", Convert.ToInt32(comboBox2.Text));
            procedure_cmd.Parameters.Add("quantity",OracleDbType.Int32,ParameterDirection.Output);
            try
            {
                procedure_cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Not Found");
            }
            quantity_txt.Text = procedure_cmd.Parameters["quantity"].Value.ToString();            
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
