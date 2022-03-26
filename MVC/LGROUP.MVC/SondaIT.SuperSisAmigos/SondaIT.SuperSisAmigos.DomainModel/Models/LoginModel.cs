using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.SuperSisAmigos.DomainModel.Models
{
    public class LoginModel:Base.BaseModel
    {
        
        public String USUARIO { get; set; }

        public String SENHA { get; set; }


    }
}
