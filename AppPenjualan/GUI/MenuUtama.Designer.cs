namespace AppPenjualan.GUI
{
    partial class MenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.Keluar = new System.Windows.Forms.ToolStripMenuItem();
            this.Master = new System.Windows.Forms.ToolStripMenuItem();
            this.Barang = new System.Windows.Forms.ToolStripMenuItem();
            this.Pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.Transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.Penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.Laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.LaporanBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.LaporanPelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.Pengaturan = new System.Windows.Forms.ToolStripMenuItem();
            this.UbahPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.TambahUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Tentang = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolBarang = new System.Windows.Forms.ToolStripButton();
            this.toolPelanggan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolTransaksi = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 839);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip.Size = new System.Drawing.Size(1053, 32);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu,
            this.Master,
            this.Transaksi,
            this.Laporan,
            this.Pengaturan,
            this.Tentang});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1053, 37);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Login,
            this.Logout,
            this.toolStripMenuItem1,
            this.Keluar});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(73, 29);
            this.Menu.Text = "Menu";
            // 
            // Login
            // 
            this.Login.Name = "Login";
            this.Login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.Login.Size = new System.Drawing.Size(239, 34);
            this.Login.Text = "Login";
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Logout.Size = new System.Drawing.Size(239, 34);
            this.Logout.Text = "LogOut";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 6);
            // 
            // Keluar
            // 
            this.Keluar.Name = "Keluar";
            this.Keluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Keluar.Size = new System.Drawing.Size(239, 34);
            this.Keluar.Text = "Keluar";
            // 
            // Master
            // 
            this.Master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Barang,
            this.Pelanggan});
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(124, 29);
            this.Master.Text = "Master Data";
            // 
            // Barang
            // 
            this.Barang.Name = "Barang";
            this.Barang.Size = new System.Drawing.Size(270, 34);
            this.Barang.Text = "Barang";
            this.Barang.Click += new System.EventHandler(this.Barang_Click);
            // 
            // Pelanggan
            // 
            this.Pelanggan.Name = "Pelanggan";
            this.Pelanggan.Size = new System.Drawing.Size(270, 34);
            this.Pelanggan.Text = "Pelanggan";
            this.Pelanggan.Click += new System.EventHandler(this.Pelanggan_Click);
            // 
            // Transaksi
            // 
            this.Transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Penjualan});
            this.Transaksi.Name = "Transaksi";
            this.Transaksi.Size = new System.Drawing.Size(98, 29);
            this.Transaksi.Text = "Transaksi";
            // 
            // Penjualan
            // 
            this.Penjualan.Name = "Penjualan";
            this.Penjualan.Size = new System.Drawing.Size(188, 34);
            this.Penjualan.Text = "Penjualan";
            // 
            // Laporan
            // 
            this.Laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LaporanBarang,
            this.LaporanPelanggan});
            this.Laporan.Name = "Laporan";
            this.Laporan.Size = new System.Drawing.Size(92, 29);
            this.Laporan.Text = "Laporan";
            // 
            // LaporanBarang
            // 
            this.LaporanBarang.Name = "LaporanBarang";
            this.LaporanBarang.Size = new System.Drawing.Size(265, 34);
            this.LaporanBarang.Text = "Laporan Barang";
            // 
            // LaporanPelanggan
            // 
            this.LaporanPelanggan.Name = "LaporanPelanggan";
            this.LaporanPelanggan.Size = new System.Drawing.Size(265, 34);
            this.LaporanPelanggan.Text = "Laporan Pelanggan";
            // 
            // Pengaturan
            // 
            this.Pengaturan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UbahPassword,
            this.TambahUser});
            this.Pengaturan.Name = "Pengaturan";
            this.Pengaturan.Size = new System.Drawing.Size(117, 29);
            this.Pengaturan.Text = "Pengaturan";
            // 
            // UbahPassword
            // 
            this.UbahPassword.Name = "UbahPassword";
            this.UbahPassword.Size = new System.Drawing.Size(260, 34);
            this.UbahPassword.Text = "Ubah Password";
            // 
            // TambahUser
            // 
            this.TambahUser.Name = "TambahUser";
            this.TambahUser.Size = new System.Drawing.Size(260, 34);
            this.TambahUser.Text = "Tambah Pengguna";
            // 
            // Tentang
            // 
            this.Tentang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info});
            this.Tentang.Name = "Tentang";
            this.Tentang.Size = new System.Drawing.Size(90, 29);
            this.Tentang.Text = "Tentang";
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(146, 34);
            this.Info.Text = "Info";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarang,
            this.toolPelanggan,
            this.toolStripSeparator1,
            this.toolTransaksi});
            this.toolStrip.Location = new System.Drawing.Point(0, 37);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(1053, 33);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // ToolBarang
            // 
            this.ToolBarang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolBarang.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarang.Image")));
            this.ToolBarang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarang.Name = "ToolBarang";
            this.ToolBarang.Size = new System.Drawing.Size(34, 28);
            this.ToolBarang.Text = "barang";
            this.ToolBarang.ToolTipText = "data barang";
            // 
            // toolPelanggan
            // 
            this.toolPelanggan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPelanggan.Image = ((System.Drawing.Image)(resources.GetObject("toolPelanggan.Image")));
            this.toolPelanggan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPelanggan.Name = "toolPelanggan";
            this.toolPelanggan.Size = new System.Drawing.Size(34, 28);
            this.toolPelanggan.Text = "Pelanggan";
            this.toolPelanggan.ToolTipText = "data Pelanggan";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolTransaksi
            // 
            this.toolTransaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("toolTransaksi.Image")));
            this.toolTransaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolTransaksi.Name = "toolTransaksi";
            this.toolTransaksi.Size = new System.Drawing.Size(34, 28);
            this.toolTransaksi.Text = "Transaksi";
            this.toolTransaksi.ToolTipText = "data Transaksi";
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppPenjualan.Properties.Resources.pos_system;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1053, 871);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Informasi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MenuStrip menuStrip;
        private ToolStrip toolStrip;
        public ToolStripMenuItem Menu;
        public ToolStripMenuItem Master;
        public ToolStripMenuItem Transaksi;
        public ToolStripMenuItem Laporan;
        public ToolStripMenuItem Tentang;
        public ToolStripMenuItem Login;
        private ToolStripSeparator toolStripMenuItem1;
        public ToolStripMenuItem Logout;
        public ToolStripMenuItem Keluar;
        public ToolStripMenuItem Barang;
        public ToolStripMenuItem Pelanggan;
        public ToolStripMenuItem Penjualan;
        public ToolStripMenuItem LaporanBarang;
        public ToolStripMenuItem LaporanPelanggan;
        public ToolStripMenuItem Pengaturan;
        public ToolStripMenuItem UbahPassword;
        public ToolStripMenuItem TambahUser;
        public ToolStripMenuItem Info;
        public ToolStripButton ToolBarang;
        public ToolStripButton toolPelanggan;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolTransaksi;
    }
}



