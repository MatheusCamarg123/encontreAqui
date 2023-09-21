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
using System.Net;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;




namespace Definição_do_objetivo_do_sistema
{
    public partial class Detalhes : Form
    {
        int idProdutoSelecionado;
        int qtimoveis;
        int posicao = 0;
        List<Foto> fotos;
        public Detalhes(int idProdutoSelecionado, int qtimoveis)
        {
            this.idProdutoSelecionado = idProdutoSelecionado;
            this.qtimoveis = qtimoveis;
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            using (MyDbContext db = new MyDbContext())
            {
                string query = "select * from Fotos where id_imovel = " + this.idProdutoSelecionado + ";";
                this.fotos = db.Database.SqlQuery<Foto>(query).ToList();

                if(this.fotos.Count() < 1)
                {
                    MessageBox.Show("Não possui fotos");
                    Form cadastro = new cadastrada(this.qtimoveis);
                    cadastro.Show();
                    this.Hide();
                    return;
                }

                mostrarFotos();
            }
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {
            


            {
                WindowState = FormWindowState.Maximized;





                int x = (Screen.PrimaryScreen.WorkingArea.Width - gbDetalhes.Width) / 2;
                int y = (Screen.PrimaryScreen.WorkingArea.Height - gbDetalhes.Height) / 2;
                gbDetalhes.Location = new Point(x, y);



            }
        }

        private void mostrarFotos()
        {
            try {
                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(this.fotos[this.posicao].foto);

                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
                this.Size = new System.Drawing.Size(500, 500);
                this.StartPosition = FormStartPosition.CenterScreen;

                this.WindowState = FormWindowState.Maximized;
            } catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOutra_Click(object sender, EventArgs e)
        {
            Form cadastro = new cadastrada (this.qtimoveis);
            cadastro.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            this.posicao = (this.posicao + 1) % this.fotos.Count();
            mostrarFotos();

        }

        private void fotomovel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            this.posicao = this.posicao == 0 ? this.fotos.Count() - 1 : this.posicao - 1;

            mostrarFotos();
        }
    }
}

