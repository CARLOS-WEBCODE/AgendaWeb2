using AgendaWeb.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers
{
    public class AgendaController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //Annotation indica que o método será executado no SUBMIT
        public IActionResult Cadastro(EventoCadastoViewModel model)
        {
            //verificar se todos os campos passaram nas regras de validação
            if(ModelState.IsValid)
            {

            }

            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }

        public IActionResult Edicao()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }
    }
}
