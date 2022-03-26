using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SondaIT.CodeFirst.Model
{
    [Table("TB_AMIGO")]
    public class AmigoModel
    {
        [Key]
        [Column("ID_AMIGO", TypeName = "int")]
        public int Codigo { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("NM_NOME", TypeName = "varchar")]
        public String Nome { get; set; }

        [Required]
        [MaxLength(30)]
        [Column("DS_EMAIL", TypeName = "varchar")]
        public String Email { get; set; }

        [Required]
        [MaxLength(15)]
        [Column("NR_TELEFONE", TypeName = "varchar")]
        public String Telefone { get; set; }

        [Required]
        [Column("DT_NESCIMENTO", TypeName = "datetime")]
        public DateTime DataNascimento { get; set; }

        //Esses campos são as FOREING KEY (Chaves Estrangeiras)
        [Required]
        [Column("ID_SEXO", TypeName = "int")]
        public Int32 CodigoSexo { get; set; }

        [Required]
        [Column("ID_ESTADO_CIVIL", TypeName = "int")]
        public Int32 CodigoEstadoCivil { get; set; }

        //Lá no banco quando as tabelas se conversam chamamos de relacionamento
        //(Foreign Key = Chave Estrangeira), aqui no C# quando as classes se relacionam chamamos de composição
        [ForeignKey("CodigoSexo")]
        public virtual SexoModel Sexo { get; set; }

        //O EF por padrao aqui no CODE FIRST NÃO FAZ JOIN AUTOMATICAMENTE, se quisermos dar JOIN com alguma tabela
        //Temos que colocar o VIRTUAL na FRENTE
        [ForeignKey("CodigoEstadoCivil")]
        public virtual EstadoCivilModel EstadoCivil { get; set; }
    }
}
