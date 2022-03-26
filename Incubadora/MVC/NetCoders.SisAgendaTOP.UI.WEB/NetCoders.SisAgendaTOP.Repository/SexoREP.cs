using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoders.SisAgendaTOP.DataAccess;
using NetCoders.SisAgendaTOP.Model;

namespace NetCoders.SisAgendaTOP.Repository
{
    public class SexoREP
    {
        public List<SexoMOD> Listar()
        {
            using (var conexao = new INCUBADORAEntities())
            {
                return conexao.TB_SEXO.ToList().ConvertAll(tabela => new SexoMOD
                                                           {
                                                               Codigo = tabela.ID_SEXO,
                                                               Descricao = tabela.DS_SEXO
                                                           });
            }
        }
    }
}
