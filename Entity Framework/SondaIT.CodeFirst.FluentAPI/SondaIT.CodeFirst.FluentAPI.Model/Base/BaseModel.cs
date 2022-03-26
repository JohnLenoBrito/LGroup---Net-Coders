using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.CodeFirst.FluentAPI.Model.Base
{
    //Base é um nome de mercado, significa PAI, a classe pai de todas os outras classes de MODELO é a classe BASEMODEL
    //Tudo que quisermos levar pra outras classes temos que jogar dentro da classe pai
    //TERCEIRO PONDO DE REFATORAÇÃO
    //Quando criamos uma classe podemos chamar ela de 2 formas
    //INICIALIZANDO -> NEW -> ABSTRACT (BLOQUEIA)
    //HERDANDO -> : -> SEALED (BLOQUEIA)
    //Agora ficou ONP (Oto Nivel de Pogamação)
    public abstract class BaseModel
    {
        //Primeiro ponto de refatoração é pegar tudo que está igual em todas as classes e levar pra classe PAI
        //ENCAPSULAMENTO e HERANÇA
        public Int32 Codigo { get; set; }
    }
}
