﻿namespace ESBX_Client.Opste
{
    partial class PodesavanjeLozinke
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
            this.NovaTxt = new System.Windows.Forms.TextBox();
            this.TrenutnaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PotvrdaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SacuvajBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NovaTxt
            // 
            this.NovaTxt.Location = new System.Drawing.Point(191, 128);
            this.NovaTxt.Name = "NovaTxt";
            this.NovaTxt.PasswordChar = '*';
            this.NovaTxt.Size = new System.Drawing.Size(200, 20);
            this.NovaTxt.TabIndex = 42;
            this.NovaTxt.Validating += new System.ComponentModel.CancelEventHandler(this.NovaTxt_Validating);
            // 
            // TrenutnaTxt
            // 
            this.TrenutnaTxt.Location = new System.Drawing.Point(191, 87);
            this.TrenutnaTxt.Name = "TrenutnaTxt";
            this.TrenutnaTxt.PasswordChar = '*';
            this.TrenutnaTxt.Size = new System.Drawing.Size(200, 20);
            this.TrenutnaTxt.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nova lozinka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Trenutna lozinka";
            // 
            // PotvrdaTxt
            // 
            this.PotvrdaTxt.Location = new System.Drawing.Point(191, 173);
            this.PotvrdaTxt.Name = "PotvrdaTxt";
            this.PotvrdaTxt.PasswordChar = '*';
            this.PotvrdaTxt.Size = new System.Drawing.Size(200, 20);
            this.PotvrdaTxt.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Potvrdi lozinku";
            // 
            // SacuvajBtn
            // 
            this.SacuvajBtn.Location = new System.Drawing.Point(316, 231);
            this.SacuvajBtn.Name = "SacuvajBtn";
            this.SacuvajBtn.Size = new System.Drawing.Size(75, 23);
            this.SacuvajBtn.TabIndex = 45;
            this.SacuvajBtn.Text = "Sačuvaj";
            this.SacuvajBtn.UseVisualStyleBackColor = true;
            this.SacuvajBtn.Click += new System.EventHandler(this.SacuvajBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // PodesavanjeLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 336);
            this.Controls.Add(this.SacuvajBtn);
            this.Controls.Add(this.PotvrdaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NovaTxt);
            this.Controls.Add(this.TrenutnaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PodesavanjeLozinke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podesavanje lozinke";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NovaTxt;
        private System.Windows.Forms.TextBox TrenutnaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PotvrdaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SacuvajBtn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}