﻿using System;
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
    public partial class frmJuridico : Form
    {
        bool cnpj;
        public frmJuridico(bool isCNPJ)
        {
            this.cnpj = isCNPJ;
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string juridico = mtbCNPJ.Text;
            Form email = Application.OpenForms["FrmDadosCadastro"];

            if (juridico.Length<18 && (email != null))
            {
                MessageBox.Show("Dado incorreto");


                return;
                email.Close();
            }
           
            
                MessageBox.Show("Dado correto:" + juridico);
                Form tel = new FormCadastro(true);
                tel.Show();
               
            








        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Form tel = new FormCadastro(this.cnpj);
            tel.Show();*/
        }

        private void frmJuridico_Load(object sender, EventArgs e)
        {
            Form email = Application.OpenForms["FrmDadosCadastro"];
            if (email != null)
                email.Close();
        }
    }
}
