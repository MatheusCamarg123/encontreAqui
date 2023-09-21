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
        int id_imovel;
        public frmFotos(int id_imovel)
        {
            this.id_imovel = id_imovel;
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
       
            
                      try
                        {

                            WebClient client = new WebClient();
                            byte[] imageData = client.DownloadData(Link.Text);

                            
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

                    new MySqlParameter("@pid_imovel", id_imovel )

                };



                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);

            }
        }

        private void frmFotos_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;

            {
                WindowState = FormWindowState.Maximized;


                int x = (Screen.PrimaryScreen.WorkingArea.Width - gbFotos.Width) / 2;
                int y = (Screen.PrimaryScreen.WorkingArea.Height - gbFotos.Height) / 2;
                gbFotos.Location = new Point(x, y);

            }

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
        }
    }
}
