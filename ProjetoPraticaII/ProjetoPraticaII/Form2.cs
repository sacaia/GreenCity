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
    public partial class frmCadastro : Form
    {
        string cs = Properties.Settings.Default.BDPRII17189ConnectionString; // String de conexao
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void llbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frmL = new frmLogin();
            frmL.Show();
            this.Hide();
            //frmLogin frmL = new frmLogin();
            //this.Hide();
            //frmL.FormClosed += (s, arg) => this.Show(); N precisa
            //frmL.Show();
        }

        private void frmCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            // Se algum campo estiver vazio, o usuario sera advertido
            if ((txbNome.Text == "" || txbSenha.Text == "" || txbConfirmarSenha.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            // Se as senhas nao corresponderem, o usuario sera advertido
            if (!(txbSenha.Text == txbConfirmarSenha.Text))
            {
                MessageBox.Show("Senhas diferrentes!");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection();
                cs = cs.Substring(cs.IndexOf("Data Source"));
                con.ConnectionString = cs;

                // Insere os valores passados pelo usuario no formulario
                string cmd_s = "insert into alunoSergio values(@nome, @senha, 0)";
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

                // Se chegar ate aqui sem nenhum problema, da um feedback pro usuario
                MessageBox.Show("Registrado com susseso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Limpa a tela para a possivel insercao de outro registro
            txbNome.Text = "";
            txbSenha.Text = "";
            txbConfirmarSenha.Text = "";
        }
    }
}
