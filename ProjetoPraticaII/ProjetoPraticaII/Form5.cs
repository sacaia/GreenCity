﻿using System;
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
        int nivel = 0;
        int gif = 0;

        public frmTratamentoDeEsgoto()
        {
            InitializeComponent();
        }

        private void frmTratamentoDeEsgoto_Load(object sender, EventArgs e)
        {
            atualizarTela();
            btnJogar.Hide();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            pagAtual++;
            atualizarTela();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (pagAtual != 0)
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
                    btnAnt.Enabled = false;
                break;

                case 1:
                    lbTitulo.Text = "Introdução";
                    lbTexto.Height = 283;
                    lbTexto.Text = "    O tratamento de esgoto é dividido em:\n" +
                                                     "        + Tratamento primário\n" +
                                                     "          - Gradeamento\n" +
                                                     "          - Arenação\n" +
                                                     "          - Caixa de gordura\n" +
                                                     "\n" +
                                                     "        + Tratamento secundário\n" +
                                                     "          - Biodigestor\n" +
                                                     "          - Biofiltro\n" +
                                                     "\n" +
                                                     "        + Tratamento terciário";
                    pbImagem.BackgroundImage = null;
                    btnAnt.Enabled = true;
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
                                   "         A fase de Tratamento primário é focada na remoção de impurezas por meio de processos físicos " +
                                   "como, filtração e decantação. Ao final desta fase a água se encontra 30% tratada." +
                                   "";
                    pbImagem.BackgroundImage = Properties.Resources.aguaReciclavelPequena;
                break;

                case 6:
                    lbTitulo.Text = "+ Tratamento secundário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Biodigestor\n" +
                                   "         A faze do biodigestor consiste na utilização de micro-organismos anaeróbicos para fazer a quebra " +
                                   "das moleculas disolvidas na água, gerando gases, como metano e biogás, que podem ser queimados para gerar " +
                                   "energia elétrica.";
                    pbImagem.BackgroundImage = Properties.Resources.bacteriaAnaerobicaPequeno;
                break;

                case 7:
                    lbTitulo.Text = "+ Tratamento secundário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Biofiltro\n" +
                                   "         O biofiltro é a fase onde são retiradas as inpurezas restantes por meio de biodegradação. " +
                                   "São utilizadas plantas para absorverem as impurezas da água." +
                                   "";
                    pbImagem.BackgroundImage = Properties.Resources.biofiltroPequeno;
                break;

                case 8:
                    lbTitulo.Text = "+ Tratamento secundário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Conclusão\n" +
                                   "         A fase de Tratamento secundário é focada na remoção de impurezas que não foram retidas por meios " +
                                   "físicos, utilizando para isso processos biológicos, como o auxílio de bactérias biodigestoras e plantas. " +
                                   "Ao final desta fase a água se encontra 90% tratada.";
                    pbImagem.BackgroundImage = Properties.Resources.aguaReciclavelPequena;
                break;

                case 9:
                    lbTitulo.Text = "+ Tratamento terciário";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - Conclusão\n" +
                                   "         O tratamento terciário consiste em eliminar os micro organismos por meio de um tratamento químico " +
                                   "adicionando cloro ou utilizando luz ultravioleta. Depois da eliminação destes micro organismos restantes " +
                                   "a água se encontra totalmente tratada e pronta para ser reutilizada.";
                    pbImagem.BackgroundImage = Properties.Resources.tratamentoLuzUVPequena;
                    btnProx.Enabled = true;
                    btnJogar.Hide();
                break;

                case 10:
                    lbTitulo.Text = "Tratamento de esgoto";
                    lbTexto.Height = 143;
                    lbTexto.Text = "     - O jogo\n" +
                                   "         Para jogar é preciso passar por todas as fazes do tratamento de esgoto conforme você aprendeu." +
                                   "" +
                                   "";
                    pbImagem.BackgroundImage = Properties.Resources.aguaReciclavelPequena;
                    btnProx.Enabled = false;
                    btnJogar.Show();
                    break;

                default:
                    Console.WriteLine("Default case");
                break;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            pnIntroducao.Hide();
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (nivel)
            {
                case 0:
                    pbItem1.BackgroundImage = Properties.Resources.gradePequena;
                    pbItem2.BackgroundImage = Properties.Resources.redePequena;
                    pbItem3.BackgroundImage = Properties.Resources.candidaPequena;
                    switch (gif)
                    {
                        case 0:
                            pbMain.BackgroundImage = Properties.Resources.entradaEsgoto1_0;
                        break;

                        case 1:
                            pbMain.BackgroundImage = Properties.Resources.entradaEsgoto1_1;
                        break;

                        case 2:
                            pbMain.BackgroundImage = Properties.Resources.entradaEsgoto1_2;
                        break;
                    }
                    if (gif == 2)
                        gif = 0;
                    else
                        gif++;
                break;

                case 1:
                    pbItem1.BackgroundImage = Properties.Resources.candidaPequena;
                    pbItem2.BackgroundImage = Properties.Resources.bactéria;
                    pbItem3.BackgroundImage = Properties.Resources.ampulheta;
                    switch (gif)
                    {
                        case 0:
                            pbMain.BackgroundImage = Properties.Resources.arenacao1_0;
                            break;

                        case 1:
                            pbMain.BackgroundImage = Properties.Resources.arenacao1_1;
                            break;

                        case 2:
                            pbMain.BackgroundImage = Properties.Resources.arenacao1_2;
                            break;
                    }
                    if (gif == 2)
                        gif = 0;
                    else
                        gif++;
                break;

                case 2:
                    pbItem1.BackgroundImage = Properties.Resources.bactéria;
                    pbItem2.BackgroundImage = Properties.Resources.redePequena;
                    pbItem3.BackgroundImage = Properties.Resources.divisorias;
                    switch (gif)
                    {
                        case 0:
                            pbMain.BackgroundImage = Properties.Resources.caixaDeGordura1_0;
                            break;

                        case 1:
                            pbMain.BackgroundImage = Properties.Resources.caixaDeGordura1_1;
                            break;

                        case 2:
                            pbMain.BackgroundImage = Properties.Resources.caixaDeGordura1_2;
                            break;
                    }
                    if (gif == 2)
                        gif = 0;
                    else
                        gif++;
                 break;

                case 3:
                    pbItem1.BackgroundImage = Properties.Resources.planta;
                    pbItem2.BackgroundImage = Properties.Resources.bactéria;
                    pbItem3.BackgroundImage = Properties.Resources.candidaPequena;
                    switch (gif)
                    {
                        case 0:
                            pbMain.BackgroundImage = Properties.Resources.biodigestor1_0;
                            break;

                        case 1:
                            pbMain.BackgroundImage = Properties.Resources.biodigestor1_1;
                            break;

                        case 2:
                            pbMain.BackgroundImage = Properties.Resources.biodigestor1_2;
                            break;
                    }
                    if (gif == 2)
                        gif = 0;
                    else
                        gif++;
                break;

                case 4:
                    pbItem1.BackgroundImage = Properties.Resources.candidaPequena;
                    pbItem2.BackgroundImage = Properties.Resources.planta;
                    pbItem3.BackgroundImage = Properties.Resources.ampulheta;
                    switch (gif)
                    {
                        case 0:
                            pbMain.BackgroundImage = Properties.Resources.biofiltro1_0;
                            break;

                        case 1:
                            pbMain.BackgroundImage = Properties.Resources.biofiltro1_1;
                            break;

                        case 2:
                            pbMain.BackgroundImage = Properties.Resources.biofiltro1_2;
                            break;
                    }
                    if (gif == 2)
                        gif = 0;
                    else
                        gif++;
                 break;

                default:
                    Console.WriteLine("Default case");
                break;
            }
        }

        private void aux(int item)
        {
            switch(nivel)
            {
                case 0:
                    if (item == 1)
                    {
                        gif = 0;
                        pbMain.BackgroundImage = Properties.Resources.entradaEsgotoFinal;
                        MessageBox.Show("parabéns");
                        nivel++;
                    }            
                    else
                        MessageBox.Show("too bad");
                break;

                case 1:
                    if (item == 3)
                    {
                        gif = 0;
                        pbMain.BackgroundImage = Properties.Resources.arenacaoFinal;
                        MessageBox.Show("parabéns");
                        nivel++;
                    }
                    else
                        MessageBox.Show("too bad");
                break;

                case 2:
                    if (item == 3)
                    {

                        gif = 0;
                        pbMain.BackgroundImage = Properties.Resources.caixaDeGorduraFinal;
                        MessageBox.Show("parabéns");
                        nivel++;
                    }
                    else
                        MessageBox.Show("too bad");
                break;

                case 3:
                    if (item == 2)
                    {

                        gif = 0;
                        pbMain.BackgroundImage = Properties.Resources.biodigestorFinal;
                        MessageBox.Show("parabéns");
                        nivel++;
                    }
                    else
                        MessageBox.Show("too bad");
                break;

                case 4:
                    if (item == 2)
                    {

                        gif = 0;
                        pbMain.BackgroundImage = Properties.Resources.biofiltroFinal;
                        MessageBox.Show("parabéns");
                        nivel++;
                    }
                    else
                        MessageBox.Show("too bad");
                break;
            }
        }

        private void pbItem1_Click(object sender, EventArgs e)
        {
            aux(1);
        }

        private void pbItem2_Click(object sender, EventArgs e)
        {
            aux(2);
        }

        private void pbItem3_Click(object sender, EventArgs e)
        {
            aux(3);
        }

        private void pbItem1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbItem1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
