namespace AppPenjualan.GUI
{
    partial class FornPelanggan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alamat = new System.Windows.Forms.RichTextBox();
            this.Telp = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grupData = new System.Windows.Forms.GroupBox();
            this.DataPelanggan = new System.Windows.Forms.DataGridView();
            this.Cari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Hapus = new System.Windows.Forms.Button();
            this.Ubah = new System.Windows.Forms.Button();
            this.Simpan = new System.Windows.Forms.Button();
            this.Baru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grupData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPelanggan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alamat);
            this.groupBox1.Controls.Add(this.Telp);
            this.groupBox1.Controls.Add(this.Nama);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // Alamat
            // 
            this.Alamat.Location = new System.Drawing.Point(170, 141);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(208, 144);
            this.Alamat.TabIndex = 9;
            this.Alamat.Text = "";
            // 
            // Telp
            // 
            this.Telp.Location = new System.Drawing.Point(170, 309);
            this.Telp.Name = "Telp";
            this.Telp.Size = new System.Drawing.Size(150, 31);
            this.Telp.TabIndex = 7;
            this.Telp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telp_KeyPress);
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(170, 90);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(208, 31);
            this.Nama.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(170, 42);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(150, 31);
            this.Id.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "No Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pelanggan Id";
            // 
            // grupData
            // 
            this.grupData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupData.Controls.Add(this.DataPelanggan);
            this.grupData.Controls.Add(this.Cari);
            this.grupData.Controls.Add(this.label5);
            this.grupData.Location = new System.Drawing.Point(420, 12);
            this.grupData.Name = "grupData";
            this.grupData.Size = new System.Drawing.Size(506, 558);
            this.grupData.TabIndex = 1;
            this.grupData.TabStop = false;
            this.grupData.Text = "Data";
            // 
            // DataPelanggan
            // 
            this.DataPelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPelanggan.Location = new System.Drawing.Point(6, 85);
            this.DataPelanggan.Name = "DataPelanggan";
            this.DataPelanggan.RowHeadersWidth = 62;
            this.DataPelanggan.RowTemplate.Height = 33;
            this.DataPelanggan.Size = new System.Drawing.Size(494, 458);
            this.DataPelanggan.TabIndex = 9;
            this.DataPelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPelanggan_CellContentClick);
            // 
            // Cari
            // 
            this.Cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cari.Location = new System.Drawing.Point(216, 42);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(284, 31);
            this.Cari.TabIndex = 8;
            this.Cari.TextChanged += new System.EventHandler(this.Cari_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cari Id/Nama Pelanggan";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.Hapus);
            this.groupBox3.Controls.Add(this.Ubah);
            this.groupBox3.Controls.Add(this.Simpan);
            this.groupBox3.Controls.Add(this.Baru);
            this.groupBox3.Location = new System.Drawing.Point(12, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 185);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proses";
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(214, 108);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(182, 72);
            this.Hapus.TabIndex = 12;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Ubah
            // 
            this.Ubah.Location = new System.Drawing.Point(6, 108);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(182, 72);
            this.Ubah.TabIndex = 11;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseVisualStyleBackColor = true;
            this.Ubah.Click += new System.EventHandler(this.Ubah_Click);
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(214, 30);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(182, 72);
            this.Simpan.TabIndex = 10;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Baru
            // 
            this.Baru.Location = new System.Drawing.Point(6, 30);
            this.Baru.Name = "Baru";
            this.Baru.Size = new System.Drawing.Size(182, 72);
            this.Baru.TabIndex = 9;
            this.Baru.Text = "Baru";
            this.Baru.UseVisualStyleBackColor = true;
            this.Baru.Click += new System.EventHandler(this.Baru_Click);
            // 
            // FornPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grupData);
            this.Controls.Add(this.groupBox1);
            this.Name = "FornPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupData.ResumeLayout(false);
            this.grupData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPelanggan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox Alamat;
        private TextBox Telp;
        private TextBox Nama;
        private TextBox Id;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox grupData;
        private TextBox Cari;
        private Label label5;
        private GroupBox groupBox3;
        private Button Hapus;
        private Button Ubah;
        private Button Simpan;
        private Button Baru;
        private DataGridView DataPelanggan;
    }
}