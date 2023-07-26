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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string document = txtCPF.Text;
            if (chkFisica.Checked)
            {
                if (document.Length < 11)
                {
                    MessageBox.Show("não validado");
                    return;
                }
                   
                
            }


        }
    }
}
