using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPraticaII;

namespace fazenda
{
    public partial class frmMenuFazenda : Form
    {
        public frmMenuFazenda()
        {
            InitializeComponent();
        }

        private void pb_MouseEnter(PictureBox imagem)
        {
            imagem.Size = new Size(((pb_celeiro.Size.Width) + (pb_celeiro.Size.Width / 10)), ((pb_celeiro.Size.Height) + (pb_celeiro.Size.Height / 10)));


        }

        private void pb_MouseLeave(PictureBox imagem)
        {
            imagem.Size = new Size(((pb_celeiro.Size.Width * 10) / 11), ((pb_celeiro.Size.Height * 10) / 11));
        }



        private void pb_celeiro_MouseEnter(object sender, EventArgs e, PictureBox imagem)
        {
            imagem.Size = new Size(((pb_celeiro.Size.Width) + (pb_celeiro.Size.Width / 10)), ((pb_celeiro.Size.Height) + (pb_celeiro.Size.Height / 10)));
        }

        private Point ultimoPonto;
        private void pb_celeiro_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            int altura = pb.Top;
            pb.Size = new Size(((pb.Size.Width) + (pb.Size.Width / 10)), ((pb.Size.Height) + (pb.Size.Height / 10)));
            ultimoPonto = pb.Location;
            pb.Location = new Point(pb.Location.X - (pb.Size.Width / 10) / 2, pb.Location.Y - (pb.Size.Height / 10) / 2);
            this.Cursor = Cursors.Hand;
            pb.Refresh();

        }


        private void pb_celeiro_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            this.Cursor = Cursors.Default;
            pb.Size = new Size(((pb.Size.Width * 10) / 11), ((pb.Size.Height * 10) / 11));
            pb.Location = ultimoPonto;
            pb.Refresh();
        }

        private void pb_celeiro_Click(object sender, EventArgs e)
        {
           

        }

        private void pb_silo_Click(object sender, EventArgs e)
        {
            Silo frmSilo = new Silo();
            frmSilo.FormClosed += (s, arg) => this.Show();
            frmSilo.Show();
            this.Hide();
        }

        private void frmMenuFazenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmPlantacaoSementes frmPlantacao = new frmPlantacaoSementes();
            frmPlantacao.FormClosed += (s, arg) => this.Show();
            frmPlantacao.Show();
            this.Hide();

        }
    }
}
