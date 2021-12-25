
namespace okulodev
{
    partial class FrmNakitOdeme
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
            this.BtnCıkısNakit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOdemeyiTamamla
            // 
            this.BtnOdemeyiTamamla.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnOdemeyiTamamla.Location = new System.Drawing.Point(87, 50);
            this.BtnOdemeyiTamamla.Name = "BtnOdemeyiTamamla";
            this.BtnOdemeyiTamamla.Size = new System.Drawing.Size(194, 49);
            this.BtnOdemeyiTamamla.TabIndex = 6;
            this.BtnOdemeyiTamamla.Text = "Ödemeyi Tamamla";
            this.BtnOdemeyiTamamla.UseVisualStyleBackColor = false;
            this.BtnOdemeyiTamamla.Click += new System.EventHandler(this.BtnOdemeyiTamamla_Click);
            // 
            // BtnCıkısNakit
            // 
            this.BtnCıkısNakit.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnCıkısNakit.Location = new System.Drawing.Point(128, 133);
            this.BtnCıkısNakit.Name = "BtnCıkısNakit";
            this.BtnCıkısNakit.Size = new System.Drawing.Size(111, 35);
            this.BtnCıkısNakit.TabIndex = 8;
            this.BtnCıkısNakit.Text = "Cıkıs";
            this.BtnCıkısNakit.UseVisualStyleBackColor = false;
            this.BtnCıkısNakit.Click += new System.EventHandler(this.BtnCıkısNakit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(245, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ana Menü";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmNakitOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 180);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCıkısNakit);
            this.Controls.Add(this.BtnOdemeyiTamamla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmNakitOdeme";
            this.Text = "FrmNakitOdeme";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnOdemeyiTamamla;
        private System.Windows.Forms.Button BtnCıkısNakit;
        private System.Windows.Forms.Button button1;
    }
}