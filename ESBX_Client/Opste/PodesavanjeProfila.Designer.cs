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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DatumRodjenjaPicker
            // 
            this.DatumRodjenjaPicker.Location = new System.Drawing.Point(294, 318);
            this.DatumRodjenjaPicker.Name = "DatumRodjenjaPicker";
            this.DatumRodjenjaPicker.Size = new System.Drawing.Size(200, 20);
            this.DatumRodjenjaPicker.TabIndex = 35;
            // 
            // TelefonTxt
            // 
            this.TelefonTxt.Location = new System.Drawing.Point(294, 190);
            this.TelefonTxt.Mask = "(999) 000-000";
            this.TelefonTxt.Name = "TelefonTxt";
            this.TelefonTxt.Size = new System.Drawing.Size(200, 20);
            this.TelefonTxt.TabIndex = 34;
            this.TelefonTxt.Validating += new System.ComponentModel.CancelEventHandler(this.TelefonTxt_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Telefon";
            // 
            // AdressTxt
            // 
            this.AdressTxt.Location = new System.Drawing.Point(294, 272);
            this.AdressTxt.Name = "AdressTxt";
            this.AdressTxt.Size = new System.Drawing.Size(200, 20);
            this.AdressTxt.TabIndex = 32;
            this.AdressTxt.Validating += new System.ComponentModel.CancelEventHandler(this.AdressTxt_Validating);
            // 
            // AdresaTxt
            // 
            this.AdresaTxt.AutoSize = true;
            this.AdresaTxt.Location = new System.Drawing.Point(188, 279);
            this.AdresaTxt.Name = "AdresaTxt";
            this.AdresaTxt.Size = new System.Drawing.Size(40, 13);
            this.AdresaTxt.TabIndex = 31;
            this.AdresaTxt.Text = "Adresa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GradCmb
            // 
            this.GradCmb.FormattingEnabled = true;
            this.GradCmb.Location = new System.Drawing.Point(294, 364);
            this.GradCmb.Name = "GradCmb";
            this.GradCmb.Size = new System.Drawing.Size(200, 21);
            this.GradCmb.TabIndex = 29;
            this.GradCmb.Validating += new System.ComponentModel.CancelEventHandler(this.GradCmb_Validating);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(294, 231);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(200, 20);
            this.EmailTxt.TabIndex = 28;
            this.EmailTxt.Validating += new System.ComponentModel.CancelEventHandler(this.EmailTxt_Validating);
            // 
            // PrezimeTxt
            // 
            this.PrezimeTxt.Location = new System.Drawing.Point(294, 149);
            this.PrezimeTxt.Name = "PrezimeTxt";
            this.PrezimeTxt.Size = new System.Drawing.Size(200, 20);
            this.PrezimeTxt.TabIndex = 27;
            this.PrezimeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.PrezimeTxt_Validating);
            // 
            // ImeTxt
            // 
            this.ImeTxt.Location = new System.Drawing.Point(294, 108);
            this.ImeTxt.Name = "ImeTxt";
            this.ImeTxt.Size = new System.Drawing.Size(200, 20);
            this.ImeTxt.TabIndex = 26;
            this.ImeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.ImeTxt_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Grad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Datum rođenja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ime";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(425, 468);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 38;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Promjeni šifru";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // PodesavanjeProfila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 520);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.DatumRodjenjaPicker);
            this.Controls.Add(this.TelefonTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AdressTxt);
            this.Controls.Add(this.AdresaTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GradCmb);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.PrezimeTxt);
            this.Controls.Add(this.ImeTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PodesavanjeProfila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podesavanje profila";
            this.Load += new System.EventHandler(this.PodesavanjeProfila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}