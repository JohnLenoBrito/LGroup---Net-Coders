using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.Data.Entities
{
    public class SexoEntities: EntityTypeConfiguration<SexoModel>
    {
        public SexoEntities()
        {
            ToTable("TB_SEXO");

            HasKey(c => c.ID);

            Property(c => c.DESCRICAO_SEXO)
                .HasColumnName("DS_DESCRICAO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
