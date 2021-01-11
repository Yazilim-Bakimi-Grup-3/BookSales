namespace YazilimBakimi.KitapSatisUygulamasi.Forms
{
    partial class WriterCRUDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriterCRUDForm));
            this.gridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBackSignUp = new System.Windows.Forms.PictureBox();
            this.pcHome = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(16, 78);
            this.gridView.Name = "gridView";
            this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridView.Size = new System.Drawing.Size(772, 259);
            this.gridView.TabIndex = 0;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBoxBackSignUp);
            this.panel1.Controls.Add(this.pcHome);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 45);
            this.panel1.TabIndex = 8;
            // 
            // pictureBoxBackSignUp
            // 
            this.pictureBoxBackSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackSignUp.BackgroundImage")));
            this.pictureBoxBackSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBackSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackSignUp.Image")));
            this.pictureBoxBackSignUp.Location = new System.Drawing.Point(13, 8);
            this.pictureBoxBackSignUp.Name = "pictureBoxBackSignUp";
            this.pictureBoxBackSignUp.Size = new System.Drawing.Size(34, 33);
            this.pictureBoxBackSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBackSignUp.TabIndex = 18;
            this.pictureBoxBackSignUp.TabStop = false;
            this.pictureBoxBackSignUp.Click += new System.EventHandler(this.pictureBoxBackSignUp_Click);
            // 
            // pcHome
            // 
            this.pcHome.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.writerBig;
            this.pcHome.Location = new System.Drawing.Point(260, 3);
            this.pcHome.Name = "pcHome";
            this.pcHome.Size = new System.Drawing.Size(319, 38);
            this.pcHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcHome.TabIndex = 2;
            this.pcHome.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(559, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(189, 74);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(319, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 79);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::YazilimBakimi.KitapSatisUygulamasi.Properties.Resources.update;
            this.btnUpdate.Location = new System.Drawing.Point(65, 365);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 79);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // WriterCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridView);
            this.Name = "WriterCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WriterCRUD";
            this.Load += new System.EventHandler(this.WriterCRUDForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxBackSignUp;
        private System.Windows.Forms.PictureBox pcHome;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}