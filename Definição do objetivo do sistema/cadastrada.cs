using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Definição_do_objetivo_do_sistema.Models;

namespace Definição_do_objetivo_do_sistema
{
    public partial class cadastrada : Form
    {
        public cadastrada(int qtimoveis)
        {

            InitializeComponent();
            
            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM encontre_aqui.dados_imoveis LIMIT " + qtimoveis+";";

                List <Dados_Imoveis> imoveis = db.Database.SqlQuery<Dados_Imoveis>(query).ToList();

                dGImoveisCadastrados.DataSource = imoveis;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrada_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Detalhes = new Detalhes();
            Detalhes.Show();
        }

        private void dGImoveisCadastrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
