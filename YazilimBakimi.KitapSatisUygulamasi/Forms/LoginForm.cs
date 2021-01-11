using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using YazilimBakimi.KitapSatisUygulamasi.Forms;
using YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms;

namespace YazilimBakimi.KitapSatisUygulamasi
{

    public partial class LoginForm : Form
    {
        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);
        public LoginForm()
        {
            InitializeComponent();
        }

        bool isThere;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            string password = Cryptology.MD5Sifrele(textBoxPassword.Text);


            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblLoginCustomer WHERE UserName='" + textBoxName.Text + "'", connection);
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (userName == reader["UserName"].ToString() && password == reader["Password"].ToString() && reader["Counter"].ToString() != "3")
                {
                    
                    isThere = true;
                    label1.Text = reader["id"].ToString();
                    break;

                }
                else
                {
                    isThere = false;
                }
                
            }

            connection.Close();

            CustomerForm cf = new CustomerForm();
            
            if (isThere)
            {
                
                cf.etc = label1.Text;
                

                this.Hide();
                cf.ShowDialog();
                this.Close();
            }
            else
            {
                connection.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM TblLoginCustomer WHERE UserName='" + textBoxName.Text + "'", connection);
                SqlDataReader read = komut.ExecuteReader();

                if (read.Read())
                {
                    
                    if(read["Counter"].ToString() == "3")
                    {
                        
                        MessageBox.Show("Hesabınız bloke olmuştur. Lütfen sistem yöneticimizle yazilimbakimi@gmail.com adresi üzerinden iletişime geçiniz..");
                    }
                    else
                    {
                        connection.Close();
                        connection.Open();
                        SqlCommand commandd = new SqlCommand("UPDATE TblLoginCustomer SET Counter = Counter +1 WHERE UserName='" + textBoxName.Text + "'", connection);
                        commandd.ExecuteNonQuery();
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                    }
                }
                
                connection.Close();
            }



        }

        private void lblSingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin loginGecis = new AdminLogin();
            loginGecis.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword frm = new ForgetPassword();
            frm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
