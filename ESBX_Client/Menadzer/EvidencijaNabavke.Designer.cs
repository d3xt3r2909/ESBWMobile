﻿namespace ESBX_Client.Menadzer
{
    partial class EvidencijaNabavke
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.NapomenaTxt = new System.Windows.Forms.RichTextBox();
            this.DobavljacCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DatumTxt = new System.Windows.Forms.TextBox();
            this.AdresaTxt = new System.Windows.Forms.Label();
            this.CijenaTxt = new System.Windows.Forms.MaskedTextBox();
            this.KolicinaTxt = new System.Windows.Forms.MaskedTextBox();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.SastojciGrid = new System.Windows.Forms.DataGridView();
            this.SastojakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sastojak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SastojakCmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SastojciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(67, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Evidentiranje nove nabavke";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(179, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.NapomenaTxt);
            this.splitContainer1.Panel1.Controls.Add(this.DobavljacCmb);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.DatumTxt);
            this.splitContainer1.Panel1.Controls.Add(this.AdresaTxt);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CijenaTxt);
            this.splitContainer1.Panel2.Controls.Add(this.KolicinaTxt);
            this.splitContainer1.Panel2.Controls.Add(this.DodajBtn);
            this.splitContainer1.Panel2.Controls.Add(this.SastojciGrid);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.SastojakCmb);
            this.splitContainer1.Size = new System.Drawing.Size(828, 376);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Datum";
            // 
            // NapomenaTxt
            // 
            this.NapomenaTxt.Location = new System.Drawing.Point(111, 131);
            this.NapomenaTxt.Name = "NapomenaTxt";
            this.NapomenaTxt.Size = new System.Drawing.Size(200, 103);
            this.NapomenaTxt.TabIndex = 53;
            this.NapomenaTxt.Text = "";
            // 
            // DobavljacCmb
            // 
            this.DobavljacCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DobavljacCmb.FormattingEnabled = true;
            this.DobavljacCmb.Location = new System.Drawing.Point(111, 36);
            this.DobavljacCmb.Name = "DobavljacCmb";
            this.DobavljacCmb.Size = new System.Drawing.Size(200, 21);
            this.DobavljacCmb.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-40, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Datum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Dobavljač";
            // 
            // DatumTxt
            // 
            this.DatumTxt.Location = new System.Drawing.Point(111, 80);
            this.DatumTxt.Name = "DatumTxt";
            this.DatumTxt.ReadOnly = true;
            this.DatumTxt.Size = new System.Drawing.Size(200, 20);
            this.DatumTxt.TabIndex = 46;
            // 
            // AdresaTxt
            // 
            this.AdresaTxt.AutoSize = true;
            this.AdresaTxt.Location = new System.Drawing.Point(18, 134);
            this.AdresaTxt.Name = "AdresaTxt";
            this.AdresaTxt.Size = new System.Drawing.Size(59, 13);
            this.AdresaTxt.TabIndex = 49;
            this.AdresaTxt.Text = "Napomena";
            // 
            // CijenaTxt
            // 
            this.CijenaTxt.Location = new System.Drawing.Point(330, 76);
            this.CijenaTxt.Mask = "000000000000000000";
            this.CijenaTxt.Name = "CijenaTxt";
            this.CijenaTxt.Size = new System.Drawing.Size(133, 20);
            this.CijenaTxt.TabIndex = 56;
            this.CijenaTxt.ValidatingType = typeof(int);
            // 
            // KolicinaTxt
            // 
            this.KolicinaTxt.Location = new System.Drawing.Point(131, 76);
            this.KolicinaTxt.Mask = "000000000000000000";
            this.KolicinaTxt.Name = "KolicinaTxt";
            this.KolicinaTxt.Size = new System.Drawing.Size(133, 20);
            this.KolicinaTxt.TabIndex = 55;
            this.KolicinaTxt.ValidatingType = typeof(int);
            // 
            // DodajBtn
            // 
            this.DodajBtn.Location = new System.Drawing.Point(283, 113);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(180, 23);
            this.DodajBtn.TabIndex = 54;
            this.DodajBtn.Text = "Dodaj sastojak za nabavku";
            this.DodajBtn.UseVisualStyleBackColor = true;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // SastojciGrid
            // 
            this.SastojciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SastojciGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SastojakId,
            this.Sastojak,
            this.Kolicina,
            this.Cijena});
            this.SastojciGrid.Location = new System.Drawing.Point(53, 166);
            this.SastojciGrid.Name = "SastojciGrid";
            this.SastojciGrid.Size = new System.Drawing.Size(410, 190);
            this.SastojciGrid.TabIndex = 53;
            // 
            // SastojakId
            // 
            this.SastojakId.DataPropertyName = "SastojakId";
            this.SastojakId.HeaderText = "Sastojakid";
            this.SastojakId.Name = "SastojakId";
            this.SastojakId.Visible = false;
            // 
            // Sastojak
            // 
            this.Sastojak.DataPropertyName = "Naziv";
            this.Sastojak.HeaderText = "Sastojak";
            this.Sastojak.Name = "Sastojak";
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Naziv sastojka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Količina";
            // 
            // SastojakCmb
            // 
            this.SastojakCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SastojakCmb.FormattingEnabled = true;
            this.SastojakCmb.Location = new System.Drawing.Point(131, 34);
            this.SastojakCmb.Name = "SastojakCmb";
            this.SastojakCmb.Size = new System.Drawing.Size(332, 21);
            this.SastojakCmb.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(901, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EvidencijaNabavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 665);
            this.Controls.Add(this.groupBox1);
            this.Name = "EvidencijaNabavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija nabavke";
            this.Load += new System.EventHandler(this.EvidencijaNabavke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SastojciGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox NapomenaTxt;
        private System.Windows.Forms.ComboBox DobavljacCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DatumTxt;
        private System.Windows.Forms.Label AdresaTxt;
        private System.Windows.Forms.MaskedTextBox CijenaTxt;
        private System.Windows.Forms.MaskedTextBox KolicinaTxt;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.DataGridView SastojciGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SastojakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sastojak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SastojakCmb;
        private System.Windows.Forms.Button button1;
    }
}