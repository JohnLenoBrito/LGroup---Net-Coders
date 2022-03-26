namespace SondaIT.CodeFirst.FluentAPI.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    //Pra fazer BACKUPS de TABELAS(ESTRUTURA = DOS CAMPOS)
    //Utilizamos o MIGTATIONS
    //Além de fazer backups das tabelas ele tbm serve pra levar novas informações pro banco

    internal sealed class Configuration : DbMigrationsConfiguration<SondaIT.CodeFirst.FluentAPI.DataAccess.Conexao>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SondaIT.CodeFirst.FluentAPI.DataAccess.Conexao";
        }

        //O Comando Seed server pra dar uma cara inicial das tabelas, assim que montar o banco ou aplicar algum BACKUP insira
        //uma massa de dados
        protected override void Seed(SondaIT.CodeFirst.FluentAPI.DataAccess.Conexao context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
