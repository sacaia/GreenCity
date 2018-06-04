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
    public partial class Silo : Form
    {
        public Silo()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void Silo_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

       

        private void Silo_Shown(object sender, EventArgs e)
        {
            frmPlantacaoSementes frmPlantaca = new frmPlantacaoSementes();
            lb_qtdcapim.Text = "Capim : " + frmPlantaca.PegaSementes1();
            lb_qtdcafe.Text = "Café : " + frmPlantaca.PegaSementes2();
            lb_qtdmilho.Text = "Milho : " + frmPlantaca.PegaSementes3();
            lb_qtdtrigo.Text = "Trigo : " + frmPlantaca.PegaSementes4();
        }
    }
}
