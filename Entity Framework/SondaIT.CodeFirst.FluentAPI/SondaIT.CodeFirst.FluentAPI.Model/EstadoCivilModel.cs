using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.CodeFirst.FluentAPI.Model
{
    //Quando criamos uma classe ela é orfão, ela não tem pai, pra dar um pai pra ela aplicar a herança ( : )
    //Essa classe virou filha (foi adotada) pela classe BaseModel
    public sealed class EstadoCivilModel : Base.BaseModel
    {
        public String Descricao { get; set; }
    }
}
