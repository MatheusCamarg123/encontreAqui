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
    class Pagamentos
    {
        [Column("id")]

        public int Id { get; set; }

        [Column("pix")]

        public string pix { get; set; }

        [Column("boleto")]

        public string boleto { get; set; }

        [Column("cartao_credito")]

        public string cartao_credito { get; set; }

        [Column("cartao_debito")]

        public string cartao_debito { get; set; }

        [Column("cpf")]

        public string cpf { get; set; }

        [Column("pacote")]

        public int pacote { get; set; }
    }
}
