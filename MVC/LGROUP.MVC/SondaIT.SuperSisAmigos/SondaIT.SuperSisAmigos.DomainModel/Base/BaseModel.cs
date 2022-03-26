using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.SuperSisAmigos.DomainModel.Base
{
    public class BaseModel
    {
        // COMO TODAS AS CLASSES QUE REPRESENTARAM NOSSO MODELO
        // DEVERÃO OU DEVERIA TER UMA PROPRIEDADE ID,
        // CRIAMOS UMA CLASSE BASE PARA DEIARMOS A PROPRIEDADE ID,
        // ASSIM AS DEMAIS CLASSES PODERÃO HERDAR ESSA CLASSEC:\LGroup\MVC\SondaIT.SuperSisAmigos\SondaIT.SuperSisAmigos.DomainModel\Base\BaseModel.cs
        // DE FORMA QUE NÃO PRECISARÃO FICAR CRIANDO A PROPRIEDADE ID
        public int ID{ get; set; }
    }
}
