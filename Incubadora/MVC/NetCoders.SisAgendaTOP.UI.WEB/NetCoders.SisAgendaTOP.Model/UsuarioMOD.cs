using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NetCoders.SisAgendaTOP.Model
{
    public class UsuarioMOD
    {
        [Required(ErrorMessage="Informe o usuario")]
        public String Nome { get; set; }

        [Required(ErrorMessage="Informe a senha")]
        public String Senha { get; set; }
    }
}
