namespace MyAnimeList
{
    partial class AnaSayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnimeAdi = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiralamasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnimeEkle = new System.Windows.Forms.Button();
            this.btnAnimeGuncelle = new System.Windows.Forms.Button();
            this.comboBoxAnimeAdiSilme = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxBolumEkle = new System.Windows.Forms.ComboBox();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.btnBolumListele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFonksiyon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnimeSayisi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAnimeAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anime Adı :";
            // 
            // txtAnimeAdi
            // 
            this.txtAnimeAdi.Location = new System.Drawing.Point(681, 61);
            this.txtAnimeAdi.Name = "txtAnimeAdi";
            this.txtAnimeAdi.Size = new System.Drawing.Size(100, 23);
            this.txtAnimeAdi.TabIndex = 1;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(681, 102);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(100, 23);
            this.txtSure.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süresi :";
            // 
            // txtSiralamasi
            // 
            this.txtSiralamasi.Location = new System.Drawing.Point(681, 145);
            this.txtSiralamasi.Name = "txtSiralamasi";
            this.txtSiralamasi.Size = new System.Drawing.Size(100, 23);
            this.txtSiralamasi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sıralaması :";
            // 
            // btnAnimeEkle
            // 
            this.btnAnimeEkle.Location = new System.Drawing.Point(648, 192);
            this.btnAnimeEkle.Name = "btnAnimeEkle";
            this.btnAnimeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAnimeEkle.TabIndex = 8;
            this.btnAnimeEkle.Text = "Anime Ekle";
            this.btnAnimeEkle.UseVisualStyleBackColor = true;
            this.btnAnimeEkle.Click += new System.EventHandler(this.btnAnimeEkle_Click);
            // 
            // btnAnimeGuncelle
            // 
            this.btnAnimeGuncelle.Location = new System.Drawing.Point(719, 192);
            this.btnAnimeGuncelle.Name = "btnAnimeGuncelle";
            this.btnAnimeGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnAnimeGuncelle.TabIndex = 9;
            this.btnAnimeGuncelle.Text = "Güncelle";
            this.btnAnimeGuncelle.UseVisualStyleBackColor = true;
            this.btnAnimeGuncelle.Click += new System.EventHandler(this.btnAnimeGuncelle_Click);
            // 
            // comboBoxAnimeAdiSilme
            // 
            this.comboBoxAnimeAdiSilme.FormattingEnabled = true;
            this.comboBoxAnimeAdiSilme.Location = new System.Drawing.Point(681, 243);
            this.comboBoxAnimeAdiSilme.Name = "comboBoxAnimeAdiSilme";
            this.comboBoxAnimeAdiSilme.Size = new System.Drawing.Size(100, 23);
            this.comboBoxAnimeAdiSilme.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Anime Adı :";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(609, 12);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(172, 23);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.Location = new System.Drawing.Point(706, 286);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(75, 23);
            this.btnSilme.TabIndex = 13;
            this.btnSilme.Text = "Silme";
            this.btnSilme.UseVisualStyleBackColor = true;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Anime Adı :";
            // 
            // comboBoxBolumEkle
            // 
            this.comboBoxBolumEkle.FormattingEnabled = true;
            this.comboBoxBolumEkle.Location = new System.Drawing.Point(681, 327);
            this.comboBoxBolumEkle.Name = "comboBoxBolumEkle";
            this.comboBoxBolumEkle.Size = new System.Drawing.Size(100, 23);
            this.comboBoxBolumEkle.TabIndex = 14;
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(706, 371);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(75, 23);
            this.btnBolumEkle.TabIndex = 16;
            this.btnBolumEkle.Text = "BölümEkle";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // btnBolumListele
            // 
            this.btnBolumListele.Location = new System.Drawing.Point(606, 371);
            this.btnBolumListele.Name = "btnBolumListele";
            this.btnBolumListele.Size = new System.Drawing.Size(91, 23);
            this.btnBolumListele.TabIndex = 17;
            this.btnBolumListele.Text = "Bölüm Listele";
            this.btnBolumListele.UseVisualStyleBackColor = true;
            this.btnBolumListele.Click += new System.EventHandler(this.btnBolumListele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(541, 382);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnFonksiyon
            // 
            this.btnFonksiyon.Location = new System.Drawing.Point(800, 12);
            this.btnFonksiyon.Name = "btnFonksiyon";
            this.btnFonksiyon.Size = new System.Drawing.Size(30, 382);
            this.btnFonksiyon.TabIndex = 19;
            this.btnFonksiyon.Text = ">";
            this.btnFonksiyon.UseVisualStyleBackColor = true;
            this.btnFonksiyon.Click += new System.EventHandler(this.btnFonksiyon_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Karakterleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Toplam Anime Sayısı :";
            // 
            // lblAnimeSayisi
            // 
            this.lblAnimeSayisi.AutoSize = true;
            this.lblAnimeSayisi.Location = new System.Drawing.Point(147, 403);
            this.lblAnimeSayisi.Name = "lblAnimeSayisi";
            this.lblAnimeSayisi.Size = new System.Drawing.Size(0, 15);
            this.lblAnimeSayisi.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Silinenler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAnimeAra
            // 
            this.btnAnimeAra.Location = new System.Drawing.Point(567, 192);
            this.btnAnimeAra.Name = "btnAnimeAra";
            this.btnAnimeAra.Size = new System.Drawing.Size(75, 23);
            this.btnAnimeAra.TabIndex = 24;
            this.btnAnimeAra.Text = "Anime Ara";
            this.btnAnimeAra.UseVisualStyleBackColor = true;
            this.btnAnimeAra.Click += new System.EventHandler(this.btnAnimeAra_Click);
            // 
            // AnaSayfa
            // 
            this.ClientSize = new System.Drawing.Size(851, 430);
            this.Controls.Add(this.btnAnimeAra);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblAnimeSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFonksiyon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBolumListele);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxBolumEkle);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAnimeAdiSilme);
            this.Controls.Add(this.btnAnimeGuncelle);
            this.Controls.Add(this.btnAnimeEkle);
            this.Controls.Add(this.txtSiralamasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnimeAdi);
            this.Controls.Add(this.label1);
            this.Name = "AnaSayfa";
            this.Text = "My Anime List";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Label label1;
        private TextBox txtAnimeAdi;
        private TextBox txtSure;
        private Label label3;
        private TextBox txtSiralamasi;
        private Label label4;
        private Button btnAnimeEkle;
        private Button btnAnimeGuncelle;
        private ComboBox comboBoxAnimeAdiSilme;
        private Label label5;
        private Button btnListele;
        private Button btnSilme;
        private Label label6;
        private ComboBox comboBoxBolumEkle;
        private Button btnBolumEkle;
        private Button btnBolumListele;
        private DataGridView dataGridView1;
        private Button btnFonksiyon;
        private Button button1;
        private Label label2;
        private Label lblAnimeSayisi;
        private Button button2;
        private Button btnAnimeAra;
    }
}