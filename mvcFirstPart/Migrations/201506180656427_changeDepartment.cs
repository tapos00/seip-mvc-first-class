namespace mvcFirstPart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeDepartment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "Code", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Code", c => c.String());
            AlterColumn("dbo.Departments", "Name", c => c.String());
        }
    }
}
