using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoders.Integracao.Services.Models
{
    public class ContatoMOD
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public SexoMOD Sexo { get; set; }
    }
}