using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Quando trabalhamos com CODE FIRST (Geramos o Banco) a partir do código, começaoms pelo código e exportamos
//Geramos o banco, tabelas e campos
//No CODE FIRST existem 2 sabores, 2 abordagens, 2 formas de estar fazendo o mapeamento das tabelas e banco

//1-> DATA ANNOTATIONS
//É uma forma mais simples (Junior e Pleno)
//Configuramos os compos com ANOTAÇÕES (COLCHETES [])

//2-> FLUENT API
//É uma forma mais complexa (Seniorzao)
//É a forma preferida dos progamadores, fazemos os mapeamentos em forma de EXPRESSÕES LAMBDAS
//Aqui no FLUENT API temos alguns recursos que não tem no DATA ANNOTATIONS
//1-> RELACIONAMENTO DE N pra N
//2-> CONSEGUIMOS MAPEAR COMPOS DECIMAIS
//3-> CONFIGURAR AS EXCLUSÕES EM CASCATA, Quando matamos o registro da tabela pai ele mata todos os registros das tabelas filhas
//4-> MAPEAMENTO DE PROCEDURES

namespace SondaIT.CodeFirst.FluentAPI.Model
{
    //Quando melhoramos o nosso codigo o nome bunitão é REFATORAÇÃO DE CÓDIGO (CODE REFACTORING)
    //Temos que refatorar sempre depois de programar, temos que refatorar (MELHORAR) sempre visando PERFORMANCE
    //NOMECLATURA DE CLASSES E OBJETOS, PADRÕES DE PROJETO (PROJETOS ARQUITETURAIS)
    //Até mesmo um simples comentario no código é uma REFATORAÇÃO
    public sealed class ClienteModel : Base.BaseModel
    {
        public String Nome { get; set; }

        public String Email { get; set; }

        public String Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

        public Decimal Salario { get; set; }

        public Int32 CodigoSexo { get; set; }

        public Int32 CodigoEstadoCivil { get; set; }

        //Criamos um reacionamento entre as classes
        //AMIGO -> SEXO
        //AMIGO -> ESTADO CIVIL
        //Quando criamos um relacionamento entre classes onome bunitão é COMPOSIÇÃO
        public SexoModel Sexo { get; set; }

        public EstadoCivilModel EstadoCivil { get; set; }

        public String Endereco { get; set; }

        public String Cep { get; set; }

        public String Cpf { get; set; }

        public String Rg { get; set; }

        public String Pis { get; set; }
    }
}