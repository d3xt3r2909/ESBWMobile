﻿namespace ESBX_Client.Opste
{
    partial class PodesavanjeProfila
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DatumRodjenjaPicker = new System.Windows.Forms.DateTimePicker();
            this.TelefonTxt = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AdressTxt = new System.Windows.Forms.TextBox();
            this.AdresaTxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GradCmb = new System.Windows.Forms.ComboBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.PrezimeTxt = new System.Windows.Forms.TextBox();
            this.ImeTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.DatumRodjenjaPicker);
            this.groupBox1.Controls.Add(this.TelefonTxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AdressTxt);
            this.groupBox1.Controls.Add(this.AdresaTxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.GradCmb);
            this.groupBox1.Controls.Add(this.EmailTxt);
            this.groupBox1.Controls.Add(this.PrezimeTxt);
            this.groupBox1.Controls.Add(this.ImeTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 500);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podesavanje Vaseg profila";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(626, 416);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 54;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Promjeni šifru";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DatumRodjenjaPicker
            // 
            this.DatumRodjenjaPicker.Location = new System.Drawing.Point(495, 266);
            this.DatumRodjenjaPicker.Name = "DatumRodjenjaPicker";
            this.DatumRodjenjaPicker.Size = new System.Drawing.Size(200, 20);
            this.DatumRodjenjaPicker.TabIndex = 53;
            // 
            // TelefonTxt
            // 
            this.TelefonTxt.Location = new System.Drawing.Point(495, 138);
            this.TelefonTxt.Mask = "(999) 000-000";
            this.TelefonTxt.Name = "TelefonTxt";
            this.TelefonTxt.Size = new System.Drawing.Size(200, 20);
            this.TelefonTxt.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Telefon";
            // 
            // AdressTxt
            // 
            this.AdressTxt.Location = new System.Drawing.Point(495, 220);
            this.AdressTxt.Name = "AdressTxt";
            this.AdressTxt.Size = new System.Drawing.Size(200, 20);
            this.AdressTxt.TabIndex = 50;
            // 
            // AdresaTxt
            // 
            this.AdresaTxt.AutoSize = true;
            this.AdresaTxt.Location = new System.Drawing.Point(389, 227);
            this.AdresaTxt.Name = "AdresaTxt";
            this.AdresaTxt.Size = new System.Drawing.Size(40, 13);
            this.AdresaTxt.TabIndex = 49;
            this.AdresaTxt.Text = "Adresa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GradCmb
            // 
            this.GradCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradCmb.FormattingEnabled = true;
            this.GradCmb.Location = new System.Drawing.Point(495, 312);
            this.GradCmb.Name = "GradCmb";
            this.GradCmb.Size = new System.Drawing.Size(200, 21);
            this.GradCmb.TabIndex = 47;
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(495, 179);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(200, 20);
            this.EmailTxt.TabIndex = 46;
            // 
            // PrezimeTxt
            // 
            this.PrezimeTxt.Location = new System.Drawing.Point(495, 97);
            this.PrezimeTxt.Name = "PrezimeTxt";
            this.PrezimeTxt.Size = new System.Drawing.Size(200, 20);
            this.PrezimeTxt.TabIndex = 45;
            // 
            // ImeTxt
            // 
            this.ImeTxt.Location = new System.Drawing.Point(495, 56);
            this.ImeTxt.Name = "ImeTxt";
            this.ImeTxt.Size = new System.Drawing.Size(200, 20);
            this.ImeTxt.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Grad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Datum rođenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ime";
            // 
            // PodesavanjeProfila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 665);
            this.Controls.Add(this.groupBox1);
            this.Name = "PodesavanjeProfila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podesavanje profila";
            this.Load += new System.EventHandler(this.PodesavanjeProfila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker DatumRodjenjaPicker;
        private System.Windows.Forms.MaskedTextBox TelefonTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AdressTxt;
        private System.Windows.Forms.Label AdresaTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GradCmb;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.TextBox PrezimeTxt;
        private System.Windows.Forms.TextBox ImeTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}