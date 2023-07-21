
namespace databaseform
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.select_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.passord_btn = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.selectP_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.productID_cmb = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(29, 459);
            this.select_btn.Margin = new System.Windows.Forms.Padding(4);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(88, 28);
            this.select_btn.TabIndex = 0;
            this.select_btn.Text = "Select";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(25, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(25, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(25, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "User Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(25, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.name_txt.Location = new System.Drawing.Point(268, 130);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(167, 28);
            this.name_txt.TabIndex = 6;
            this.name_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(268, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mail_txt
            // 
            this.mail_txt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.mail_txt.Location = new System.Drawing.Point(268, 177);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(167, 28);
            this.mail_txt.TabIndex = 9;
            // 
            // phone_txt
            // 
            this.phone_txt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.phone_txt.Location = new System.Drawing.Point(268, 223);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(167, 28);
            this.phone_txt.TabIndex = 10;
            this.phone_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // address_txt
            // 
            this.address_txt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.address_txt.Location = new System.Drawing.Point(268, 278);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(167, 28);
            this.address_txt.TabIndex = 11;
            this.address_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(29, 562);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(88, 28);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "Back\r\n";
            this.back_btn.UseMnemonic = false;
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.Back_click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(178, 459);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(78, 28);
            this.insert_btn.TabIndex = 13;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // passord_btn
            // 
            this.passord_btn.AutoSize = true;
            this.passord_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.passord_btn.Location = new System.Drawing.Point(25, 393);
            this.passord_btn.Name = "passord_btn";
            this.passord_btn.Size = new System.Drawing.Size(152, 24);
            this.passord_btn.TabIndex = 14;
            this.passord_btn.Text = "Insert Password";
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(268, 393);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(167, 24);
            this.password_txt.TabIndex = 16;
            // 
            // selectP_btn
            // 
            this.selectP_btn.Location = new System.Drawing.Point(506, 227);
            this.selectP_btn.Name = "selectP_btn";
            this.selectP_btn.Size = new System.Drawing.Size(89, 31);
            this.selectP_btn.TabIndex = 17;
            this.selectP_btn.Text = "Select";
            this.selectP_btn.UseVisualStyleBackColor = true;
            this.selectP_btn.Click += new System.EventHandler(this.selectP_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(502, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select Using Stored Proceduer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(351, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Select without Using Stored Proceduer";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.quantity_txt.Location = new System.Drawing.Point(745, 181);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(167, 28);
            this.quantity_txt.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.Location = new System.Drawing.Point(502, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.Location = new System.Drawing.Point(496, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 24);
            this.label12.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(502, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "product ID";
            // 
            // productID_cmb
            // 
            this.productID_cmb.FormattingEnabled = true;
            this.productID_cmb.Location = new System.Drawing.Point(745, 134);
            this.productID_cmb.Name = "productID_cmb";
            this.productID_cmb.Size = new System.Drawing.Size(167, 24);
            this.productID_cmb.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(745, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 24);
            this.comboBox2.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(502, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "User ID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 655);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.productID_cmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectP_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.passord_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Connected Mode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Label passord_btn;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button selectP_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox productID_cmb;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
    }
}