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
    public partial class CadastroFisica : Form
    {
        public CadastroFisica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string data = txtData.Text;
            string loc = txtLocalidade.Text;
            string tel = txtTelefone.Text;
            string email = txtEmail.Text;
            string senha = txtsenha.Text;
            string confsenha = txtconfsenha.Text;



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

            if (txtTelefone.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }

            if (txtsenha.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }

            if (txtconfsenha.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATÓRIO");
                return;
            }

            using (MyDbContext db = new MyDbContext())

             {

                 string query = @"INSERT INTO usuarios (nome, senha, email, telefone, endereco) VALUES (@pnome, @psenha, @email, @telefone, @endereco); SELECT LAST_INSERT_ID();";

                 var parameters = new[]

                 {

                     new MySqlParameter("@pnome", nome),

                     new MySqlParameter("@psenha", senha),

                     new MySqlParameter("@email", email),

                     new MySqlParameter("@telefone", tel),

                     new MySqlParameter("@endereco", loc)

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
            Form end = new CadastroMapa(false);
            end.Show();


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CodigoFisica_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
           
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
