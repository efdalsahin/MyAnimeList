using Npgsql;

namespace MyAnimeList
{
    class Baglanti
    {

        public Baglanti()
        {

        }

        public NpgsqlConnection dondur()
        {
            NpgsqlConnection baglan = new NpgsqlConnection("Server=localHost ;Port=5432;Database=MyAnimeList;User Id=postgres;Password=efdal1020; ");
            baglan.Open();
            return baglan;
        }
    }
}
