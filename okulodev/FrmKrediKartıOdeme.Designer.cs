
namespace okulodev
{
    partial class FrmKrediKartıOdeme
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MskKartNo = new System.Windows.Forms.MaskedTextBox();
            this.MskCcv = new System.Windows.Forms.MaskedTextBox();
            this.BtnOdemeyiTamamla = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCıkısKart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kart No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ccv:";
            // 
            // MskKartNo
            // 
            this.MskKartNo.Location = new System.Drawing.Point(171, 87);
            this.MskKartNo.Mask = "0000000000000000";
            this.MskKartNo.Name = "MskKartNo";
            this.MskKartNo.Size = new System.Drawing.Size(240, 29);
            this.MskKartNo.TabIndex = 13;
            this.MskKartNo.ValidatingType = typeof(int);
            // 
            // MskCcv
            // 
            this.MskCcv.Location = new System.Drawing.Point(171, 127);
            this.MskCcv.Mask = "000";
            this.MskCcv.Name = "MskCcv";
            this.MskCcv.Size = new System.Drawing.Size(240, 29);
            this.MskCcv.TabIndex = 14;
            this.MskCcv.ValidatingType = typeof(int);
            // 
            // BtnOdemeyiTamamla
            // 
            this.BtnOdemeyiTamamla.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOdemeyiTamamla.Location = new System.Drawing.Point(171, 172);
            this.BtnOdemeyiTamamla.Name = "BtnOdemeyiTamamla";
            this.BtnOdemeyiTamamla.Size = new System.Drawing.Size(240, 49);
            this.BtnOdemeyiTamamla.TabIndex = 16;
            this.BtnOdemeyiTamamla.Text = "Ödemeyi Tamamla";
            this.BtnOdemeyiTamamla.UseVisualStyleBackColor = false;
            this.BtnOdemeyiTamamla.Click += new System.EventHandler(this.BtnOdemeyiTamamla_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 184);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 24);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kart Ekle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCıkısKart
            // 
            this.btnCıkısKart.Location = new System.Drawing.Point(16, 258);
            this.btnCıkısKart.Name = "btnCıkısKart";
            this.btnCıkısKart.Size = new System.Drawing.Size(101, 48);
            this.btnCıkısKart.TabIndex = 19;
            this.btnCıkısKart.Text = "Cıkıs";
            this.btnCıkısKart.UseVisualStyleBackColor = true;
            this.btnCıkısKart.Click += new System.EventHandler(this.btnCıkısKart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmKrediKartıOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCıkısKart);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtnOdemeyiTamamla);
            this.Controls.Add(this.MskCcv);
            this.Controls.Add(this.MskKartNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmKrediKartıOdeme";
            this.Text = "Kredi Kartı Ödemeleri";
            this.Load += new System.EventHandler(this.FrmKrediKartıOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskKartNo;
        private System.Windows.Forms.MaskedTextBox MskCcv;
        private System.Windows.Forms.Button BtnOdemeyiTamamla;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnCıkısKart;
        private System.Windows.Forms.Button button1;
    }
}