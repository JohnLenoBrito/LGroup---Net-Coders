using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.DomainModel.Models
{
    public class AmigosModel : Base.BaseModel
    {
        public String Nome { get; set; }

        public String Rg { get; set; }

        public String Cpf { get; set; }

        public String Email { get; set; }

        public String Telefone { get; set; }

        public DateTime Data_Nascimento { get; set; }

        public Int32 Id_Sexo { get; set; }

        public Int32 Id_Estado_Civil { get; set; }

        //Estamos fazendo o relacionamento das classes EstadoCivilModel e SexoModel
        //Chave estrangeira
        public virtual EstadoCivilModel RelEstadoCivil { get; set; }

        public virtual SexoModel RelSexo { get; set; }
    }
}
