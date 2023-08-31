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
        bool pessoaFisica;
        
        public FrmDadosCadastro(bool isFisica)
        {
            pessoaFisica = isFisica;
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
            Form fFisica = Application.OpenForms["CodigoFisica"];
            Form fJuridico = Application.OpenForms["PessoaJuridica"];

            if (fFisica != null)
            {
                fFisica.Close();
            }
              
            else
            {
                
                fJuridico.Close();
            }
                
            
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
               
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            

           
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
       
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}