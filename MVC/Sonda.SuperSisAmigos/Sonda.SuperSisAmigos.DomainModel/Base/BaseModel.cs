using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.DomainModel.Base
{
    public class BaseModel
    {
        //Como todas as classes que representarão nosso modelo deverão ou deveria ter uma propriedade
        //ID, criamos uma classe base para deixarmos a propriedade ID, assmim as demais classes poderão
        //Herdar essa classe de forma que não precisarão ficar criando a propriedade ID
        public int ID { get; set; }
    }
}
