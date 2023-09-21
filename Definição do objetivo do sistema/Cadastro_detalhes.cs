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
            string quarto = txtQuarto.Text;
            string banheiro = txtBanheiro.Text;
            string vaga = txtVaga.Text;
            

            if (reg =="" || cid =="" || est =="" || pont=="" || cep=="" || met=="" || bai=="" || quarto == "" || banheiro == "" || vaga == "" )
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
                if (quarto == "")
                {

                    txtQuarto.BackColor = Color.Tomato;
                }
                if (banheiro == "")
                {

                    txtBanheiro.BackColor = Color.Tomato;
                }
                if (vaga == "")
                {
                    txtVaga.BackColor = Color.Tomato;

                }


               
                MessageBox.Show("Preencha todos os campos!");
               


            }
            else
            {
                int quart = Convert.ToInt32(txtQuarto.Text);
                int banheir = Convert.ToInt32(txtBanheiro.Text);
                int vag = Convert.ToInt32(txtVaga.Text);

                using (MyDbContext db = new MyDbContext())

                {

                    string query = @"INSERT INTO cadastro_detalhes (regiao, cidade, estado, ponto_referencia, cep, metros_quadrados, bairro, banheir, quart, vag) VALUES (@regiao,@cidade, @estado, @ponto_referencia, @cep, @metros_quadrados, @bairro, @banheiro, @quarto, @vaga); SELECT LAST_INSERT_ID();";

                    var parameters = new[]

                    {

                    new MySqlParameter("@regiao",reg),

                    new MySqlParameter("@cidade", cid),

                    new MySqlParameter("@estado", est),

                    new MySqlParameter("@ponto_referencia", pont ),

                    new MySqlParameter("@cep", cep),

                    new MySqlParameter("@metros_quadrados", met),

                    new MySqlParameter("@bairro", bai),

                    new MySqlParameter("@banheiro", banheiro),

                    new MySqlParameter("@quarto", quarto),

                    new MySqlParameter("@vaga", vag)





                };

                    int imov_id = db.Database.SqlQuery<int>(query, parameters).SingleOrDefault();

                    if (imov_id == null)
                    {
                        MessageBox.Show("Não cadastrou a casa");
                        return;
                    }
                    MessageBox.Show("i: " + imov_id);
                    MessageBox.Show("Detalhes do imóvel cadastrados com sucesso :)");
                    Form Cadastro_detalhes = new frmFotos(imov_id);
                    Cadastro_detalhes.Show();
                    this.Hide();


                }
            }

            



            




        }

        private void Detalhes_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;



            {
                WindowState = FormWindowState.Maximized;





                int x = (Screen.PrimaryScreen.WorkingArea.Width - gbDetalhess.Width) / 2;
                int y = (Screen.PrimaryScreen.WorkingArea.Height - gbDetalhess.Height) / 2;
                gbDetalhess.Location = new Point(x, y);



            }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbQuartos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form login = new frmBV();
            login.WindowState = FormWindowState.Maximized;
            login.Show();
            this.Close();
        }

        
    }
}
