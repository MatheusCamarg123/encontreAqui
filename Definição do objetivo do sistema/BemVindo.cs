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
    public partial class frmBV : Form
    {
        public frmBV()
        {
            InitializeComponent();
        }

        private void btnFisica_Click(object sender, EventArgs e)
        {
            
        }

        private void btnJuridica_Click(object sender, EventArgs e)
        {
            Form Juridica = new PessoaJuridica();
            Juridica.Show();
        }

        private void frmBV_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cCadastrar_Click(object sender, EventArgs e)
        {
            Form LOGIN = new frmFotos();
            LOGIN.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
