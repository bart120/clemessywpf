namespace clemessywpf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePieces : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Pieces", name: "Reference", newName: "ref");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Pieces", name: "ref", newName: "Reference");
        }
    }
}
