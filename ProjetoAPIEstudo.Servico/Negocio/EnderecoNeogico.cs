using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Infraestruture.Repositorio;
using ProjetoAPIEstudo.Entidade.Entidade;

namespace ProjetoAPIEstudo.Servico.Negocio
{
    public class EnderecoNeogico
    {
        private readonly EnderecoRepositorio enderecoRepositorio;

        public EnderecoNeogico()
        {
            enderecoRepositorio = new EnderecoRepositorio();
        }

        public void InserirEndereco(Endereco endereco)
        {
            enderecoRepositorio.Adicionar(endereco);
        }

        public List<Endereco> ListarTodosEndereco()
        {
            return enderecoRepositorio.ObterTodos();
        }

        public void Deletar(int idEndereco)
        {
            enderecoRepositorio.Deletar(idEndereco);
        }

        public void AlterarEndereco(Endereco endereco)
        {
            enderecoRepositorio.Atualizar(endereco);
        }

        public Endereco Buscar(int id)
        {
            return enderecoRepositorio.Buscar(id, id);
        }
    }
}
