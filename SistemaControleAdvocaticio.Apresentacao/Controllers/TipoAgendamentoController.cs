using Microsoft.AspNetCore.Mvc;
using SistemaControleAdvocaticio.Apresentacao.ViewModel;
using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Servico;
using System.Linq;

namespace SistemaControleAdvocaticio.Apresentacao.Controllers
{
    public class TipoAgendamentoController : Controller
    {

        private readonly IServicoTipoAgendamento _servicoTipoAgendamento;

        public TipoAgendamentoController(IServicoTipoAgendamento servicoTipoAgendamento)
        {
            _servicoTipoAgendamento = servicoTipoAgendamento;
        }



        [HttpGet]
        public IActionResult Inserir()
        {
            TipoAgendamentoViewModel tipoAgendamentoViewModel = new TipoAgendamentoViewModel();
            return View(tipoAgendamentoViewModel);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            TipoAgendamentoViewModel tipoAgendamentoViewModel = new TipoAgendamentoViewModel();
            TipoAgendamento tipoAgendamento = _servicoTipoAgendamento.PesquisaPorCodigo(id);
            if (tipoAgendamento != null && tipoAgendamento.Codigo > 0)
            {
                tipoAgendamentoViewModel.Codigo = tipoAgendamento.Codigo;
                tipoAgendamentoViewModel.Descricao = tipoAgendamento.Descricao;
            }
            return View(tipoAgendamentoViewModel);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            TipoAgendamentoViewModel tipoAgendamentoViewModel = new TipoAgendamentoViewModel();
            tipoAgendamentoViewModel.ListaTipoAgendamento = _servicoTipoAgendamento.Listar().ToList();
            return View(tipoAgendamentoViewModel);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            TipoAgendamentoViewModel tipoAgendamentoViewModel = new TipoAgendamentoViewModel();
            TipoAgendamento tipoAgendamento = _servicoTipoAgendamento.PesquisaPorCodigo(id);
            
            if (tipoAgendamento != null && tipoAgendamento.Codigo > 0)
            {
                tipoAgendamentoViewModel.Codigo = tipoAgendamento.Codigo;
                tipoAgendamentoViewModel.Descricao = tipoAgendamento.Descricao;
                
            }
            return View(tipoAgendamentoViewModel);
        }



        [HttpPost]
        public IActionResult Inserir(TipoAgendamentoViewModel tipoAgendamentoViewModel)
        {
            if (!ModelState.IsValid)
            {
                //return View(tipoAgendamentoViewModel);
            }
            else
            {
                _servicoTipoAgendamento.Adicionar(new TipoAgendamento() { Descricao = tipoAgendamentoViewModel.Descricao });
                //return View(tipoAgendamentoViewModel);
            }
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Editar(TipoAgendamentoViewModel tipoAgendamentoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(tipoAgendamentoViewModel);
            }
            else
            {
                TipoAgendamento tipoAgendamento = _servicoTipoAgendamento.PesquisaPorCodigo(tipoAgendamentoViewModel.Codigo);
                if (tipoAgendamento != null && tipoAgendamento.Codigo > 0)
                {
                    tipoAgendamento.Codigo = tipoAgendamentoViewModel.Codigo;
                    tipoAgendamento.Descricao = tipoAgendamentoViewModel.Descricao;
                    _servicoTipoAgendamento.Atualizar(tipoAgendamento);
                }
                return RedirectToAction("Listar");
            }
        }

        [HttpPost]
        public IActionResult Deletar(TipoAgendamentoViewModel tipoAgendamentoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                TipoAgendamento tipoAgendamento = _servicoTipoAgendamento.PesquisaPorCodigo(tipoAgendamentoViewModel.Codigo);
                if (tipoAgendamento != null && tipoAgendamento.Codigo > 0)
                {
                    tipoAgendamento.Codigo = tipoAgendamentoViewModel.Codigo;
                    tipoAgendamento.Descricao = tipoAgendamentoViewModel.Descricao;

                    _servicoTipoAgendamento.Deletar(tipoAgendamento);
                }
                return RedirectToAction("Listar");
            }
        }

    }
}
