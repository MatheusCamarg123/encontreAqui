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
    public partial class FrmDadosCadastro : Form
    {
        public FrmDadosCadastro()
        {
            InitializeComponent();
        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
           
            string batata = txtPrincipal.Text;
            string carne = txtConfirmacao.Text;
            if (batata == carne)
            {
                MessageBox.Show("E-mails corretos");
                return;
                
            }
            MessageBox.Show("Dados Incorretos");





        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
