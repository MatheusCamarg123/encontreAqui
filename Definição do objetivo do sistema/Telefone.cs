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
    public partial class FormCadastro : Form
    {
        bool cnpj;
        public FormCadastro(bool isCNPJ)
        {
            this.cnpj = isCNPJ;
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            char[] charsToClean = { ' ', '(', ')','-' };
            string telefone = mtTelefone.Text.Trim(charsToClean);
            string celular1 = mtCelular1.Text.Trim(charsToClean);
            string celular2 = mtCelular2.Text.Trim(charsToClean);

            if (celular1.Length < 11)
            {
                MessageBox.Show("numero incompleto");
                return;
            }

            Form maps = new CadastroMapa(this.cnpj);
            maps.Show();
        }

        private void mtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtCelular1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

            Form cpf1 = Application.OpenForms["frFisico"];
            Form cnpj = Application.OpenForms["frmJuridico"];
            if (cpf1 != null)
                cpf1.Close();
            else
            {
                cnpj.Close();
            }
        }
    }
}
