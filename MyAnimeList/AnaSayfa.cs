using Npgsql;
using System.Data;

namespace MyAnimeList
{
    public partial class AnaSayfa : Form
    {




        NpgsqlConnection baglan = new NpgsqlConnection("Server=localHost ;Port=5432;Database=MyAnimeList;User Id=postgres;Password=efdal1020; ");


        public AnaSayfa()
        {
            InitializeComponent();

        }

        private void btnAnimeEkle_Click(object sender, EventArgs e)
        {
            string isim = txtAnimeAdi.Text;
            int sure = int.Parse(txtSiralamasi.Text);
            int siralama = int.Parse(txtSure.Text);

            this.Visible = false;
            DetayEkle detay = new DetayEkle(isim, sure, siralama);
            detay.ShowDialog();
            this.Visible = true;

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //string sorgub = "select * from \"Anime\" ";

            //NpgsqlDataAdapter dab = new NpgsqlDataAdapter(sorgub, baglan);

            //DataSet dsb = new DataSet();
            //dab.Fill(dsb);
            //dataGridView1.DataSource = dsb.Tables[0];

            string sorgu = "select * from \"AnimeGoruntu\" ";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Open();

            string ad = "select * from \"Anime\" ";


            NpgsqlDataAdapter daa = new NpgsqlDataAdapter(ad, baglan);
            DataTable dta = new DataTable();
            daa.Fill(dta);

            comboBoxBolumEkle.DisplayMember = "AnimeName";
            comboBoxBolumEkle.ValueMember = "ID";
            comboBoxBolumEkle.DataSource = dta;

            NpgsqlDataAdapter dae = new NpgsqlDataAdapter(ad, baglan);
            DataTable dte = new DataTable();
            dae.Fill(dte);

            comboBoxAnimeAdiSilme.DisplayMember = "AnimeName";
            comboBoxAnimeAdiSilme.ValueMember = "ID";
            comboBoxAnimeAdiSilme.DataSource = dte;



            string sorguu = "select * from \"toplamAnime\"() ";
            NpgsqlCommand dan = new NpgsqlCommand(sorguu, baglan);

            lblAnimeSayisi.Text = dan.ExecuteScalar().ToString();
            baglan.Close();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from \"AnimeGoruntu\" ";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Open();

            string ad = "select * from \"Anime\" ";


            NpgsqlDataAdapter daa = new NpgsqlDataAdapter(ad, baglan);
            DataTable dta = new DataTable();
            daa.Fill(dta);

            comboBoxBolumEkle.DisplayMember = "AnimeName";
            comboBoxBolumEkle.ValueMember = "ID";
            comboBoxBolumEkle.DataSource = dta;

            NpgsqlDataAdapter dae = new NpgsqlDataAdapter(ad, baglan);
            DataTable dte = new DataTable();
            dae.Fill(dte);

            comboBoxAnimeAdiSilme.DisplayMember = "AnimeName";
            comboBoxAnimeAdiSilme.ValueMember = "ID";
            comboBoxAnimeAdiSilme.DataSource = dte;

            string sorguu = "select * from \"toplamAnime\"() ";
            NpgsqlCommand dan = new NpgsqlCommand(sorguu, baglan);

            lblAnimeSayisi.Text = dan.ExecuteScalar().ToString();

            baglan.Close();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string komut = "delete from \"Anime\" where \"ID\" = @p1 ";
            NpgsqlCommand komut1 = new NpgsqlCommand(komut, baglan);
            komut1.Parameters.AddWithValue("@p1", comboBoxAnimeAdiSilme.SelectedValue);

            komut1.ExecuteNonQuery();

            baglan.Close();


            MessageBox.Show("Anime Silindi :( ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BölümEkle bolum = new BölümEkle((short)comboBoxBolumEkle.SelectedValue, comboBoxBolumEkle.Text);
            bolum.ShowDialog();
            this.Visible = true;
        }

        private void btnBolumListele_Click(object sender, EventArgs e)
        {

            short gstbolum = (short)comboBoxBolumEkle.SelectedValue;
            string sorgub = "select * from \"Episode\" where \"Anime_ID\" = " + gstbolum + "  ";

            NpgsqlDataAdapter dab = new NpgsqlDataAdapter(sorgub, baglan);


            DataSet dsb = new DataSet();
            dab.Fill(dsb);
            dataGridView1.DataSource = dsb.Tables[0];
        }

        private void btnAnimeGuncelle_Click(object sender, EventArgs e)
        {



            short isim = (short)comboBoxAnimeAdiSilme.SelectedValue;
            this.Visible = false;
            Güncelle detay = new Güncelle(isim);
            detay.ShowDialog();
            this.Visible = true;
        }

        private void btnFonksiyon_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fonksiyon fonksiyon = new Fonksiyon();
            fonksiyon.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short gstbolum = (short)comboBoxAnimeAdiSilme.SelectedValue;
            string sorgub = "select * from \"Character\" where \"Anime_ID\" = " + gstbolum + "  ";

            NpgsqlDataAdapter dab = new NpgsqlDataAdapter(sorgub, baglan);


            DataSet dsb = new DataSet();
            dab.Fill(dsb);
            dataGridView1.DataSource = dsb.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from \"YedekBolum\" ";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglan);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAnimeAra_Click(object sender, EventArgs e)
        {

            //baglan.Open();
            string deger = txtAnimeAdi.Text;

            string komut = "SELECT * FROM arama( \' " + deger + " \' ) ";
            NpgsqlDataAdapter komut1 = new NpgsqlDataAdapter(komut, baglan);


            DataSet dsb = new DataSet();
            komut1.Fill(dsb);
            dataGridView1.DataSource = dsb.Tables[0];

            baglan.Close();



            string sorgu = "select * from \"Anime\" where \"ID\"=  " + deger + "   ";

            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglan);

            //DataSet ds = new DataSet();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
        }
    }
}