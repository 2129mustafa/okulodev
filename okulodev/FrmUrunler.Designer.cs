
namespace okulodev
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblUrunAdi = new System.Windows.Forms.Label();
            this.LblUrunFiyati = new System.Windows.Forms.Label();
            this.LblUrunAgirlik = new System.Windows.Forms.Label();
            this.LblUrunKategori = new System.Windows.Forms.Label();
            this.TxtUrunAdi = new System.Windows.Forms.TextBox();
            this.TxtUrunFiyati = new System.Windows.Forms.TextBox();
            this.TxtUrunAgirlik = new System.Windows.Forms.TextBox();
            this.TxtUrunKategori = new System.Windows.Forms.TextBox();
            this.grbUrunler = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUrunId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAnaSayfayaDon = new System.Windows.Forms.Button();
            this.BtnUrunSil = new System.Windows.Forms.Button();
            this.BtnUrunGuncelle = new System.Windows.Forms.Button();
            this.BtnUrunEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbUrunler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // LblUrunAdi
            // 
            this.LblUrunAdi.AutoSize = true;
            this.LblUrunAdi.Location = new System.Drawing.Point(59, 89);
            this.LblUrunAdi.Name = "LblUrunAdi";
            this.LblUrunAdi.Size = new System.Drawing.Size(89, 24);
            this.LblUrunAdi.TabIndex = 1;
            this.LblUrunAdi.Text = "Ürün Adı:";
            // 
            // LblUrunFiyati
            // 
            this.LblUrunFiyati.AutoSize = true;
            this.LblUrunFiyati.Location = new System.Drawing.Point(53, 140);
            this.LblUrunFiyati.Name = "LblUrunFiyati";
            this.LblUrunFiyati.Size = new System.Drawing.Size(95, 24);
            this.LblUrunFiyati.TabIndex = 2;
            this.LblUrunFiyati.Text = "Ürün Fiyat";
            // 
            // LblUrunAgirlik
            // 
            this.LblUrunAgirlik.AutoSize = true;
            this.LblUrunAgirlik.Location = new System.Drawing.Point(41, 190);
            this.LblUrunAgirlik.Name = "LblUrunAgirlik";
            this.LblUrunAgirlik.Size = new System.Drawing.Size(107, 24);
            this.LblUrunAgirlik.TabIndex = 3;
            this.LblUrunAgirlik.Text = "Ürün Ağrılık";
            // 
            // LblUrunKategori
            // 
            this.LblUrunKategori.AutoSize = true;
            this.LblUrunKategori.Location = new System.Drawing.Point(23, 244);
            this.LblUrunKategori.Name = "LblUrunKategori";
            this.LblUrunKategori.Size = new System.Drawing.Size(125, 24);
            this.LblUrunKategori.TabIndex = 4;
            this.LblUrunKategori.Text = "Ürün Kategori";
            // 
            // TxtUrunAdi
            // 
            this.TxtUrunAdi.Location = new System.Drawing.Point(154, 89);
            this.TxtUrunAdi.Name = "TxtUrunAdi";
            this.TxtUrunAdi.Size = new System.Drawing.Size(161, 29);
            this.TxtUrunAdi.TabIndex = 5;
            // 
            // TxtUrunFiyati
            // 
            this.TxtUrunFiyati.Location = new System.Drawing.Point(154, 140);
            this.TxtUrunFiyati.Name = "TxtUrunFiyati";
            this.TxtUrunFiyati.Size = new System.Drawing.Size(161, 29);
            this.TxtUrunFiyati.TabIndex = 6;
            // 
            // TxtUrunAgirlik
            // 
            this.TxtUrunAgirlik.Location = new System.Drawing.Point(154, 187);
            this.TxtUrunAgirlik.Name = "TxtUrunAgirlik";
            this.TxtUrunAgirlik.Size = new System.Drawing.Size(161, 29);
            this.TxtUrunAgirlik.TabIndex = 7;
            // 
            // TxtUrunKategori
            // 
            this.TxtUrunKategori.Location = new System.Drawing.Point(154, 239);
            this.TxtUrunKategori.Name = "TxtUrunKategori";
            this.TxtUrunKategori.Size = new System.Drawing.Size(161, 29);
            this.TxtUrunKategori.TabIndex = 8;
            // 
            // grbUrunler
            // 
            this.grbUrunler.Controls.Add(this.label1);
            this.grbUrunler.Controls.Add(this.TxtUrunId);
            this.grbUrunler.Controls.Add(this.TxtUrunKategori);
            this.grbUrunler.Controls.Add(this.LblUrunAdi);
            this.grbUrunler.Controls.Add(this.TxtUrunAgirlik);
            this.grbUrunler.Controls.Add(this.LblUrunFiyati);
            this.grbUrunler.Controls.Add(this.TxtUrunFiyati);
            this.grbUrunler.Controls.Add(this.LblUrunAgirlik);
            this.grbUrunler.Controls.Add(this.TxtUrunAdi);
            this.grbUrunler.Controls.Add(this.LblUrunKategori);
            this.grbUrunler.Location = new System.Drawing.Point(15, 302);
            this.grbUrunler.Name = "grbUrunler";
            this.grbUrunler.Size = new System.Drawing.Size(359, 306);
            this.grbUrunler.TabIndex = 9;
            this.grbUrunler.TabStop = false;
            this.grbUrunler.Text = "Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Id:";
            // 
            // TxtUrunId
            // 
            this.TxtUrunId.Enabled = false;
            this.TxtUrunId.Location = new System.Drawing.Point(154, 40);
            this.TxtUrunId.Name = "TxtUrunId";
            this.TxtUrunId.Size = new System.Drawing.Size(161, 29);
            this.TxtUrunId.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAnaSayfayaDon);
            this.groupBox2.Controls.Add(this.BtnUrunSil);
            this.groupBox2.Controls.Add(this.BtnUrunGuncelle);
            this.groupBox2.Controls.Add(this.BtnUrunEkle);
            this.groupBox2.Location = new System.Drawing.Point(389, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 294);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnAnaSayfayaDon
            // 
            this.BtnAnaSayfayaDon.Location = new System.Drawing.Point(17, 233);
            this.BtnAnaSayfayaDon.Name = "BtnAnaSayfayaDon";
            this.BtnAnaSayfayaDon.Size = new System.Drawing.Size(170, 46);
            this.BtnAnaSayfayaDon.TabIndex = 3;
            this.BtnAnaSayfayaDon.Text = "Ana Sayfaya Dön";
            this.BtnAnaSayfayaDon.UseVisualStyleBackColor = true;
            this.BtnAnaSayfayaDon.Click += new System.EventHandler(this.BtnAnaSayfayaDon_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.Location = new System.Drawing.Point(17, 173);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(170, 46);
            this.BtnUrunSil.TabIndex = 2;
            this.BtnUrunSil.Text = "Ürün Sil";
            this.BtnUrunSil.UseVisualStyleBackColor = true;
            this.BtnUrunSil.Click += new System.EventHandler(this.BtnUrunSil_Click);
            // 
            // BtnUrunGuncelle
            // 
            this.BtnUrunGuncelle.Location = new System.Drawing.Point(17, 102);
            this.BtnUrunGuncelle.Name = "BtnUrunGuncelle";
            this.BtnUrunGuncelle.Size = new System.Drawing.Size(170, 46);
            this.BtnUrunGuncelle.TabIndex = 1;
            this.BtnUrunGuncelle.Text = "Ürün Güncelle";
            this.BtnUrunGuncelle.UseVisualStyleBackColor = true;
            this.BtnUrunGuncelle.Click += new System.EventHandler(this.BtnUrunGuncelle_Click);
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.Location = new System.Drawing.Point(17, 35);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(170, 46);
            this.BtnUrunEkle.TabIndex = 0;
            this.BtnUrunEkle.Text = "Ürün Ekle";
            this.BtnUrunEkle.UseVisualStyleBackColor = true;
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(883, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbUrunler);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmUrunler";
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbUrunler.ResumeLayout(false);
            this.grbUrunler.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblUrunAdi;
        private System.Windows.Forms.Label LblUrunFiyati;
        private System.Windows.Forms.Label LblUrunAgirlik;
        private System.Windows.Forms.Label LblUrunKategori;
        private System.Windows.Forms.TextBox TxtUrunAdi;
        private System.Windows.Forms.TextBox TxtUrunFiyati;
        private System.Windows.Forms.TextBox TxtUrunAgirlik;
        private System.Windows.Forms.TextBox TxtUrunKategori;
        private System.Windows.Forms.GroupBox grbUrunler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnUrunSil;
        private System.Windows.Forms.Button BtnUrunGuncelle;
        private System.Windows.Forms.Button BtnUrunEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUrunId;
        private System.Windows.Forms.Button BtnAnaSayfayaDon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}