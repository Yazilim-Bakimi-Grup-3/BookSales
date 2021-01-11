using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimBakimi.KitapSatisUygulamasi.EntityClasses;

namespace YazilimBakimi.KitapSatisUygulamasi.Classes
{
    class DbSale
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


        public static List<Sale> GetSales()
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT TC,isnull(TC,'') as TC, isnull(customerName,'') as customerName, isnull(customerPhone,'') as customerPhone, isnull(customerAdress,'') as customerAdress, isnull(Price,'') as Price, isnull([Order],'') as [Order] FROM tblSales", connection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Sale> Sales = new List<Sale>();
            while (dataReader.Read())
            {
                Sales.Add(new Sale()
                {
                    TC = (string)dataReader["TC"],
                    customerName = (string)dataReader["customerName"],
                    customerPhone = (string)dataReader["customerPhone"],
                    customerAdress = (string)dataReader["customerAdress"],
                    Price = (string)dataReader["Price"],
                    Order = (string)dataReader["Order"]

                });
            }
            connection.Close();


            return Sales;
        }


        public static bool CreateSale(Sale CreatedSale)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO tblSales VALUES(@TC,@customerName,@customerPhone,@customerAdress,@Order,@Price)", connection);
                sqlCommand.Parameters.Add("@TC", SqlDbType.NChar).Value = CreatedSale.TC;
                sqlCommand.Parameters.Add("@customerName", SqlDbType.NVarChar).Value = CreatedSale.customerName;
                sqlCommand.Parameters.Add("@customerPhone", SqlDbType.NChar).Value = CreatedSale.customerPhone;
                sqlCommand.Parameters.Add("@customerAdress", SqlDbType.NVarChar).Value = CreatedSale.customerAdress;
                sqlCommand.Parameters.Add("@Order", SqlDbType.NVarChar).Value = CreatedSale.Order;
                sqlCommand.Parameters.Add("@Price", SqlDbType.NVarChar).Value = CreatedSale.Price;
               // sqlCommand.Parameters.Add("@transactionDate", SqlDbType.SmallDateTime).Value = CreatedSale.transactionDate;
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

        internal static bool DeleteSale(string tC)
        {
            throw new NotImplementedException();
        }

        public static bool UpdateSale(Sale UptatedSale)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE tblSales SET customerName=@customerName,customerPhone=@customerPhone,customerAdress=@customerAdress,Price=@Price, Order=@Order WHERE TC=@TC ", connection);
                sqlCommand.Parameters.Add("@customerName", SqlDbType.NVarChar).Value = UptatedSale.customerName;
                sqlCommand.Parameters.Add("@customerPhone", SqlDbType.NVarChar).Value = UptatedSale.customerPhone;
                sqlCommand.Parameters.Add("@customerAdress", SqlDbType.NVarChar).Value = UptatedSale.customerAdress;
                sqlCommand.Parameters.Add("@Price", SqlDbType.NVarChar).Value = UptatedSale.Price;
                sqlCommand.Parameters.Add("@Order", SqlDbType.NVarChar).Value = UptatedSale.Price;

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

        public static bool DeleteSale(int TC)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM tblSales WHERE TC=@TC", connection);
                sqlCommand.Parameters.AddWithValue("@TC", SqlDbType.NVarChar).Value = TC;
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
