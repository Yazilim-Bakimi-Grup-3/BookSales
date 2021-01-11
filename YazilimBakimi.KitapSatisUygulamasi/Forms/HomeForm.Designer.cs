namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnBookForm = new System.Windows.Forms.Button();
            this.btnInvoiceForm = new System.Windows.Forms.Button();
            this.pnSeperator = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBackSignUp = new System.Windows.Forms.PictureBox();
            this.pcHome = new System.Windows.Forms.PictureBox();
            this.btnWriterForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsername.Location = new System.Drawing.Point(367, 194);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 43);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "admin";
            // 
            // btnBookForm
            // 
            this.btnBookForm.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.book;
            this.btnBookForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBookForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBookForm.Location = new System.Drawing.Point(360, 350);
            this.btnBookForm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBookForm.Name = "btnBookForm";
            this.btnBookForm.Size = new System.Drawing.Size(280, 113);
            this.btnBookForm.TabIndex = 4;
            this.btnBookForm.UseVisualStyleBackColor = true;
            this.btnBookForm.Click += new System.EventHandler(this.btnBookForm_Click);
            // 
            // btnInvoiceForm
            // 
            this.btnInvoiceForm.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.sale;
            this.btnInvoiceForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInvoiceForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInvoiceForm.Location = new System.Drawing.Point(652, 350);
            this.btnInvoiceForm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInvoiceForm.Name = "btnInvoiceForm";
            this.btnInvoiceForm.Size = new System.Drawing.Size(292, 113);
            this.btnInvoiceForm.TabIndex = 5;
            this.btnInvoiceForm.UseVisualStyleBackColor = true;
            this.btnInvoiceForm.Click += new System.EventHandler(this.btnInvoiceForm_Click);
            // 
            // pnSeperator
            // 
            this.pnSeperator.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnSeperator.Location = new System.Drawing.Point(-2, 319);
            this.pnSeperator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnSeperator.Name = "pnSeperator";
            this.pnSeperator.Size = new System.Drawing.Size(972, 6);
            this.pnSeperator.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(154)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.pictureBoxBackSignUp);
            this.panel1.Controls.Add(this.pcHome);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 87);
            this.panel1.TabIndex = 7;
            // 
            // pictureBoxBackSignUp
            // 
            this.pictureBoxBackSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackSignUp.BackgroundImage")));
            this.pictureBoxBackSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBackSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackSignUp.Image")));
            this.pictureBoxBackSignUp.Location = new System.Drawing.Point(26, 17);
            this.pictureBoxBackSignUp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBoxBackSignUp.Name = "pictureBoxBackSignUp";
            this.pictureBoxBackSignUp.Size = new System.Drawing.Size(68, 63);
            this.pictureBoxBackSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackSignUp.TabIndex = 18;
            this.pictureBoxBackSignUp.TabStop = false;
            this.pictureBoxBackSignUp.Click += new System.EventHandler(this.pictureBoxBackSignUp_Click);
            // 
            // pcHome
            // 
            this.pcHome.Image = ((System.Drawing.Image)(resources.GetObject("pcHome.Image")));
            this.pcHome.Location = new System.Drawing.Point(164, 6);
            this.pcHome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pcHome.Name = "pcHome";
            this.pcHome.Size = new System.Drawing.Size(638, 75);
            this.pcHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHome.TabIndex = 2;
            this.pcHome.TabStop = false;
            // 
            // btnWriterForm
            // 
            this.btnWriterForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWriterForm.Image = ((System.Drawing.Image)(resources.GetObject("btnWriterForm.Image")));
            this.btnWriterForm.Location = new System.Drawing.Point(24, 350);
            this.btnWriterForm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnWriterForm.Name = "btnWriterForm";
            this.btnWriterForm.Size = new System.Drawing.Size(324, 113);
            this.btnWriterForm.TabIndex = 0;
            this.btnWriterForm.UseVisualStyleBackColor = true;
            this.btnWriterForm.Click += new System.EventHandler(this.btnWriterForm_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(968, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnSeperator);
            this.Controls.Add(this.btnInvoiceForm);
            this.Controls.Add(this.btnBookForm);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnWriterForm);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriterForm;
        private System.Windows.Forms.PictureBox pcHome;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnBookForm;
        private System.Windows.Forms.Button btnInvoiceForm;
        private System.Windows.Forms.Panel pnSeperator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBackSignUp;
    }
}