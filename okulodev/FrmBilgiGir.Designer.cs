
namespace okulodev
{
    partial class FrmBilgiGir
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
            this.TxtAlıcıSoyad = new System.Windows.Forms.TextBox();
            this.TxtAlıcıAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAlıcıSoyad
            // 
            this.TxtAlıcıSoyad.Location = new System.Drawing.Point(169, 73);
            this.TxtAlıcıSoyad.Name = "TxtAlıcıSoyad";
            this.TxtAlıcıSoyad.Size = new System.Drawing.Size(240, 29);
            this.TxtAlıcıSoyad.TabIndex = 13;
            // 
            // TxtAlıcıAd
            // 
            this.TxtAlıcıAd.Location = new System.Drawing.Point(169, 31);
            this.TxtAlıcıAd.Name = "TxtAlıcıAd";
            this.TxtAlıcıAd.Size = new System.Drawing.Size(240, 29);
            this.TxtAlıcıAd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alıcı Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alıcı Ad:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(169, 131);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(240, 29);
            this.MskTelefon.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon:";
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(169, 234);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(240, 124);
            this.RchAdres.TabIndex = 17;
            this.RchAdres.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Adres:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Devam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBilgiGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(479, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RchAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtAlıcıSoyad);
            this.Controls.Add(this.TxtAlıcıAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmBilgiGir";
            this.Text = "FrmBilgiGir";
            this.Load += new System.EventHandler(this.FrmBilgiGir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAlıcıSoyad;
        private System.Windows.Forms.TextBox TxtAlıcıAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RchAdres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}