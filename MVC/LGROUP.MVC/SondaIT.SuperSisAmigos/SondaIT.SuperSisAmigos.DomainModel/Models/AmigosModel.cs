using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.SuperSisAmigos.DomainModel.Models
{
    public class AmigosModel:Base.BaseModel
    {

        public String NOME { get; set; }

        public String RG { get; set; }

        public String CPF { get; set; }

        public String  EMAIL{ get; set; }

        public String  TELEFONE{ get; set; }

        public DateTime DATA_NASCIMENTO{ get; set; }

        public Int32 ID_SEXO{ get; set; }
        
        public Int32 ID_ESTADO_CIVIL { get; set; }

        // ESTAMOS FAZENDO O RELACIONAMENTO DAS CLASSES
        // ESTADO EstadoCivilModel E SexoModel ... CHAVE ESTRANGEIRA 
        public virtual EstadoCivilModel REL_ESTADO_CIVIL { get; set; }

        public virtual SexoModel REL_SEXO { get; set; }
    }
}
