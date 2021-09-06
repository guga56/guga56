using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Infraestruture.Repositorio.Interface;
using ProjetoAPIEstudo.Entidade.Entidade;

namespace ProjetoAPIEstudo.Infraestruture.Repositorio
{
    public class EnderecoRepositorio : GenericRepositorio<Endereco>, IEnderecoRepositorio
    {
        public IEnumerable<Endereco> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
