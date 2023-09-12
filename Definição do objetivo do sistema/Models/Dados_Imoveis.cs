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
   public class Dados_Imoveis
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("regiao")]
        public string regiao { get; set; }



        [Column("cidade")]

        public string cidade { get; set; }

        [Column("estado")]

        public string estado { get; set; }

        [Column("ponto_referencia")]

        public string ponto_referencia { get; set; }


        [Column("cep")]

        public string cep { get; set; }

        [Column("metros_quadrados")]

        public string metros_quadrados { get; set; }

        [Column("bairro")]

        public string bairro { get; set; }

        [Column("banheir")]

        public int banheir { get; set; }

        [Column("quart")]

        public int quart { get; set; }

        [Column("vag")]

        public int vag { get; set; }



    }
}
