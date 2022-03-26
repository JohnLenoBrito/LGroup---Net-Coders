using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoders.SisAgendaTOP.Model;
using NetCoders.SisAgendaTOP.DataAccess;

namespace NetCoders.SisAgendaTOP.Repository
{
    public class LoginREP
    {
        public Boolean ValidarLogin(UsuarioMOD dadosTela)
        {
            using (var conexao = new INCUBADORAEntities())
            {
                return conexao.TB_LOGIN.Any(x => x.NM_NOME == dadosTela.Nome && x.DS_SENHA == dadosTela.Senha);
            }
        }
    }
}
