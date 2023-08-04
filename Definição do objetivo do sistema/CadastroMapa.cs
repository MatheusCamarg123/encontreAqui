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
    public partial class CadastroMapa : Form
    {
        bool cnpj;
        public CadastroMapa(bool isCNPJ)
        {
            this.cnpj = isCNPJ;
            InitializeComponent();
        }

        private void CadastroMapa_Load(object sender, EventArgs e)
        {
            Form tele = Application.OpenForms["FormCadastro"];
            if (tele != null)
                tele.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
          
            if (txtEndereco.Text == "") 
            {
                MessageBox.Show("Preenchimento Obrigatório");
                
                return;
                
            }

            if (txtBairro.Text == "")
            {
                MessageBox.Show("Preenchimento Obrigatório");
               
                return;

            }

            if (txtCEP.Text == "")
            {
                MessageBox.Show("Preenchimento Obrigatório");
               
                return;

            }

            if (txtCepCobranca.Text == "")
            {
                MessageBox.Show("Preenchimento Obrigatório");
               
                return;

            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Preenchimento Obrigatório");
              
                return;

            }

            if (txtEndCobranca.Text == "")
            {
                MessageBox.Show("Preenchimento Obrigatório");
               
                return;

            }

            if (txtEstado.Text == "")
            {
                MessageBox.Show("Preenchimento Obrigatório");
                
                return;

            }

            if (txtReferencia.Text == "")
            {
                MessageBox.Show("Preenchimento Obrigatório");
                
                return;

            }
            if (!this.cnpj)
            {
                Form Fotos = new frmFotos();
                Fotos.Show();
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCepCobranca.Text = "";
            txtCidade.Text = "";
            txtEndCobranca.Text = "";
            txtEndereco.Text = "";
            txtEstado.Text = "";
            txtReferencia.Text = "";
        }
    }
}
