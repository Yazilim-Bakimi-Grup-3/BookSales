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
    static class DbBook
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);

        public static List<Book> GetBooks()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT id,isnull(WriterFullName,'') as WriterFullName,isnull(BookName,'') as BookName,isnull(Price,'') as Price,isnull(Genre,'') as Genre FROM TblBook", connection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Book> Books = new List<Book>();
            while (dataReader.Read())
            {
                Books.Add(new Book()
                {
                    id = (int)dataReader["id"],
                    WriterFullName = (string)dataReader["WriterFullName"],
                    BookName = (string)dataReader["BookName"],
                    Price = (string)dataReader["Price"],
                    Genre = (string)dataReader["Genre"]
                });
            }
            connection.Close();


            return Books;
        }

        public static bool CreateBook(Book CreatedBook)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TblBook VALUES(@BookName,@Genre,@WriterFullName,@Price)", connection);
                sqlCommand.Parameters.Add("@WriterFullName", SqlDbType.NVarChar).Value = CreatedBook.WriterFullName;
                sqlCommand.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = CreatedBook.BookName;
                sqlCommand.Parameters.Add("@Price", SqlDbType.NVarChar).Value = CreatedBook.Price;
                sqlCommand.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = CreatedBook.Genre;
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

        public static bool UpdateBook(Book UptatedBook)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TblBook SET WriterFullName=@WriterFullName,BookName=@BookName,Price=@Price,Genre=@Genre WHERE id=@id ", connection);
                sqlCommand.Parameters.Add("@WriterFullName", SqlDbType.NVarChar).Value = UptatedBook.WriterFullName;
                sqlCommand.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = UptatedBook.BookName;
                sqlCommand.Parameters.Add("@Price", SqlDbType.NVarChar).Value = UptatedBook.Price;
                sqlCommand.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = UptatedBook.Genre;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = UptatedBook.id;
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

        public static bool DeleteBook(int id)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM TblBook WHERE id=@id", connection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
