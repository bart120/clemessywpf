namespace clemessywpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pieces",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Reference = c.String(),
                        Tarif = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Maj = c.DateTime(nullable: false),
                        Statut = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pieces");
        }
    }
}
