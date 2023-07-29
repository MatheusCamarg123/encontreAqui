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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDefinição_Click(object sender, EventArgs e)
        {

        }

        private void lblDefinicao_Click(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDefinicao.Text = "Definição do objetivo do sistema: Vendas de \n áreas exclusivas, que se \n encaixa com o sonho do cliente";
            lblNaoFuncional.Text = "Requisitos funcionais: Design, barra de pesquisa,\n descrição, botões \n e imagens";
            lblFuncional.Text = "Requisitos não funcionais: Acessibilidade, \n botão de legenda e  letras garrafais para enfatizar \n  títulos e pontos especifícos";

            string[,] swot = new string[2, 2];
            swot[0, 0] = "Força";
            swot[0, 1] = "Oportunidade";
            swot[1, 1] = "Fraqueza";
            swot[1, 0] = "Ameaça";

            lblForca.Text = "Localização precisa no mapa \n Filtro mais preciso  \n - Regiões lançadas a pouco tempo \n - Maior número de dados \n - Todos os imóveis em um determinado local";
            lblOportunidade.Text = "- Site pesado \n - Erro no processamento ";
            lblFraqueza.Text = "- Mapa desatualizado \n - Concorrência \n - Plagio";
            lblameaca.Text = "- Mais segurança na hora de escolher \n - Um número considerável de novos contratados";

            string[] VetordeAPIs = new string[6];



            VetordeAPIs[0] = "Cristian: https://developers.google.com/maps/documentation/places/web-service/overview?hl=pt-br ";
            VetordeAPIs[1] = " Kevy: https://fred.stlouisfed.org/docs/api/fred/";
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

        private void lblFuncional_Click(object sender, EventArgs e)
        {
            

        }

        private void lblFuncional_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblForca_Click(object sender, EventArgs e)
        {

        }

        private void lblameaca_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string imovel = Imobiliaria.Text;
            decimal func = Convert.ToDecimal(Funcionarios.Text);

            if (func >0 && func <= 50)
            {
                Respon.Text = ("Aprovado");
            }
            else
            {
                Respon.Text = "Não Aprovado";
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Cadastrar";
            Form frmCPF = new frmCPF();
            frmCPF.WindowState = FormWindowState.Maximized;
            frmCPF.Show();
        }
    }
}
