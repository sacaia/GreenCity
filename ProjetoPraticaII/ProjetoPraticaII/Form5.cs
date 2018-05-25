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
            atualizarTela();
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
                    lbTexto.Height = 143;
                    lbTexto.Text = "    Esta é a introdução ao tema do tratamento de esgoto, clique no botão para continuar a explicação";
                    pbImagem.BackgroundImage = Properties.Resources.aguaReciclavelPequena;
                break;

                case 1:
                    lbTitulo.Text = "Introdução";
                    lbTexto.Height = 283;
                    lbTexto.Text = "    O tratamento de esgoto é dividido em:\n" +
                                                     "        + Tratamento primário\n" +
                                                     "          - Gradeamento\n" +
                                                     "          - Arenção\n" +
                                                     "          - Caixa de gordura\n" +
                                                     "\n" +
                                                     "        + Tratamento secundário\n" +
                                                     "          - Biodigestor\n" +
                                                     "          - Biofiltro\n" +
                                                     "\n" +
                                                     "        + Tratamento terciário";
                    pbImagem.BackgroundImage = null;
                break;

                case 2:
                    lbTitulo.Text = "+ Tratamento primário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Gradeamento\n" + 
                                   "         A fase do gradeamento consiste em retirar as particulas grandes da água como: folhas, animais mortos, " +
                                   "galhos de arvores, pedras entre outros. Essas particulas são retiradas por meio de grades, dai o nome " +
                                   "'Gradeamento'.";
                    pbImagem.BackgroundImage = Properties.Resources.caixaGradeadaPequena;
                break;

                case 3:
                    lbTitulo.Text = "+ Tratamento primário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Arenação\n" +
                                   "         Após o filtramento da água ela é levada para um container onde é deixada para descansar(decantação) " +
                                   "separando assim a fase sólida da fase liquida, o lodo da agua." +
                                   "";
                    pbImagem.BackgroundImage = Properties.Resources.decantaçãoPequeno;
                break;

                case 4:
                    lbTitulo.Text = "+ Tratamento primário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Caixa de gordura\n" +
                                   "         Com a água agora já sem o lodo, só é nescessário retirar a gordura presente na água " +
                                   "para que isso seja possivel é utilizada uma caixa de gordura. A gordura sendo menos densa que a água " +
                                   "fica retida na parte superior da caixa deixando que apenas a água passe.";
                    pbImagem.BackgroundImage = Properties.Resources.caixaDeGorduraPequena;
                break;

                case 5:
                    lbTitulo.Text = "+ Tratamento primário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Conclusão\n" +
                                   "         A fase de Tratamento primário é focada na remoção de impurezas por meio de processos químicos " +
                                   "como, filtração e decantação. Ao final desta fase a água se encontra 30% tratada." +
                                   "";
                    pbImagem.BackgroundImage = Properties.Resources.aguaReciclavelPequena;
                break;

                case 6:
                    lbTitulo.Text = "+ Tratamento secundário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Biodigestor\n" +
                                   "         A fase de Tratamento primário é focada na remoção de impurezas por meio de processos químicos " +
                                   "como, filtração e decantação. Ao final desta fase a água se encontra 30% tratada." +
                                   "";
                    pbImagem.BackgroundImage = Properties.Resources.aguaReciclavelPequena;
                break;

                default:
                    Console.WriteLine("Default case");
                break;
            }
        }
    }
}
