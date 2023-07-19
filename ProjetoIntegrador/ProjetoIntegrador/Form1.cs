using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llbl1.Text = "Vendas de áreas exclusivas, que se encaixa com o sonho do cliente  ";
            llbl2.Text = "Design, barra de pesquisa, descrição, botões e imagens ";
            llbl3.Text = "Acessibilidade, botão de legenda e letras garrafais para enfatizar títulos e pontos especifícos ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] swot = new string[2, 2];
            swot[0, 0] = "- Localização precisa no mapa\n Filtro mais preciso \n- Regiões lançadas a pouco tempo\n - Maior número de dados\n - Todos os imóveis em um determinado\n local";
            swot[0, 1] = "- Site pesado \n - Erro no processamento";
            swot[1, 0] = "- Mapa desatualizado\n - Concorrência\n - Plagio ";
            swot[1, 1] = "- Mais segurança na hora de escolher\n - Um número considerável de novos contratados";

            lblF.Text = swot[0, 0];
            lblO.Text = swot[0, 1];
            lblF2.Text = swot[1, 0];
            lblA.Text = swot[1,1];

            string[] VetordeAPIs = new string[6];

            VetordeAPIs[0] = "Cristian: https://developers.google.com/maps/documentation/places/web-service/overview?hl=pt-br ";
            VetordeAPIs[1] = "Kevy: https://fred.stlouisfed.org/docs/api/fred/";
            VetordeAPIs[2] = "Beatriz: https://m3o.com/weather/api";
            VetordeAPIs[3] = "Gaby: https://www.zillowgroup.com/developers/api/public-data/public-records-api/";
            VetordeAPIs[4] = "Matheus: https://www.zillowgroup.com/developers/api/public-data/real-estate-metrics/";
            VetordeAPIs[5] = "Luis: https://developers.google.com/maps/documentation/geocoding/start";



            string textoAPIs = "";
            for (int i = 0; i < VetordeAPIs.Length; i++)
            {
                textoAPIs += VetordeAPIs[i] + "\n";
            }
            APIs.Text = textoAPIs;
        }

        private void llbl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imovel = Imobiliaria.Text;
            decimal func = Convert.ToDecimal(Funcionarios.Text);

            if (func <= 50 && func >=0)
            {
                Respon.Text = "Aprovado";
            }
            else
            {
                Respon.Text = "Não Aprovado";
            }
        }
    }
}
