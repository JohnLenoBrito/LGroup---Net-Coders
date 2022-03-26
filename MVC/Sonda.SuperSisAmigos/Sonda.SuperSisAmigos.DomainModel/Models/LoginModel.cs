using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.DomainModel.Models
{
    public class LoginModel : Base.BaseModel
    {
        public String Usuario { get; set; }

        public String Senha { get; set; }
    }
}
