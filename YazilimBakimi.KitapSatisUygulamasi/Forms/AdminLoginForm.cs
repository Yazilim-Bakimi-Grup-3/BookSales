using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimBakimi.KitapSatisUygulamasi.Forms;
using YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms;

namespace YazilimBakimi.KitapSatisUygulamasi
{
    public partial class AdminLogin : Form
    {
        SqlConnection connection = LoginForm.connection;
        bool isThere;
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAdmin.Text;
            string password = textBoxPasswordAdmin.Text;

           
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblLoginAdmin", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (userName == reader["UserName"].ToString() && password == reader["Password"].ToString())
                {
                    isThere = true;
                    break;

                }
                else
                {
                    isThere = false;
                }
            }
            connection.Close();
            if (isThere)
            {
                MessageBox.Show("Başarılı giriş yaptınız!", "Program");

                this.Hide();
                HomeForm HF = new HomeForm(userName);
                HF.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
        }

        private void pictureBoxBackAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginFormGecis = new LoginForm();
            loginFormGecis.Show();
        }
    }
}
