using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SondaIT.SisAmigos.UI.Mvc.Models;

namespace SondaIT.SisAmigos.UI.Mvc.Controllers
{
    public class AmigosController : Controller
    {
        
        
        #region Metodos Get
        // GET: Amigos
        public ActionResult Index()
        {
            return View();
        }

        // POR PADRÃO A ACTION É DO TIPO GET
        [HttpGet]
        public ActionResult Listagem()
        {
            // CRIAMOS UM BLOCO TYR CATCH PARA CASO HAJA ALGUM ERRO EM
            // TEMPO DE EXECUÇÃ, SEJA LANÇADA UMA exeption (ERRO)
            // PARA O USUARIO
            try
            {

                // AQUI FIZEMOS A INSTANCIA DA CLASSE DE CONEXÃO
                // E CRIAMOS O OBJETO CHAMADO context
                var context = new Conexao.AmigosContext();

                // ESSA VARIAVEL query IRÁ RECEBER UMA LISTA DE REGISTROS
                // EXISTENTES NA TABELA DE AMIGOS

                var query = (from p in context.Amigos
                    select p);

                // PARA ENVIARMOS OS DADOS VARIAVEL    query PARA A VIEW
                // DE FORMA MAIS ELEGANTE, DEIXAMOS A NOSSA VIEW FORTEMENTE
                // TIPADA, ISSO SE DA NO RETORNO DOS DADOS return View(query)
                // OU SEJA NOSSA VIEW TIPADA É DO TIPO LIST
                return View(query);
            }
            catch (Exception ex)
            {
                // LANÇANDO UMA MSG DE eception PARA O USUARIO
                throw new ApplicationException(ex.Message);
            }
        }

        public ActionResult Filtrar(string nome)
        {
            try
            {
                // CRIANDO INSTANIA DA CLASSE  DE CONEXAO
                var _conexao = new Conexao.AmigosContext();

                // Contains() equivalente ao like SQL
                var query = (from p in _conexao.Amigos
                    where p.NOME.Contains(nome)
                    select p);
                // A VIEWBAG SERVE PARA PERSISTIR INFORMAÇÕES ENTRE
                // O CONTROLLER E A VIEW
                ViewBag.Alerta = "Nenhum Registro Foi Encontrado";

                // APÓS RECEBERMOS OS DADOS NAVARIAVEL QUERY, RETORNAMOS
                // PARA VIEW DE LISTAGEM , E PASSAMOS OS DADOS RETORNADOS TBM
                return View("Listagem", query);
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException(ex.Message);
            }
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        // UTILIZAMOS O RECURSO DO CODE SNAPT PARA CRIAR 
        // A NOSSA ACTION, mvcaction4 + TAB  TAB
        public ActionResult Editar(int ID)
        {
            try
            {
                // INSTANCIA DA CLASSE DE ACESSO A DADOS
                var context = new Conexao.AmigosContext();

                var query = (from p in context.Amigos
                    where p.ID == ID
                    select p).SingleOrDefault();

                return View(query);
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException(ex.Message);
            }
        }

        #endregion

        #region Metodos Post
        [HttpPost]
        public ActionResult Insert(AmigosModel novoRegistro )
        {

            try
            {
                // INSTANCIA DA CLASSE DE ACESSO A DADOS
                var context = new Conexao.AmigosContext();

                // INDO NO BANCO DA DADOS NA TABELA DE AMIGOS E ADICIONANDO
                // UM NOVO REGISTRO
                context.Amigos.Add(novoRegistro);

                // COMO O ENTITY FRAMEWORK NÃO É AUTO COMMIT
                // USAMOS O METODO SaveChanges PARA CONFIRMAR A OPERAÇÃO
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                
                throw new ApplicationException(ex.Message);
            }
            return RedirectToAction("Listagem");
        }

        [HttpPost]
        public ActionResult Delete(AmigosModel registro)
        {
            try
            {
                // INSTANCIA DA CLASSE DE CONEXÃO
                var context = new Conexao.AmigosContext();
                
                // AQUI VERIFICAMOS SE FOI PASADO UM ID PARA EXLUSAO
                if (registro.ID == 0)
                {
                    throw new ApplicationException("É Necessario informar o ID do amigo");
                }
                else
                {

                    // ATRAVEZDO PARAMETRO VINDO DA ACTION
                    // FILTRAMOS O REGISTRO A SER DELETADO E INFORMAMOS AO BANCO
                    // DE DADOS QUE IREMOS NA TABELA DE AMIGOS E IREMOS REMOVER O OBJETO
                    // CHAMADO ecluirRegistro, E FAZESMOS O COMMIT E REFIRECIONAMOS PARA A VIEW DE LISTAGEM
                    var excluiRregistro = (from p in context.Amigos
                        where p.ID == registro.ID
                        select p).SingleOrDefault();
                    context.Amigos.Remove(excluiRregistro);
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
        public ActionResult Update(AmigosModel atualizaRegistro)
        {
            try
            {
                var context = new Conexao.AmigosContext();
                context.Entry<AmigosModel>(atualizaRegistro).State = System.Data.Entity.EntityState.Modified;
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