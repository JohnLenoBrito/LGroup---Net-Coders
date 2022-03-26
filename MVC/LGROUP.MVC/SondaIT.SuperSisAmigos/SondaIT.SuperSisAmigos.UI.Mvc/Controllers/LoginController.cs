using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SondaIT.SuperSisAmigos.Repository.Repositories;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.UI.Mvc.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        #region [METODOS GET]
        public ActionResult Home()
        {
            return View();
        }      
        
        // mvcaction4 PARA CRIAR UMA ACTION DO TIPO GET 
        public ActionResult Login()
        {
            return View();
        }
        #endregion

        #region [METODOS POST]
        [HttpPost]
        public ActionResult Autentication(LoginModel entity)
        {
            // FIZEMOS UMA INSTANCIA DA CLASSE REPOSITORY PARA UTILIZARMOS O METODO DE AUTENTICACAO           
            var repository = new LoginRepository();

            // VARIVAEL QUE IRÁ RECEBER O RETORNO VINDO DA VASE DE DADS
            var query = repository.Autentication(entity);
            
            // ESTAMOS VERIFICANDO SE O RETORNO DA QUERY TEM 0 USUARIOS
            if (query.Count() == 0)
            {
                // ENVIANDO UMA MENSAGEM PARA A VIEW UTILIZANDO A ViewBag
                ViewBag.Information = "Usuario ou Senha Inválidos";
                
                // RETORNANDO PARA A VIEW DE LOGIN
                return View("Login");
           
            }
            else
            {
                // SE O RETORNO DA QUERY FOR MAIOR QUE ZERO ENTÃO REDIRECIONAMOS PARA A ACTION HOME
                return RedirectToAction("Home");
            }
            
        }

        #endregion

     
    }
}
