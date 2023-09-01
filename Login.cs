using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;
using Definição_do_objetivo_do_sistema.Models;



namespace Definição_do_objetivo_do_sistema
{
    public partial class frmBV : Form
    {
        public frmBV()
        {
            InitializeComponent();
        }

        private void btnFisica_Click(object sender, EventArgs e)
        {
            
        }

        private void btnJuridica_Click(object sender, EventArgs e)
        {
            Form Juridica = new CadastroJuridica();
            Juridica.Show();
        }

        private void frmBV_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cCadastrar_Click(object sender, EventArgs e)
        {
            if (cbPFPJ.SelectedItem != null)
            {
                string combo = cbPFPJ.SelectedItem.ToString();

                if (combo == "PF")
                {
                    Form pf = new CadastroFisica();
                    pf.Show();
                }
                else if (combo == "PJ")
                {
                    Form pj = new CadastroJuridica();
                    pj.Show();
                }
            }else 
            {
                MessageBox.Show("Selecione para continuar");
            }
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string login = txtCpfcnpj.Text;
            string senha = txtSenha.Text;

            using (MyDbContext db = new MyDbContext())

            {
                string query = @"SELECT * from Usuario where cpf = @cpf AND senha = @senha;";
                var parameters = new[]

                {
                  new MySqlParameter("@cpf", login),
                  new MySqlParameter("@senha", senha)
                  
                };

                Usuario user = db.Database.SqlQuery<Usuario>(query).Single();
            }
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0'; // Mostrar a senha
                versenha.Image = System.Drawing.Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                txtSenha.PasswordChar = '*'; // Ocultar a senha
                versenha.Image = System.Drawing.Image.FromFile(@"..\..\Resources\hide.png");
            }
        }

        private void cbPFPJ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBV_Validated(object sender, EventArgs e)
        {
            
           
        }
    }


}
