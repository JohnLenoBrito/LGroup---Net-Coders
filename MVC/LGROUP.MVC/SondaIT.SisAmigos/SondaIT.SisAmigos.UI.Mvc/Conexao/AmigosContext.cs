using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using SondaIT.SisAmigos.UI.Mvc.Entities;
using SondaIT.SisAmigos.UI.Mvc.Models;

namespace SondaIT.SisAmigos.UI.Mvc.Conexao
{
    public class AmigosContext:DbContext
    {
        // NO METODO CONSTRUTOR IREMOS PASSAR A STRING DE CONEXÃO
        // UTILIZAMOS A PALAVRA base PARA INFORMAR QUE ESTAMOS PASSANDO
        // UM PARAMETRO PARA A CLASSE BASE DA HERENÇA NO CASO DbContext

        // OBS. CASO ESTEJA PROGRAMANDO SEU PROJETO EM N-CAMADAS A STRING DE CONEXÃO
        // DEVE PERMANECER NA CAMADA ROOT, OU SEJA NA CAMADA DE VISÃO, NORMALMENTE
        // WEB.CONFIG

        //integrated security =true : LOGANDO COM O USUARIO CORRENTE DO WINDOWS
        public AmigosContext()
            : base(@"data source=ALAN-PC; initial catalog =DB_AMIGOS; user id=sa;password=123456;")
        {
                
        }

        // AQUI CRIAMOS UMAPROPRIEDADE QUE REPRESENTARÁ A NOSSA TABELA
        // ELA SERA DO TIPO AmigosModel
        public DbSet<AmigosModel> Amigos { get; set; }


        // ESTAMOS SOBREESCREVENDO A API DO ENTITY FRAMEWORK ASSIM PODEMOS
        // FAZER TODAS AS CONFIGURAÇÕES NECESSARIAS PARA CRIAR O NOSSO BANCO DE DADOS
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // AQUI ESTAMOS FALANDO PARA O CONTEXXTO QUE NOSSO CONTEXTO DEVE SER INICIALIZADO
            // POREM, ESSA INSTANCIA SÓ IRÁ OCORRER SE O BANCO DE DADOS NÃO EXISTIR
            // PARA ISSO UTILIZAMOS A CLASSE VERIFICADORA CreateDatabaseIfNotExists
            Database.SetInitializer(new CreateDatabaseIfNotExists<AmigosContext>());

            // AQUI PASSAMOS AS CONFIGURAÇÕES FEITAS NA CLASSE AmigosEntities
            modelBuilder.Configurations.Add(new AmigosEntities());


            // AO FIM FALAMOS PARA O EF MANTER O RESTANTE DAS CONFIGURAÇÕES DA BASE
            base.OnModelCreating(modelBuilder);
        }
    }
}