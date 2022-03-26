using Sonda.SuperSisAmigos.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.Data.Entities
{
    public class AmigosEntities : EntityTypeConfiguration<AmigosModel>
    {
        public AmigosEntities()
        {
            ToTable("TB_AMIGOS");

            HasKey(x => x.ID);

            Property(x => x.Nome).HasColumnName("NM_AMIGO")
                                 .HasColumnType("varchar")
                                 .HasMaxLength(30)
                                 .IsRequired();

            Property(x => x.Rg).HasColumnName("DS_RG")
                                 .HasColumnType("varchar")
                                 .HasMaxLength(20)
                                 .IsRequired();

            Property(x => x.Cpf).HasColumnName("DS_CPF")
                                 .HasColumnType("varchar")
                                 .HasMaxLength(20)
                                 .IsRequired();

            Property(x => x.Data_Nascimento).HasColumnName("DT_NASCIMENTO")
                                            .IsRequired();

            Property(x => x.Email).HasColumnName("DS_EMAIL")
                                  .HasColumnType("varchar")
                                  .HasMaxLength(50)
                                  .IsRequired();

            Property(x => x.Telefone).HasColumnName("NR_TELEFONE")
                                     .HasColumnType("varchar")
                                     .HasMaxLength(20)
                                     .IsRequired();

            Property(x => x.Id_Estado_Civil).HasColumnName("ID_ESTADO_CIVIL")
                                            .IsRequired();

            Property(x => x.Id_Sexo).HasColumnName("ID_SEXO")
                                            .IsRequired();

            //HasRequired: Define o requerimento para uma propriedade relacionada
            //WithMany: Informa que teremos o relacionamento de 1 para N (muitos)
            //HasForeignKey: Define quem sera a chave estrangeira
            HasRequired(x => x.RelEstadoCivil).WithMany().HasForeignKey(x => x.Id_Estado_Civil);

            HasRequired(x => x.RelSexo).WithMany().HasForeignKey(x => x.Id_Sexo);
        }
    }
}
