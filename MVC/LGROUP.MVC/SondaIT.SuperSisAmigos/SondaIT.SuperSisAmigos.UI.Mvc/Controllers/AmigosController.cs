using SondaIT.SuperSisAmigos.DomainModel.Models;
using SondaIT.SuperSisAmigos.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SondaIT.SuperSisAmigos.UI.Mvc.Controllers
{
    public class AmigosController : Controller
    {
        //
        // GET: /Amigos/

  
        #region [METODOS GET]
        public ActionResult Listar()
        {
            var _repository = new AmigosRepository();
            var geral =_repository.GetAll();
            
            return View(geral);
        }

        public ActionResult Adicionar()
        {

            PreencherEstadoCivil();
            PreencherSexo();
            return View();
        }

        public ActionResult Editar(int id)
        {
            
            PreencherEstadoCivil();
            PreencherSexo();
            var _repository = new AmigosRepository();
            var query = _repository.Find(id);

            return View(query);
        }
        public ActionResult Deletar(AmigosModel entity)
        {
            var _repository = new AmigosRepository();
            var query = _repository.Find(entity.ID);
            _repository.Delete(query);

            return RedirectToAction("Listar");
        }
        #endregion

        #region [METODOS POST]
        [HttpPost]
        public ActionResult Adicionar(AmigosModel entity)
        {
            //INSTANCIA PARA O REPOSITORIO
            var _repository = new AmigosRepository();
            // CHAMANDO O METODO ADD E PASSANDO OS DADOS DO MODELO  COMO PARAMETRO
            _repository.Add(entity);

            // APOS ADICIONAR REDIRECIONAMOS PARA ACTION LISTAR
            return RedirectToAction("Listar");

        }


        [HttpPost]
        public void PreencherSexo()
        {
            var _repositorySexo = new SexoRepository();

            var listaSexo = new List<SexoModel>();

            listaSexo.Add(new SexoModel { ID = 0, DESCRICAO_SEXO = "Selecione.." });

            listaSexo.AddRange(_repositorySexo.GetAll());

            ViewBag.listaSexo = new SelectList(listaSexo, "ID", "DESCRICAO_SEXO");
        }

        [HttpPost]
        public ActionResult Editar(AmigosModel entity)
        {
            var _repository = new AmigosRepository();
            _repository.Update(entity);
            return RedirectToAction("Listar");
        }
        
        
        [HttpPost]
        public void PreencherEstadoCivil()
        {
            var _repositoryEstadoCivil = new EstadoCivilRespository();

            var listaEstadoCivil = new List<EstadoCivilModel>();

            listaEstadoCivil.Add(new EstadoCivilModel { ID = 0, DESCRICAO_ESTADO_CIVIL = "Selecione.." });

            listaEstadoCivil.AddRange(_repositoryEstadoCivil.GetAll());

            ViewBag.listaEstadoCivil = new SelectList(listaEstadoCivil, "ID", "DESCRICAO_ESTADO_CIVIL");
        }

        #endregion
    }
}
