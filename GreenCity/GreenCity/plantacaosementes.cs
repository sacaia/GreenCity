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

namespace fazenda
{

    public partial class frmPlantacaoSementes : Form
    {
        string cs =  ProjetoPraticaII.Properties.Settings.Default.BDPRII17189ConnectionString; // String de conexao
        frmMenuFazenda frmMenu1;
        int tempo = 0;
        int idade = 0;

        String plantaescolhida = "";
        bool sementeplantada = false;
        int crescendo = 0;
        int agua = 0;
        bool colheita = false;
        int[] qtdsementes = new int[5];

        public frmPlantacaoSementes()
        {
            InitializeComponent();
        }


        public String PegaSementes1()
        {
            return qtdsementes[0].ToString();
        }

        public String PegaSementes2()
        {
            return qtdsementes[1].ToString();
        }

        public String PegaSementes3()
        {
            return qtdsementes[2].ToString();
        }
        public String PegaSementes4()
        {
            return qtdsementes[3].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            for (int i = 0; i < qtdsementes.Length; i++)
            {
                qtdsementes[i] = 0;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

            pictureBox1.DoDragDrop("agua",
                DragDropEffects.Copy |
                DragDropEffects.Move);
        }

        public frmPlantacaoSementes(frmMenuFazenda frmMenu) : this()
        {
            frmMenu1 = frmMenu;
        }





        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Copy;

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

            plantacao(pictureBox1, e);

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop("inseticida",
                            DragDropEffects.Copy |
                            DragDropEffects.Move);
        }



        private void plantacao(PictureBox picBox, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.Text).ToString() == "agua")
            {
                agua++;
            }
            if ((idade == 0) && !(plantaescolhida == ""))
            {
                sementeplantada = true;
            }


            if ((e.Data.GetData(DataFormats.Text).ToString() == "agua") && (idade < 2) && (sementeplantada == true))
            {
                picBox.BackgroundImage = planta.Images[1];
                idade++;



            }



            if ((idade == 3) && (e.Data.GetData(DataFormats.Text).ToString() == "adubo"))
            {
                idade = 4;
                pictureBox1.BackgroundImage = planta.Images[3];

                colheita = true;
            }
        }

        private void btn_mudarsemente_Click(object sender, EventArgs e)
        {
            Form2 semente = new Form2(this);
            semente.FormClosed += (s, arg) => this.Show();
            semente.Show();
            this.Hide();
        }

        public void escolhaSemente(String semente)
        {
            this.plantaescolhida = semente;
            lb_sementeescolhida.Text = "Semente Escolhida: " + semente;


        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            hint_plantacao.SetToolTip(pictureBox1, plantaescolhida);

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if ((plantaescolhida != "") && (idade == 0))
            {
                pictureBox1.DoDragDrop(plantaescolhida,
                              DragDropEffects.Copy |
                              DragDropEffects.Move);
                idade++;
            }
            else
            {
                if (idade == 0)
                    MessageBox.Show("Escolha uma semente");

            }
        }

        private void plantacresce_Tick(object sender, EventArgs e)
        {
            if ((idade == 2) && (crescendo >= 10) && (agua >= 3))
            {
                pb_1.Value = 0;
                idade = 3;
                pictureBox1.BackgroundImage = planta.Images[2];
            }
            else
                if ((idade == 2) && (crescendo < 10))
            {
                pb_1.PerformStep();
                crescendo++;
                hint_plantacao.SetToolTip(pb_1, "A planta está crescendo!");
            }
            else
            if ((idade == 2) && (pb_1.Value >= 100))
            {
                hint_plantacao.SetToolTip(pb_1, "A planta precisa de adubo e ou água");


            }



        }

        private void pb_adubo_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop("adubo",
                        DragDropEffects.Copy |
                        DragDropEffects.Move);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //0=capim
            //1=cafe
            //2=milho
            //3=trigo
            MessageBox.Show("Você colheu : " + (hint_plantacao.GetToolTip(pictureBox1)));
            if (colheita == true)
            {
                colheita = false;
                idade = 0;
                pictureBox1.BackgroundImage = planta.Images[0];

                if ((hint_plantacao.GetToolTip(pictureBox1) == "capim"))
                {

                    qtdsementes[0] += 10;

                }
                else
                if ((hint_plantacao.GetToolTip(pictureBox1) == "cafe"))
                {

                    qtdsementes[1] += 10;

                }
                else
                    if ((hint_plantacao.GetToolTip(pictureBox1) == "milho"))
                {

                    qtdsementes[2] += 10;

                }
                else
                    if ((hint_plantacao.GetToolTip(pictureBox1) == "trigo"))
                {

                    qtdsementes[3] += 10;

                }

            }
        }

      

      

        private void pb_botaomenu_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pb_botaomenu_Click(object sender, EventArgs e)
        {
            if (pb_botaomenu.Location.X < 100)
            {
                pb_botaomenu.Visible = false;
                for (int i = 0; i < 50; i++)
                {
                    System.Threading.Thread.Sleep(1);
                    panelMenu.Refresh();
                    Size tamanho = new Size(i * 4, 592);
                    panelMenu.Size = tamanho;
                }
                pb_botaomenu.Location = new Point(180, 200);
                pb_botaomenu.Visible = true;
                pb_botaomenu.Image = ProjetoPraticaII.Properties.Resources.fazenda_SetaMenuEsquerda;
            }
            else
            {
                Size tamanho = new Size(1, 592);
                panelMenu.Size = tamanho;
                pb_botaomenu.Location = new Point(1, 200);
                pb_botaomenu.Image = ProjetoPraticaII.Properties.Resources.fazenda_SetaMenuDireita;
            }

        }

        private void pb_botaomenu_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (colheita == true)
            {
                this.Cursor = Cursors.Hand;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
        int paginaAtual = 1;
        private void brn_explicacaoProximo_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            if (paginaAtual == 2)
            {
                btn_explicacoVoltar.Enabled = true;
                lb_explicacao.Text = "De maneira geral, os pesticidas são tóxicos, independentemente de qual composto é usado, sendo uns menos, e outros mais danosos à saúde humana e ao meio ambiente. Um dos problemas mais comuns é a contaminação do solo, de lençóis freáticos e de rios e lagos. Quando o agrotóxico é utilizado, ele chega ao solo e a chuva, ou o próprio sistema de irrigação da plantação, facilita a chegada dos pesticidas aos corpos de água, poluindo-os e intoxicando toda vida lá presente. Um bom exemplo de como esse tipo de produto tóxico funciona pode ser observado em inseticidas, como os organocloradose organofosforados. Ambos sãobioacumulativos, o que significa que o composto permanece no corpo do inseto ou de um peixe após sua morte.Se algum outro animal se alimentar de um ser contaminado, também ficará intoxicado, e assim sucessivamente, aumentando o alcance do problema. O uso de pesticidas, inclusive, contribui com o empobrecimento do solo.Estudosmostram que a utilização de pesticidas reduz a eficiência da fixação de nitrogênio realizada por micro - organismos, o que faz com que o uso defertilizantes seja cada vez mais necessário.";
                pb_explicacao.Image = ProjetoPraticaII.Properties.Resources.comidaInseticida;
                pb_explicacao2.Image = ProjetoPraticaII.Properties.Resources.plantacaoInseticida;
                lb_explicacaoTitulo.Text = "Problemas com o uso de inseticidas";
                btn_explicacaoJogar.Enabled = true;
            }
        }

        private void btn_explicacaoJogar_Click(object sender, EventArgs e)
        {
            panel_explicacao.Hide();
            hint_plantacao.SetToolTip(pictureBox3, "Esta terra está bloqueada ,para desbloquear ,compre no mercado");
            hint_plantacao.SetToolTip(pictureBox5, "Esta terra está bloqueada ,para desbloquear ,compre no mercado");
            hint_plantacao.SetToolTip(pictureBox6, "Esta terra está bloqueada ,para desbloquear ,compre no mercado");

        }

        private void btn_historia_Click(object sender, EventArgs e)
        {
            lb_explicacao.Text = "De maneira geral, o uso de fertilizantes inorgânicos acarreta problemas para o meio ambiente, dentre eles a contaminação de lençóis freáticos, rios e lagos. Muitos fertilizantes inorgânicos levam poluentes orgânicos persistentes , que contaminam os animais e plantas que vivem na água. Outros animais ou o próprio ser humano podem se contaminar ao beber a água ou comer animais intoxicados      A contaminação da água também pode levar à sua eutrofização. Esse é um processo em que, segundo estudos, os compostos, ao chegarem à rios, lagos e zonas costeiras favorecem o crescimento e o aumento de número de algas, que por sua vez levam à morte diversos organismos. Alguns ambientalistas afirmam que esse processo gera 'zonas mortas' nos ambientes aquáticos, sem qualquer tipo de vida além das algas.";
            pb_explicacao.Image = ProjetoPraticaII.Properties.Resources.aduboQuimico;
            pb_explicacao2.Image = ProjetoPraticaII.Properties.Resources.baciaHidrografica;
            paginaAtual = 1;
            btn_explicacoVoltar.Enabled = false;
            btn_explicacaoJogar.Enabled = false;
            panel_explicacao.Show();
        }

        private void btn_explicacoVoltar_Click(object sender, EventArgs e)
        {
            if (paginaAtual == 2)
            {
                paginaAtual--;
                lb_explicacao.Text = "De maneira geral, o uso de fertilizantes inorgânicos acarreta problemas para o meio ambiente, dentre eles a contaminação de lençóis freáticos, rios e lagos. Muitos fertilizantes inorgânicos levam poluentes orgânicos persistentes , que contaminam os animais e plantas que vivem na água. Outros animais ou o próprio ser humano podem se contaminar ao beber a água ou comer animais intoxicados      A contaminação da água também pode levar à sua eutrofização. Esse é um processo em que, segundo estudos, os compostos, ao chegarem à rios, lagos e zonas costeiras favorecem o crescimento e o aumento de número de algas, que por sua vez levam à morte diversos organismos. Alguns ambientalistas afirmam que esse processo gera 'zonas mortas' nos ambientes aquáticos, sem qualquer tipo de vida além das algas.";
                pb_explicacao.Image = ProjetoPraticaII.Properties.Resources.aduboQuimico;
                pb_explicacao2.Image = ProjetoPraticaII.Properties.Resources.baciaHidrografica;
                paginaAtual = 1;
                btn_explicacoVoltar.Enabled = false;
                btn_explicacaoJogar.Enabled = false;
            }
        }
    }
}
