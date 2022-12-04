namespace AppPenjualan.GUI
{
    partial class DialogPelanggan
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
            this.DataPelanggan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Cari = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataPelanggan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cari);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DataPelanggan
            // 
            this.DataPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPelanggan.Location = new System.Drawing.Point(12, 104);
            this.DataPelanggan.Name = "DataPelanggan";
            this.DataPelanggan.RowHeadersWidth = 62;
            this.DataPelanggan.RowTemplate.Height = 33;
            this.DataPelanggan.Size = new System.Drawing.Size(764, 316);
            this.DataPelanggan.TabIndex = 2;
            this.DataPelanggan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPelanggan_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Cari
            // 
            this.Cari.Location = new System.Drawing.Point(164, 51);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(586, 31);
            this.Cari.TabIndex = 0;
            this.Cari.TextChanged += new System.EventHandler(this.Cari_TextChanged);
            // 
            // DialogPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "DialogPelanggan";
            this.Text = "DialogPelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataPelanggan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView DataPelanggan;
        private Label label1;
        private TextBox Cari;
    }
}