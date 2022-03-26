using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.CodeFirst.FluentAPI.Model
{
    //SEGUNDO PONTO DE Refatoração
    //Quando criamos uma classe ela por padrão pode ser pai, de outras classes, isso é ruim pq alguem pode chegar e fazer
    //merda nas heranças, nas classes
    //Pra bloquear uma classe pra ela não ser herdada TIRAR AS BOLAS DA CLASSE, VASECTOMIZAR A CLASSE, colocar o SEALED
    public sealed class SexoModel : Base.BaseModel
    {
        public String Descricao { get; set; }
    }
}
