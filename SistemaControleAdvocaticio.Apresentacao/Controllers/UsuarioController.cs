using Microsoft.AspNetCore.Mvc;
using SistemaControleAdvocaticio.Apresentacao.ViewModel;
using SistemaControleAdvocaticio.Dados;

namespace SistemaControleAdvocaticio.Apresentacao.Controllers
{
    public class UsuarioController : Controller
    {
        

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(UsuarioViewModel usuarioViewModel)
        {

            return View();
        }

    }
}
