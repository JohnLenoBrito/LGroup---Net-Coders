using Sonda.SuperSisAmigos.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sonda.SuperSisAmigos.Data.Entities
{
    public class LoginEntities : EntityTypeConfiguration<LoginModel>
    {
        public LoginEntities()
        {
            //ToTable: DEFINE O NOME DA TABELA
            ToTable("TB_LOGIN");

            //HasKey: Define a chave primaria
            HasKey(x => x.ID);

            //Property: Para pegarmos a prioriedade a ser configurada
            //HasColumnName: Define o nome da coluna
            //HasColumnType: Define o tipo da coluna
            //HasMaxLength: Define o tamanho da string
            //HasMaxLength: Define o tamanho da string
            //IsRequired: Define que o campo seja obrigatorio
            Property(x => x.Usuario).HasColumnName("DS_USUARIO")
                                    .HasColumnType("varchar")
                                    .HasMaxLength(30)
                                    .IsRequired();

            Property(x => x.Senha).HasColumnName("DS_SENHA")
                                    .HasColumnType("varchar")
                                    .HasMaxLength(30)
                                    .IsRequired();
        }
    }
}
