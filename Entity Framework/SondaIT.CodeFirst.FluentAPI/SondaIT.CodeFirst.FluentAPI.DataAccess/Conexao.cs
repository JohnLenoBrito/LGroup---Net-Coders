using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Baixamos o EF via NUGET
//Como é CODE FIRST é NA RAÇA (LINHA CÓDIGO)
using System.Data.Entity;

//Pra poder visualizar as classes de mapeamento subiamos as classes pra memoria
using SondaIT.CodeFirst.FluentAPI.DataAccess.Mappings;
using SondaIT.CodeFirst.FluentAPI.Model;

namespace SondaIT.CodeFirst.FluentAPI.DataAccess
{
    //Bloqueamos a herança da classe, só vai poder na NEW
    //Transformamos a nossa simples classe em uma classe de conexao do EF através da herança DbContext
    public sealed class Conexao : DbContext
    {
        //CODE REFACTORING (PONTO DE MELHORIA)
        //Uma String de conexão é mutavel, ela é flexivel, uma hora é PRODUÇÃO, outra hora é HOMOLOGAÇÃO outra hora é sua maquina
        //Strings de Conexão Sempre devem ficar no arquivo de configuração APP.CONFIG (WINDOWS), WEB.CONFIG (WEB)
        //Ao gerar o banco ele vai buscar os dados de conexão lá do arquivo de configuração dentro do nome SONDAIT
        public Conexao()
            : base("name=SONDAIT")
        {

        }

        public void CriarBanco()
        {
            //São comandos do EF
            Database.Create();
        }

        public void DeletarBanco()
        {
            //São comandos do EF
            Database.Delete();
        }

        //Criando as propriedades que representarão nossas tabelas
        public DbSet<ClienteModel> Cliente { get; set; }

        public DbSet<SexoModel> Sexo { get; set; }

        public DbSet<EstadoCivilModel> EstadoCivil { get; set; }

        //Alem de gerar o banco tem que gerar tbm as tabelas e os campos dela, todo mapeamento de tabelas
        //e compos está dentro dos arquivos de mapeamento, temos que colocar aqueles arquivos dentro da conexão
        //O operador override serve para subscrever algum comando da classe pai (DBCONTEXT)
        //Esse comando serve pra trazer pra descer pra classe filha qualquer momento que tenha sido criado
        //na classe Pai
        //O comando OnModelCreating serve pra colocar os mapeamentos dentro da conexao
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //É aqui dentro do OnModelCreating que colocamos os mapeamentos de tabela, quando for gerar o banco de dados
            //internamente.
            //Ele executa os aequivos de mapeamento
            //A ordem dos mapeamentos tanto faz, não importa se é um mapeamento de tabela pai ou filha
            modelBuilder.Configurations.Add(new SexoMapping());
            modelBuilder.Configurations.Add(new EstadoCivilMapping());
            modelBuilder.Configurations.Add(new ClienteMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
