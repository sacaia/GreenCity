using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
