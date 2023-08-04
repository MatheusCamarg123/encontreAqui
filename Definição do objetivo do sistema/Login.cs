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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pFisica_Click(object sender, EventArgs e)
        {
            Form Fisica = new CodigoFisica();
            Fisica.Show();
        }

        private void pJuridica_Click(object sender, EventArgs e)
        {
            Form Juridica = new PessoaJuridica();
            Juridica.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
