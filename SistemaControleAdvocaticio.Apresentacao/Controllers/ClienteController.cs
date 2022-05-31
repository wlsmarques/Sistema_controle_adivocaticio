using Microsoft.AspNetCore.Mvc;
using SistemaControleAdvocaticio.Apresentacao.ViewModel;
using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Servico;
using System.Linq;

namespace SistemaControleAdvocaticio.Apresentacao.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IServicoCliente _servicoCliente;

        public ClienteController(IServicoCliente servicoCliente)
        {
            _servicoCliente = servicoCliente;
        }

        [HttpGet]
        public IActionResult Inserir()
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel();
            return View(clienteViewModel);
        }

        [HttpGet]
        public IActionResult Editar(int codigo)
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel();
            Cliente cliente = _servicoCliente.PesquisaPorCodigo(codigo);
            
            if (cliente != null && cliente.Codigo > 0)
            {
                clienteViewModel.Codigo = cliente.Codigo;
                clienteViewModel.Cpf = cliente.Cpf;
                clienteViewModel.Nome = cliente.Nome;
                clienteViewModel.Endereco = cliente.Endereco;
            }
            return View(clienteViewModel);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel();
            clienteViewModel.ListaCliente = _servicoCliente.Listar().ToList();
            return View(clienteViewModel);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            ClienteViewModel clienteViewModel = new ClienteViewModel();
            Cliente cliente = _servicoCliente.PesquisaPorCodigo(id);
            if (cliente != null && cliente.Codigo > 0)
            {
                clienteViewModel.Codigo = cliente.Codigo;
                clienteViewModel.Cpf = cliente.Cpf;
                clienteViewModel.Nome = cliente.Nome;
                clienteViewModel.Endereco = cliente.Endereco;
            }
            return View(clienteViewModel);
        }

        [HttpPost]
        public IActionResult Inserir(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }
            else
            {
                Cliente cliente = _servicoCliente.PesquisarPorCpf(clienteViewModel.Cpf);
                if (cliente == null)
                {


                    _servicoCliente.Adicionar(new Cliente()
                    {
                        Cpf = clienteViewModel.Cpf,
                        Nome = clienteViewModel.Nome,
                        Endereco = clienteViewModel.Endereco
                    });
                }
                //return View(clienteViewModel);
                return RedirectToAction("Listar");
            }
        }

        [HttpPost]
        public IActionResult Editar(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }
            else
            {
                //Cliente cliente = _servicoCliente.PesquisaPorCodigo(clienteViewModel.Codigo);
                Cliente cliente = _servicoCliente.PesquisarPorCpf(clienteViewModel.Cpf);
                if (cliente != null && cliente.Codigo > 0)
                {
                    cliente.Cpf = clienteViewModel.Cpf;
                    cliente.Nome = clienteViewModel.Nome;
                    cliente.Endereco = clienteViewModel.Endereco;
                    _servicoCliente.Atualizar(cliente);
                }
                //return View(clienteViewModel);
                return RedirectToAction("Listar");
            }
        }

        [HttpPost]
        public IActionResult Deletar(ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }
            else
            {
                Cliente cliente = _servicoCliente.PesquisaPorCodigo(clienteViewModel.Codigo);
                if(cliente == null)
                {
                    cliente = _servicoCliente.PesquisarPorCpf(clienteViewModel.Cpf);
                }
                if (cliente != null && cliente.Codigo > 0)
                {
                    _servicoCliente.Deletar(cliente);
                }
                //return View(clienteViewModel);
                return RedirectToAction("Listar");
            }
        }
    }
}
