using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetCoders.WPF.Model;

namespace NetCoders.WPF.DataAccess
{
    public class SexoREP
    {
        public List<SexoMOD> ListaSexos()
        {
            var listarSexos = new List<SexoMOD>();
            var conexao = new INCUBADORAEntities();

            var resultadoListaSexos = conexao.TB_SEXO.ToList();

            foreach (var i in resultadoListaSexos)
            {
                var sexoCarregado = new SexoMOD();

                sexoCarregado.Codigo = i.ID_SEXO;
                sexoCarregado.Descricao = i.DS_SEXO;

                listarSexos.Add(sexoCarregado);
            }
            return listarSexos;
        }
    }
}
