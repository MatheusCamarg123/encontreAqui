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
    public partial class CadastroFisica : Form
    {
        public CadastroFisica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new frmBV();
            login.Show();

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

            if (txtLocalidade.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }


            
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtsenha.PasswordChar == '*')
            {
                txtsenha.PasswordChar = '\0'; // Mostrar a senha
                versenha.Image = System.Drawing.Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                txtsenha.PasswordChar = '*'; // Ocultar a senha
                versenha.Image = System.Drawing.Image.FromFile(@"..\..\Resources\hide.png");
            }
        }

        private void ocultarsenha_Click(object sender, EventArgs e)
        {
            
        }

        private void ocultarsenha_Click_1(object sender, EventArgs e)
        {
            if (txtconfsenha.PasswordChar == '*')
            {
                txtconfsenha.PasswordChar = '\0'; // Mostrar a senha
                ocultarsenha.Image = System.Drawing.Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                txtconfsenha.PasswordChar = '*'; // Ocultar a senha
                ocultarsenha.Image = System.Drawing.Image.FromFile(@"..\..\Resources\hide.png");
            }
        }

        private void textconfsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
