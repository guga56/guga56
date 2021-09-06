using ProjetoAPIEstudo.Entidade.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Infraestruture.Repositorio.Interface;

namespace ProjetoAPIEstudo.Infraestruture.Repositorio
{
    public class RequerenteRepositorio : GenericRepositorio<Requerente>, IRequerenteRepositorio
    {
        public IEnumerable<Endereco> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
