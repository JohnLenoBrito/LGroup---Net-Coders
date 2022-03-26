using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SondaIT.CodeFirst.Model
{
    //O Code First Substitui a criação das tabelas pelo SQL Server Management Studio
    [Table("TB_ESTADO_CIVIL")]
    public class EstadoCivilModel
    {
        [Key]
        [Column("ID_ESTADO_CIVIL", TypeName = "int")]
        public Int32 Codigo { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("DS_ESTADO_CIVIL", TypeName = "varchar")]
        public String Descricao { get; set; }
    }
}
