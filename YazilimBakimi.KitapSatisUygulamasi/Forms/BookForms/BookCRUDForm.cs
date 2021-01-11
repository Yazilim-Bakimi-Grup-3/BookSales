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
    public partial class BookCRUDForm : Form
    {

        private List<Book> Books { get; set; }
        private BindingSource bindingSource { get; set; } = new BindingSource();

        ToolTip toolTip = new ToolTip();
        public BookCRUDForm()
        {
            InitializeComponent();
            toolTip.SetToolTip(btnBookUpdate, "Update Book");
            toolTip.SetToolTip(btnBookAdd, "Add Book");
            toolTip.SetToolTip(btnBookDelete, "Delete Book");
        }

        private void BookCRUDForm_Load(object sender, EventArgs e)
        {
            Books = DbBook.GetBooks();
            bindingSource.DataSource = Books;
            gridViewBook.DataSource = bindingSource;
        }


        private void backToSignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = new HomeForm("");
            homeForm.ShowDialog();
            this.Close();
        }

        private void btnBookUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selecetedBook = gridViewBook.SelectedRows[0].DataBoundItem as Book;
                SwitchPages(new BookUpdateForm(selecetedBook));

            }
            catch
            {
                MessageBox.Show(this, "Bir yazar seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            SwitchPages(new BookCreateForm());
        }



        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Book selectedBook = gridViewBook.SelectedRows[0].DataBoundItem as Book;
                if (selectedBook == null) throw new Exception();

                bool deleteSuccessful = DbWriter.DeleteWriter(selectedBook.id);
                if (deleteSuccessful)
                {
                    MessageBox.Show(this, "Silme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridViewBook.Rows.RemoveAt(gridViewBook.SelectedRows[0].Index);
                }
                else
                    MessageBox.Show(this, "Silme işleminde bir hata oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch
            {
                MessageBox.Show(this, "Bir kitap seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SwitchPages(Form newForm)
        {
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

      
    }
}
