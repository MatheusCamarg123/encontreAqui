using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Definição_do_objetivo_do_sistema.Models;


namespace Definição_do_objetivo_do_sistema
{
    class MyDbContext : DbContext
    {
        
        public MyDbContext() : base("name=MyDbContext") { }


        
    }
}
