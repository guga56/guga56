using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Entidade.Entidade;
using ProjetoAPIEstudo.Servico.Negocio;

namespace ProjetoAPIEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorController : ControllerBase
    {
        private readonly ClienteNegocio clienteNegocio;
        private readonly EnderecoNeogico enderecoNeogico;
        private readonly RequerenteNegocio requerenteNegocio;
        private readonly VeiculoNegocio veiculoNegocio;

        public ControladorController()
        {
            clienteNegocio = new ClienteNegocio();
            enderecoNeogico = new EnderecoNeogico();
            requerenteNegocio = new RequerenteNegocio();
            veiculoNegocio = new VeiculoNegocio();
        }

        #region Salvar Cliente
        [EnableCors("MyAllowSpecificOrigims")]
        [HttpPost("InserirCliente")]
        public IActionResult SalvarCliente(Cliente cliente)
        {
            try
            {
                clienteNegocio.InserirCliente(cliente);

                return new JsonResult(cliente);
            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion



        #region Listar Cliente
        [EnableCors("MyAllowSpecificOrigims")]
        [HttpGet("ListarTodosClientes")]
        public ICollection<Cliente> ListarTodosClientes()
        {
            try
            {
                var lista = clienteNegocio.ListarTodosClientes();
                return lista;
            }
            catch(Exception)
            {
                throw;
            }
        }
        #endregion

        #region Salvar Endereco

        [EnableCors("MyAllowSpecificOrigims")]
        [HttpPost("InserirEndereco")]
        public IActionResult SalvarEndereco(Endereco endereco)
        {
            try
            {
                enderecoNeogico.InserirEndereco(endereco);

                return new JsonResult(endereco);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Listar Endereco
        [EnableCors("MyAllowSpecificOrigims")]
        [HttpGet("ListarTodosEnderecos")]
        public ICollection<Endereco> ListarTodosEnderecos()
        {
            try
            {
                var lista = enderecoNeogico.ListarTodosEndereco();
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Salvar Endereco

        [EnableCors("MyAllowSpecificOrigims")]
        [HttpPost("InserirVeiculo")]
        public IActionResult SalvarVeiculo(Veiculo veiculo)
        {
            try
            {
                veiculoNegocio.InserirVeiculo(veiculo);

                return new JsonResult(veiculo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Listar Veiculo
        [EnableCors("MyAllowSpecificOrigims")]
        [HttpGet("ListarTodosVeiculo")]
        public ICollection<Veiculo> ListarTodosVeiculos()
        {
            try
            {
                var lista = veiculoNegocio.ListarTodosVeiculos();
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Salvar Requerente

        [EnableCors("MyAllowSpecificOrigims")]
        [HttpPost("InserirRequerente")]
        public IActionResult SalvarRequerente(Requerente requerente)
        {
            try
            {
                requerenteNegocio.InserirReqeurente(requerente);

                return new JsonResult(requerente);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Listar Requerente
        [EnableCors("MyAllowSpecificOrigims")]
        [HttpGet("ListarTodosRequerente")]
        public ICollection<Requerente> ListarTodosReqeurentes()
        {
            try
            {
                var lista = requerenteNegocio.ListarTodosRequerente();
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

    }
}
