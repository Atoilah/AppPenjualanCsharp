namespace AppPenjualan.GUI
{
    partial class FromBarang
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
            this.Satuan = new System.Windows.Forms.ComboBox();
            this.Stok = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Harga = new System.Windows.Forms.TextBox();
            this.Kode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.Cari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Hapus = new System.Windows.Forms.Button();
            this.Simpan = new System.Windows.Forms.Button();
            this.Ubah = new System.Windows.Forms.Button();
            this.Baru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Satuan);
            this.groupBox1.Controls.Add(this.Stok);
            this.groupBox1.Controls.Add(this.Nama);
            this.groupBox1.Controls.Add(this.Harga);
            this.groupBox1.Controls.Add(this.Kode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // Satuan
            // 
            this.Satuan.FormattingEnabled = true;
            this.Satuan.Items.AddRange(new object[] {
            "Unit",
            "Kodi",
            "Lusin",
            "Pack"});
            this.Satuan.Location = new System.Drawing.Point(172, 229);
            this.Satuan.Name = "Satuan";
            this.Satuan.Size = new System.Drawing.Size(269, 33);
            this.Satuan.TabIndex = 9;
            // 
            // Stok
            // 
            this.Stok.Location = new System.Drawing.Point(172, 185);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(119, 31);
            this.Stok.TabIndex = 8;
            this.Stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stok_KeyPress);
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(172, 87);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(269, 31);
            this.Nama.TabIndex = 7;
            // 
            // Harga
            // 
            this.Harga.Location = new System.Drawing.Point(172, 138);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(182, 31);
            this.Harga.TabIndex = 6;
            this.Harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Harga_KeyPress);
            // 
            // Kode
            // 
            this.Kode.Location = new System.Drawing.Point(172, 40);
            this.Kode.Name = "Kode";
            this.Kode.Size = new System.Drawing.Size(119, 31);
            this.Kode.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satuan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DataBarang);
            this.groupBox2.Controls.Add(this.Cari);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(505, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(608, 514);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // DataBarang
            // 
            this.DataBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(12, 89);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.RowHeadersWidth = 62;
            this.DataBarang.RowTemplate.Height = 33;
            this.DataBarang.Size = new System.Drawing.Size(590, 419);
            this.DataBarang.TabIndex = 12;
            this.DataBarang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellContentClick);
            // 
            // Cari
            // 
            this.Cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cari.Location = new System.Drawing.Point(214, 37);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(377, 31);
            this.Cari.TabIndex = 11;
            this.Cari.TextChanged += new System.EventHandler(this.Cari_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cari Nama/Kode Barang";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.Hapus);
            this.groupBox3.Controls.Add(this.Simpan);
            this.groupBox3.Controls.Add(this.Ubah);
            this.groupBox3.Controls.Add(this.Baru);
            this.groupBox3.Location = new System.Drawing.Point(12, 335);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 191);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proses";
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(253, 111);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(228, 72);
            this.Hapus.TabIndex = 3;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Simpan
            // 
            this.Simpan.Location = new System.Drawing.Point(253, 30);
            this.Simpan.Name = "Simpan";
            this.Simpan.Size = new System.Drawing.Size(228, 72);
            this.Simpan.TabIndex = 2;
            this.Simpan.Text = "Simpan";
            this.Simpan.UseVisualStyleBackColor = true;
            this.Simpan.Click += new System.EventHandler(this.Simpan_Click);
            // 
            // Ubah
            // 
            this.Ubah.Location = new System.Drawing.Point(6, 111);
            this.Ubah.Name = "Ubah";
            this.Ubah.Size = new System.Drawing.Size(228, 72);
            this.Ubah.TabIndex = 1;
            this.Ubah.Text = "Ubah";
            this.Ubah.UseVisualStyleBackColor = true;
            this.Ubah.Click += new System.EventHandler(this.Ubah_Click);
            // 
            // Baru
            // 
            this.Baru.Location = new System.Drawing.Point(6, 30);
            this.Baru.Name = "Baru";
            this.Baru.Size = new System.Drawing.Size(228, 72);
            this.Baru.TabIndex = 0;
            this.Baru.Text = "Baru";
            this.Baru.UseVisualStyleBackColor = true;
            this.Baru.Click += new System.EventHandler(this.Baru_Click);
            // 
            // FromBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FromBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Barang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox Satuan;
        private TextBox Stok;
        private TextBox Nama;
        private TextBox Harga;
        private TextBox Kode;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView DataBarang;
        private TextBox Cari;
        private Label label6;
        private Button Hapus;
        private Button Simpan;
        private Button Ubah;
        private Button Baru;
    }
}