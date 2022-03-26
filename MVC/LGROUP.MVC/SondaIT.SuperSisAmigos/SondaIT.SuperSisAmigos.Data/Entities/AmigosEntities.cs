using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.DomainModel.Models;

namespace SondaIT.SuperSisAmigos.Data.Entities
{
    public class AmigosEntities: EntityTypeConfiguration<AmigosModel>
    {
        public AmigosEntities()
        {
            ToTable("TB_AMIGO");

            HasKey(c => c.ID);

            Property(c => c.NOME)
                .HasColumnName("NM_NOME")
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired();

            Property(c => c.EMAIL)
                .HasColumnName("DS_EMAIL")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.RG)
                .HasColumnType("NR_RG")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.CPF)
                .HasColumnName("NR_CPF")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.TELEFONE)
                .HasColumnName("NR_TELEFONE")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();

            Property(c => c.DATA_NASCIMENTO)
                 .HasColumnName("DT_DATA_NASCIMENTO")
                 .IsRequired();

            Property(c => c.ID_ESTADO_CIVIL)
                .HasColumnName("ID_ESTADO_CIVIL")
                .IsRequired();

            Property(c => c.ID_SEXO)
                .HasColumnName("ID_SEXO")
                .IsRequired();


            // HasRequired : DEFINE OREQUERIMENTO PARA UMA PROPRIEDADE RELACIONADA
            // WithMany : INFORMA QUE TEREMOS O RELACIONAMENTO DE 1 PARA N (MUITOS)
            // HasForeignKey: DEFINE QUEM SERÁ A CHAVE ESTRANGEIRA
            HasRequired(c => c.REL_ESTADO_CIVIL)
                .WithMany()
                .HasForeignKey(c => c.ID_ESTADO_CIVIL);

            HasRequired(c => c.REL_SEXO)
                .WithMany()
                .HasForeignKey(c => c.ID_SEXO);

        }
    }
}
