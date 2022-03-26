namespace SondaIT.CodeFirst.FluentAPI.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CpfRgBackup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_CLIENTE", "NR_CPF", c => c.String(maxLength: 15, unicode: false));
            AddColumn("dbo.TB_CLIENTE", "NR_RG", c => c.String(maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_CLIENTE", "NR_RG");
            DropColumn("dbo.TB_CLIENTE", "NR_CPF");
        }
    }
}
