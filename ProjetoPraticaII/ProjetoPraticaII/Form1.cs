using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPraticaII
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void llbCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro frmC = new frmCadastro();
            this.Hide();
            //frmC.FormClosed += (s, arg) => this.Show();
            frmC.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
