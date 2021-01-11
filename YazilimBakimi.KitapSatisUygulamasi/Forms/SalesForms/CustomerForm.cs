using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    public partial class CustomerForm : Form
    {
        
        public CustomerForm()
        {
            InitializeComponent();
        }

        public string etc;

        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);
        ToolTip toolTip = new ToolTip();


        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (!TextFieldsAreValid())
            {
                MessageBox.Show(this, "Lütfen alanları boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            buttonListele.Enabled = true;

            bool TextFieldsAreValid()
            {
                if (string.IsNullOrWhiteSpace(textboxName.Text) ||
                    string.IsNullOrWhiteSpace(textboxTC.Text) ||
                    string.IsNullOrWhiteSpace(textboxPhone.Text) ||
                    string.IsNullOrWhiteSpace(textboxAdress.Text))
                    return false;

                return true;
            }

            

        }

        private bool TextFieldsAreValid()
        {
            throw new NotImplementedException();
        }



        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textboxTC.Text = "";
            textboxName.Text = "";
            textboxAdress.Text = "";
            textboxPhone.Text = "";
        }

        private void groupBoxKisiselBilgiler_Enter(object sender, EventArgs e)
        {
            
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            buttonListele.Enabled = false;
            textboxGecis.Text = etc;

            SqlCommand cmd = new SqlCommand("SELECT UserName, TC, customerName, customerPhone, customerAdress, Date FROM TblLoginCustomer lc inner join TblOrderInfo cp on lc.id = cp.idc where idc='"+ textboxGecis.Text + "' ORDER BY Date ASC", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                textboxTC.Text = dr["TC"].ToString();
                textboxName.Text = dr["customerName"].ToString();
                textboxPhone.Text = dr["customerPhone"].ToString();
                textboxAdress.Text = dr["customerAdress"].ToString();
            }

            dr.Close();
            connection.Close();

        }

        SalesForm sf = new SalesForm();

        private void buttonListele_Click(object sender, EventArgs e)
        {
            sf.textboxName.Items.Add(textboxName.Text);
            sf.textboxTC.Items.Add(textboxTC.Text);
            sf.textboxPhone.Items.Add(textboxPhone.Text);
            sf.textboxAdress.Items.Add(textboxAdress.Text);
            sf.listBox1.Items.Add(textboxGecis.Text);
            

            this.Hide();
            sf.ShowDialog();

            connection.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO TblOrderInfo (idc, TC, customerName, customerPhone, customerAdress, Date) VALUES (@idc, @TC, @customerName, @customerPhone, @customerAdress, @date)");
            cmd.Connection = connection;

            cmd.Parameters.AddWithValue("@idc", textboxGecis.Text);
            cmd.Parameters.AddWithValue("@TC", textboxTC.Text);
            cmd.Parameters.AddWithValue("@customerName", textboxName.Text);
            cmd.Parameters.AddWithValue("@customerPhone", textboxPhone.Text);
            cmd.Parameters.AddWithValue("@customerAdress", textboxAdress.Text);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

            cmd.ExecuteNonQuery();
            connection.Close();

        }

        private void textboxTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxGecis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
