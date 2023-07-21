
namespace databaseform
{
    partial class Form3
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
            this.save_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cart_radio = new System.Windows.Forms.RadioButton();
            this.product_radio = new System.Windows.Forms.RadioButton();
            this.Users_radio = new System.Windows.Forms.RadioButton();
            this.load_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(25, 642);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(88, 28);
            this.save_btn.TabIndex = 0;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(257, 642);
            this.back_btn.Margin = new System.Windows.Forms.Padding(4);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(88, 28);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cart_radio);
            this.groupBox1.Controls.Add(this.product_radio);
            this.groupBox1.Controls.Add(this.Users_radio);
            this.groupBox1.Location = new System.Drawing.Point(25, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // cart_radio
            // 
            this.cart_radio.AutoSize = true;
            this.cart_radio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cart_radio.Location = new System.Drawing.Point(6, 99);
            this.cart_radio.Name = "cart_radio";
            this.cart_radio.Size = new System.Drawing.Size(68, 28);
            this.cart_radio.TabIndex = 2;
            this.cart_radio.TabStop = true;
            this.cart_radio.Text = "Cart";
            this.cart_radio.UseVisualStyleBackColor = true;
            this.cart_radio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // product_radio
            // 
            this.product_radio.AutoSize = true;
            this.product_radio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_radio.Location = new System.Drawing.Point(6, 65);
            this.product_radio.Name = "product_radio";
            this.product_radio.Size = new System.Drawing.Size(107, 28);
            this.product_radio.TabIndex = 1;
            this.product_radio.TabStop = true;
            this.product_radio.Text = "Products";
            this.product_radio.UseVisualStyleBackColor = true;
            // 
            // Users_radio
            // 
            this.Users_radio.AutoSize = true;
            this.Users_radio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_radio.Location = new System.Drawing.Point(6, 31);
            this.Users_radio.Name = "Users_radio";
            this.Users_radio.Size = new System.Drawing.Size(80, 28);
            this.Users_radio.TabIndex = 0;
            this.Users_radio.TabStop = true;
            this.Users_radio.Text = "Users";
            this.Users_radio.UseVisualStyleBackColor = true;
            // 
            // load_btn
            // 
            this.load_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.Location = new System.Drawing.Point(139, 642);
            this.load_btn.Margin = new System.Windows.Forms.Padding(4);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(88, 28);
            this.load_btn.TabIndex = 3;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(352, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(657, 632);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(21, 339);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(172, 28);
            this.name_txt.TabIndex = 6;
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(253, 339);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(88, 27);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search for payment And oreder detailes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 722);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.save_btn);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Disconnected Mode";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton product_radio;
        private System.Windows.Forms.RadioButton Users_radio;
        private System.Windows.Forms.RadioButton cart_radio;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
    }
}