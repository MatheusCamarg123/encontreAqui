﻿using System;
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
            int numfunc = Convert.ToInt32 (txtFuncionario.Text);
            string loc = txtLocalidade.Text;
            string email = textBox2.Text;
            string senha = txtsenha.Text;
            string confsenha = txtconfsenha.Text;
            string tele = txtTel.Text;





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
            if (lbltelef.Text == "")
            {
                MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
            }
            if (numfunc > 50)
            {
                MessageBox.Show("Limite de Funcionários excedido");
                return;
            }

          

            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO usuarios (nome, senha, email, telefone,  endereco) VALUES (@pnome, @psenha, @email, @telefone, @endereco); SELECT LAST_INSERT_ID();";

                var parameters = new[]

                {

                     new MySqlParameter("@pnome", nomeemp),

                     new MySqlParameter("@psenha", senha),

                     new MySqlParameter("@email", email),

                     new MySqlParameter("@telefone", tele),

                     new MySqlParameter("@endereco", loc),





                 };

                int batatinha = db.Database.SqlQuery<int>(query, parameters).Single();



                query = @"INSERT INTO Pessoa_Juridica (cnpj, numero_funcionarios, ano_fundacao, nome_empresa, user_id) VALUES (@cnpj, @numero_funcionarios, @ano_fundacao, @nome_empresa, @user_id); SELECT LAST_INSERT_ID();";

                parameters = new[]

                {

                     new MySqlParameter("@cnpj", cnpj),

                     new MySqlParameter("@numero_funcionarios", numfunc),

                     new MySqlParameter("@ano_fundacao", anofund),

                     new MySqlParameter("@nome_empresa", nomeemp),

                     new MySqlParameter("@user_id", batatinha)

                 };



                int id_juridica = db.Database.SqlQuery<int>(query, parameters).Single();

                Form end = new CadastroMapa(true, id_juridica);
                end.Show();
                this.Hide();

            }

            
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form login = new frmBV();
            login.WindowState = FormWindowState.Maximized;
            login.Show();
            this.Hide();
        }
    }
}
