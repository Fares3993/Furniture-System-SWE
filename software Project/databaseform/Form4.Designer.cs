
namespace databaseform
{
    partial class Form4
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
            this.OrderRepButton = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.UsersCartRepButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderRepButton
            // 
            this.OrderRepButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrderRepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderRepButton.Location = new System.Drawing.Point(754, 34);
            this.OrderRepButton.Name = "OrderRepButton";
            this.OrderRepButton.Size = new System.Drawing.Size(181, 45);
            this.OrderRepButton.TabIndex = 1;
            this.OrderRepButton.Text = "Orders Report";
            this.OrderRepButton.UseVisualStyleBackColor = false;
            this.OrderRepButton.Click += new System.EventHandler(this.OrderRepButton_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(19, 103);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1447, 735);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(19, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // UsersCartRepButton
            // 
            this.UsersCartRepButton.BackColor = System.Drawing.Color.SlateGray;
            this.UsersCartRepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersCartRepButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsersCartRepButton.Location = new System.Drawing.Point(509, 34);
            this.UsersCartRepButton.Name = "UsersCartRepButton";
            this.UsersCartRepButton.Size = new System.Drawing.Size(207, 45);
            this.UsersCartRepButton.TabIndex = 4;
            this.UsersCartRepButton.Text = "Users Cart Report";
            this.UsersCartRepButton.UseVisualStyleBackColor = false;
            this.UsersCartRepButton.Click += new System.EventHandler(this.UsersCartRepButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 850);
            this.Controls.Add(this.UsersCartRepButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.OrderRepButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OrderRepButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button UsersCartRepButton;
    }
}