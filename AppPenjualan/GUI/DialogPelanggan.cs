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
    public partial class DialogPelanggan : Form
    {

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        public string pelangganId, namaPelanggan;

        Kelas.Koneksi kon = new Kelas.Koneksi();

        void tampil()
        {
            SqlConnection conn = kon.getConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Select * From Pelanggan", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "Pelanggan");
                    DataPelanggan.DataSource = ds;
                    DataPelanggan.DataMember = "Pelanggan";
                    DataPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataPelanggan.AllowUserToAddRows = false;
                    DataPelanggan.Refresh();

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
                    cmd = new SqlCommand("Select * From Pelanggan where PelangganId LIKE '%" + Cari.Text + "%' OR PelangganNama LIKE '%" + Cari.Text + "%'", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "Pelanggan");
                    DataPelanggan.DataSource = ds;
                    DataPelanggan.DataMember = "Pelanggan";
                    DataPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataPelanggan.AllowUserToAddRows = false;
                    DataPelanggan.Refresh();

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

        private void DataPelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataPelanggan.Rows[e.RowIndex];
                pelangganId = row.Cells["PelangganId"].Value.ToString();
                namaPelanggan = row.Cells["PelangganNama"].Value.ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string ambilId
        {
            get
            {
                return pelangganId;
            }
        }
        public string ambilNama
        {
            get
            {
                return namaPelanggan;
            }
        }

        public DialogPelanggan()
        {
            InitializeComponent();
            tampil();
        }
    }
}
