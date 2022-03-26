using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sonda.SisAmigos.UI.Mvc.Models
{
    public class AmigosModel
    {
        //Para criar um propriedades usamos o atalho, vc digita a palavra prop + tab tab
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public string Sexo { get; set; }

        public string Estado_Civil { get; set; }

        public DateTime Data_Nascimento { get; set; }
    }
}