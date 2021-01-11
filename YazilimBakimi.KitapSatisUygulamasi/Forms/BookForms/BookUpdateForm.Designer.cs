
namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class BookUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_BookUpdate = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblWriterName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxWriterName = new System.Windows.Forms.TextBox();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.cmbWriterGenre = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_BookUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pb_BookUpdate);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 117);
            this.panel1.TabIndex = 0;
            // 
            // pb_BookUpdate
            // 
            this.pb_BookUpdate.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.book;
            this.pb_BookUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_BookUpdate.Location = new System.Drawing.Point(400, 15);
            this.pb_BookUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pb_BookUpdate.Name = "pb_BookUpdate";
            this.pb_BookUpdate.Size = new System.Drawing.Size(200, 96);
            this.pb_BookUpdate.TabIndex = 1;
            this.pb_BookUpdate.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.back_arrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Location = new System.Drawing.Point(18, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 63);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWriterName
            // 
            this.lblWriterName.AutoSize = true;
            this.lblWriterName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWriterName.Location = new System.Drawing.Point(18, 163);
            this.lblWriterName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWriterName.Name = "lblWriterName";
            this.lblWriterName.Size = new System.Drawing.Size(131, 34);
            this.lblWriterName.TabIndex = 1;
            this.lblWriterName.Text = "Yazar Adı";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(14, 271);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(129, 34);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Kitap Adı";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenre.Location = new System.Drawing.Point(18, 385);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(59, 34);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Tür";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(18, 490);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 34);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Fiyat";
            // 
            // txtBoxWriterName
            // 
            this.txtBoxWriterName.Location = new System.Drawing.Point(20, 202);
            this.txtBoxWriterName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxWriterName.Name = "txtBoxWriterName";
            this.txtBoxWriterName.Size = new System.Drawing.Size(558, 31);
            this.txtBoxWriterName.TabIndex = 5;
            // 
            // txtBoxBookName
            // 
            this.txtBoxBookName.Location = new System.Drawing.Point(20, 310);
            this.txtBoxBookName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxBookName.Name = "txtBoxBookName";
            this.txtBoxBookName.Size = new System.Drawing.Size(558, 31);
            this.txtBoxBookName.TabIndex = 6;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(20, 529);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(558, 31);
            this.txtBoxPrice.TabIndex = 8;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.update;
            this.btnUpdateBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateBook.Location = new System.Drawing.Point(20, 617);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(562, 131);
            this.btnUpdateBook.TabIndex = 9;
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // cmbWriterGenre
            // 
            this.cmbWriterGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWriterGenre.FormattingEnabled = true;
            this.cmbWriterGenre.Location = new System.Drawing.Point(20, 432);
            this.cmbWriterGenre.Name = "cmbWriterGenre";
            this.cmbWriterGenre.Size = new System.Drawing.Size(558, 33);
            this.cmbWriterGenre.TabIndex = 20;
            // 
            // BookUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 771);
            this.Controls.Add(this.cmbWriterGenre);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxBookName);
            this.Controls.Add(this.txtBoxWriterName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblWriterName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BookUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookUpdateForm";
            this.Load += new System.EventHandler(this.BookUpdateForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_BookUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblWriterName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxWriterName;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.PictureBox pb_BookUpdate;
        private System.Windows.Forms.ComboBox cmbWriterGenre;
    }
}