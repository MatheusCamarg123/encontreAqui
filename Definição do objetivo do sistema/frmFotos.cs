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
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;

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
                
                MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO fotos (foto,id_imovel ) VALUES (@pfotos, @pid_imovel)";

                var parameters = new[]

                {

                    new MySqlParameter("@pfotos", Link.Text ),

                    new MySqlParameter("@pid_imovel", 1 )

                };



                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);

            }
        }

        private void frmFotos_Load(object sender, EventArgs e)
        {
            Form maps1 = Application.OpenForms["CadastroMapa"];
            if (maps1 != null)
                maps1.Close();

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
        }
    }
}
