
namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class BookCreateForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateBack = new System.Windows.Forms.Button();
            this.lblWriterName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxWriterName = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.btnSendBookCreate = new System.Windows.Forms.Button();
            this.txtBoxBookName = new System.Windows.Forms.TextBox();
            this.cmbWriterGenre = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCreateBack);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 104);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.book;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(398, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 96);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateBack
            // 
            this.btnCreateBack.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.back_arrow;
            this.btnCreateBack.Location = new System.Drawing.Point(22, 21);
            this.btnCreateBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateBack.Name = "btnCreateBack";
            this.btnCreateBack.Size = new System.Drawing.Size(68, 63);
            this.btnCreateBack.TabIndex = 0;
            this.btnCreateBack.UseVisualStyleBackColor = true;
            this.btnCreateBack.Click += new System.EventHandler(this.btnCreateBack_Click);
            // 
            // lblWriterName
            // 
            this.lblWriterName.AutoSize = true;
            this.lblWriterName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWriterName.Location = new System.Drawing.Point(18, 152);
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
            this.lblBookName.Location = new System.Drawing.Point(18, 271);
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
            this.lblGenre.Location = new System.Drawing.Point(18, 383);
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
            this.lblPrice.Location = new System.Drawing.Point(18, 488);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 34);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Fiyat";
            // 
            // txtBoxWriterName
            // 
            this.txtBoxWriterName.Location = new System.Drawing.Point(24, 192);
            this.txtBoxWriterName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxWriterName.Name = "txtBoxWriterName";
            this.txtBoxWriterName.Size = new System.Drawing.Size(554, 31);
            this.txtBoxWriterName.TabIndex = 6;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPrice.Location = new System.Drawing.Point(24, 528);
            this.txtBoxPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBoxPrice.Size = new System.Drawing.Size(556, 31);
            this.txtBoxPrice.TabIndex = 9;
            // 
            // btnSendBookCreate
            // 
            this.btnSendBookCreate.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.add;
            this.btnSendBookCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSendBookCreate.Location = new System.Drawing.Point(24, 604);
            this.btnSendBookCreate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSendBookCreate.Name = "btnSendBookCreate";
            this.btnSendBookCreate.Size = new System.Drawing.Size(558, 144);
            this.btnSendBookCreate.TabIndex = 5;
            this.btnSendBookCreate.UseVisualStyleBackColor = true;
            this.btnSendBookCreate.Click += new System.EventHandler(this.btnSendBookCreate_Click);
            // 
            // txtBoxBookName
            // 
            this.txtBoxBookName.Location = new System.Drawing.Point(24, 311);
            this.txtBoxBookName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxBookName.Name = "txtBoxBookName";
            this.txtBoxBookName.Size = new System.Drawing.Size(554, 31);
            this.txtBoxBookName.TabIndex = 7;
            // 
            // cmbWriterGenre
            // 
            this.cmbWriterGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWriterGenre.FormattingEnabled = true;
            this.cmbWriterGenre.Location = new System.Drawing.Point(24, 420);
            this.cmbWriterGenre.Name = "cmbWriterGenre";
            this.cmbWriterGenre.Size = new System.Drawing.Size(554, 33);
            this.cmbWriterGenre.TabIndex = 20;
            // 
            // BookCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 771);
            this.Controls.Add(this.cmbWriterGenre);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.txtBoxBookName);
            this.Controls.Add(this.txtBoxWriterName);
            this.Controls.Add(this.btnSendBookCreate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblWriterName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "BookCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCreateForm";
            this.Load += new System.EventHandler(this.BookCreateForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateBack;
        private System.Windows.Forms.Label lblWriterName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSendBookCreate;
        private System.Windows.Forms.TextBox txtBoxWriterName;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxBookName;
        private System.Windows.Forms.ComboBox cmbWriterGenre;
    }
}