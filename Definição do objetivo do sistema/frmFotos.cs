using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Definição_do_objetivo_do_sistema
{
    public partial class frmFotos : Form
    {
        public frmFotos()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
          

           try
            {
                // Faz o download da imagem a partir da URL
                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(Link.Text);

                // Converte os dados da imagem para um objeto Image
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
                this.Size = new Size(500, 500);
                this.StartPosition = FormStartPosition.CenterScreen;

                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Dock = DockStyle.Fill;
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                // Trata possíveis erros ao carregar a imagem
                MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFotos_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
        }
    }
}
