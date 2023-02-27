using Npgsql;
using System.Data;

namespace MyAnimeList
{
    public partial class DetayEkle : Form
    {
        //Baglanti baglanti = new Baglanti();
        NpgsqlConnection baglan = new NpgsqlConnection("Server=localHost ;Port=5432;Database=MyAnimeList;User Id=postgres;Password=efdal1020; ");
        string animeAdi;
        int sure;
        int siralama;
        public DetayEkle(string animeAd, int sure, int siralama)
        {
            InitializeComponent();
            this.animeAdi = animeAd;
            this.sure = sure;
            this.siralama = siralama;
            lblAnimeAdi.Text = animeAdi;
            lblSira.Text = siralama.ToString();
            lblSure.Text = sure.ToString();
        }

        private void DetayEkle_Load(object sender, EventArgs e)
        {
            baglan.Open();
            string genre = "select * from \"Genre\" ";
            string country = "select * from \"Country\" ";
            string certificate = "select * from \"Certificate\" ";
            string distrubutır = "select * from \"Company\" where \"Tipi\"=\'D\' ";
            string producer = "select * from \"Company\" where \"Tipi\"=\'P\' ";
            string language = "select * from \"Language\" ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(genre, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxGenre.DisplayMember = "Name";
            comboBoxGenre.ValueMember = "ID";
            comboBoxGenre.DataSource = dt;

            NpgsqlDataAdapter daa = new NpgsqlDataAdapter(country, baglan);
            DataTable dta = new DataTable();
            daa.Fill(dta);

            comboBoxCountry.DisplayMember = "Country";
            comboBoxCountry.ValueMember = "ID";
            comboBoxCountry.DataSource = dta;

            NpgsqlDataAdapter dab = new NpgsqlDataAdapter(certificate, baglan);
            DataTable dtb = new DataTable();
            dab.Fill(dtb);

            comboBoxCertificate.DisplayMember = "Certificate";
            comboBoxCertificate.ValueMember = "ID";
            comboBoxCertificate.DataSource = dtb;

            NpgsqlDataAdapter dac = new NpgsqlDataAdapter(distrubutır, baglan);
            DataTable dtc = new DataTable();
            dac.Fill(dtc);

            comboBoxDistrubutor.DisplayMember = "Company";
            comboBoxDistrubutor.ValueMember = "ID";
            comboBoxDistrubutor.DataSource = dtc;

            NpgsqlDataAdapter dad = new NpgsqlDataAdapter(producer, baglan);
            DataTable dtd = new DataTable();
            dad.Fill(dtd);

            comboBoxProducer.DisplayMember = "Company";
            comboBoxProducer.ValueMember = "ID";
            comboBoxProducer.DataSource = dtd;


            NpgsqlDataAdapter dae = new NpgsqlDataAdapter(language, baglan);
            DataTable dte = new DataTable();
            dae.Fill(dte);

            comboBoxLanguage.DisplayMember = "Language";
            comboBoxLanguage.ValueMember = "ID";
            comboBoxLanguage.DataSource = dte;

            baglan.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string komut1 = "INSERT INTO \"public\".\"Anime\" ( \"ID\"," +
                " \"AnimeName\", \"Runtime\", \"Rank\", \"Episodes\", \"Country\", \"Genre\", \"Language\", \"Certificate\", \"Distrubutor\", \"Producer\" )" +
                " VALUES(DEFAULT, @p1, @p2, @p3, DEFAULT, @p4, @p5, @p6, @p7, @p8, @p9 )";
            NpgsqlCommand komut = new NpgsqlCommand(komut1, baglan);

            komut.Parameters.AddWithValue("@p1", animeAdi);
            komut.Parameters.AddWithValue("@p2", siralama);
            komut.Parameters.AddWithValue("@p3", sure);
            komut.Parameters.AddWithValue("@p4", comboBoxCountry.SelectedValue);
            komut.Parameters.AddWithValue("@p5", comboBoxGenre.SelectedValue);
            komut.Parameters.AddWithValue("@p6", comboBoxLanguage.SelectedValue);
            komut.Parameters.AddWithValue("@p7", comboBoxCertificate.SelectedValue);
            komut.Parameters.AddWithValue("@p8", comboBoxDistrubutor.SelectedValue);
            komut.Parameters.AddWithValue("@p9", comboBoxProducer.SelectedValue);

            komut.ExecuteNonQuery();

            MessageBox.Show("Anime Eklendi :) ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);




        }
    }
}
