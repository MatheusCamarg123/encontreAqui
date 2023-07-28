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
    public partial class PessoaFisica : Form
    {
        public PessoaFisica()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imovel = btnConfirma.Text;


            if (txtNome.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }

            if (txtData.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }

            if (txtIdade.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }

            if (txtLocalidade.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }


            


            if (txtNome.Text == "" && txtLocalidade.Text == "" && txtIdade.Text == "" && txtData.Text == "")
            {
                lbl8.Text = "";
            }
            else
            {
                lbl8.Text = "EM ANALISE\nLOGO ENTRAREMOS EM CONTATO";
            }

            if (ccb1.Checked || ccb2.Checked)
            {
                lbl8.Text = "EM ANALISE\nLOGO ENTRAREMOS EM CONTATO";
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }

    }
}
