using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace Definição_do_objetivo_do_sistema
{
    public partial class FrmDadosCadastro : Form
    {
        public FrmDadosCadastro()
        {
            InitializeComponent();
        }

        private void txtPrincipal_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfimar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmDadosCadastro_Load(object sender, EventArgs e)
        {

        }

        private void FrmDadosCadastro_Validated(object sender, EventArgs e)
        {

        }

        private void txtPrincipal_Validated(object sender, EventArgs e)
        {
            string email = txtPrincipal.Text;
            Regex regex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email inválido");
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string batata = txtPrincipal.Text;
            string carne = txtConfirmacao.Text;
            if (batata == carne)
            {
                MessageBox.Show("E-mail correto");
                return;
            }
            MessageBox.Show("Dados Incorretos");

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form CPF = new frmCPF();
            CPF.Show();
        }
    }
}