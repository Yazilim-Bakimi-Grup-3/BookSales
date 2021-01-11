using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimBakimi.KitapSatisUygulamasi.Classes;

namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    public partial class WriterUpdateForm : Form
    {
        Writer Writer;
        ToolTip toolTip = new ToolTip();
        public  WriterUpdateForm(Writer writer)
        {
            InitializeComponent();
            this.Writer = writer;
            toolTip.SetToolTip(btnUpdateWriter, "Update");
            txtFullName.Text = Writer.FullName;
            txtBirthDate.Text = Writer.BirthDate;
            txtCountry.Text = Writer.Country;
        }

        private async void WriterUpdateForm_Load(object sender, EventArgs e)
        {

            var Genres = await DbGenre.GetGenres();

            foreach (string Genre in Genres)
            {
                cmbWriterGenre.Items.Add(Genre);
                if(Writer.Genre == Genre)
                    cmbWriterGenre.SelectedItem = Genre;
            }
        }





        private void btnUpdateWriter_Click(object sender, EventArgs e)
        {
            if(!TextFieldsAreValid())
            {
                MessageBox.Show(this, "Alanları boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            bool updateSuccessful = DbWriter.UpdateWriter(new Writer()
            {
                ID = Writer.ID,
                FullName = txtFullName.Text,
                BirthDate = txtBirthDate.Text,
                Country = txtCountry.Text,
                Genre = cmbWriterGenre.SelectedItem.ToString()
            });;

            if (updateSuccessful)
                MessageBox.Show(this, "Yazar güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Yazar güncellenirken bir hata oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool TextFieldsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtCountry.Text) ||
                string.IsNullOrWhiteSpace(txtBirthDate.Text) ||
                string.IsNullOrWhiteSpace(cmbWriterGenre.SelectedItem.ToString()))
                return false;

            return true;
        }


        private void pictureBoxBackSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriterCRUDForm writerCRUDForm = new WriterCRUDForm();
            writerCRUDForm.ShowDialog();
            this.Close();
        }

       
    }
}
