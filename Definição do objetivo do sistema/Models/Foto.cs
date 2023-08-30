using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Definição_do_objetivo_do_sistema.Models
{
    public class Foto
    {
        [Column("id")]
        public int Id { get; set; }



        [Column("foto")]
        public string foto { get; set; }
   


        [Column("id_imovel")]
        public int id_imovel { get; set; }



   

    }
}
