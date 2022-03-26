using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoders.WPF.Model
{
    public class ContatoMOD
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public String Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public Int32 CodigoSexo { get; set; }
    }
}
