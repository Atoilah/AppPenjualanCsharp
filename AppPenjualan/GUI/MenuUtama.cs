using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPenjualan.GUI
{
    public partial class MenuUtama : Form
    {
        FromBarang brg;
        FornPelanggan plgn;
        FormTransaksi trx;

        void brg_tutup(Object sender, FormClosedEventArgs e)
        {
            brg = null;
        }
        void plgn_tutup(Object sender, FormClosedEventArgs e)
        {
            plgn = null;
        }
        void trx_tutup(Object sender, FormClosedEventArgs e)
        {
            trx = null;
        }

        public MenuUtama()
        {
            InitializeComponent();
        }

        private void Barang_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FromBarang();
                brg.MdiParent = this;

                brg.FormClosed += new FormClosedEventHandler(brg_tutup);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void Pelanggan_Click(object sender, EventArgs e)
        {
            if (plgn == null)
            {
                plgn = new FornPelanggan();
                plgn.MdiParent = this;

                plgn.FormClosed += new FormClosedEventHandler(plgn_tutup);
                plgn.Show();
            }
            else
            {
                plgn.Activate();
            }
        }

        private void Penjualan_Click(object sender, EventArgs e)
        {
            if (trx == null)
            {
                trx = new FormTransaksi();
                trx.MdiParent = this;

                trx.FormClosed += new FormClosedEventHandler(plgn_tutup);
                trx.Show();
            }
            else
            {
                trx.Activate();
            }
        }
    }
}
