using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Entidade.Entidade;

namespace ProjetoAPIEstudo.Infraestruture.Contexto
{
    public class ProjetoAIEstudoContexto : DbContext
    {
        public ProjetoAIEstudoContexto()
        {

        }

        public ProjetoAIEstudoContexto(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Veiculo> Veiculo { get; set; }

        public DbSet<Requerente> Requerente { get; set; }
    }
}
