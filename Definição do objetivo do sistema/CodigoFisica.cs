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
    public partial class CodigoFisica : Form
    {
        public CodigoFisica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imovel = btnConfirma.Text;


            if (txtNome.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }

            if (txtData.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }

            if (txtIdade.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }

            if (txtLocalidade.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }


            



            Form Email = new FrmDadosCadastro(true);
            Email.Show();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CodigoFisica_Load(object sender, EventArgs e)
        {
            Form login = Application.OpenForms["Login"];
            
            if (login != null)
            {
                login.Close();
            }
        }

        private void txtData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
