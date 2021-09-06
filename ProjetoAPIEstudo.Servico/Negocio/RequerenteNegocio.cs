using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Infraestruture.Repositorio;
using ProjetoAPIEstudo.Entidade.Entidade;

namespace ProjetoAPIEstudo.Servico.Negocio
{
    public class RequerenteNegocio
    {
        private readonly RequerenteRepositorio requerenteRepositorio;

        public RequerenteNegocio()
        {
            requerenteRepositorio = new RequerenteRepositorio();
        }

        public void InserirReqeurente(Requerente requerente)
        {
            requerenteRepositorio.Adicionar(requerente);
        }

        public List<Requerente> ListarTodosRequerente()
        {
            return requerenteRepositorio.ObterTodos();
        }

        public void DeletarRequerente(int idRequerente)
        {
            requerenteRepositorio.Deletar(idRequerente);
        }

        public void AlterarReqeurente(Requerente requerente)
        {
            requerenteRepositorio.Atualizar(requerente);
        }

        public Requerente Buscar(int id)
        {
            return requerenteRepositorio.Buscar(id, id);
        }
    }
}
