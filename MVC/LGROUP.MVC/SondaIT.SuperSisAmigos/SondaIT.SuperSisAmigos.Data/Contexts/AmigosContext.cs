using SondaIT.SuperSisAmigos.DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SondaIT.SuperSisAmigos.Data.Entities;

namespace SondaIT.SuperSisAmigos.Data.Contexts
{
    public class AmigosContext : DbContext
    {
        public AmigosContext() : 
            base(ConfigurationManager.ConnectionStrings["SONDA"].ConnectionString)
        {
        }

        // ESTAMMOS ENCAPSULANDO A NOSSA CLASSES MODELOS
        public DbSet<AmigosModel> AMIGOS { get; set; }

        public DbSet<LoginModel> LOGIN { get; set; }

        public DbSet<EstadoCivilModel> ESTADO_CIVIL { get; set; }

        public DbSet<SexoModel> SEXO { get; set; }

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
