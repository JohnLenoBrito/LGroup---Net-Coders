using Sonda.SisAmigos.UI.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sonda.SisAmigos.UI.Mvc.Controllers
{
    public class AmigosController : Controller
    {
        #region Metodos Get
        // GET: Amigos
        public ActionResult Index()
        {
            return View();
        }

        //Por padrão a Action é do tipo GET
        [HttpGet]
        public ActionResult Listagem()
        {
            //Criamos um bloco try catch para caso haja algum erro em tempo de execução, seja lançada uma Exception (Erro) para o usuario
            try
            {
                //Aqui fizemos a instancia da classe de conexão e criamos o objeto chamado context
                var context = new Conexao.AmigosContext();

                //Essa variavel query ira receber uma lista de registros existentes na tabela de amigos
                var query = (from x in context.Amigos select x);

                //Para enviarmos os dados da variavel query para a view de forma mais elegante, deixamos a nossa view fortemente
                //tipada, isso se da no retorno dos dados return View(query) ou seja nossa  view tipada é do tipo list
                return View(query);
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }

        public ActionResult Filtrar(string nome)
        {
            try
            {
                //Criando instancia da classe de conexão
                var conexao = new Conexao.AmigosContext();

                var query = (from x in conexao.Amigos
                             //Contains equivale o like sql
                             where x.Nome.Contains(nome)
                             select x);

                //A ViewBag server para persistir informações entre o controller e a view
                ViewBag.Alerta = "Nenhum registro foi encontrado!!!";

                //Após recebermos os dados na varavel query, retornamos para a view de Listagem, e passamos os dados retornados tbm
                return View("Listagem", query);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public ActionResult Adicionar()
        {
            return View();
        }

        //Utilizamos o recurso do Code Snapt para criar a nossa Action, mvcaction4 + tab tab
        public ActionResult Editar(int ID)
        {
            try
            {
                //Istancia da classe de conexao
                var context = new Conexao.AmigosContext();

                //de acordo com o ID passado por parametro pela view de listagem iremos fazer uma consulta no banco de dados
                //para retornar o registro informado
                AmigosModel query = (from x in context.Amigos
                             where x.ID == ID
                             select x).SingleOrDefault();

                //Aqui retornamos uma view tipada (do tipo AmigosModel)
                return View(query);
            }
            catch (Exception ex)
            {

                throw new NotImplementedException();
            }
            
        }

  
        #endregion

        #region Metodos post
        [HttpPost]
        public ActionResult Insert(AmigosModel novoRegistro)
        {
            try
            {
                //Instancia da classe de acesso a dados
                var context = new Conexao.AmigosContext();

                //Indo no banco de dados, na tabela de amigos e adicionando um novo registro
                context.Amigos.Add(novoRegistro);

                //como o EF não é auto commit, usamos o método SaveChanges para confirmar a operação
                context.SaveChanges();

                return RedirectToAction("Listagem");
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Delete(AmigosModel excluirRegistro)
        {
            try
            {
                //Instancia da classe de conexão
                var context = new Conexao.AmigosContext();

                //Aqui estamos verificando se foi passado um ID para exclusão
                if (excluirRegistro.ID == 0)
                    throw new ApplicationException("É necessário informar o ID do Amigo");
                else
                {
                    //Através do parametro vindo da action, filtramos o registro a ser deletado e informamos ao banco de dados
                    //que iremos na tb de amigo e iremos remover o objeto chamado registroDeletado, e fazemos o commit e redirecionamos
                    //para a view
                    var registroDeletado = (from x in context.Amigos
                                            where x.ID == excluirRegistro.ID
                                            select x).SingleOrDefault();
                    context.Amigos.Remove(registroDeletado);
                    context.SaveChanges();
                    return RedirectToAction("Listagem");
                }
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Update(AmigosModel atualizarRegistro)
        {
            try
            {
                var context = new Conexao.AmigosContext();

                context.Entry<AmigosModel>(atualizarRegistro).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();

                return RedirectToAction("Listagem");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        #endregion
    }
}