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
    public partial class Pagamentos : Form
    {
        public Pagamentos()
        {
            InitializeComponent();


        }

        private void Pagamentos_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtcartaonumero.Visible = true;
            txtnome.Visible = true;
            txtcvv.Visible = true;
            mtvencimento.Visible = true;
            cbparcelas.Visible = true;
            lblnomecartao.Visible = true;
            lblnumerocartao.Visible = true;
            lblparcelas.Visible = true;
            lblvencimento.Visible = true;
            lblcvv.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtcartaonumero.Visible = true;
            txtnome.Visible = true;
            txtcvv.Visible = true;
            mtvencimento.Visible = true;
            lblnomecartao.Visible = true;
            lblnumerocartao.Visible = true;
            lblvencimento.Visible = true;
            lblcvv.Visible = true;
            lblparcelas.Visible = false;
            cbparcelas.Visible = false;
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




            if (radioButton3.Checked || radioButton1.Checked)
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

                if (cvv.Length <= 3)
                {
                    MessageBox.Show("NUMERO INCOMPLETO");
                    return;
                }
                if (vencimento == "")
                {
                    MessageBox.Show("VENCIMENTO INCOMPLETO");
                    return;
                }
                else
                {
                    MessageBox.Show("PAGAMENTO CONCLUIDO");
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

                if (boletinho.Checked)
                {
                    
                    if (boleto == "")
                    {
                        MessageBox.Show("BOLETO ENVIADO PARA O EMAIL CADASTRADO");
                        return;
                    }

                }
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
                txtnome.Visible = false;
                txtcvv.Visible = false;
                mtvencimento.Visible = false;
                lblnomecartao.Visible = false;
                lblnumerocartao.Visible = false;
                lblvencimento.Visible = false;
                lblcvv.Visible = false;
                lblparcelas.Visible = false;
                cbparcelas.Visible = false;

            }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
                txtcartaonumero.Visible = false;
                txtnome.Visible = false;
                txtcvv.Visible = false;
                mtvencimento.Visible = false;
                lblnomecartao.Visible = false;
                lblnumerocartao.Visible = false;
                lblvencimento.Visible = false;
                lblcvv.Visible = false;
                lblparcelas.Visible = false;
                cbparcelas.Visible = false;
            }
        }
    }