
namespace okulodev
{
    partial class FrmCekEkle
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
            this.MskBankaNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnBankaNoEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MskBankaNo
            // 
            this.MskBankaNo.Location = new System.Drawing.Point(138, 36);
            this.MskBankaNo.Mask = "0000000";
            this.MskBankaNo.Name = "MskBankaNo";
            this.MskBankaNo.Size = new System.Drawing.Size(194, 29);
            this.MskBankaNo.TabIndex = 26;
            this.MskBankaNo.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Banka No:";
            // 
            // BtnBankaNoEkle
            // 
            this.BtnBankaNoEkle.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnBankaNoEkle.Location = new System.Drawing.Point(138, 96);
            this.BtnBankaNoEkle.Name = "BtnBankaNoEkle";
            this.BtnBankaNoEkle.Size = new System.Drawing.Size(194, 42);
            this.BtnBankaNoEkle.TabIndex = 24;
            this.BtnBankaNoEkle.Text = "Banka No Ekle";
            this.BtnBankaNoEkle.UseVisualStyleBackColor = false;
            this.BtnBankaNoEkle.Click += new System.EventHandler(this.BtnBankaNoEkle_Click);
            // 
            // FrmCekEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(387, 223);
            this.Controls.Add(this.MskBankaNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnBankaNoEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmCekEkle";
            this.Text = "FrmCekEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskBankaNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnBankaNoEkle;
    }
}