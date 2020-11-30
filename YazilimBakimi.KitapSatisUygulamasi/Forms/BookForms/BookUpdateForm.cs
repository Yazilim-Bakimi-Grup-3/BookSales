﻿using System;
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
    public partial class BookUpdateForm : Form
    {
        Book Book;
        ToolTip toolTip = new ToolTip();
        public BookUpdateForm(Book book)
        {
            InitializeComponent();
            this.Book = book;
            toolTip.SetToolTip(btnUpdateBook, " Update ");
            txtBoxBookName.Text = Book.BookName;
            txtBoxGenre.Text = Book.Genre;
            txtBoxPrice.Text = Book.Price;
            txtBoxWriterName.Text = Book.WriterFullName;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookCRUDForm bookCRUDForm = new BookCRUDForm();
            bookCRUDForm.ShowDialog();
            this.Close();
        }



        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!TextFieldsAreValid())
            {
                MessageBox.Show(this, "Alanları boş bırakmayınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            bool updateSuccessful = DbBook.UpdateBook(new Book()
            {
                id = Book.id,
                BookName = txtBoxBookName.Text,
                Price = txtBoxPrice.Text,
                WriterFullName = txtBoxWriterName.Text,
                Genre = txtBoxGenre.Text
            });

            if (updateSuccessful)
                MessageBox.Show(this, "Kitap güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Kitap güncellenirken bir hata oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool TextFieldsAreValid()
        {
            if (string.IsNullOrWhiteSpace(txtBoxBookName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxGenre.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(txtBoxWriterName.Text))
                return false;

            return true;
        }

    
    }
}
