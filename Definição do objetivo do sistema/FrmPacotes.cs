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
    public partial class FrmPacotes : Form
    {
        public FrmPacotes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Pacotes_Load(object sender, EventArgs e)
        {
            { WindowState = FormWindowState.Maximized;


                int x = (Screen.PrimaryScreen.WorkingArea.Width - gbPacotes.Width) / 2;
                int y = (Screen.PrimaryScreen.WorkingArea.Height - gbPacotes.Height) / 2;
                gbPacotes.Location = new Point(x, y);

            }
    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form cadastrada = new Pagamentos(1);
            cadastrada.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form cadastrada = new Pagamentos(2);
            cadastrada.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Form cadastrada = new Pagamentos(3);
            cadastrada.Show();
        }

        private void gb_Enter(object sender, EventArgs e)
        {

        }
    }
}
