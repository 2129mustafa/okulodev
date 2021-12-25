
namespace okulodev
{
    partial class FrmCekOdeme
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
            this.BtnOdemeyiTamamla = new System.Windows.Forms.Button();
            this.MskBankaNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCıkısCek = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOdemeyiTamamla
            // 
            this.BtnOdemeyiTamamla.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOdemeyiTamamla.Location = new System.Drawing.Point(165, 99);
            this.BtnOdemeyiTamamla.Name = "BtnOdemeyiTamamla";
            this.BtnOdemeyiTamamla.Size = new System.Drawing.Size(194, 49);
            this.BtnOdemeyiTamamla.TabIndex = 21;
            this.BtnOdemeyiTamamla.Text = "Ödemeyi Tamamla";
            this.BtnOdemeyiTamamla.UseVisualStyleBackColor = false;
            this.BtnOdemeyiTamamla.Click += new System.EventHandler(this.BtnOdemeyiTamamla_Click);
            // 
            // MskBankaNo
            // 
            this.MskBankaNo.Location = new System.Drawing.Point(165, 39);
            this.MskBankaNo.Mask = "0000000";
            this.MskBankaNo.Name = "MskBankaNo";
            this.MskBankaNo.Size = new System.Drawing.Size(194, 29);
            this.MskBankaNo.TabIndex = 23;
            this.MskBankaNo.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Banka No:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 152);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 24);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Banko No Ekle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCıkısCek
            // 
            this.btnCıkısCek.Location = new System.Drawing.Point(106, 192);
            this.btnCıkısCek.Name = "btnCıkısCek";
            this.btnCıkısCek.Size = new System.Drawing.Size(80, 37);
            this.btnCıkısCek.TabIndex = 27;
            this.btnCıkısCek.Text = "Cıkıs";
            this.btnCıkısCek.UseVisualStyleBackColor = true;
            this.btnCıkısCek.Click += new System.EventHandler(this.btnCıkısCek_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCekOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(502, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCıkısCek);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.MskBankaNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnOdemeyiTamamla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCekOdeme";
            this.Text = "FrmCekOdeme";
            this.Load += new System.EventHandler(this.FrmCekOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOdemeyiTamamla;
        private System.Windows.Forms.MaskedTextBox MskBankaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnCıkısCek;
        private System.Windows.Forms.Button button1;
    }
}