using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity.ModelConfiguration;
using SondaIT.CodeFirst.FluentAPI.Model;

namespace SondaIT.CodeFirst.FluentAPI.DataAccess.Mappings
{
    //Com Migrations podemos fazer Backup de tabelas, podemos gerar e aplicar backups e voltar backups de dias anteriores
    //Migrations não é nada visual, são apenas 3 comandos no Power Shell
    //1-> Enable-Migrations -> Habilitar os Backups no PROJETO
    //2-> Add-Migrations NomeDoBackup -> Ele detecta as mudanças e gera um arquivo de backup no C#
    //3-> Update-Database -> Ele aplica os BACKUPS pra especificar uma versão de BACKUP
    //Update-DataBase -TargetMigration: NomeDoBackup

    public sealed class ClienteMapping : EntityTypeConfiguration<ClienteModel>
    {
        public ClienteMapping()
        {
            ToTable("TB_CLIENTE");
            HasKey(x => x.Codigo);

            Property(x => x.Codigo).HasColumnName("ID_CLIENTE")
                                   .HasColumnType("int");

            Property(x => x.Nome).HasColumnName("NM_CLIENTE")
                                 .HasColumnType("varchar")
                                 .HasMaxLength(50)
                                 .IsRequired();

            Property(x => x.Email).HasColumnName("DS_EMAIL")
                                  .HasColumnType("varchar")
                                  .HasMaxLength(30)
                                  .IsRequired();

            Property(x => x.Telefone).HasColumnName("NR_TELEFONE")
                                     .HasColumnType("varchar")
                                     .HasMaxLength(15)
                                     .IsRequired();

            Property(x => x.DataNascimento).HasColumnName("DT_NASCIMENTO")
                                           .HasColumnType("datetime")
                                           .IsRequired();

            //Precisão do campo decimal é onde configuramos a quantidade de numeros e quantos serão decimal 1234,56
            Property(x => x.Salario).HasColumnName("SALARIO")
                                    .HasColumnType("decimal")
                                    .HasPrecision(6, 2)
                                    .IsRequired();

            Property(x => x.CodigoSexo).HasColumnName("ID_SEXO")
                                       .HasColumnType("int")
                                       .IsRequired();

            Property(x => x.CodigoEstadoCivil).HasColumnName("ID_ESTADO_CIVIL")
                                              .HasColumnType("int")
                                              .IsRequired();

            //É nesse momento que fizemos um relacionamento lá no banco entre as tabelas
            //É isso que vai gerar a chave estrangeira
            HasRequired(x => x.Sexo).WithMany()
                                    .HasForeignKey(x => x.CodigoSexo)
                                    .WillCascadeOnDelete(false);

            //Estamos em cliente, tamo indo conversar com a tabela de estado civil, podemos ter varios clientes com
            //aquele Estado Civil e o campo que vamos relacionar é o campo CodigoEstadoCivil
            //CONSIDERAÇÕES
            //Quando criamos uma chave estrangeira o campo automaticamente já é INDEXADO, ele já vira um INDEX NON-CLUSTERED
            HasRequired(x => x.EstadoCivil).WithMany()
                                           .HasForeignKey(x => x.CodigoEstadoCivil)
                                           .WillCascadeOnDelete(false);

            //O SQL SERVER por padrão bloqueia a exclusão em cascata, não podemos deletar chaves estrangeiras que estão em uso
            //Só que a merda no CODE FIRST por padrão a exclusão em cascata vem HABILITADA, vamos aprender a bloquear a exclusão em CASCATA


            Property(x => x.Endereco).HasColumnName("DS_ENDERECO")
                                              .HasColumnType("varchar")
                                              .HasMaxLength(50);

            Property(x => x.Cep).HasColumnName("NR_CEP")
                                              .HasColumnType("varchar")
                                              .HasMaxLength(9);

            Property(x => x.Cpf).HasColumnName("NR_CPF")
                                              .HasColumnType("varchar")
                                              .HasMaxLength(15);

            Property(x => x.Rg).HasColumnName("NR_RG")
                                              .HasColumnType("varchar")
                                              .HasMaxLength(10);

            Property(x => x.Pis).HasColumnName("NR_PIS")
                                              .HasColumnType("varchar")
                                              .HasMaxLength(22);
        }
    }
}
