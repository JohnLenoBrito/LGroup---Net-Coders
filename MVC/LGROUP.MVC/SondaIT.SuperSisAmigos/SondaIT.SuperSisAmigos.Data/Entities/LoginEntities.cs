using SondaIT.SuperSisAmigos.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SondaIT.SuperSisAmigos.Data.Entities
{
    public class LoginEntities : EntityTypeConfiguration<LoginModel>
    {
        public LoginEntities()
        {
            // ToTable: DEFINE O NOME DA TABEL
            ToTable("TB_LOGIN");

            //  HasKey: DEFINE A CHAVE PRIMARIA 
            HasKey(c => c.ID);

            // Property: PARA PEGARMOS A PROPRIEDADE A SER CONFIGURADA
            // HasColumnName: DEFINE O NOME DA COLUNA
            // HasColumnType: DEFINE O TIPO DA COLUNA
            // HasMaxLength: DEFINE O TAMANHO DA STRING
            // IsRequired: DEFINE QUE O CAMPO SEJA OBRIGATORIO
            Property(c => c.USUARIO)
                .HasColumnName("DS_LOGIN")
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired();
            
            Property(c => c.SENHA)
                .HasColumnName("DS_SENHA")
                .HasColumnType("VARCHAR")
                .HasMaxLength(30)
                .IsRequired();

        }

    }
}
