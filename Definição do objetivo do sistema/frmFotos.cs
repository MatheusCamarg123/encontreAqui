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
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

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

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            String url = null;
            Account cloudinaryAccount = new Account(
                "dxcza5hfy",
                "491239265868345",
                "e5blkG_wmq_F7-QYC2G5mVR4FnQ"
            );

            Cloudinary cloudinary = new Cloudinary(cloudinaryAccount);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(imagePath),
                    };

                    var uploadResult = await cloudinary.UploadAsync(uploadParams);

                    if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        url = ""+uploadResult.SecureUri;
                        MessageBox.Show("A imagem foi enviada com sucesso. Link da imagem no Cloudinary: "+uploadResult.SecureUri);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao enviar a imagem para o Cloudinary: "+ uploadResult.Error.Message);
                        return;
                    }
                }
            }

            try
            {

                WebClient client = new WebClient();
                byte[] imageData = client.DownloadData(url);

                            
                using (var ms = new System.IO.MemoryStream(imageData))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
                this.Size = new System.Drawing.Size(500, 500);
                this.StartPosition = FormStartPosition.CenterScreen;

                //pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                //pictureBox.Dock = DockStyle.Fill;
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO fotos (foto,id_imovel ) VALUES (@pfotos, @pid_imovel)";
                MessageBox.Show("i: " + this.id_imovel);

                var parameters = new[]

                {

                    new MySqlParameter("@pfotos", url ),

                    new MySqlParameter("@pid_imovel", this.id_imovel )

                };



                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);

            }
        }

        private void frmFotos_Load(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form CD = new Cadastro_Detalhes();
            CD.WindowState = FormWindowState.Maximized;
            CD.Show();
            this.Close();
        }
    }
}
