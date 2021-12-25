
namespace okulodev
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnMusteriGirisi = new System.Windows.Forms.Button();
            this.BtnKayıtMusteri = new System.Windows.Forms.Button();
            this.BtnYetkiliGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMusteriGirisi
            // 
            this.BtnMusteriGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnMusteriGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteriGirisi.BackgroundImage")));
            this.BtnMusteriGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMusteriGirisi.Location = new System.Drawing.Point(15, 106);
            this.BtnMusteriGirisi.Name = "BtnMusteriGirisi";
            this.BtnMusteriGirisi.Size = new System.Drawing.Size(187, 174);
            this.BtnMusteriGirisi.TabIndex = 0;
            this.BtnMusteriGirisi.UseVisualStyleBackColor = false;
            this.BtnMusteriGirisi.Click += new System.EventHandler(this.BtnMusteriGirisi_Click);
            // 
            // BtnKayıtMusteri
            // 
            this.BtnKayıtMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnKayıtMusteri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnKayıtMusteri.BackgroundImage")));
            this.BtnKayıtMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnKayıtMusteri.Location = new System.Drawing.Point(208, 106);
            this.BtnKayıtMusteri.Name = "BtnKayıtMusteri";
            this.BtnKayıtMusteri.Size = new System.Drawing.Size(187, 174);
            this.BtnKayıtMusteri.TabIndex = 0;
            this.BtnKayıtMusteri.UseVisualStyleBackColor = false;
            this.BtnKayıtMusteri.Click += new System.EventHandler(this.BtnKayıtMusteri_Click);
            // 
            // BtnYetkiliGirisi
            // 
            this.BtnYetkiliGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnYetkiliGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnYetkiliGirisi.BackgroundImage")));
            this.BtnYetkiliGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnYetkiliGirisi.Location = new System.Drawing.Point(401, 106);
            this.BtnYetkiliGirisi.Name = "BtnYetkiliGirisi";
            this.BtnYetkiliGirisi.Size = new System.Drawing.Size(187, 174);
            this.BtnYetkiliGirisi.TabIndex = 0;
            this.BtnYetkiliGirisi.UseVisualStyleBackColor = false;
            this.BtnYetkiliGirisi.Click += new System.EventHandler(this.BtnYetkiliGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Giriş Yapmak İstediğiniz Alana Tıklayınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Giriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(203, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Kayıt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(403, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yönetici Giriş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(640, 356);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnYetkiliGirisi);
            this.Controls.Add(this.BtnKayıtMusteri);
            this.Controls.Add(this.BtnMusteriGirisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMusteriGirisi;
        private System.Windows.Forms.Button BtnKayıtMusteri;
        private System.Windows.Forms.Button BtnYetkiliGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

