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
    public partial class PessoaJuridica : Form
    {
        public PessoaJuridica()
        {
            InitializeComponent();

        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
      

            if (txtNome.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }


            if (txtAno.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }


            if (txtFuncionario.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }

            if (txtLocalidade.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }
           

            Form Email = new FrmDadosCadastro(false);
            Email.Show();
        }

        private void PessoaJuridica_Load(object sender, EventArgs e)
        {
            
        }

        private void PessoaJuridica_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
