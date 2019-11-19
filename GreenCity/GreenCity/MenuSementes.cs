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
    public partial class Form2 : Form
    {
        frmPlantacaoSementes frm1;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(frmPlantacaoSementes frm) : this()
        {
            frm1 = frm;
        }

        private void btn_trigo_Click(object sender, EventArgs e)
        {
            frm1.escolhaSemente((sender as Button).Name.Split('_')[1]);
            frm1.Show();
            this.Close();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Show();
        }
    }
}
