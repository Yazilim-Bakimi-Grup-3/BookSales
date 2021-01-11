
namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    partial class SalesCRUD
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
            this.gridViewSale = new System.Windows.Forms.DataGridView();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSalesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kitapSatisDataSet6 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet6();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbBaslik = new System.Windows.Forms.PictureBox();
            this.backToSignUpButton = new System.Windows.Forms.Button();
            this.btnSaleDelete = new System.Windows.Forms.Button();
            this.tblSalesTableAdapter = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet4TableAdapters.tblSalesTableAdapter();
            this.tblSalesTableAdapter1 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet5TableAdapters.tblSalesTableAdapter();
            this.tblSalesTableAdapter2 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet6TableAdapters.tblSalesTableAdapter();
            this.tblSalesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapSatisDataSet4 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet4();
            this.kitapSatisDataSet5 = new YazilimBakimi.KitapSatisUygulamasi.KitapSatisDataSet5();
            this.btnSaleUpdate = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewSale
            // 
            this.gridViewSale.AutoGenerateColumns = false;
            this.gridViewSale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.gridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.customerAdressDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn});
            this.gridViewSale.DataSource = this.tblSalesBindingSource2;
            this.gridViewSale.Location = new System.Drawing.Point(2, 66);
            this.gridViewSale.Name = "gridViewSale";
            this.gridViewSale.Size = new System.Drawing.Size(655, 273);
            this.gridViewSale.TabIndex = 6;
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "customerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "customerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            // 
            // customerAdressDataGridViewTextBoxColumn
            // 
            this.customerAdressDataGridViewTextBoxColumn.DataPropertyName = "customerAdress";
            this.customerAdressDataGridViewTextBoxColumn.HeaderText = "customerAdress";
            this.customerAdressDataGridViewTextBoxColumn.Name = "customerAdressDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // tblSalesBindingSource2
            // 
            this.tblSalesBindingSource2.DataMember = "tblSales";
            this.tblSalesBindingSource2.DataSource = this.kitapSatisDataSet6;
            // 
            // kitapSatisDataSet6
            // 
            this.kitapSatisDataSet6.DataSetName = "KitapSatisDataSet6";
            this.kitapSatisDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pbBaslik);
            this.panel1.Controls.Add(this.backToSignUpButton);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 54);
            this.panel1.TabIndex = 5;
            // 
            // pbBaslik
            // 
            this.pbBaslik.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.sale;
            this.pbBaslik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBaslik.Location = new System.Drawing.Point(325, -10);
            this.pbBaslik.Name = "pbBaslik";
            this.pbBaslik.Size = new System.Drawing.Size(116, 64);
            this.pbBaslik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            // btnSaleDelete
            // 
            this.btnSaleDelete.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.delete;
            this.btnSaleDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaleDelete.Location = new System.Drawing.Point(337, 345);
            this.btnSaleDelete.Name = "btnSaleDelete";
            this.btnSaleDelete.Size = new System.Drawing.Size(320, 79);
            this.btnSaleDelete.TabIndex = 9;
            this.btnSaleDelete.UseVisualStyleBackColor = true;
            this.btnSaleDelete.Click += new System.EventHandler(this.btnSaleDelete_Click);
            // 
            // tblSalesTableAdapter
            // 
            this.tblSalesTableAdapter.ClearBeforeFill = true;
            // 
            // tblSalesTableAdapter1
            // 
            this.tblSalesTableAdapter1.ClearBeforeFill = true;
            // 
            // tblSalesTableAdapter2
            // 
            this.tblSalesTableAdapter2.ClearBeforeFill = true;
            // 
            // tblSalesBindingSource1
            // 
            this.tblSalesBindingSource1.DataMember = "tblSales";
            // 
            // tblSalesBindingSource
            // 
            this.tblSalesBindingSource.DataMember = "tblSales";
            // 
            // kitapSatisDataSet4
            // 
            this.kitapSatisDataSet4.DataSetName = "KitapSatisDataSet4";
            this.kitapSatisDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapSatisDataSet5
            // 
            this.kitapSatisDataSet5.DataSetName = "KitapSatisDataSet5";
            this.kitapSatisDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaleUpdate
            // 
            this.btnSaleUpdate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaleUpdate.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.update;
            this.btnSaleUpdate.Location = new System.Drawing.Point(2, 345);
            this.btnSaleUpdate.Name = "btnSaleUpdate";
            this.btnSaleUpdate.Size = new System.Drawing.Size(319, 79);
            this.btnSaleUpdate.TabIndex = 7;
            this.btnSaleUpdate.UseMnemonic = false;
            this.btnSaleUpdate.UseVisualStyleBackColor = true;
            this.btnSaleUpdate.Click += new System.EventHandler(this.btnSaleUpdate_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(64, 456);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(257, 20);
            this.txtAd.TabIndex = 10;
//            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(400, 456);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(257, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(400, 430);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(257, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(64, 485);
            this.txtAdress.MaxLength = 11;
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(257, 70);
            this.txtAdress.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "TC:";
//            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(64, 430);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(257, 20);
            this.txtTC.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Sipariş:";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(400, 482);
            this.txtOrder.MaxLength = 50;
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(257, 70);
            this.txtOrder.TabIndex = 20;
            // 
            // SalesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 611);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnSaleDelete);
            this.Controls.Add(this.btnSaleUpdate);
            this.Controls.Add(this.gridViewSale);
            this.Controls.Add(this.panel1);
            this.Name = "SalesCRUD";
            this.Text = "SalesCRUD";
            this.Load += new System.EventHandler(this.SalesCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet6)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapSatisDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaleDelete;
        private System.Windows.Forms.DataGridView gridViewSale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBaslik;
        private System.Windows.Forms.Button backToSignUpButton;
        private KitapSatisDataSet4TableAdapters.tblSalesTableAdapter tblSalesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private KitapSatisDataSet5TableAdapters.tblSalesTableAdapter tblSalesTableAdapter1;
        private KitapSatisDataSet6 kitapSatisDataSet6;
        private System.Windows.Forms.BindingSource tblSalesBindingSource2;
        private KitapSatisDataSet6TableAdapters.tblSalesTableAdapter tblSalesTableAdapter2;
        private System.Windows.Forms.BindingSource tblSalesBindingSource1;
        private System.Windows.Forms.BindingSource tblSalesBindingSource;
        private KitapSatisDataSet4 kitapSatisDataSet4;
        private KitapSatisDataSet5 kitapSatisDataSet5;
        private System.Windows.Forms.Button btnSaleUpdate;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrder;
    }
}