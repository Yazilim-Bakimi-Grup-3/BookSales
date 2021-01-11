using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace YazilimBakimi.KitapSatisUygulamasi
{
    public partial class SignUp : Form
    {
        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);
        public SignUp()
        {
            InitializeComponent();

            cbForgetQuestion.Items.Add("İlkokul Öğretmeninizin Adı Ne?");
            cbForgetQuestion.Items.Add("Evcil Hayvanınızın Cinsi Ne?");
            cbForgetQuestion.Items.Add("Nerede Doğdunuz?");
        }

        

        private void btnLoginSignUp_Click(object sender, EventArgs e)
        {
            int Counter = 0;
            connection.Open();
            if (cbForgetQuestion.SelectedItem == null && txtBxAnswer.Text == null) MessageBox.Show("Parola Kurtarma Sorusu Boş Bırakılamaz...","Program");
            SqlCommand command = new SqlCommand("INSERT INTO TblLoginCustomer (UserName,Password,Question,Answer,Counter) values ('" + textBoxNameSignUp.Text + "','" + Cryptology.MD5Sifrele(textBoxPasswordSignUp.Text) + "','" + cbForgetQuestion.SelectedItem.ToString() + "','" + txtBxAnswer.Text + "','" + 0 + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Başarılı", "Program");
        }

        private void pictureBoxBackSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginFormGecis = new LoginForm();
            loginFormGecis.Show();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
