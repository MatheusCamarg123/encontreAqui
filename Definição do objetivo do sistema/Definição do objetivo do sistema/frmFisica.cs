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
    public partial class frFisico : Form
    {
        public frFisico()
        {
            InitializeComponent();
        }

        private void btnConfirme_Click(object sender, EventArgs e)
        {
            string fisico = mtbCPF.Text;
            string documento = mtbRG.Text;

            if (fisico.Length <14 || documento.Length <12)
            {
                MessageBox.Show("Dado incorreto");
                return;
            }
            MessageBox.Show("Dado correto:" + fisico);
            
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form tel = new FormCadastro();
            tel.Show();

        }
    }
}
