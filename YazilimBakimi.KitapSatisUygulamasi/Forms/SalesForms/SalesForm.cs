using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    public partial class SalesForm : Form
    {
        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);
        private List<Book> Books { get; set; }
        private BindingSource BindingSource { get; set; } = new BindingSource();
        public bool CreationSuccessful { get; private set; }
        ToolTip toolTip = new ToolTip();

        public string etc2;


        public SalesForm()
        {
            InitializeComponent();
            toolTip.SetToolTip(buttonSiparisAl, "Add Order");
            toolTip.SetToolTip(buttonSil, "Delete Order");
            toolTip.SetToolTip(buttonTamamla, "Done Order");
            toolTip.SetToolTip(buttonGeri, "Back");
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            Books = DbBook.GetBooks();
            BindingSource.DataSource = Books;
            gridViewBook.DataSource = BindingSource;
        }

        private void buttonSiparisAl_Click(object sender, EventArgs e)
        {
            string Siparisler = "";
            int toplamTutar = 0;
            int tutar = 0;

            Siparisler = Siparisler + gridViewBook.CurrentRow.Cells[0].Value;
            toplamTutar = toplamTutar + Convert.ToInt32(gridViewBook.CurrentRow.Cells[3].Value);
            tutar = tutar + Convert.ToInt32(gridViewBook.CurrentRow.Cells[3].Value);
            textboxOrder.Items.Add(Siparisler);

            labelTutar.Text = Convert.ToString(tutar) + " TL";
            labelTutar2.Text = Convert.ToString(toplamTutar);

        }

        private void buttonFavoriEkle_Click(object sender, EventArgs e)
        {



            string favoriler = null;
            favoriler = favoriler + gridViewBook.CurrentRow.Cells[0].Value;
            textboxFavori.Items.Add(favoriler);

            connection.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO TblFavori (idf, favName) VALUES (@idf, @fav)");
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@idf", "");
            cmd.Parameters.AddWithValue("@fav", "");
            

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                cmd.Parameters["@idf"].Value = listBox1.Items[i].ToString();
            }

            for (int i = 0; i < textboxFavori.Items.Count; i++)
            {
                cmd.Parameters["@fav"].Value = textboxFavori.Items[i].ToString();
            }

            cmd.ExecuteNonQuery();
            connection.Close();

            
        }


        private void buttonFavoriTamamla_Click(object sender, EventArgs e)
        {
            
            textboxFavori.Items.Remove(textboxFavori.SelectedItem);

            if (listBox1.SelectedItem == null)
            {
                
                return;

            }
            else
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE FROM TblFavori WHERE idf=@idf AND favName=@fav", connection);
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@idf", "");
                cmd.Parameters.AddWithValue("@fav", "");

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    cmd.Parameters["@idf"].Value = listBox1.Items[i].ToString();
                }

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    cmd.Parameters["@fav"].Value = textboxFavori.Items[i].ToString();
                }

                
                //cmd.Parameters["@fav"].Value = textboxFavori.SelectedItem.ToString();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }

        private void buttonFavTamamla_Click(object sender, EventArgs e)
        {
            
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kitapSatisDataSet9.TblBook' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblBookTableAdapter2.Fill(this.kitapSatisDataSet9.TblBook);
            // TODO: Bu kod satırı 'kitapSatisDataSet8.TblBook' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblBookTableAdapter1.Fill(this.kitapSatisDataSet8.TblBook);
            // TODO: Bu kod satırı 'kitapSatisDataSet7.tblSales' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblSalesTableAdapter.Fill(this.kitapSatisDataSet7.tblSales);

            SqlCommand cmd = new SqlCommand("SELECT favName FROM TblLoginCustomer lc inner join TblFavori fav on lc.id = fav.idf where idf='" + listBox1.Items[0].ToString() + "'", connection) ;
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                    textboxFavori.Items.Add(dr["favName"]);
            }

            dr.Close();
            connection.Close();

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            textboxOrder.Items.Remove(textboxOrder.SelectedItem);
        }

        private void buttonTamamla_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tblSales (TC, customerName, customerPhone, customerAdress, Price, [Order], Date) VALUES (@TC, @customerName, @customerPhone, @customerAdress, @Price, @Order, @Date)");
            cmd.Connection = connection;

            string order;

            cmd.Parameters.AddWithValue("@TC", "");
            cmd.Parameters.AddWithValue("@customerName", "");
            cmd.Parameters.AddWithValue("@customerPhone", "");
            cmd.Parameters.AddWithValue("@customerAdress", "");
            cmd.Parameters.Add("@Order", SqlDbType.NVarChar, 200);
            cmd.Parameters.AddWithValue("@Price", labelTutar2.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

            for (int i = 0; i < textboxTC.Items.Count; i++)
            {
                cmd.Parameters["@TC"].Value = textboxTC.Items[i].ToString();
            }

            for (int i = 0; i < textboxName.Items.Count; i++)
            {
                cmd.Parameters["@customerName"].Value = textboxName.Items[i].ToString();
            }

            for (int i = 0; i < textboxPhone.Items.Count; i++)
            {
                cmd.Parameters["@customerPhone"].Value = textboxPhone.Items[i].ToString();
            }

            for (int i = 0; i < textboxAdress.Items.Count; i++)
            {
                cmd.Parameters["@customerAdress"].Value = textboxAdress.Items[i].ToString();
            }

            order = textboxOrder.Items.Cast<string>().Aggregate("| ", (q, x) => x + " | " + q.ToString());
            cmd.Parameters["@Order"].Value = order.ToString();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Siparişiniz Başarıyla Tamamlandı.");

            CustomerForm cf = new CustomerForm();
            this.Hide();
            cf.ShowDialog();
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm();
            this.Hide();
            cf.ShowDialog();
        }

        private void gridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textboxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
