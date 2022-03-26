using Sonda.SuperSisAmigos.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.Data.Entities
{
    public class EstadoCivilEntities : EntityTypeConfiguration<EstadoCivilModel>
    {
        public EstadoCivilEntities()
        {
            ToTable("TB_ESTADO_CIVIL");

            HasKey(x => x.ID);

            Property(x => x.Descricao).HasColumnName("DS_ESTADO_CIVIL")
                                      .HasColumnType("varchar")
                                      .HasMaxLength(30)
                                      .IsRequired();
        }
    }
}
