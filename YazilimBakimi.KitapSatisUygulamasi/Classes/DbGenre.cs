using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimBakimi.KitapSatisUygulamasi.Classes
{
   static class DbGenre
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);

        public static async Task<List<string>> GetGenres()
        {
            var OpenTask = connection.OpenAsync();
            SqlCommand sqlCommand = new SqlCommand("SELECT Genre FROM TblGenre", connection);
            await OpenTask;
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            var Genres = new List<string>();
            while (dataReader.Read())
            {
                Genres.Add((string) dataReader["Genre"]);
            }
            connection.Close();


            return Genres;
        }
    }
}
