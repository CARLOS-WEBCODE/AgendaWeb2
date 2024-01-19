using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Infra.Data.Interfaces;
using AgendaWeb.Infra.Data.Utils;
using AgendaWeb.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers
{
    public class AccountController : Controller
    {
        //atributo
        private readonly IUsuarioRepository _usuarioRepository;

        //construtor para inicialização do atributo
        public AccountController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountLoginViewModel model)
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //verificar se o email informado 
                    //já está cadastrado no banco de dados
                    if (_usuarioRepository.GetByEmail(model.Email) != null)
                    {
                        TempData["MensagemErro"] = $"O email informado já está cadastrado.Tente outro.";
                    }
                    else
                    {
                        var usuario = new Usuario();

                        usuario.Id = Guid.NewGuid();
                        usuario.Nome = model.Nome;
                        usuario.Email = model.Email;
                        usuario.Senha = CriptografiaUtil.GetMD5(model.Senha);
                        usuario.DataInclusao = DateTime.Now;

                        _usuarioRepository.Create(usuario); //cadastrando o usuário

                        TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso!";

                        ModelState.Clear(); //limpar os campos do formulário
                    }
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = e.Message;
                }
            }
            return View();
        }
    }
}
