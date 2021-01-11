using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    public partial class HomeForm : Form
    {

        ToolTip toolTip = new ToolTip();
        public HomeForm(string Username)
        {
            InitializeComponent();
            lblUsername.Text = $"Welcome {Username}";
            toolTip.SetToolTip(btnWriterForm, "Writer CRUD");
            toolTip.SetToolTip(btnBookForm, "Book CRUD");
            toolTip.SetToolTip(btnInvoiceForm, "Invoice CRUD");
        }

        public HomeForm()
        {
        }

        private void pictureBoxBackSignUp_Click(object sender, EventArgs e)
        {
            SwitchPages(new LoginForm());
        }

        private void btnWriterForm_Click(object sender, EventArgs e)
        {
            SwitchPages(new WriterCRUDForm());
        }

        private void SwitchPages(Form newForm)
        {
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void btnBookForm_Click(object sender, EventArgs e)
        {
            SwitchPages(new BookCRUDForm());
        }

        private void btnInvoiceForm_Click(object sender, EventArgs e)
        {
            SwitchPages(new SalesCRUD());
        }
    }
}
