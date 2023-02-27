using Npgsql;
using System.Data;

namespace MyAnimeList
{
    public partial class Fonksiyon : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("Server=localHost ;Port=5432;Database=MyAnimeList;User Id=postgres;Password=efdal1020; ");

        public Fonksiyon()
        {
            InitializeComponent();
        }

        private void Fonksiyon_Load(object sender, EventArgs e)
        {
            baglan.Open();

            string ad = "select * from \"Anime\" ";
            string dil = "select * from \"Language\" ";


            NpgsqlDataAdapter daa = new NpgsqlDataAdapter(ad, baglan);
            DataTable dta = new DataTable();
            daa.Fill(dta);

            comboBoxAnime.DisplayMember = "AnimeName";
            comboBoxAnime.ValueMember = "ID";
            comboBoxAnime.DataSource = dta;

            NpgsqlDataAdapter dae = new NpgsqlDataAdapter(dil, baglan);
            DataTable dte = new DataTable();
            dae.Fill(dte);

            comboBoxDil.DisplayMember = "Language";
            comboBoxDil.ValueMember = "ID";
            comboBoxDil.DataSource = dte;

            baglan.Close();
        }

        private void btnOrtBolum_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string komut = "SELECT * FROM ortalamabolum(" + comboBoxAnime.SelectedValue + ") ";
            NpgsqlDataAdapter komut1 = new NpgsqlDataAdapter(komut, baglan);


            DataSet dsb = new DataSet();
            komut1.Fill(dsb);
            dataGridView2.DataSource = dsb.Tables[0];

            baglan.Close();
        }

        private void btnNeKadar_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string komut = "SELECT * FROM nekadarsürer(" + comboBoxAnime.SelectedValue + ") ";
            NpgsqlDataAdapter komut1 = new NpgsqlDataAdapter(komut, baglan);


            DataSet dsb = new DataSet();
            komut1.Fill(dsb);
            dataGridView2.DataSource = dsb.Tables[0];

            baglan.Close();
        }

        private void btnYasYetermi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string yas;

            yas = textBoxYas.Text;

            string komut = "SELECT * FROM yetermi(" + comboBoxAnime.SelectedValue + "," + yas + ") ";
            NpgsqlDataAdapter komut1 = new NpgsqlDataAdapter(komut, baglan);


            DataSet dsb = new DataSet();
            komut1.Fill(dsb);
            dataGridView2.DataSource = dsb.Tables[0];

            baglan.Close();
        }

        private void btnDileGore_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string komut = "SELECT * FROM dilegöreanime(" + comboBoxDil.SelectedValue + ") ";
            NpgsqlDataAdapter komut1 = new NpgsqlDataAdapter(komut, baglan);


            DataSet dsb = new DataSet();
            komut1.Fill(dsb);
            dataGridView2.DataSource = dsb.Tables[0];

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
