using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Definição_do_objetivo_do_sistema.Models;



namespace Definição_do_objetivo_do_sistema
{
    public partial class Detalhes : Form
    {
        public Detalhes()
        {
            InitializeComponent();
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            using (MyDbContext db = new MyDbContext())
            {
                string query = "select * from Fotos;";
                List<Foto> fotos = db.Database.SqlQuery<Foto>(query).ToList();
                fotomovel.DataSource = fotos;
            }
        }

        private void btnOutra_Click(object sender, EventArgs e)
        {
            Form cadastro = new cadastrada (1);
            cadastro.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            PictureBox pictureBox = new PictureBox();
             pictureBox.Image = Image.FromFile("https://i.imgur.com/PIrlQaG.jpeg"); 
             pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void fotomovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

