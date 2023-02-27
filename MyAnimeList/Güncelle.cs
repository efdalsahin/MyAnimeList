using Npgsql;
using System.Data;

namespace MyAnimeList
{
    public partial class Güncelle : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("Server=localHost ;Port=5432;Database=MyAnimeList;User Id=postgres;Password=efdal1020; ");


        short animeid;

        public Güncelle(short animeAd)
        {
            InitializeComponent();

            this.animeid = animeAd;

        }

        private void Güncelle_Load(object sender, EventArgs e)
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
            string komut1 = "update \"Anime\" set \"Country\"=@p1,\"Genre\"=@p2,\"Language\"=@p3,\"Certificate\"=@p4,\"Distrubutor\"=@p5," +
                "\"Producer\"=@p6 where \"ID\" =@p7 ";
            NpgsqlCommand komut = new NpgsqlCommand(komut1, baglan);


            komut.Parameters.AddWithValue("@p1", comboBoxCountry.SelectedValue);
            komut.Parameters.AddWithValue("@p2", comboBoxGenre.SelectedValue);
            komut.Parameters.AddWithValue("@p3", comboBoxLanguage.SelectedValue);
            komut.Parameters.AddWithValue("@p4", comboBoxCertificate.SelectedValue);
            komut.Parameters.AddWithValue("@p5", comboBoxDistrubutor.SelectedValue);
            komut.Parameters.AddWithValue("@p6", comboBoxProducer.SelectedValue);
            komut.Parameters.AddWithValue("@p7", animeid);

            komut.ExecuteNonQuery();

            MessageBox.Show("Anime Güncellendi :) ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
