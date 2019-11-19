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
    public partial class frmEnergia : Form
    {
        public frmEnergia()
        {
            InitializeComponent();
        }

        private void frmEnergia_Load(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic.Location = new System.Drawing.Point(100, 100);
            pic.Size = new System.Drawing.Size(140, 89);
            pic.Image = Properties.Resources.ampulheta;
        }

    }
}
