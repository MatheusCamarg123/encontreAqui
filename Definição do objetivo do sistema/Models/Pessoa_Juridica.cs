using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Definição_do_objetivo_do_sistema.Models
{
    class Pessoa_Juridica
    {
        [Column("id")]
        public int id { get; set; }

        [Column("cnpj")]
        public string cnpj { get; set; }

        [Column("numero_funcionarios")]
        public int numero_funcionarios { get; set; }

        [Column("ano_fundacao")]
        public int ano_fundacao { get; set; }

        [Column("nome_empresa")]
        public int nome_empresa { get; set; }

        [Column("user_id")]
        public int user_id { get; set; }
    }
}
