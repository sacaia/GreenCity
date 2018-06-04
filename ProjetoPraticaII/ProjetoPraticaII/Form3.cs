using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fazenda;

namespace ProjetoPraticaII
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuFazenda frmMenuFazenda = new frmMenuFazenda();
            frmMenuFazenda.FormClosed += (s, arg) => this.Show();
            frmMenuFazenda.Show();
            this.Hide();
        }

      
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnEsgoto_Click(object sender, EventArgs e)
        {
            frmTratamentoDeEsgoto frmEsgoto = new frmTratamentoDeEsgoto();
            frmEsgoto.FormClosed += (s, arg) => this.Show();
            frmEsgoto.Show();
            this.Hide();
        }
    }
}
