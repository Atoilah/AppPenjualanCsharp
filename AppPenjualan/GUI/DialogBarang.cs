using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPenjualan.GUI
{
    public partial class DialogBarang : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        public string KodeBarang, NamaBarang, harga;

        Kelas.Koneksi kon = new Kelas.Koneksi();

        void Tampil()
        {
            SqlConnection conn = kon.getConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Select * From Barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "Barang");
                    DataBarang.DataSource = ds;
                    DataBarang.DataMember = "Barang";
                    DataBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataBarang.AllowUserToAddRows = false;
                    DataBarang.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        void search()
        {
            SqlConnection conn = kon.getConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Select * From Barang where KodeBarang LIKE '%" + Cari.Text + "%' OR NamaBarang LIKE '%" + Cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "Barang");
                    DataBarang.DataSource = ds;
                    DataBarang.DataMember = "Barang";
                    DataBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataBarang.AllowUserToAddRows = false;
                    DataBarang.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Cari_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void DataBarang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataBarang.Rows[e.RowIndex];
                KodeBarang = row.Cells["KodeBarang"].Value.ToString();
                NamaBarang = row.Cells["NamaBarang"].Value.ToString();
                harga = row.Cells["Harga"].Value.ToString();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string ambilKode
        {
            get
            {
                return KodeBarang;
            }
        }
        public string ambilNama
        {
            get
            {
                return NamaBarang;
            }
        }
        public string ambilHarga
        {
            get
            {
                return harga;
            }
        }


        public DialogBarang()
        {
            InitializeComponent();
            Tampil();
        }
    }
}
