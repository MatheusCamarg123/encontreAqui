using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())

            {



                string query = @"INSERT INTO Users (name, birth_date) VALUES (@name, @birth_date)";



                var parameters = new[]



                {



                    new MySqlParameter("@celular1", mtCelular1),



                    new MySqlParameter("@calcular", btnEncontrar)



                };





                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);



            }
        }

        private void Detalhes_Load(object sender, EventArgs e)
        {

        }
    }
}
