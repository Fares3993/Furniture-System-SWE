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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectedModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void disConnectedModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 formopen = new Form4();
            formopen.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formopen = new Form2();
            formopen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 formopen = new Form3();
            formopen.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 formopen = new Form4();
            formopen.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void connectedModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 formopen = new Form2();
            formopen.Show();
            this.Hide();
        }

        private void disconnectedModeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 formopen = new Form3();
            formopen.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
