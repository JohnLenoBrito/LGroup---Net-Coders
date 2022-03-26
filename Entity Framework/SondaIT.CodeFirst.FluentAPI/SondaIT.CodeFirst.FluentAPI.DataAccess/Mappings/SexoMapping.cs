using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Pra poder abilitar a classe de mapeamento de tabelas, temos que importar essa namespace
using System.Data.Entity.ModelConfiguration;

//Subimos pra memoria a DLL que possui as classes de modelo, as classes que vão virar tabelas
using SondaIT.CodeFirst.FluentAPI.Model;

namespace SondaIT.CodeFirst.FluentAPI.DataAccess.Mappings
{
    //Aqui no FLUENT API temos que criar 1 arquivo de mapeamento pra cada modelo
    //É no arquivo de mapeamento que configuramos o nome da tabela, nome e tamanho dos campos
    //A classe EntityTypeConfiguration possui os comandos de nome de tabela e de campos
    //Dentro do diamante <> passamos o nome da classe que vai virar tabela
    public sealed class SexoMapping : EntityTypeConfiguration<SexoModel>
    {
        public SexoMapping()
        {
            ToTable("TB_SEXO");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("ID_SEXO")
                                   .HasColumnType("INT");

            Property(x => x.Descricao).HasColumnName("DS_SEXO")
                                      .HasColumnType("VARCHAR")
                                      .HasMaxLength(50)
                                      .IsRequired();
        }
    }
}
