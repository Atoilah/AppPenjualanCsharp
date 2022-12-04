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
    public partial class FornPelanggan : Form
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
            Cari.Select();
            Id.Text = "";
            Nama.Text = "";
            Alamat.Text = "";
            Telp.Text = "0";

            Id.Enabled = false;
            Nama.Enabled = false;
            Alamat.Enabled = false;
            Telp.Enabled = false;

            Baru.Enabled = true;
            Simpan.Enabled = false;
            Hapus.Enabled = false;
            Ubah.Enabled = false;
        }
        void Auto()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection con = kon.getConn();

            con.Open();

            cmd = new SqlCommand("SELECT PelangganId FROM Pelanggan WHERE PelangganId in (SELECT MAX (PelangganId) FROM Pelanggan ) ORDER BY PelangganId DESC", con);

            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["PelangganId"].ToString().Length - 3, 3)) + 1;
                string join = "000" + hitung;
                urut = "P" + join.Substring(join.Length - 3, 3);
            }
            else
            {
                urut = "P001";
            }
            rd.Close();
            Id.Text = urut;
            con.Close();
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

        public FornPelanggan()
        {
            InitializeComponent();
            Default();
        }
        private void Baru_Click(object sender, EventArgs e)
        {
            Auto();

            Nama.Text = "";
            Alamat.Text = "";
            Telp.Text = "0";

            Id.Enabled = false;
            Nama.Enabled = true;
            Alamat.Enabled = true;
            Telp.Enabled = true;

            Baru.Enabled = true;
            Simpan.Enabled = true;
            Hapus.Enabled = false;
            Ubah.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if (Id.Text.Trim() == "" || Nama.Text.Trim() == "" || Alamat.Text.Trim() == "" || Telp.Text.Trim() == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection con = kon.getConn();
                try
                {
                    cmd = new SqlCommand("Insert Into Pelanggan Values('" + Id.Text + "', '" + Nama.Text + "', '" + Alamat.Text + "', '" + Telp.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Default();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Telp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Cari_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void DataPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Nama.Select();
                Id.Enabled = false;
                Nama.Enabled = true;
                Alamat.Enabled = true;
                Telp.Enabled = true;

                Baru.Enabled = true;
                Simpan.Enabled = false;
                Hapus.Enabled = true;
                Ubah.Enabled = true;

                DataGridViewRow row = this.DataPelanggan.Rows[e.RowIndex];
                Id.Text = row.Cells["PelangganId"].Value.ToString();
                Nama.Text = row.Cells["PelangganNama"].Value.ToString();
                Alamat.Text = row.Cells["Alamat"].Value.ToString();
                Telp.Text = row.Cells["NoTelp"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data = " + Nama.Text + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = kon.getConn();
                try
                {
                    cmd = new SqlCommand("Delete Pelanggan Where PelangganId = '" + Id.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil DiHapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Default();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
            }
        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            if (Id.Text.Trim() == "" || Nama.Text.Trim() == "" || Alamat.Text.Trim() == "" || Telp.Text.Trim() == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection con = kon.getConn();
                try
                {
                    cmd = new SqlCommand("Update Pelanggan set PelangganNama = '" + Nama.Text + "', Alamat = '" + Alamat.Text + "', NoTelp = '" + Telp.Text + "' Where KodeBarang = '" + Id.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil DiUbah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Default();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
