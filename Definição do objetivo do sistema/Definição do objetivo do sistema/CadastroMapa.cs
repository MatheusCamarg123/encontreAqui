using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 

namespace Definição_do_objetivo_do_sistema
{
    public partial class CadastroMapa : Form
    {
        public CadastroMapa()
        {
            InitializeComponent();
        }

        private void CadastroMapa_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Campo invalido");
                
                return;
                
            }

            if (txtBairro.Text == "")
            {
                MessageBox.Show("Campo invalido");
               
                return;

            }

            if (txtCEP.Text == "")
            {
                MessageBox.Show("Campo invalido");
               
                return;

            }

            if (txtCepCobranca.Text == "")
            {
                MessageBox.Show("Campo invalido");
               
                return;

            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Campo invalido");
              
                return;

            }

            if (txtEndCobranca.Text == "")
            {
                MessageBox.Show("Campo invalido");
               
                return;

            }

            if (txtEstado.Text == "")
            {
                MessageBox.Show("Campo invalido");
                
                return;

            }

            if (txtReferencia.Text == "")
            {
                MessageBox.Show("Campo invalido");
                
                return;

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
