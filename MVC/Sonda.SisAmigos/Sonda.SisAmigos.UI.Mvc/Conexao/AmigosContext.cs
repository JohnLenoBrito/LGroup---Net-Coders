using Sonda.SisAmigos.UI.Mvc.Entities;
using Sonda.SisAmigos.UI.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sonda.SisAmigos.UI.Mvc.Conexao
{
    public class AmigosContext : DbContext
    {
        //No metodo construtor iremos passar a string de conexão, utilizamos a palavra base para informar que estamos passando um parametro
        //para a classe base da herança no caso DbContext
        //Obs. Caso esteja progamando seu projeto em N-Camadas a string de conexão deve permanecer na camada root, ou seja na camada de visão,
        //normalmente na arquivo web.config
        public AmigosContext()
            : base(@"data source=172.28.128.29;initial catalog=DBAMIGOS;integrated security=true;")
        {
        }

        //Aqui criamos uma propriedade que representará a nossa tabela ela será do tipo AmigosModel
        public DbSet<AmigosModel> Amigos { get; set; }

        //Estamos sobreescrevendo a API do Entity Framework, assim podemos fazer todas as configurações necessarias para criar o
        //nosso banco de dados
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Aqui estamos falando para o contexto que nosso contexto deve ser inicializado, porem essa instancia só irá ocorrer se o banco
            //de dados não existir, para isso utilizamos a classe verificador, CreateDatabaseIfNotExists
            Database.SetInitializer(new CreateDatabaseIfNotExists<AmigosContext>());

            //Aqui passamos as configurações feitas na classe AmigosEntities
            modelBuilder.Configurations.Add(new AmigosEntities());

            //Ao fim falamos para o EF manter o restante das configurações da base
            base.OnModelCreating(modelBuilder);
        }
    }
}