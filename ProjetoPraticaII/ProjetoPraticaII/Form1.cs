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

namespace ProjetoPraticaII
{
    public partial class frmLogin : Form
    {
        string cs = Properties.Settings.Default.BDPRII17189ConnectionString; // String de conexao
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
            // Se algum campo estiver vazio, o usuario sera advertido
            if (txbNome.Text == "" || txbSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;

                // verifica os parametros passados pelo usuario no formulario
                string cmd_s = "select * from usuario where nome=@nome and senha=@senha)";
                SqlCommand cmd = new SqlCommand(cmd_s, con);

                // @nome = nome escolhido pelo usuario
                cmd.Parameters.AddWithValue("@nome", txbNome.Text);

                // @senha = senha escolhida pelo usuario
                cmd.Parameters.AddWithValue("@senha", txbSenha.Text);

                con.Open();

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adapt.Fill(ds);
                con.Close();

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // existe o usuario com essa senha
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Limpa a tela
            txbNome.Text = "";
            txbSenha.Text = "";
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
