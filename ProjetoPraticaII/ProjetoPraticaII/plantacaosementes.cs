using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fazenda
{
    
    public partial class plantacaosementes : Form
    {
        frmMenuFazenda frmMenu1;
        int tempo = 0;
        int idade = 0;
        bool bicho = false;
        String  plantaescolhida="";
        bool sementeplantada = false;
        int crescendo = 0;
        int agua = 0;
        bool colheita=false;
        int[] qtdsementes = new int[5];

        public plantacaosementes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            for (int i = 0; i< qtdsementes.Length; i++)
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

        public plantacaosementes(frmMenuFazenda frmMenu) : this()
        {
            frmMenu1 = frmMenu;
        }





        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
           
                e.Effect = DragDropEffects.Copy;
           
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

            plantacao(pictureBox1,e);

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop("inseticida",
                            DragDropEffects.Copy |
                            DragDropEffects.Move);
        }

        private void bichotimer_Tick(object sender, EventArgs e)
        {
            if ((idade==2)&&(tempo > 10))
            {
                bicho = true;
                pictureBox1.BackgroundImage = planta.Images[4];
                tempo = 0;
                
            }
            if (idade == 2){
                tempo++;
            }
            
        }

        private void plantacao(PictureBox picBox, DragEventArgs e)
        {
            if(e.Data.GetData(DataFormats.Text).ToString() == "agua")
            {
                agua++;
            }
            if ((idade == 0)&&!(plantaescolhida==""))
            {
                sementeplantada = true;
            }


            if ((e.Data.GetData(DataFormats.Text).ToString() == "agua") && (idade < 2)&&(sementeplantada==true))
            {
               picBox.BackgroundImage = planta.Images[1];
                idade++;



            }
            if ((e.Data.GetData(DataFormats.Text).ToString() == "inseticida") && (idade == 2)&&(bicho==true))
            {
                picBox.BackgroundImage = planta.Images[1];
                
                bicho = false;


            }
            else
            {
                if (e.Data.GetData(DataFormats.Text).ToString() == "inseticida")
                    tempo = 0;
            }

            if((idade==3)&& (e.Data.GetData(DataFormats.Text).ToString() == "adubo"))
            {
                idade = 4;
                pictureBox1.BackgroundImage = planta.Images[3];
                colheita = true;
            }
        }

        private void btn_mudarsemente_Click(object sender, EventArgs e)
        {
            Form2 semente = new Form2(this);
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
            if ((plantaescolhida != "")&&(idade==0))
            {
                pictureBox1.DoDragDrop(plantaescolhida,
                              DragDropEffects.Copy |
                              DragDropEffects.Move);
                idade++;
            }
            else
            {
             
                MessageBox.Show("Escolha uma semente");
            }
        }

        private void plantacresce_Tick(object sender, EventArgs e)
        {
            if ((idade == 2)&&(crescendo>=10)&&(agua>=3))
            {
                idade = 3;
                pictureBox1.BackgroundImage = planta.Images[2];
            }else
                if (idade == 2)
            {
                crescendo++;
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
            MessageBox.Show(hint_plantacao.GetToolTip(pictureBox1));
            if (colheita == true)
            {
                colheita = false;
                idade = 0;
                pictureBox1.BackgroundImage = planta.Images[0];

                if ((hint_plantacao.GetToolTip(pictureBox1) == "capim"))
                {

                    qtdsementes[0]+=10;

                }else
                if ((hint_plantacao.GetToolTip(pictureBox1) == "cafe"))
                {

                    qtdsementes[1]+=10;

                }
                else
                    if ((hint_plantacao.GetToolTip(pictureBox1) == "milho"))
                {

                    qtdsementes[2]+=10;

                }
                else
                    if ((hint_plantacao.GetToolTip(pictureBox1) == "trigo"))
                {

                    qtdsementes[3] += 10;

                }

            }
        }

        private void btn_silo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuFazenda frmMenuFazenda1 = new frmMenuFazenda();
            frmMenuFazenda1.Show();

        }
    }
}
