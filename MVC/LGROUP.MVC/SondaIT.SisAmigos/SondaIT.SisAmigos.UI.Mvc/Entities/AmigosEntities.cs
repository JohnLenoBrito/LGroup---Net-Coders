using SondaIT.SisAmigos.UI.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace SondaIT.SisAmigos.UI.Mvc.Entities
{
    // FIZEMOS A HERANÇA DA CLASSE EntityTypeConfiguration 
    // PARA MODELARMOS AS NOSSAS CLASSE QUE REPRESENTARAM 
    // AS NOSSAS TABELAS NO BANCO, ESSA CLASSE TRABALHA COM
    // INJEÇÃO DE DEPENDENCIA, SENDO ASSIM TEREMOS QUE PASSAR 
    // UMA CLASSE MODELO COMO PARAMETRO
    public class AmigosEntities : EntityTypeConfiguration<AmigosModel>
    {
        public AmigosEntities()
        {
            //  DANDO NOME A TABELA NO BANCO
            ToTable("TB_AMIGOS");
            //  CRIAMOS UMA CHAVE PRIMARIA
            HasKey(c => c.ID);
            // UTILIZAMOS O METODO property PARA PODER ACESSAR
            // A PROPRIEDADE, HasColumnName PARA DEFINIR O NOME DO CAMPO
            // HasColumnName PARA DEFINIR O TAMANHO
            // E IsRequired PARA FAZER O CAMPO SER OBRIGATORIO
            Property(x => x.NOME).HasColumnName("NM_NOME")
                                 .HasColumnType("VARCHAR")
                                 .HasMaxLength(30)
                                 .IsRequired();

            Property(x => x.RG).HasColumnName("NR_RG")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.CPF).HasColumnName("NR_CPF")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.DATA_NASCIMENTO).HasColumnName("DT_NASCIMENTO")
                .IsRequired();

            Property(x => x.EMAIL).HasColumnName("DS_EMAIL")
                .HasColumnType("VARCHAR")
                .HasMaxLength(40)
                .IsRequired();

            Property(x => x.ESTADO_CIVIL).HasColumnName("DS_ESTADO_CIVIL")
                .HasColumnType("VARCHAR")
                .HasMaxLength(20)
                .IsRequired();

            Property(x => x.SEXO).HasColumnName("DS_SEXO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(10)
                .IsRequired();

        }

        
    }
}