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
using YazilimBakimi.KitapSatisUygulamasi.Classes;
using YazilimBakimi.KitapSatisUygulamasi.EntityClasses;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    public partial class SalesCRUD : Form
    {
        public static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["YunusEmreConnection"].ConnectionString);
        ToolTip toolTip = new ToolTip();
        private List<Sale> Sales;

        private BindingSource bindingSource { get; set; } = new BindingSource();

        public SalesCRUD()
        {
            InitializeComponent();
            toolTip.SetToolTip(btnSaleUpdate, "Update");
            toolTip.SetToolTip(btnSaleDelete, "Delete");
        }

        private void SalesCRUD_Load(object sender, EventArgs e)
        {
            this.tblSalesTableAdapter.Fill(this.kitapSatisDataSet4.tblSales);
            Sales = DbSale.GetSales();
            bindingSource.DataSource = Sales;
            gridViewSale.DataSource = bindingSource;
        }

        private void backToSignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm("");
            homeForm.ShowDialog();
            this.Close();
        }

        private void btnSaleUpdate_Click(object sender, EventArgs e)
        {
           SqlCommand cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "UPDATE tblSales SET customerName='" + txtAd.Text + "',customerPhone='" + txtPhone.Text + "',customerAdress='" + txtAdress.Text + "', [Price]='" + txtPrice.Text + "' , [Order]='" + txtOrder.Text + "'  WHERE TC=" + txtTC.Text + "";
            cmd.ExecuteNonQuery();
            connection.Close();

            this.tblSalesTableAdapter.Fill(this.kitapSatisDataSet4.tblSales);
            Sales = DbSale.GetSales();
            bindingSource.DataSource = Sales;
            gridViewSale.DataSource = bindingSource;
        }

        private void SwitchPages(BookUpdateForm bookUpdateForm)
        {
            throw new NotImplementedException();
        }

        private void btnSaleDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM tblSales WHERE TC=" + txtTC.Text + "";
                cmd.ExecuteNonQuery();
                connection.Close();

                this.tblSalesTableAdapter.Fill(this.kitapSatisDataSet4.tblSales);
                Sales = DbSale.GetSales();
                bindingSource.DataSource = Sales;
                gridViewSale.DataSource = bindingSource;
            }
            catch
            {
                MessageBox.Show(this, "Bir satış seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
