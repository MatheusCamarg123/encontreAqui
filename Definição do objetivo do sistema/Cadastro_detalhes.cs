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
    public partial class txtBair : Form
    {
        public txtBair()
        {
            InitializeComponent();
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            string reg = txtReg.Text;
            string cid = txtCid.Text;
            string est = txtEst.Text;
            string pont = txtPont.Text;
            string cep = mtCep.Text;
            string met = txtMet.Text;
            string bai = txtBai.Text;



            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO dados_imoveis (regiao, cidade, estado, ponto de referencia, CEP, metros quarados, bairro, quartos, banheiro, vagas) VALUES (@regiao, @estado, @ponto_de_referencia, @CEP, @metros_quarados, @bairro, @quartos, @banheiro, @vagas); SELECT LAST_INSERT_ID();";

                var parameters = new[]

                {

                    new MySqlParameter("@regiao",reg),

                    new MySqlParameter("@cidade", cid),

                    new MySqlParameter("@estado", est),

                    new MySqlParameter("@ponto_de_referencia", pont ),

                    new MySqlParameter("@CEP", cep),

                    new MySqlParameter("@metros_quadrados", met),

                    new MySqlParameter("@bairro", bai),





           };

                int dados =  db.Database.SqlQuery<int>(query, parameters).Single();

            }



            Form Cadastro_detalhes = new frmFotos();
            Cadastro_detalhes.Show();




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
    }
}
