using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Infraestruture.Repositorio;
using ProjetoAPIEstudo.Entidade.Entidade;

namespace ProjetoAPIEstudo.Servico.Negocio
{
    public class ClienteNegocio
    {
        private readonly ClienteRepositorio clienteRepositorio;

        public ClienteNegocio()
        {
            clienteRepositorio = new ClienteRepositorio();
        }

        public void InserirCliente(Cliente cliente)
        {
            clienteRepositorio.Adicionar(cliente);
        }

        public List<Cliente> ListarTodosClientes()
        {
            return clienteRepositorio.ObterTodos();
        }

        public void DeletarCliente(int idCliente)
        {
            clienteRepositorio.Deletar(idCliente);
        }

        public void AlterarCliente(Cliente cliente)
        {
            clienteRepositorio.Atualizar(cliente);
        }

        public Cliente BuscarCliente(int id)
        {
            return clienteRepositorio.Buscar(id, id);
        }
    }
}
