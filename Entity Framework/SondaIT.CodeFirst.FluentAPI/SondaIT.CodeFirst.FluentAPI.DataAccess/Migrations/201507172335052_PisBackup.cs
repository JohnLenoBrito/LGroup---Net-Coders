namespace SondaIT.CodeFirst.FluentAPI.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PisBackup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_CLIENTE", "NR_PIS", c => c.String(maxLength: 22, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_CLIENTE", "NR_PIS");
        }
    }
}
