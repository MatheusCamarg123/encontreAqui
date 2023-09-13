using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Definição_do_objetivo_do_sistema.Models
{
    public class Usuarios
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("email")]
        public string Email { get; set; }
    }
}    
    
