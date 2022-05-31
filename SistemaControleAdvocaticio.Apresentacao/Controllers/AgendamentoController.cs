using Microsoft.AspNetCore.Mvc;
using SistemaControleAdvocaticio.Apresentacao.ViewModel;
using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Servico;
using System.Linq;

namespace SistemaControleAdvocaticio.Apresentacao.Controllers
{
    public class AgendamentoController : Controller
    {
        private readonly IServicoAgendamento _servicoAgendamento;

        public AgendamentoController(IServicoAgendamento servicoAgendamento)
        {
            _servicoAgendamento = servicoAgendamento;
        }

        
        [HttpGet]
        public IActionResult Inserir()
        {
            AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel();
            return View(agendamentoViewModel);
        }

        [HttpGet]
        public IActionResult Editar(int codigo)
        {
            AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel();
            Agendamento agendamento = new Agendamento();
            agendamento = _servicoAgendamento.PesquisaPorCodigo(codigo); 
           
            if (agendamento != null && agendamento.Codigo > 0)
            {
                agendamentoViewModel.Codigo = agendamento.Codigo;
                agendamentoViewModel.ClienteCodigo = agendamento.ClienteCodigo;
                agendamentoViewModel.ProcessoCodigo = agendamento.ProcessoCodigo;
                agendamentoViewModel.TipoAgendamentoCodigo = agendamento.TipoAgendamentoCodigo;
                agendamentoViewModel.DataAgendamento = agendamento.DataAgendamento;
                

            }
            return View(agendamentoViewModel);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel();
            agendamentoViewModel.ListaAgendamento = _servicoAgendamento.Listar().ToList();
            return View(agendamentoViewModel);
        }

        [HttpGet]
        public IActionResult Deletar(int id)
        {
            AgendamentoViewModel agendamentoViewModel = new AgendamentoViewModel();
            Agendamento agendamento = new Agendamento();
            agendamento = _servicoAgendamento.PesquisaPorCodigo(id); 
            
            if (agendamento != null && agendamento.Codigo > 0)
            {
                agendamentoViewModel.Codigo = agendamento.Codigo;
                agendamentoViewModel.ClienteCodigo = agendamento.ClienteCodigo;
                agendamentoViewModel.ProcessoCodigo = agendamento.ProcessoCodigo;
                agendamentoViewModel.TipoAgendamentoCodigo = agendamento.TipoAgendamentoCodigo;
                agendamentoViewModel.DataAgendamento = agendamento.DataAgendamento;

            }
            return View(agendamentoViewModel);
        }

        [HttpPost]
        public IActionResult Inserir(AgendamentoViewModel agendamentoViewModel)
        {

            Agendamento agendamento = new Agendamento();
            
            if (!ModelState.IsValid)
            {
                return View(agendamentoViewModel);
            }
            else
            {
                agendamento.Codigo = agendamentoViewModel.Codigo;
                agendamento.ClienteCodigo = agendamentoViewModel.ClienteCodigo;
                agendamento.ProcessoCodigo = agendamentoViewModel.ProcessoCodigo;
                agendamento.TipoAgendamentoCodigo = agendamentoViewModel.TipoAgendamentoCodigo;
                agendamento.DataAgendamento = agendamentoViewModel.DataAgendamento;
                _servicoAgendamento.Adicionar(agendamento);

                return RedirectToAction("Listar");
            }
        }

        [HttpPost]
        public IActionResult Editar(AgendamentoViewModel agendamentoViewModel)
        {
            Agendamento agendamento = new Agendamento();
            
            if (!ModelState.IsValid)
            {
                return View(agendamentoViewModel);
            }
            else
            {
                agendamento = _servicoAgendamento.PesquisaPorCodigo(agendamentoViewModel.Codigo);
                
                if (agendamento != null && agendamento.Codigo > 0)
                {
                    agendamento.Codigo = agendamentoViewModel.Codigo;
                    agendamento.ClienteCodigo = agendamentoViewModel.ClienteCodigo;
                    agendamento.ProcessoCodigo = agendamentoViewModel.ProcessoCodigo;
                    agendamento.TipoAgendamentoCodigo = agendamentoViewModel.TipoAgendamentoCodigo;
                    agendamento.DataAgendamento = agendamentoViewModel.DataAgendamento;

                    _servicoAgendamento.Atualizar(agendamento);
                }
                return RedirectToAction("Listar");
            }
        }

        [HttpPost]
        public IActionResult Deletar(AgendamentoViewModel agendamentoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(agendamentoViewModel);
            }
            else
            {
                Agendamento agendamento = _servicoAgendamento.PesquisaPorCodigo(agendamentoViewModel.Codigo);
                
                if (agendamento != null && agendamento.Codigo > 0)
                {
                    _servicoAgendamento.Deletar(agendamento);
                }
                return RedirectToAction("Listar");
            }
        }

    }
}
