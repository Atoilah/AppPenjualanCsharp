using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AppPenjualan.Kelas;

namespace AppPenjualan.GUI
{
    public partial class FromBarang : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Kelas.Koneksi kon = new Kelas.Koneksi();

        void Default ()
        {
            SqlConnection conn = kon.getConn();
            {
                try
                {
                    conn.Open ();
                    cmd = new SqlCommand("Select * From Barang", conn);
                    ds = new DataSet();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "Barang");
                    DataBarang.DataSource = ds;
                    DataBarang.DataMember = "Barang";
                    DataBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    DataBarang.AllowUserToAddRows = false;
                    DataBarang.Refresh();

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }finally
                { 
                    conn.Close();
                }
            }
            Cari.Select();
            Kode.Text = "";
            Nama.Text = "";
            Harga.Text = "0";
            Stok.Text = "0";
            Satuan.Text = "-Pilih Satuan-";

            Kode.Enabled= false;
            Nama.Enabled= false;
            Harga.Enabled= false;
            Stok.Enabled= false;
            Satuan.Enabled= false;

            Baru.Enabled = true;
            Simpan.Enabled= false;
            Hapus.Enabled= false;
            Ubah.Enabled= false;
        }
        void Auto()
        {
            long hitung;
            string urut;
            SqlDataReader rd;
            SqlConnection con = kon.getConn();

            con.Open();

            cmd = new SqlCommand("SELECT KodeBarang FROM Barang WHERE KodeBarang in (SELECT MAX (KodeBarang) FROM Barang ) ORDER BY KodeBarang DESC",con);

            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length -3, 3)) + 1;
                string join = "000"+ hitung;
                urut = "B" + join.Substring(join.Length-3, 3);
            }else
            {
                urut= "B001";
            }
            rd.Close();
            Kode.Text = urut;
            con.Close();
        }
        void search()
        {
            SqlConnection conn = kon.getConn();
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Select * From Barang where KodeBarang LIKE '%"+Cari.Text+"%' OR NamaBarang LIKE '%"+Cari.Text+"%'", conn);
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
        public FromBarang()
        {
            InitializeComponent();
            Default();
        }

        private void Baru_Click(object sender, EventArgs e)
        {
            Nama.Select();
            Auto();

            Nama.Text = "";
            Harga.Text = "0";
            Stok.Text = "0";
            Satuan.Text = "-Pilih Satuan-";

            Kode.Enabled = false;
            Nama.Enabled = true;
            Harga.Enabled = true;
            Stok.Enabled = true;
            Satuan.Enabled = true;

            Baru.Enabled = true;
            Simpan.Enabled = true;
            Hapus.Enabled = false;
            Ubah.Enabled = false;
        }

        private void Cari_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        void Simpan_Click(object sender, EventArgs e)
        {
            if (Kode.Text.Trim() == "" || Nama.Text.Trim() == "" || Harga.Text.Trim() == "" || Stok.Text.Trim() == "" || Satuan.Text.Trim() == "-Pilih Satuan-")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                SqlConnection con = kon.getConn();
                try
                {
                    cmd = new SqlCommand("Insert Into Barang Values('"+Kode.Text+"', '"+Nama.Text+"', '"+Harga.Text+"', '"+Stok.Text+"', '"+Satuan.Text+"')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Default();
                }catch(Exception ex) 
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void DataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Nama.Select();
                Kode.Enabled = false;
                Nama.Enabled = true;
                Harga.Enabled = true;
                Stok.Enabled = true;
                Satuan.Enabled = true;

                Baru.Enabled = true;
                Simpan.Enabled = false;
                Hapus.Enabled = true;
                Ubah.Enabled = true;

                DataGridViewRow row = this.DataBarang.Rows[e.RowIndex];
                Kode.Text = row.Cells["KodeBarang"].Value.ToString();
                Nama.Text = row.Cells["NamaBarang"].Value.ToString();
                Harga.Text = row.Cells["Harga"].Value.ToString();
                Stok.Text = row.Cells["Stok"].Value.ToString();
                Satuan.Text = row.Cells["Satuan"].Value.ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            if (Kode.Text.Trim() == "" || Nama.Text.Trim() == "" || Harga.Text.Trim() == "" || Stok.Text.Trim() == "" || Satuan.Text.Trim() == "-Pilih Satuan-")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection con = kon.getConn();
                try
                {
                    cmd = new SqlCommand("Update Barang set NamaBarang = '"+Nama.Text+"', Harga = '"+Harga.Text+"', Stok = '"+Stok.Text+"', Satuan = '"+Satuan.Text+"' Where KodeBarang = '"+Kode.Text+"'", con);
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

        private void Hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin Ingin Menghapus Data = " + Nama.Text + "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection con = kon.getConn();
                try
                {
                    cmd = new SqlCommand("Delete Barang Where KodeBarang = '" + Kode.Text + "'", con);
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

        private void Harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void Stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
