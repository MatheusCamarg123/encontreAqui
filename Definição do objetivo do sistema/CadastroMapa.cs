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

        public CadastroMapa()
        {
        }

        private void CadastroMapa_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string endereco = txtEndereco.Text;
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string estado = txtEstado.Text;
            string cep = txtCEP.Text;


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

            

            if (txtCidade.Text == "")
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
                
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }


            using (MyDbContext db = new MyDbContext())

            {
                string query = @"INSERT INTO endereco_pf_pj (endereco, bairro, cidade, estado, cep) VALUES (@endereco, @bairro, @cidade, @estado, @cep)";
                var parameters = new[]

                {

                    new MySqlParameter("@endereco", endereco),
                    new MySqlParameter("@bairro", bairro),
                    new MySqlParameter("@cidade", cidade),
                    new MySqlParameter("@estado", estado),
                    new MySqlParameter("@cep", cep),
                };

                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);

                if (this.cnpj)
                {
                    Form end = new FrmPacotes();
                    end.Show();
                }
                else
                {

                    Form login = new frmBV();
                    login.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBairro.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtEndereco.Text = "";
            txtEstado.Text = "";
            txtReferencia.Text = "";
        }

        private void txtEndCobranca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
