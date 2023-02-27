namespace MyAnimeList
{
    partial class Fonksiyon
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
            this.comboBoxAnime = new System.Windows.Forms.ComboBox();
            this.comboBoxDil = new System.Windows.Forms.ComboBox();
            this.textBoxYas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDileGore = new System.Windows.Forms.Button();
            this.btnOrtBolum = new System.Windows.Forms.Button();
            this.btnNeKadar = new System.Windows.Forms.Button();
            this.btnYasYetermi = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAnime
            // 
            this.comboBoxAnime.FormattingEnabled = true;
            this.comboBoxAnime.Location = new System.Drawing.Point(655, 44);
            this.comboBoxAnime.Name = "comboBoxAnime";
            this.comboBoxAnime.Size = new System.Drawing.Size(121, 23);
            this.comboBoxAnime.TabIndex = 0;
            // 
            // comboBoxDil
            // 
            this.comboBoxDil.FormattingEnabled = true;
            this.comboBoxDil.Location = new System.Drawing.Point(616, 134);
            this.comboBoxDil.Name = "comboBoxDil";
            this.comboBoxDil.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDil.TabIndex = 1;
            // 
            // textBoxYas
            // 
            this.textBoxYas.Location = new System.Drawing.Point(616, 106);
            this.textBoxYas.Name = "textBoxYas";
            this.textBoxYas.Size = new System.Drawing.Size(121, 23);
            this.textBoxYas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anime Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dil :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yaş :";
            // 
            // btnDileGore
            // 
            this.btnDileGore.Location = new System.Drawing.Point(740, 134);
            this.btnDileGore.Name = "btnDileGore";
            this.btnDileGore.Size = new System.Drawing.Size(110, 23);
            this.btnDileGore.TabIndex = 6;
            this.btnDileGore.Text = "Dile Göre Anime";
            this.btnDileGore.UseVisualStyleBackColor = true;
            this.btnDileGore.Click += new System.EventHandler(this.btnDileGore_Click);
            // 
            // btnOrtBolum
            // 
            this.btnOrtBolum.Location = new System.Drawing.Point(577, 77);
            this.btnOrtBolum.Name = "btnOrtBolum";
            this.btnOrtBolum.Size = new System.Drawing.Size(129, 23);
            this.btnOrtBolum.TabIndex = 7;
            this.btnOrtBolum.Text = "Ortalama Bölüm Süresi";
            this.btnOrtBolum.UseVisualStyleBackColor = true;
            this.btnOrtBolum.Click += new System.EventHandler(this.btnOrtBolum_Click);
            // 
            // btnNeKadar
            // 
            this.btnNeKadar.Location = new System.Drawing.Point(712, 77);
            this.btnNeKadar.Name = "btnNeKadar";
            this.btnNeKadar.Size = new System.Drawing.Size(138, 23);
            this.btnNeKadar.TabIndex = 8;
            this.btnNeKadar.Text = "İzlemek Ne Kadar Sürer";
            this.btnNeKadar.UseVisualStyleBackColor = true;
            this.btnNeKadar.Click += new System.EventHandler(this.btnNeKadar_Click);
            // 
            // btnYasYetermi
            // 
            this.btnYasYetermi.Location = new System.Drawing.Point(740, 105);
            this.btnYasYetermi.Name = "btnYasYetermi";
            this.btnYasYetermi.Size = new System.Drawing.Size(110, 23);
            this.btnYasYetermi.TabIndex = 9;
            this.btnYasYetermi.Text = "Yaşın Yeterli Mi";
            this.btnYasYetermi.UseVisualStyleBackColor = true;
            this.btnYasYetermi.Click += new System.EventHandler(this.btnYasYetermi_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(58, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(497, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 198);
            this.button1.TabIndex = 11;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fonksiyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnYasYetermi);
            this.Controls.Add(this.btnNeKadar);
            this.Controls.Add(this.btnOrtBolum);
            this.Controls.Add(this.btnDileGore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxYas);
            this.Controls.Add(this.comboBoxDil);
            this.Controls.Add(this.comboBoxAnime);
            this.Name = "Fonksiyon";
            this.Text = "Fonksiyon";
            this.Load += new System.EventHandler(this.Fonksiyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxAnime;
        private ComboBox comboBoxDil;
        private TextBox textBoxYas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDileGore;
        private Button btnOrtBolum;
        private Button btnNeKadar;
        private Button btnYasYetermi;
        private DataGridView dataGridView2;
        private Button button1;
    }
}