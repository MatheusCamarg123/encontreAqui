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
    public partial class Pagamentos : Form
    {

        int id_pj;
        int pacote;
        private int v;
        int id_usuarios;
      
        public Pagamentos(int id_pj, int pacote)
        {
            this.id_pj = id_pj;
            this.pacote = pacote;
            
            InitializeComponent();


        }

        public Pagamentos(int v)
        {
            this.v = v;
        }

        private void Pagamentos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            {
                WindowState = FormWindowState.Maximized;


                int x = (Screen.PrimaryScreen.WorkingArea.Width - gbPagamentos.Width) / 2;
                int y = (Screen.PrimaryScreen.WorkingArea.Height - gbPagamentos.Height) / 2;
                gbPagamentos.Location = new Point(x, y);

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtcartaonumero.Visible = true;
            txtcpf.Visible = true;
            txtnome.Visible = true;
            txtcvv.Visible = true;
            mtvencimento.Visible = true;
            cbparcelas.Visible = true;
            lblnomecartao.Visible = true;
            lblnumerocartao.Visible = true;
            lblparcelas.Visible = true;
            lblvencimento.Visible = true;
            lblcvv.Visible = true;
            lblcpf.Visible = true;
            pixx.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtcartaonumero.Visible = true;
            txtcpf.Visible = true;
            txtnome.Visible = true;
            txtcvv.Visible = true;
            mtvencimento.Visible = true;
            lblnomecartao.Visible = true;
            lblnumerocartao.Visible = true;
            lblvencimento.Visible = true;
            lblcvv.Visible = true;
            lblparcelas.Visible = false;
            cbparcelas.Visible = false;
            lblcpf.Visible = true;
            pixx.Visible = false;
        }

        private void lblnomecartao_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirmado_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string numerocartao = txtcartaonumero.Text;
            string cvv = txtcvv.Text;
            string parcelas = cbparcelas.Text;
            string vencimento = mtvencimento.Text.Trim();
            string boleto = boletinho.Text;
            string pix = pixx.ImageLocation;
            string cpf = cpff.Text;




            if (cpff.Checked || radioButton1.Checked)
            {

                if (nome == "")
                {
                    MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                    return;
                }

                if (numerocartao.Length <= 16)
                {
                    MessageBox.Show("PREENCHIMENTO OBRIGATORIO");
                    return;
                }

                if (cvv.Length < 3)
                {
                    MessageBox.Show("NUMERO INCOMPLETO");
                    return;
                }
                if (vencimento == "")
                {
                    MessageBox.Show("VENCIMENTO INCOMPLETO");
                    return;
                }
            }

            if (radioButton1.Checked)
            {
                if (parcelas == "")
                {
                    MessageBox.Show("SELECIONE QUANTAS PARCELAS");
                    return;

                }


            }
            if (boletinho.Checked)
            {

                if (boleto == "")
                {
                    MessageBox.Show("BOLETO ENVIADO PARA O EMAIL CADASTRADO");
                    return;
                }

            }
        


             using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO pagamento (pix, boleto,nome_cartao, numero_cartao, cpf_cartao, cvv_cartao, data_cartao, parcela_cartao , cpf, id_dadospj, pacote) VALUES (@pix, @boleto, @nome_cartao, @numero_cartao, @cpf_cartao, @cvv_cartao, @data_cartao, @parcela_cartao, @id_dadospj, @pacote);";

                var parameters = new[]
                {
                     new MySqlParameter("@pix", pix),
                     new MySqlParameter("@boleto", boleto),
                      new MySqlParameter("@nome_cartao", nome),
                     new MySqlParameter("@numero_cartao", numerocartao),
                      new MySqlParameter("@cpf_cartao", cpf),
                       new MySqlParameter("cvv_cartao", cvv),
                     new MySqlParameter("@data_cartao", vencimento),
                      new MySqlParameter("@parcela_cartao", parcelas),
                     new MySqlParameter("@id_dadospj", this.id_pj),
                     new MySqlParameter("@pacote", this.pacote),
                 };
                MessageBox.Show("PAGAMENTO CONCLUIDO");
                Form login = new frmBV();
                login.Show();

            }
        }
            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void txtnome_TextChanged(object sender, EventArgs e)
            {

            }

            private void radioButton4_CheckedChanged(object sender, EventArgs e)
            {
                txtcartaonumero.Visible = false;
                txtcpf.Visible = false;
                txtnome.Visible = false;
                txtcvv.Visible = false;
                mtvencimento.Visible = false;
                lblnomecartao.Visible = false;
                lblnumerocartao.Visible = false;
                lblvencimento.Visible = false;
                lblcvv.Visible = false;
                lblparcelas.Visible = false;
                cbparcelas.Visible = false;
                lblcpf.Visible = false;
            pixx.Visible = false;

        }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
                txtcartaonumero.Visible = false;
                txtcpf.Visible = false;
                txtnome.Visible = false;
                txtcvv.Visible = false;
                mtvencimento.Visible = false;
                lblnomecartao.Visible = false;
                lblnumerocartao.Visible = false;
                lblvencimento.Visible = false;
                lblcvv.Visible = false;
                lblparcelas.Visible = false;
                cbparcelas.Visible = false;
                lblcpf.Visible = false;
                pixx.Visible = true;
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form login = new frmBV();
            login.WindowState = FormWindowState.Maximized;
            login.Show();
            this.Hide();
        }
    }
    }