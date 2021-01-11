using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace YazilimBakimi.KitapSatisUygulamasi
{
     static class DbWriter
    {
        private static  SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);

        public static List<Writer> GetWriters()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT ID,isnull(FullName,'') as FullName,isnull(BirthDate,'') as BirthDate,isnull(Country,'') as Country,isnull(Genre,'') as Genre FROM TblWriter", connection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Writer> Writers = new List<Writer>();
            while (dataReader.Read())
            {
                Writers.Add(new Writer()
                {
                    ID= (int) dataReader["ID"],
                    FullName = (string) dataReader["FullName"],
                    BirthDate=(string) dataReader["BirthDate"],
                    Country=(string) dataReader["Country"],
                    Genre = (string) dataReader["Genre"]
                });
            }
            connection.Close();


            return Writers;
        }

        public static bool CreateWriter(Writer CreatedWriter)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TblWriter VALUES(@FullName,@BirthDate,@Country,@Genre)", connection);
                sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = CreatedWriter.FullName;
                sqlCommand.Parameters.Add("@BirthDate", SqlDbType.NVarChar).Value = CreatedWriter.BirthDate;
                sqlCommand.Parameters.Add("@Country", SqlDbType.NVarChar).Value = CreatedWriter.Country;
                sqlCommand.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = CreatedWriter.Genre;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = CreatedWriter.ID;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool UpdateWriter(Writer UptatedWriter)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TblWriter SET FullName=@FullName,BirthDate=@BirthDate,Country=@Country,Genre=@Genre WHERE ID=@ID ", connection);
                sqlCommand.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = UptatedWriter.FullName;
                sqlCommand.Parameters.Add("@BirthDate", SqlDbType.NVarChar).Value = UptatedWriter.BirthDate;
                sqlCommand.Parameters.Add("@Country", SqlDbType.NVarChar).Value = UptatedWriter.Country;
                sqlCommand.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = UptatedWriter.Genre;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = UptatedWriter.ID;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public static bool DeleteWriter(int ID)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM TblWriter WHERE ID=@ID",connection);
                sqlCommand.Parameters.Add("@ID",SqlDbType.Int).Value = ID;
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        
        }


    }
}
