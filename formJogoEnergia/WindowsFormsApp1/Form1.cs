using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Dynamic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int level = 0;
        int pontuacao = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           int contador  = 0;
            contador++;
            Random rnd = new Random();
            
            Class1 pb = new Class1();

            pb.count = contador;
            pb.BackColor = Color.Blue;

            Controls.Add(pb.count);
            int x = rnd.Next(0, 300);
            int y = rnd.Next(0, 300);
            pb.Location = new Point(x, y);
            pb.Top -= 10;


            pb.Visible = true;

        pb.Size = new Size(50, 50);
        }

   

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.A))
            {
                if (!(pb_jogador.Left < 10))
                {
                    pb_jogador.Left -= 10;
                }
          
                

            }
            if ((e.KeyCode == Keys.Right) || (e.KeyCode == Keys.D))
            {
                if (!(pb_jogador.Left > 780))
                {
                    pb_jogador.Left += 10;
                }

            }
        }

        private void Gravidade_Tick(object sender, EventArgs e)
        {
            int velocidade;
            if (level > 30)
            Gravidade.Interval -= level;
            else
                velocidade = level  + 5;
            pontuacao += level;

        }

        private void Level_Tick(object sender, EventArgs e)
        {
          
        level++;
            lb_level.Text= "Nivel: " + level;
        }
    }
}
