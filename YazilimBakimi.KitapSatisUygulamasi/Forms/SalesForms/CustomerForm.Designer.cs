
namespace YazilimBakimi.KitapSatisUygulamasi.Forms.SalesForms
{
    partial class CustomerForm
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
            this.groupBoxKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonListele = new System.Windows.Forms.Button();
            this.textboxAdress = new System.Windows.Forms.TextBox();
            this.textboxPhone = new System.Windows.Forms.TextBox();
            this.textboxName = new System.Windows.Forms.TextBox();
            this.textboxTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxGecis = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxKisiselBilgiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKisiselBilgiler
            // 
            this.groupBoxKisiselBilgiler.Controls.Add(this.buttonTemizle);
            this.groupBoxKisiselBilgiler.Controls.Add(this.buttonKaydet);
            this.groupBoxKisiselBilgiler.Controls.Add(this.buttonListele);
            this.groupBoxKisiselBilgiler.Controls.Add(this.textboxAdress);
            this.groupBoxKisiselBilgiler.Controls.Add(this.textboxPhone);
            this.groupBoxKisiselBilgiler.Controls.Add(this.textboxName);
            this.groupBoxKisiselBilgiler.Controls.Add(this.textboxTC);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label4);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label3);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label2);
            this.groupBoxKisiselBilgiler.Controls.Add(this.label1);
            this.groupBoxKisiselBilgiler.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKisiselBilgiler.Name = "groupBoxKisiselBilgiler";
            this.groupBoxKisiselBilgiler.Size = new System.Drawing.Size(290, 348);
            this.groupBoxKisiselBilgiler.TabIndex = 2;
            this.groupBoxKisiselBilgiler.TabStop = false;
            this.groupBoxKisiselBilgiler.Text = "Kişisel Bilgiler";
            this.groupBoxKisiselBilgiler.Enter += new System.EventHandler(this.groupBoxKisiselBilgiler_Enter);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemizle.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.delete;
            this.buttonTemizle.Location = new System.Drawing.Point(105, 269);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(75, 73);
            this.buttonTemizle.TabIndex = 14;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaydet.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.add;
            this.buttonKaydet.Location = new System.Drawing.Point(20, 269);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 73);
            this.buttonKaydet.TabIndex = 13;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonListele
            // 
            this.buttonListele.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.back_arrow___Kopya;
            this.buttonListele.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListele.Location = new System.Drawing.Point(196, 269);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(75, 73);
            this.buttonListele.TabIndex = 15;
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // textboxAdress
            // 
            this.textboxAdress.Location = new System.Drawing.Point(92, 116);
            this.textboxAdress.Multiline = true;
            this.textboxAdress.Name = "textboxAdress";
            this.textboxAdress.Size = new System.Drawing.Size(179, 134);
            this.textboxAdress.TabIndex = 9;
            this.textboxAdress.TextChanged += new System.EventHandler(this.textboxAdress_TextChanged);
            // 
            // textboxPhone
            // 
            this.textboxPhone.Location = new System.Drawing.Point(92, 86);
            this.textboxPhone.MaxLength = 11;
            this.textboxPhone.Name = "textboxPhone";
            this.textboxPhone.Size = new System.Drawing.Size(179, 20);
            this.textboxPhone.TabIndex = 8;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(92, 51);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(179, 20);
            this.textboxName.TabIndex = 7;
            // 
            // textboxTC
            // 
            this.textboxTC.Location = new System.Drawing.Point(92, 20);
            this.textboxTC.MaxLength = 11;
            this.textboxTC.Name = "textboxTC";
            this.textboxTC.Size = new System.Drawing.Size(179, 20);
            this.textboxTC.TabIndex = 6;
            this.textboxTC.TextChanged += new System.EventHandler(this.textboxTC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No";
            // 
            // textboxGecis
            // 
            this.textboxGecis.Location = new System.Drawing.Point(63, 432);
            this.textboxGecis.Name = "textboxGecis";
            this.textboxGecis.Size = new System.Drawing.Size(100, 20);
            this.textboxGecis.TabIndex = 3;
            this.textboxGecis.TextChanged += new System.EventHandler(this.textboxGecis_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 416);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 366);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textboxGecis);
            this.Controls.Add(this.groupBoxKisiselBilgiler);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.groupBoxKisiselBilgiler.ResumeLayout(false);
            this.groupBoxKisiselBilgiler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKisiselBilgiler;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonTemizle;
        public System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textboxAdress;
        private System.Windows.Forms.TextBox textboxPhone;
        private System.Windows.Forms.TextBox textboxName;
        private System.Windows.Forms.TextBox textboxTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textboxGecis;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}