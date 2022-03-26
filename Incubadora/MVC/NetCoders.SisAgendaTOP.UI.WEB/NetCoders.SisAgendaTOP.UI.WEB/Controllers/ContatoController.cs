using NetCoders.SisAgendaTOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetCoders.SisAgendaTOP.Repository;
using System.Web.Security;

namespace NetCoders.SisAgendaTOP.UI.WEB.Controllers
{
    public class ContatoController : Controller
    {

        private ContatoREP banco = new ContatoREP();

        private void CarregarSexos()
        {
            var sexoRepositorio = new SexoREP();

            ViewBag.Sexos = new SelectList(sexoRepositorio.Listar(),
                                              "Codigo",
                                              "Descricao");
        }

        [Authorize]
        public ActionResult Cadastrar()
        {
            CarregarSexos();

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(ContatoMOD dadosTela)
        {
            banco.Cadastrar(dadosTela);

            TempData.Add("Mensagem", "Cadastrado com sucesso!");

            return RedirectToAction("Listar");
        }

        [Authorize]
        public ActionResult Listar()
        {
            var contatos = banco.Listar();

            return View(contatos);
        }

        public ActionResult Editar(Int32 id)
        {
            CarregarSexos();

            var contato = banco.PesquisarPorCodigo(id);

            return View(contato);
        }

        [HttpPost]
        public ActionResult Editar(ContatoMOD dadosTela, Int32 id)
        {
            try
            {
                dadosTela.Codigo = id;

                banco.Atualizar(dadosTela);

                TempData.Add("Mensagem", "Cadastro atualizado com sucesso!");

                return RedirectToAction("Listar");
            }
            catch (Exception)
            {
                TempData.Add("Mensagem", "Erro ao atualizar!");

                CarregarSexos();

                return View();
            }
        }

        public ActionResult Deletar(Int32 id)
        {
            banco.Deletar(id);

            TempData.Add("Mensagem", "Contato excluido com sucesso!");

            return RedirectToAction("Listar");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UsuarioMOD dadosTela)
        {
            var repositorio = new LoginREP();

            if (!repositorio.ValidarLogin(dadosTela))
            {
                TempData.Add("Mensagem", "Usuario ou Senha Inválidos");

                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(dadosTela.Nome, true);

                return RedirectToAction("Listar");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }
    }
}