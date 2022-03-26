namespace SondaIT.CodeFirst.FluentAPI.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    //Pra habilitar o MIGRATOINS NO PROJETO temos que utilizar POWER SHELL
    //Pra habilitar digitar o comando ENABLE-MIGRATIONS
    public partial class InitialCreate : DbMigration
    {
        //Quando habilitamos o MIGRATIONS no projeto ele ja gerou um BACKUP inicial das tabelas
        //Os backups que ele faz não são de dados, são de ESTRUTURAS (NOME E CAMPOS DA TABELA)
        //MIGRATION = BACKUP
        public override void Up()
        {
            CreateTable(
                "dbo.TB_SEXO",
                c => new
                    {
                        ID_SEXO = c.Int(nullable: false, identity: true),
                        DS_SEXO = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID_SEXO);
            
            CreateTable(
                "dbo.TB_ESTADO_CIVIL",
                c => new
                    {
                        ID_ESTADO_CIVIL = c.Int(nullable: false, identity: true),
                        DS_ESTADO_CIVIL = c.String(nullable: false, maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.ID_ESTADO_CIVIL);
            
            CreateTable(
                "dbo.TB_CLIENTE",
                c => new
                    {
                        ID_CLIENTE = c.Int(nullable: false, identity: true),
                        NM_CLIENTE = c.String(nullable: false, maxLength: 50, unicode: false),
                        DS_EMAIL = c.String(nullable: false, maxLength: 30, unicode: false),
                        NR_TELEFONE = c.String(nullable: false, maxLength: 15, unicode: false),
                        DT_NASCIMENTO = c.DateTime(nullable: false),
                        SALARIO = c.Decimal(nullable: false, precision: 6, scale: 2),
                        ID_SEXO = c.Int(nullable: false),
                        ID_ESTADO_CIVIL = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CLIENTE)
                .ForeignKey("dbo.TB_ESTADO_CIVIL", t => t.ID_ESTADO_CIVIL)
                .ForeignKey("dbo.TB_SEXO", t => t.ID_SEXO)
                .Index(t => t.ID_SEXO)
                .Index(t => t.ID_ESTADO_CIVIL);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_CLIENTE", "ID_SEXO", "dbo.TB_SEXO");
            DropForeignKey("dbo.TB_CLIENTE", "ID_ESTADO_CIVIL", "dbo.TB_ESTADO_CIVIL");
            DropIndex("dbo.TB_CLIENTE", new[] { "ID_ESTADO_CIVIL" });
            DropIndex("dbo.TB_CLIENTE", new[] { "ID_SEXO" });
            DropTable("dbo.TB_CLIENTE");
            DropTable("dbo.TB_ESTADO_CIVIL");
            DropTable("dbo.TB_SEXO");
        }
    }
}
