namespace YazilimBakimi.KitapSatisUygulamasi
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.lblSingUp = new System.Windows.Forms.Label();
            this.lblPasswordAdmin = new System.Windows.Forms.Label();
            this.lblUserNameAdmin = new System.Windows.Forms.Label();
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.textBoxPasswordAdmin = new System.Windows.Forms.TextBox();
            this.textBoxNameAdmin = new System.Windows.Forms.TextBox();
            this.pictureBoxBackAdmin = new System.Windows.Forms.PictureBox();
            this.pbAdminLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSingUp
            // 
            this.lblSingUp.BackColor = System.Drawing.Color.CadetBlue;
            this.lblSingUp.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSingUp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSingUp.Location = new System.Drawing.Point(127, 218);
            this.lblSingUp.Name = "lblSingUp";
            this.lblSingUp.Size = new System.Drawing.Size(155, 39);
            this.lblSingUp.TabIndex = 2;
            this.lblSingUp.Text = "ADMIN GİRİŞİ";
            this.lblSingUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasswordAdmin
            // 
            this.lblPasswordAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordAdmin.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPasswordAdmin.Location = new System.Drawing.Point(25, 379);
            this.lblPasswordAdmin.Name = "lblPasswordAdmin";
            this.lblPasswordAdmin.Size = new System.Drawing.Size(109, 28);
            this.lblPasswordAdmin.TabIndex = 15;
            this.lblPasswordAdmin.Text = "Parola:";
            this.lblPasswordAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserNameAdmin
            // 
            this.lblUserNameAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNameAdmin.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNameAdmin.Location = new System.Drawing.Point(25, 311);
            this.lblUserNameAdmin.Name = "lblUserNameAdmin";
            this.lblUserNameAdmin.Size = new System.Drawing.Size(109, 28);
            this.lblUserNameAdmin.TabIndex = 14;
            this.lblUserNameAdmin.Text = "Kullanıcı Adı:";
            this.lblUserNameAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLoginAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoginAdmin.Location = new System.Drawing.Point(167, 437);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(194, 36);
            this.btnLoginAdmin.TabIndex = 13;
            this.btnLoginAdmin.Text = "Giriş";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // textBoxPasswordAdmin
            // 
            this.textBoxPasswordAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPasswordAdmin.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPasswordAdmin.Location = new System.Drawing.Point(167, 379);
            this.textBoxPasswordAdmin.Name = "textBoxPasswordAdmin";
            this.textBoxPasswordAdmin.PasswordChar = '*';
            this.textBoxPasswordAdmin.Size = new System.Drawing.Size(194, 28);
            this.textBoxPasswordAdmin.TabIndex = 12;
            // 
            // textBoxNameAdmin
            // 
            this.textBoxNameAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNameAdmin.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNameAdmin.Location = new System.Drawing.Point(167, 311);
            this.textBoxNameAdmin.Name = "textBoxNameAdmin";
            this.textBoxNameAdmin.Size = new System.Drawing.Size(194, 28);
            this.textBoxNameAdmin.TabIndex = 11;
            // 
            // pictureBoxBackAdmin
            // 
            this.pictureBoxBackAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackAdmin.BackgroundImage")));
            this.pictureBoxBackAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBackAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackAdmin.Image")));
            this.pictureBoxBackAdmin.Location = new System.Drawing.Point(12, 26);
            this.pictureBoxBackAdmin.Name = "pictureBoxBackAdmin";
            this.pictureBoxBackAdmin.Size = new System.Drawing.Size(34, 33);
            this.pictureBoxBackAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackAdmin.TabIndex = 16;
            this.pictureBoxBackAdmin.TabStop = false;
            this.pictureBoxBackAdmin.Click += new System.EventHandler(this.pictureBoxBackAdmin_Click);
            // 
            // pbAdminLogin
            // 
            this.pbAdminLogin.BackgroundImage = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.admin;
            this.pbAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAdminLogin.Location = new System.Drawing.Point(127, 69);
            this.pbAdminLogin.Name = "pbAdminLogin";
            this.pbAdminLogin.Size = new System.Drawing.Size(155, 132);
            this.pbAdminLogin.TabIndex = 17;
            this.pbAdminLogin.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(387, 537);
            this.Controls.Add(this.pbAdminLogin);
            this.Controls.Add(this.pictureBoxBackAdmin);
            this.Controls.Add(this.lblPasswordAdmin);
            this.Controls.Add(this.lblUserNameAdmin);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.textBoxPasswordAdmin);
            this.Controls.Add(this.textBoxNameAdmin);
            this.Controls.Add(this.lblSingUp);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSingUp;
        private System.Windows.Forms.Label lblPasswordAdmin;
        private System.Windows.Forms.Label lblUserNameAdmin;
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.TextBox textBoxPasswordAdmin;
        private System.Windows.Forms.TextBox textBoxNameAdmin;
        private System.Windows.Forms.PictureBox pictureBoxBackAdmin;
        private System.Windows.Forms.PictureBox pbAdminLogin;
    }
}