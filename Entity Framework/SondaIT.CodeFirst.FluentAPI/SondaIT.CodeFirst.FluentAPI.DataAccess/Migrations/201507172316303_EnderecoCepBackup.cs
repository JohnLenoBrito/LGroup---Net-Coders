namespace SondaIT.CodeFirst.FluentAPI.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnderecoCepBackup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_CLIENTE", "DS_ENDERECO", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.TB_CLIENTE", "NR_CEP", c => c.String(maxLength: 9, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_CLIENTE", "NR_CEP");
            DropColumn("dbo.TB_CLIENTE", "DS_ENDERECO");
        }
    }
}
