using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Infraestruture.Repositorio;
using ProjetoAPIEstudo.Entidade.Entidade;

namespace ProjetoAPIEstudo.Servico.Negocio
{
    public class VeiculoNegocio 
    {
        private readonly VeiculoRepositorio veiculoRepositorio;

        public VeiculoNegocio()
        {
            veiculoRepositorio = new VeiculoRepositorio();
        }

        public void InserirVeiculo(Veiculo veiculo)
        {
            veiculoRepositorio.Adicionar(veiculo);
        }

        public List<Veiculo> ListarTodosVeiculos()
        {
            return veiculoRepositorio.ObterTodos();
        }

        public void Deletar(int idVeiculo)
        {
            veiculoRepositorio.Deletar(idVeiculo);
        }

        public void AlterarVeiculo(Veiculo veiculo)
        {
            veiculoRepositorio.Atualizar(veiculo);
        }

        public Veiculo Buscar(int id)
        {
            return veiculoRepositorio.Buscar(id, id);
        }
    }
}
