using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaControleAdvocaticio.Apresentacao.Models;
using SistemaControleAdvocaticio.Apresentacao.ViewModel;
using SistemaControleAdvocaticio.Dominio.Entidades;
using SistemaControleAdvocaticio.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaControleAdvocaticio.Apresentacao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicoUsuario _servicoUsuario;

        public HomeController(ILogger<HomeController> logger, IServicoUsuario servicoUsuario)
        {
            _logger = logger;
            _servicoUsuario = servicoUsuario;
        }



        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult EsqueceuSenha()
        {
            return View();
        }

        public IActionResult CriarConta()
        {
            return View();
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpPost]
        public IActionResult Login(HomeViewModel homeViewModel)
        {
            if (!ModelState.IsValid)
            {
                //return View(homeViewModel);
                return RedirectToAction("Index");
            }

            List<Usuario> usuarios = _servicoUsuario.Listar().ToList();
            Usuario usuarioLogado = usuarios.Where(u => u.Login.ToUpper().Equals(homeViewModel.Login.Trim().ToUpper()) && u.Senha.ToUpper().Equals(homeViewModel.Senha.Trim().ToUpper())).FirstOrDefault();
            if (usuarioLogado != null && usuarioLogado.Codigo > 0){
                return RedirectToAction("Index");
            }
            else
            {
                return View(homeViewModel);
            }
        }

        [HttpPost]
        public IActionResult EsqueceuSenha(HomeViewModel homeViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(homeViewModel);
            }

            return View();
        }

        [HttpPost]
        public IActionResult CriarConta(HomeViewModel homeViewModel)
        {
            return View(homeViewModel);
        }

    }
}
