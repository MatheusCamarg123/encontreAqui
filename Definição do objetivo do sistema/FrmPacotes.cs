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
        int id_pj;
        

        public FrmPacotes(int id_pj)
        {
            this.id_pj = id_pj;
            
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
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form cadastrada = new Pagamentos(this.id_pj, 16);
            cadastrada.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Form cadastrada = new Pagamentos(this.id_pj, 24);
            cadastrada.Show();
        }

        private void gb_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            Form cadastrada = new Pagamentos(this.id_pj, 8);
            cadastrada.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form CM = new CadastroMapa(true, this.id_pj);
            CM.WindowState = FormWindowState.Maximized;
            CM.Show();
            this.Close();
        }
    }
}
