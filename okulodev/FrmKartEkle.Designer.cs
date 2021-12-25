
namespace okulodev
{
    partial class FrmKartEkle
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
            this.MskCcv = new System.Windows.Forms.MaskedTextBox();
            this.MskKartNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKartEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MskCcv
            // 
            this.MskCcv.Location = new System.Drawing.Point(128, 79);
            this.MskCcv.Mask = "000";
            this.MskCcv.Name = "MskCcv";
            this.MskCcv.Size = new System.Drawing.Size(240, 29);
            this.MskCcv.TabIndex = 18;
            this.MskCcv.ValidatingType = typeof(int);
            // 
            // MskKartNo
            // 
            this.MskKartNo.Location = new System.Drawing.Point(127, 38);
            this.MskKartNo.Mask = "0000000000000000";
            this.MskKartNo.Name = "MskKartNo";
            this.MskKartNo.Size = new System.Drawing.Size(240, 29);
            this.MskKartNo.TabIndex = 17;
            this.MskKartNo.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ccv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kart No:";
            // 
            // BtnKartEkle
            // 
            this.BtnKartEkle.Location = new System.Drawing.Point(127, 134);
            this.BtnKartEkle.Name = "BtnKartEkle";
            this.BtnKartEkle.Size = new System.Drawing.Size(189, 43);
            this.BtnKartEkle.TabIndex = 19;
            this.BtnKartEkle.Text = "Yeni Kart Ekle";
            this.BtnKartEkle.UseVisualStyleBackColor = true;
            this.BtnKartEkle.Click += new System.EventHandler(this.BtnKartEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Kart Odemeye Geri Don";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmKartEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnKartEkle);
            this.Controls.Add(this.MskCcv);
            this.Controls.Add(this.MskKartNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmKartEkle";
            this.Text = "FrmKartEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskCcv;
        private System.Windows.Forms.MaskedTextBox MskKartNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKartEkle;
        private System.Windows.Forms.Button button1;
    }
}