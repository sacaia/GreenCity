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
    public partial class MenuFazenda : Form
    {
        public MenuFazenda()
        {
            InitializeComponent();
        }

        private void pb_celeiro_MouseEnter(object sender, EventArgs e)
        {
            pb_celeiro.Size = new Size( ((pb_celeiro.Size.Width) + (pb_celeiro.Size.Width / 10)),((pb_celeiro.Size.Height) + (pb_celeiro.Size.Height / 10)));


        }

        private void pb_celeiro_MouseLeave(object sender, EventArgs e)
        {
            pb_celeiro.Size = new Size( ((pb_celeiro.Size.Width * 10) / 11),((pb_celeiro.Size.Height * 10) / 11));
        }
    }
}
