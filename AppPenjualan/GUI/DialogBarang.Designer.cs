namespace AppPenjualan.GUI
{
    partial class DialogBarang
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
            this.Cari = new System.Windows.Forms.TextBox();
            this.DataBarang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cari);
            this.groupBox1.Controls.Add(this.DataBarang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Cari
            // 
            this.Cari.Location = new System.Drawing.Point(225, 40);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(483, 31);
            this.Cari.TabIndex = 1;
            this.Cari.TextChanged += new System.EventHandler(this.Cari_TextChanged);
            // 
            // DataBarang
            // 
            this.DataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBarang.Location = new System.Drawing.Point(6, 93);
            this.DataBarang.Name = "DataBarang";
            this.DataBarang.RowHeadersWidth = 62;
            this.DataBarang.RowTemplate.Height = 33;
            this.DataBarang.Size = new System.Drawing.Size(764, 333);
            this.DataBarang.TabIndex = 1;
            this.DataBarang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataBarang_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "DialogBarang";
            this.Text = "DialogBarang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Cari;
        private DataGridView DataBarang;
        private Label label1;
    }
}