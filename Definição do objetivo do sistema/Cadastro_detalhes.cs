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
    public partial class Cadastro_Detalhes : Form
    {
        public Cadastro_Detalhes()
        {
            InitializeComponent();
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            string reg = txtReg.Text;
            string cid = txtCid.Text;
            string est = txtEst.Text;
            string pont = txtPont.Text;
            string cep = txtCep.Text;
            string met = txtMet.Text;
            string bai = txtBai.Text;
          

            if(reg =="" || cid =="" || est =="" || pont=="" || cep=="" || met=="" || bai=="" )
            {
                if (reg == "")
                {
                    txtReg.BackColor = Color.Tomato;
                }
                if (cid == "")
                {

                    txtCid.BackColor = Color.Tomato;
                }

                if (est == "")
                {

                    txtEst.BackColor = Color.Tomato;
                }
                if (pont == "")
                {

                    txtPont.BackColor = Color.Tomato;
                }
                if (cep == "")
                {

                    txtCep.BackColor = Color.Tomato;
                }
                if (met == "")
                {

                    txtMet.BackColor = Color.Tomato;
                }
                if (bai == "")
                {

                    txtBai.BackColor = Color.Tomato;
                }
                //depois de todos os ifs
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                using (MyDbContext db = new MyDbContext())

                {

                    string query = @"INSERT INTO cadastro_detalhes (regiao, cidade, estado, ponto_referencia, cep, metros_quadrados, bairro) VALUES (@regiao,@cidade, @estado, @ponto_referencia, @cep, @metros_quadrados, @bairro); SELECT LAST_INSERT_ID();";

                    var parameters = new[]

                    {

                    new MySqlParameter("@regiao",reg),

                    new MySqlParameter("@cidade", cid),

                    new MySqlParameter("@estado", est),

                    new MySqlParameter("@ponto_referencia", pont ),

                    new MySqlParameter("@cep", cep),

                    new MySqlParameter("@metros_quadrados", met),

                    new MySqlParameter("@bairro", bai)





                };

                    Dados_Imoveis detalhes = db.Database.SqlQuery<Dados_Imoveis>(query, parameters).SingleOrDefault();
                    MessageBox.Show("Detalhes do imóvel cadastrados com suscesso :)");
                    Form Cadastro_detalhes = new frmFotos();
                    Cadastro_detalhes.Show();
                    this.Hide();


                }
            }

            



            




        }

        private void Detalhes_Load(object sender, EventArgs e)
        {

        }

        private void cMobiliado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void gbQuarto_Enter(object sender, EventArgs e)
        {

        }
    }
}
