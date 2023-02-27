using Npgsql;
using System.Data;

namespace MyAnimeList
{
    public partial class BölümEkle : Form
    {

        NpgsqlConnection baglan = new NpgsqlConnection("Server=localHost ;Port=5432;Database=MyAnimeList;User Id=postgres;Password=efdal1020; ");

        short animeid;
        string isim;

        public BölümEkle(short animeid, string isim)
        {
            InitializeComponent();
            this.animeid = animeid;
            this.isim = isim;
        }

        private void BölümEkle_Load(object sender, EventArgs e)
        {
            lblAnimeAdi.Text = isim;

            string bolum = "select * from \"Episode\" where \"Anime_ID\"=" + animeid + " ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(bolum, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxBolumler.DisplayMember = "Episode Name";
            comboBoxBolumler.ValueMember = "ID";
            comboBoxBolumler.DataSource = dt;

            string bolum1 = "select * from \"Character\" where \"Anime_ID\"=" + animeid + " ";
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(bolum1, baglan);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            comboBoxKarakterler.DisplayMember = "Name";
            comboBoxKarakterler.ValueMember = "Character_ID";
            comboBoxKarakterler.DataSource = dt1;

        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string komut1 = "INSERT INTO \"public\".\"Episode\" ( \"ID\", \"Episode Name\", \"Time\", \"Season\", \"Anime_ID\" ) VALUES(DEFAULT, @p1, @p2, @p3, @p4 )";


            NpgsqlCommand komut = new NpgsqlCommand(komut1, baglan);

            komut.Parameters.AddWithValue("@p1", txtBolumAdı.Text);
            komut.Parameters.AddWithValue("@p2", Int32.Parse(txtBolumSure.Text));
            komut.Parameters.AddWithValue("@p3", Int32.Parse(txtSezon.Text));
            komut.Parameters.AddWithValue("@p4", animeid);

            komut.ExecuteNonQuery();

            MessageBox.Show("Bölüm Eklendi :) ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            baglan.Close();

        }

        private void btnBolumSil_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string komut = "delete from \"Episode\" where \"ID\" = @p1 ";
            NpgsqlCommand komut1 = new NpgsqlCommand(komut, baglan);
            komut1.Parameters.AddWithValue("@p1", comboBoxBolumler.SelectedValue);

            komut1.ExecuteNonQuery();

            baglan.Close();


            MessageBox.Show("Bölüm Silindi :( ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMainEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string namee = txtCharacter.Text;
            string komut = "CALL mainEkle(@p1::smallint,@p2::text) ";
            NpgsqlCommand komut1 = new NpgsqlCommand(komut, baglan);
            komut1.Parameters.AddWithValue("@p1", animeid.ToString());
            komut1.Parameters.AddWithValue("@p2", namee);

            komut1.ExecuteNonQuery();

            baglan.Close();


            MessageBox.Show("Karakter Eklendi :) ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSideEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string namee = txtCharacter.Text;
            string komut = "CALL sideEkle(@p1::smallint,@p2::text) ";
            NpgsqlCommand komut1 = new NpgsqlCommand(komut, baglan);
            komut1.Parameters.AddWithValue("@p1", animeid.ToString());
            komut1.Parameters.AddWithValue("@p2", namee);

            komut1.ExecuteNonQuery();

            baglan.Close();


            MessageBox.Show("Karakter Eklendi :) ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVillianEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string namee = txtCharacter.Text;
            string komut = "CALL villianEkle(@p1::smallint,@p2::text) ";
            NpgsqlCommand komut1 = new NpgsqlCommand(komut, baglan);
            komut1.Parameters.AddWithValue("@p1", animeid.ToString());
            komut1.Parameters.AddWithValue("@p2", namee);

            komut1.ExecuteNonQuery();

            baglan.Close();


            MessageBox.Show("Karakter Eklendi :) ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKarakterSil_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string komut = "CALL karakterSil(@p1::smallint) ";
            NpgsqlCommand komut1 = new NpgsqlCommand(komut, baglan);
            komut1.Parameters.AddWithValue("@p1", comboBoxKarakterler.SelectedValue.ToString());


            komut1.ExecuteNonQuery();

            baglan.Close();


            MessageBox.Show("Karakter Silindi :( ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
