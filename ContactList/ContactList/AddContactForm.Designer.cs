﻿namespace ContactList
{
    partial class AddContactForm
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
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblThongTinBoSung = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(278, 181);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(132, 22);
            this.txtPhoneNumber.TabIndex = 0;
            this.txtPhoneNumber.Text = "PhoneNumber";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(422, 286);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(490, 53);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(132, 22);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Text = "FullName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(588, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Email";
            // 
            // lblThongTinBoSung
            // 
            this.lblThongTinBoSung.AutoSize = true;
            this.lblThongTinBoSung.Location = new System.Drawing.Point(422, 413);
            this.lblThongTinBoSung.Name = "lblThongTinBoSung";
            this.lblThongTinBoSung.Size = new System.Drawing.Size(113, 16);
            this.lblThongTinBoSung.TabIndex = 3;
            this.lblThongTinBoSung.Text = "Thông tin bổ sung";
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblThongTinBoSung);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhoneNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblThongTinBoSung;
    }
}