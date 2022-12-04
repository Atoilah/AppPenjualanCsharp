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
    public partial class FormTransaksi : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi kon = new Kelas.Koneksi();
        void Default()
        {
            SqlConnection conn = kon.getConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Select * From vw_penjualan ", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "vw_penjualan");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "vw_penjualan";
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.AllowUserToAddRows = false;
                    dataGridView1.Refresh();

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

        void auto()
        {

        }

        public FormTransaksi()
        {
            Default();
            InitializeComponent();
        }

        private void CariPelanggan_Click(object sender, EventArgs e)
        {
            DialogPelanggan plgn = new DialogPelanggan();
            plgn.ShowDialog();
            PelangganId.Text = plgn.ambilId;
            PelangganNama.Text = plgn.ambilNama;
        }

        private void CariBarang_Click(object sender, EventArgs e)
        {
            DialogBarang brg = new DialogBarang();
            brg.ShowDialog();
            KodeBarang.Text = brg.ambilKode;
            NamaBarang.Text = brg.ambilNama;
            HargaBarang.Text = brg.ambilHarga;
        }
    }
}
