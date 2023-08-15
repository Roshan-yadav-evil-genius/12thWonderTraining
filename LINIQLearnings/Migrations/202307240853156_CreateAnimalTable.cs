namespace LINIQLearnings.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAnimalTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        location = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Animals");
        }
    }
}
