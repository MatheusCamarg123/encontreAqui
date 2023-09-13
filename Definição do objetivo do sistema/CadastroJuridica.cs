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
    public partial class CadastroJuridica : Form
    {
        public CadastroJuridica()
        {
            InitializeComponent();

        }

        private void txtFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            string nomeemp = txtNome.Text;
            string cnpj = textBox1.Text;
            string anofund = txtAno.Text;
            string numfunc = txtFuncionario.Text;
            string loc = txtLocalidade.Text;
            string email = textBox2.Text;
            string senha = txtsenha.Text;
            string confsenha = txtconfsenha.Text;





            if (txtNome.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }


            if (txtAno.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }


            if (txtFuncionario.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }

            if (txtLocalidade.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                return;
            }

            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO usuarios (nome, cnpj, numero_funcionarios, ano_fundacao, endereco) VALUES (@pnome, @psenha, @email, @telefone, @endereco); SELECT LAST_INSERT_ID();";

                var parameters = new[]

                {

                     new MySqlParameter("@pnome", nomeemp),

                     new MySqlParameter("@psenha", senha),

                     new MySqlParameter("@email", email),

                 

                     

                 };

                int batatinha = db.Database.SqlQuery<int>(query, parameters).Single();



                query = @"INSERT INTO Pessoa_Fisica (cpf, user_id) VALUES (@pcpf, @puser_id);";

                parameters = new[]

                {

                     new MySqlParameter("@pcpf", cpf),

                     new MySqlParameter("@puser_id", batatinha)

                 };



                int nRowAfetted = db.Database.ExecuteSqlCommand(query, parameters);



            }

            Form end = new CadastroMapa(true);
            end.Show();
        }

        private void PessoaJuridica_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void PessoaJuridica_Shown(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void versenha_Click(object sender, EventArgs e)
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

    }
}
