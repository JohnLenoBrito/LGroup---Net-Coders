using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SondaIT.SisAmigos.UI.Mvc.Models
{
    public class AmigosModel
    {
        public Int32  ID { get; set; }
        
        public String NOME{ get; set; }

        public String RG { get; set; }

        public String  CPF { get; set; }

        public String EMAIL { get; set; }

        public String SEXO { get; set; }

        public String  ESTADO_CIVIL{ get; set; }

        public DateTime DATA_NASCIMENTO{ get; set; }
    }
}