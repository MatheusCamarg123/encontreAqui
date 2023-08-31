using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace Definição_do_objetivo_do_sistema.Models
{
    public class Detalhes 
    {
        [Column("id")]
        public int id { get; set; }

        [Column("cnpj")]
        public string cnpj { get; set; }

        [Column("numero_funcionarios")]
        public int numero_funcionarios { get; set; }

        [Column("ano_fundacao")]
        public int ano_fundacao { get; set; }

        [Column("user_id")]
        public int user_id { get; set; }
    }
}
