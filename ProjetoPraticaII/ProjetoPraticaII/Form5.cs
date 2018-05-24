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
    public partial class frmTratamentoDeEsgoto : Form
    {
        int pagAtual = 0;

        public frmTratamentoDeEsgoto()
        {
            InitializeComponent();
        }

        private void frmTratamentoDeEsgoto_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "Bem vindo a introdução";
            lbTexto.Text = "    Esta é a introdução ao tema do tratamento de esgoto, clique no botão para continuar a explicação";
            pbImagem.BackgroundImage = Properties.Resources.Mapa;
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            pagAtual++;
            atualizarTela();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            pagAtual--;
            atualizarTela();
        }

        private void atualizarTela()
        {
            switch(pagAtual)
            {
                case 0:
                    lbTitulo.Text = "Bem vindo a introdução";
                    lbTexto.Text = "    Esta é a introdução ao tema do tratamento de esgoto, clique no botão para continuar a explicação";
                    pbImagem.BackgroundImage = Properties.Resources.Mapa;
                break;

                case 1:
                    lbTitulo.Text = "Teste";
                    lbTexto.Text = "    Esta é a introdução ao tema do tratamento de esgoto, clique no botão para continuar a explicação";
                    pbImagem.BackgroundImage = Properties.Resources.Mapa;
                    break;

                case 2:
                    Console.WriteLine("Case 2");
                break;

                default:
                    Console.WriteLine("Default case");
                break;
            }
        }
    }
}
