using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Definição_do_objetivo_do_sistema
{
    public partial class frmCPF : Form
    {
        public frmCPF()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            

            
        }

        private void gbTipo_Enter(object sender, EventArgs e)
        {

        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbJuridico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            string fisico = rbFisica.Text;

            if (rbFisica.Checked)
            {
                Form fisica = new frFisico();
                fisica.Show();
            }

            string juridico = rbJuridico.Text;
            if (rbJuridico.Checked)
            {
                Form juridica = new frmJuridico();
                juridica.Show();

            }

        }
    }
}
