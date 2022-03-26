using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.Data.Entities
{
    public class EstadoCivilEntities: EntityTypeConfiguration<EstadoCivilModel>
    {
        public EstadoCivilEntities()
        {
            ToTable("TB_ESTADO_CIVIL");

            HasKey(c => c.ID);

            Property(c => c.DESCRICAO_ESTADO_CIVIL)
                .HasColumnName("DS_DESCRICAO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
