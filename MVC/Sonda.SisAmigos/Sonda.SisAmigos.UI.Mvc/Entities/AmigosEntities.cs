using Sonda.SisAmigos.UI.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Sonda.SisAmigos.UI.Mvc.Entities
{
    //Fizemoa a herança da classe EntityTypeConfiguration para modelarmos as nossas classes que representarão as nossas tabelas
    //no banco, essa classe trabalha com injeção de pendencia, sendo assim teremos que passar um classe modelo para dentro como
    //parametro
    public class AmigosEntities : EntityTypeConfiguration<AmigosModel>
    {
        public AmigosEntities()
        {
            //Dando nome a Tabela no banco
            ToTable("TB_AMIGOS");
            //Criando uma chave primaria
            HasKey(x => x.ID);

            //Utilizamos o metodo Property para poder acessar a propriedade, HasColumnName para definir o nome do campo HasColumnName
            //para definir o typo HasColumnType, HasMaxLength para definir o tamanho e IsRequired para fazer o campo obrigatório
            Property(x => x.Nome).HasColumnName("NM_NOME")
                                 .HasColumnType("varchar")
                                 .HasMaxLength(30)
                                 .IsRequired();

            Property(x => x.Rg).HasColumnName("NM_RG")
                               .HasColumnType("varchar")
                               .HasMaxLength(20)
                               .IsRequired();

            Property(x => x.Cpf).HasColumnName("NM_CPF")
                                .HasColumnType("varchar")
                                .HasMaxLength(20)
                                .IsRequired();

            Property(x => x.Data_Nascimento).HasColumnName("DT_NASCIMENTO")
                                            .IsRequired();

            Property(x => x.Email).HasColumnName("DS_EMAIL")
                                  .HasColumnType("varchar")
                                  .HasMaxLength(50)
                                  .IsRequired();

            Property(x => x.Estado_Civil).HasColumnName("DS_ESTADO_CIVIL")
                                         .HasColumnType("varchar")
                                         .HasMaxLength(20)
                                         .IsRequired();

            Property(x => x.Sexo).HasColumnName("DS_SEXO")
                                  .HasColumnType("varchar")
                                  .HasMaxLength(10)
                                  .IsRequired();
        }
    }
}