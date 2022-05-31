using Microsoft.AspNetCore.Mvc;
using SistemaControleAdvocaticio.Apresentacao.ViewModel;
using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Servico;
using System.Linq;

namespace SistemaControleAdvocaticio.Apresentacao.Controllers
{
    public class ProcessoController : Controller
    {
        private readonly IServicoProcesso _servicoProcesso;

        public ProcessoController(IServicoProcesso servicoProcesso)
        {
            _servicoProcesso = servicoProcesso;
        }

        
        [HttpGet]
        public IActionResult Inserir()
        {
            ProcessoViewModel processoViewModel = new ProcessoViewModel();
            return View(processoViewModel);
        }

        [HttpGet]
        public IActionResult Editar(int codigo)
        {
            ProcessoViewModel processoViewModel = new ProcessoViewModel();
            //processoViewModel.Cliente = new Cliente();
            Processo processo = new Processo();
            //processo.Cliente = new Cliente();
            processo = _servicoProcesso.PesquisaPorCodigo(codigo); 
           
            if (processo != null && processo.Codigo > 0)
            {
                processoViewModel.Codigo = processo.Codigo;
                processoViewModel.clientecodigo = processo.clientecodigo;
                
            }
            return View(processoViewModel);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            ProcessoViewModel processoViewModel = new ProcessoViewModel();
            //processoViewModel.Cliente = new Cliente();
            processoViewModel.ListaProcesso = _servicoProcesso.Listar().ToList();
            return View(processoViewModel);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            ProcessoViewModel processoViewModel = new ProcessoViewModel();
            //processoViewModel.Cliente = new Cliente();
            Processo processo = new Processo();
            //processo.Cliente = new Cliente();
            processo = _servicoProcesso.PesquisaPorCodigo(id); 
            
            if (processo != null && processo.Codigo > 0)
            {
                processoViewModel.Codigo = processo.Codigo;
                processoViewModel.clientecodigo = processo.clientecodigo;

            }
            return View(processoViewModel);
        }

        [HttpPost]
        public IActionResult Inserir(ProcessoViewModel processoViewModel)
        {
            
            Processo processo = new Processo();
            //processo.Cliente = new Cliente();

            if (!ModelState.IsValid)
            {
                return View(processoViewModel);
            }
            else
            {
                processo.Codigo = processoViewModel.Codigo;
                processo.clientecodigo = processoViewModel.clientecodigo;
                _servicoProcesso.Adicionar(processo);

                return RedirectToAction("Listar");
            }
        }

        [HttpPost]
        public IActionResult Editar(ProcessoViewModel processoViewModel)
        {
            Processo processo = new Processo();
            //processo.Cliente = new Cliente();

            if (!ModelState.IsValid)
            {
                return View(processoViewModel);
            }
            else
            {
                processo = _servicoProcesso.PesquisaPorCodigo(processoViewModel.Codigo);
                
                if (processo != null && processo.Codigo > 0)
                {
                    processo.Codigo = processoViewModel.Codigo;
                    processo.clientecodigo = processoViewModel.clientecodigo;

                    _servicoProcesso.Atualizar(processo);
                }
                return RedirectToAction("Listar");
            }
        }

        [HttpPost]
        public IActionResult Deletar(ProcessoViewModel processoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(processoViewModel);
            }
            else
            {
                Processo processo = _servicoProcesso.PesquisaPorCodigo(processoViewModel.Codigo);
                
                if (processo != null && processo.Codigo > 0)
                {
                    _servicoProcesso.Deletar(processo);
                }
                return RedirectToAction("Listar");
            }
        }

    }
}
