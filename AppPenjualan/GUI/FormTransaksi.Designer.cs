namespace AppPenjualan.GUI
{
    partial class FormTransaksi
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
            this.CariPelanggan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TglKwitansi = new System.Windows.Forms.DateTimePicker();
            this.PelangganNama = new System.Windows.Forms.TextBox();
            this.PelangganId = new System.Windows.Forms.TextBox();
            this.NoKwitansi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Kurang = new System.Windows.Forms.Button();
            this.Tambah = new System.Windows.Forms.Button();
            this.CariBarang = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.JumlahBarang = new System.Windows.Forms.TextBox();
            this.HargaBarang = new System.Windows.Forms.TextBox();
            this.NamaBarang = new System.Windows.Forms.TextBox();
            this.KodeBarang = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalHarga = new System.Windows.Forms.Label();
            this.Baru = new System.Windows.Forms.Button();
            this.Simpan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CariPelanggan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TglKwitansi);
            this.groupBox1.Controls.Add(this.PelangganNama);
            this.groupBox1.Controls.Add(this.PelangganId);
            this.groupBox1.Controls.Add(this.NoKwitansi);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CariPelanggan
            // 
            this.CariPelanggan.Location = new System.Drawing.Point(190, 267);
            this.CariPelanggan.Name = "CariPelanggan";
            this.CariPelanggan.Size = new System.Drawing.Size(61, 34);
            this.CariPelanggan.TabIndex = 9;
            this.CariPelanggan.Text = "Cari";
            this.CariPelanggan.UseVisualStyleBackColor = true;
            this.CariPelanggan.Click += new System.EventHandler(this.CariPelanggan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pelanggan ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tanggal Kwitansi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "No Kwitansi";
            // 
            // TglKwitansi
            // 
            this.TglKwitansi.CustomFormat = "MM/dd/yyyy";
            this.TglKwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TglKwitansi.Location = new System.Drawing.Point(441, 97);
            this.TglKwitansi.Name = "TglKwitansi";
            this.TglKwitansi.Size = new System.Drawing.Size(150, 31);
            this.TglKwitansi.TabIndex = 4;
            this.TglKwitansi.Value = new System.DateTime(2022, 12, 4, 0, 0, 0, 0);
            // 
            // PelangganNama
            // 
            this.PelangganNama.Location = new System.Drawing.Point(282, 267);
            this.PelangganNama.Name = "PelangganNama";
            this.PelangganNama.Size = new System.Drawing.Size(150, 31);
            this.PelangganNama.TabIndex = 3;
            // 
            // PelangganId
            // 
            this.PelangganId.Location = new System.Drawing.Point(20, 267);
            this.PelangganId.Name = "PelangganId";
            this.PelangganId.Size = new System.Drawing.Size(150, 31);
            this.PelangganId.TabIndex = 2;
            // 
            // NoKwitansi
            // 
            this.NoKwitansi.Location = new System.Drawing.Point(441, 41);
            this.NoKwitansi.Name = "NoKwitansi";
            this.NoKwitansi.Size = new System.Drawing.Size(150, 31);
            this.NoKwitansi.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 161);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Kurang);
            this.groupBox2.Controls.Add(this.Tambah);
            this.groupBox2.Controls.Add(this.CariBarang);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.JumlahBarang);
            this.groupBox2.Controls.Add(this.HargaBarang);
            this.groupBox2.Controls.Add(this.NamaBarang);
            this.groupBox2.Controls.Add(this.KodeBarang);
            this.groupBox2.Location = new System.Drawing.Point(12, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Kurang
            // 
            this.Kurang.Location = new System.Drawing.Point(397, 167);
            this.Kurang.Name = "Kurang";
            this.Kurang.Size = new System.Drawing.Size(53, 34);
            this.Kurang.TabIndex = 14;
            this.Kurang.Text = "-";
            this.Kurang.UseVisualStyleBackColor = true;
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(338, 167);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(53, 34);
            this.Tambah.TabIndex = 13;
            this.Tambah.Text = "+";
            this.Tambah.UseVisualStyleBackColor = true;
            // 
            // CariBarang
            // 
            this.CariBarang.Location = new System.Drawing.Point(182, 94);
            this.CariBarang.Name = "CariBarang";
            this.CariBarang.Size = new System.Drawing.Size(69, 34);
            this.CariBarang.TabIndex = 10;
            this.CariBarang.Text = "Cari";
            this.CariBarang.UseVisualStyleBackColor = true;
            this.CariBarang.Click += new System.EventHandler(this.CariBarang_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Jumlah";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Harga Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nama Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kode Barang";
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.Location = new System.Drawing.Point(182, 170);
            this.JumlahBarang.Name = "JumlahBarang";
            this.JumlahBarang.Size = new System.Drawing.Size(150, 31);
            this.JumlahBarang.TabIndex = 7;
            // 
            // HargaBarang
            // 
            this.HargaBarang.Location = new System.Drawing.Point(20, 170);
            this.HargaBarang.Name = "HargaBarang";
            this.HargaBarang.Size = new System.Drawing.Size(150, 31);
            this.HargaBarang.TabIndex = 6;
            // 
            // NamaBarang
            // 
            this.NamaBarang.Location = new System.Drawing.Point(269, 94);
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.Size = new System.Drawing.Size(150, 31);
            this.NamaBarang.TabIndex = 5;
            // 
            // KodeBarang
            // 
            this.KodeBarang.Location = new System.Drawing.Point(20, 94);
            this.KodeBarang.Name = "KodeBarang";
            this.KodeBarang.Size = new System.Drawing.Size(150, 31);
            this.KodeBarang.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(644, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 583);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(572, 516);
            this.dataGridView1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(734, 621);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Seluruh Rp";
            // 
            // TotalHarga
            // 
            this.TotalHarga.AutoSize = true;
            this.TotalHarga.Location = new System.Drawing.Point(914, 620);
            this.TotalHarga.Name = "TotalHarga";
            this.TotalHarga.Size = new System.Drawing.Size(22, 25);
            this.TotalHarga.TabIndex = 14;
            this.TotalHarga.Text = "0";
            // 
            // Baru
            // 
            this.Baru.Location = new System.Drawing.Point(42, 601);
            this.Baru.Name = "Baru";
            this.Baru.Size = new System.Drawing.Size(152, 65);
            this.Baru.TabIndex = 15;
            this.Baru.Text = "Baru";
            this.Baru.UseVisualStyleBackColor = true;
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(309, 600);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(152, 65);
            this.Simpan.TabIndex = 16;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 665);
            this.Controls.Add(this.Simpan);
            this.Controls.Add(this.Baru);
            this.Controls.Add(this.TotalHarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransaksi";
            this.Text = "FormTransaksi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DateTimePicker TglKwitansi;
        private TextBox PelangganNama;
        private TextBox PelangganId;
        private TextBox NoKwitansi;
        private TextBox JumlahBarang;
        private TextBox HargaBarang;
        private TextBox NamaBarang;
        private TextBox KodeBarang;
        private Button CariPelanggan;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Kurang;
        private Button Tambah;
        private Button CariBarang;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label9;
        private Label TotalHarga;
        private Button Baru;
        private Button Simpan;
    }
}