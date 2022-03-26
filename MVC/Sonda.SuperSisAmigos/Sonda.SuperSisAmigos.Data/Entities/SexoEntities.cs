using Sonda.SuperSisAmigos.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.Data.Entities
{
    public class SexoEntities : EntityTypeConfiguration<SexoModel>
    {
        public SexoEntities()
        {
            ToTable("TB_SEXO");

            HasKey(x => x.ID);

            Property(x => x.Descricao).HasColumnName("DS_SEXO")
                                      .HasColumnType("varchar")
                                      .HasMaxLength(30)
                                      .IsRequired();
        }
    }
}
