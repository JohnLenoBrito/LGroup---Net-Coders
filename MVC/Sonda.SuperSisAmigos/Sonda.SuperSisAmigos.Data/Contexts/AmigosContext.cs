using Sonda.SuperSisAmigos.Data.Entities;
using Sonda.SuperSisAmigos.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.SuperSisAmigos.Data.Contexts
{
    public class AmigosContext : DbContext
    {
        public AmigosContext() : base (ConfigurationManager.ConnectionStrings["SONDA"].ConnectionString)
        {

        }

        //estamos encapsulando as nossas classes modelos
        public DbSet<AmigosModel> Amigos { get; set; }

        public DbSet<LoginModel> Login { get; set; }

        public DbSet<SexoModel> Sexo { get; set; }

        public DbSet<EstadoCivilModel> EstadoCivil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AmigosContext>());

            modelBuilder.Configurations.Add(new AmigosEntities());
            modelBuilder.Configurations.Add(new LoginEntities());
            modelBuilder.Configurations.Add(new SexoEntities());
            modelBuilder.Configurations.Add(new EstadoCivilEntities());
        }
    }
}
