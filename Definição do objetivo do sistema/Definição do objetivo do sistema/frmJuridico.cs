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
        public frmJuridico()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string juridico = mtbCNPJ.Text;
           

            if (juridico.Length<18)
            {
                MessageBox.Show("Dado incorreto");
                return;
                
            }
             MessageBox.Show("Dado correto:" + juridico);

            
           







        }
    }
}
