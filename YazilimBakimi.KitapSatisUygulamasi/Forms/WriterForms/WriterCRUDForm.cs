using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    public partial class WriterCRUDForm : Form
    {

       private List<Writer> Writers { get; set; }
        private BindingSource bindingSource { get; set; } = new BindingSource();
        ToolTip toolTip = new ToolTip();
        public WriterCRUDForm()
        {
            InitializeComponent();
            toolTip.SetToolTip(btnAdd, "Add Writer");
            toolTip.SetToolTip(btnDelete, "Delete Writer");
            toolTip.SetToolTip(btnUpdate, "Update Writer");
        }

        private void pictureBoxBackSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm("");
            homeForm.ShowDialog();
            this.Close();
        }

        private void WriterCRUDForm_Load(object sender, EventArgs e)
        {
            Writers = DbWriter.GetWriters();
            bindingSource.DataSource = Writers;
           gridView.DataSource = bindingSource;
            gridView.Columns["ID"].Visible = false;
            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = Writers;
            //gridView.DataSource = bindingSource;
        }

 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedWriter = gridView.SelectedRows[0].DataBoundItem as Writer;
                SwitchPages(new WriterUpdateForm(selectedWriter));
                
            }
            catch
            {
                MessageBox.Show(this, "Bir yazar seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SwitchPages(new WriterCreateForm());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Writer selectedWriter = gridView.SelectedRows[0].DataBoundItem as Writer;
                if (selectedWriter == null) throw new Exception();

                bool deleteSuccessful = DbWriter.DeleteWriter(selectedWriter.ID);
                if (deleteSuccessful)
                {
                    MessageBox.Show(this, "Silme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridView.Rows.RemoveAt(gridView.SelectedRows[0].Index);
                }
                else
                    MessageBox.Show(this, "Silme işleminde bir hata oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch 
            {
                MessageBox.Show(this, "Bir yazar seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void SwitchPages(Form newForm)
        {
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
