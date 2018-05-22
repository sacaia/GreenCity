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

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuFazenda frmMenuFazenda = new frmMenuFazenda();
            frmMenuFazenda.Show();
            this.Hide();
        }

      

        private void frmPrincipal_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
