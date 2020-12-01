namespace PhoneManagement
{
    partial class PhoneCatalog
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCataloges = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBrandId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lnDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPriceExport = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbPriceImport = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbResolution = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSoundCard = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(248, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone Cataloges";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Cataloges";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.Size = new System.Drawing.Size(718, 195);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbName.Location = new System.Drawing.Point(127, 296);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 21);
            this.lbName.TabIndex = 25;
            this.lbName.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label11.Location = new System.Drawing.Point(12, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "Name: ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbID.Location = new System.Drawing.Point(127, 263);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 21);
            this.lbID.TabIndex = 23;
            this.lbID.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label10.Location = new System.Drawing.Point(12, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID : ";
            // 
            // lbCataloges
            // 
            this.lbCataloges.AutoSize = true;
            this.lbCataloges.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCataloges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbCataloges.Location = new System.Drawing.Point(127, 329);
            this.lbCataloges.Name = "lbCataloges";
            this.lbCataloges.Size = new System.Drawing.Size(92, 21);
            this.lbCataloges.TabIndex = 27;
            this.lbCataloges.Text = "Cataloges";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(12, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cataloges: ";
            // 
            // lbBrandId
            // 
            this.lbBrandId.AutoSize = true;
            this.lbBrandId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrandId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbBrandId.Location = new System.Drawing.Point(127, 363);
            this.lbBrandId.Name = "lbBrandId";
            this.lbBrandId.Size = new System.Drawing.Size(56, 21);
            this.lbBrandId.TabIndex = 29;
            this.lbBrandId.Text = "Brand";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(12, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Brand: ";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbQuantity.Location = new System.Drawing.Point(382, 363);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(80, 21);
            this.lbQuantity.TabIndex = 37;
            this.lbQuantity.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label6.Location = new System.Drawing.Point(250, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Quantity: ";
            // 
            // lnDate
            // 
            this.lnDate.AutoSize = true;
            this.lnDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lnDate.Location = new System.Drawing.Point(382, 329);
            this.lnDate.Name = "lnDate";
            this.lnDate.Size = new System.Drawing.Size(50, 21);
            this.lnDate.TabIndex = 35;
            this.lnDate.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label8.Location = new System.Drawing.Point(250, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "Warranty: ";
            // 
            // lbPriceExport
            // 
            this.lbPriceExport.AutoSize = true;
            this.lbPriceExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbPriceExport.Location = new System.Drawing.Point(382, 296);
            this.lbPriceExport.Name = "lbPriceExport";
            this.lbPriceExport.Size = new System.Drawing.Size(101, 21);
            this.lbPriceExport.TabIndex = 33;
            this.lbPriceExport.Text = "Price Export";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label.Location = new System.Drawing.Point(250, 296);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(109, 21);
            this.label.TabIndex = 32;
            this.label.Text = "Price Export: ";
            // 
            // lbPriceImport
            // 
            this.lbPriceImport.AutoSize = true;
            this.lbPriceImport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbPriceImport.Location = new System.Drawing.Point(382, 263);
            this.lbPriceImport.Name = "lbPriceImport";
            this.lbPriceImport.Size = new System.Drawing.Size(104, 21);
            this.lbPriceImport.TabIndex = 31;
            this.lbPriceImport.Text = "Price Import";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label14.Location = new System.Drawing.Point(250, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 21);
            this.label14.TabIndex = 30;
            this.label14.Text = "Price Import : ";
            // 
            // lbResolution
            // 
            this.lbResolution.AutoSize = true;
            this.lbResolution.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbResolution.Location = new System.Drawing.Point(382, 399);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.Size = new System.Drawing.Size(89, 21);
            this.lbResolution.TabIndex = 41;
            this.lbResolution.Text = "Resolution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label7.Location = new System.Drawing.Point(250, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 40;
            this.label7.Text = "Img Resolution: ";
            // 
            // lbSoundCard
            // 
            this.lbSoundCard.AutoSize = true;
            this.lbSoundCard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoundCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbSoundCard.Location = new System.Drawing.Point(127, 399);
            this.lbSoundCard.Name = "lbSoundCard";
            this.lbSoundCard.Size = new System.Drawing.Size(99, 21);
            this.lbSoundCard.TabIndex = 39;
            this.lbSoundCard.Text = "SoundCard";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label12.Location = new System.Drawing.Point(14, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 21);
            this.label12.TabIndex = 38;
            this.label12.Text = "Sound Card: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(502, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 157);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // PhoneCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(718, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbResolution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSoundCard);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lnDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbPriceExport);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbPriceImport);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbBrandId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCataloges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhoneCatalog";
            this.Text = "PhoneCatalogue";
            this.Load += new System.EventHandler(this.PhoneCatalog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chupAnhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanHieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianBaoHanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maManHinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amThanhDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCataloges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBrandId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lnDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPriceExport;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbPriceImport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbResolution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbSoundCard;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}