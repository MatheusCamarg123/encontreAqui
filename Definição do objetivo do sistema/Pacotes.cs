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
    public partial class Pacotes : Form
    {
        public Pacotes()
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

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Form cadastrada = new cadastrada(1);
            cadastrada.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form cadastrada = new cadastrada(2);
            cadastrada.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Form cadastrada = new cadastrada(3);
            cadastrada.Show();
        }
    }
}
