using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using NetCoders.Integracao.Services.DataAccess;
using NetCoders.Integracao.Services.Models;

//Importamos o Cors.
using System.Web.Http.Cors;

namespace NetCoders.Integracao.Services.Controllers
{
    //São os métodos do http que estamos autorizando
    //Get, Post, Put, Delete
    [EnableCors("*", "*", "*")]
    public class ContatoController : ApiController
    {
        [HttpGet]
        public IEnumerable<ContatoMOD> Listar()
        {
            using (var conexao = new INCUBADORAEntities())
            {
                return conexao.TB_CONTATO.ToList()
                                         .ConvertAll<ContatoMOD>(x =>
                                         {
                                             return new ContatoMOD
                                             {
                                                 Codigo = x.ID_CONTATO,
                                                 Nome = x.NM_CONTATO,
                                                 DataNascimento = x.DT_NASCIMENTO,
                                                 Email = x.DS_EMAIL,
                                                 Telefone = x.NR_TELEFONE,
                                                 Sexo = new SexoMOD
                                                 {
                                                     Codigo = x.ID_SEXO,
                                                     Descricao = x.TB_SEXO.DS_SEXO
                                                 }
                                             };
                                         });
            }
        }

        [HttpGet]
        public Boolean TelefoneJaExiste(String numero)
        {
            using (var conexao = new INCUBADORAEntities())
            {
                return conexao.TB_CONTATO.Any(x => x.NR_TELEFONE == numero);
            }
        }

        [HttpGet]
        public Boolean EmailJaExiste(String email)
        {
            using (var conexao = new INCUBADORAEntities())
            {
                return conexao.TB_CONTATO.Any(x => x.DS_EMAIL == email);
            }
        }
    }
}
