
namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class BookCRUDForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBaslik = new System.Windows.Forms.PictureBox();
            this.backToSignUpButton = new System.Windows.Forms.Button();
            this.gridViewBook = new System.Windows.Forms.DataGridView();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writerFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kitapSatisDataSet2 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet2();
            this.kitapSatisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapSatisDataSet = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.kitapSatisDataSet1 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet1();
            this.tblBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblBookTableAdapter = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet1TableAdapters.TblBookTableAdapter();
            this.tblBookTableAdapter1 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet2TableAdapters.TblBookTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pbBaslik);
            this.panel1.Controls.Add(this.backToSignUpButton);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 54);
            this.panel1.TabIndex = 0;
            // 
            // pbBaslik
            // 
            this.pbBaslik.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.book;
            this.pbBaslik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbBaslik.Location = new System.Drawing.Point(324, 0);
            this.pbBaslik.Name = "pbBaslik";
            this.pbBaslik.Size = new System.Drawing.Size(183, 48);
            this.pbBaslik.TabIndex = 1;
            this.pbBaslik.TabStop = false;
            // 
            // backToSignUpButton
            // 
            this.backToSignUpButton.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.back_arrow;
            this.backToSignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backToSignUpButton.Location = new System.Drawing.Point(10, 12);
            this.backToSignUpButton.Name = "backToSignUpButton";
            this.backToSignUpButton.Size = new System.Drawing.Size(34, 33);
            this.backToSignUpButton.TabIndex = 0;
            this.backToSignUpButton.UseVisualStyleBackColor = true;
            this.backToSignUpButton.Click += new System.EventHandler(this.backToSignUpButton_Click);
            // 
            // gridViewBook
            // 
            this.gridViewBook.AutoGenerateColumns = false;
            this.gridViewBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.gridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookNameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.writerFullNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.gridViewBook.DataSource = this.tblBookBindingSource1;
            this.gridViewBook.Location = new System.Drawing.Point(12, 102);
            this.gridViewBook.Name = "gridViewBook";
            this.gridViewBook.Size = new System.Drawing.Size(786, 231);
            this.gridViewBook.TabIndex = 1;
//            this.gridViewBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewBook_CellContentClick);
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // writerFullNameDataGridViewTextBoxColumn
            // 
            this.writerFullNameDataGridViewTextBoxColumn.DataPropertyName = "WriterFullName";
            this.writerFullNameDataGridViewTextBoxColumn.HeaderText = "WriterFullName";
            this.writerFullNameDataGridViewTextBoxColumn.Name = "writerFullNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // tblBookBindingSource1
            // 
            this.tblBookBindingSource1.DataMember = "TblBook";
            this.tblBookBindingSource1.DataSource = this.kitapSatisDataSet2;
            // 
            // kitapSatisDataSet2
            // 
            this.kitapSatisDataSet2.DataSetName = "KitapSatisDataSet2";
            this.kitapSatisDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapSatisDataSetBindingSource
            // 
            this.kitapSatisDataSetBindingSource.DataSource = this.kitapSatisDataSet;
            this.kitapSatisDataSetBindingSource.Position = 0;
            // 
            // kitapSatisDataSet
            // 
            this.kitapSatisDataSet.DataSetName = "KitapSatisDataSet";
            this.kitapSatisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBookUpdate.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.update;
            this.btnBookUpdate.Location = new System.Drawing.Point(53, 359);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(189, 79);
            this.btnBookUpdate.TabIndex = 2;
            this.btnBookUpdate.UseMnemonic = false;
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            this.btnBookUpdate.Click += new System.EventHandler(this.btnBookUpdate_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.add;
            this.btnBookAdd.Location = new System.Drawing.Point(320, 359);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(189, 79);
            this.btnBookAdd.TabIndex = 3;
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.delete;
            this.btnBookDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBookDelete.Location = new System.Drawing.Point(565, 359);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(189, 79);
            this.btnBookDelete.TabIndex = 4;
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // kitapSatisDataSet1
            // 
            this.kitapSatisDataSet1.DataSetName = "KitapSatisDataSet1";
            this.kitapSatisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblBookBindingSource
            // 
            this.tblBookBindingSource.DataMember = "TblBook";
            this.tblBookBindingSource.DataSource = this.kitapSatisDataSet1;
            // 
            // tblBookTableAdapter
            // 
            this.tblBookTableAdapter.ClearBeforeFill = true;
            // 
            // tblBookTableAdapter1
            // 
            this.tblBookTableAdapter1.ClearBeforeFill = true;
            // 
            // BookCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBookDelete);
            this.Controls.Add(this.btnBookAdd);
            this.Controls.Add(this.btnBookUpdate);
            this.Controls.Add(this.gridViewBook);
            this.Controls.Add(this.panel1);
            this.Name = "BookCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookCRUD";
            this.Load += new System.EventHandler(this.BookCRUDForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backToSignUpButton;
        private System.Windows.Forms.DataGridView gridViewBook;
        private System.Windows.Forms.BindingSource kitapSatisDataSetBindingSource;
        private KitapSatisDataSet kitapSatisDataSet;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Button btnBookDelete;
        private KitapSatisDataSet1 kitapSatisDataSet1;
        private System.Windows.Forms.BindingSource tblBookBindingSource;
        private KitapSatisDataSet1TableAdapters.TblBookTableAdapter tblBookTableAdapter;
        private KitapSatisDataSet2 kitapSatisDataSet2;
        private System.Windows.Forms.BindingSource tblBookBindingSource1;
        private KitapSatisDataSet2TableAdapters.TblBookTableAdapter tblBookTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writerFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pbBaslik;
    }
}