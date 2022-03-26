using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importamos pra dentro do projeto a DLL System.ComponentModel,DataAnnotations
//Os comandos que vão nos auxiliar a dar o NOME DA TABELA
//O nome dos campos, o tamanho dos campos descem dessa tabela
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SondaIT.CodeFirst.Model
{
    //Quando criamos o banco primeiro pra depois motar o EF se chama DataBase First
    //Quando não temos BANCO e formos montar o BANCO a PARTIR do código (C#) o nome bunitão é Code First
    //O banco e as tabelas vão ser gerados a partir do código (C#)
    //Não temos EDMX, Diagramas, Model Sofredor = True
    //Cada classe vai virar 1 TABELA
    //AmigoModel -> TB_AMIGO
    //SexoModel -> TB_SEXO
    //EstadoCivilModel -> TB_ESTADO_CIVIL
    //Model é um termo arquitetural, significa armazenamento de dados
    //MODELO
    //Uma classe é uma definição, é uma representação de algo do mundo real, abstrato, imaginario dentro do mundo computacional
    //O public é a visibilidade da classe, significa que qualquer pessoa pode acessar ela de qualquer local do bloco de código do projeto\
    //A configuração ou DataAnnotation é uma forma de adicionar novas definições na classe ou nos campos
    [Table("TB_SEXO")]
    public class SexoModel
    {
        //A classe vai virar tabela e as propriedades vão virar campos da tabela
        //As propriedades são caracteristicas da nossa classe (Nome, Idade, Altura, Peso, Sexo, Orientação Sexual, Cor de Cabelo)
        //Uma propriedade lembra muito uma variavel, o que muda é que na propriedade conseguimos dar permissão
        //GET -> Leitura da Variavel
        //SET -> Gravação da Variavel
        //Pra não montar na raça, utilizar PROP + TAB + TAB

        //Colocamos uma configuração adicional pra transformar a propriedade em Campo (Coluna) da tabela
        //O Key serve pra 3 coisas
        //1-> Chave Primaria (PK)
        //2-> Ele coloca como AUTO INCREMENTO
        //3-> Requerido (Compo Obrigatorio) NOT NULL
        [Key]
        [Column("ID_SEXO", TypeName = "int")]
        public Int32 Codigo { get; set; }

        [Required]
        [MaxLength(9)]
        [Column("DS_SEXO", TypeName = "varchar")]
        public String Descricao { get; set; }
    }
}
