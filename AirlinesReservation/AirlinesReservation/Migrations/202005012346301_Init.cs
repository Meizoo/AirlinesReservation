namespace AirlinesReservation.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Sits = c.Int(nullable: false),
                        TakenSits = c.Int(nullable: false),
                        Cost = c.Double(nullable: false),
                        FromCity = c.String(),
                        ToCity = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Guid(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        DurationTime = c.Int(nullable: false),
                        ReservationType = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        FlightId = c.Int(nullable: false),
                        TicketId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .ForeignKey("dbo.Tickets", t => t.TicketId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.FlightId)
                .Index(t => t.TicketId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        IsBought = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Surname = c.String(),
                        Birth = c.DateTime(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reservations", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.Reservations", "FlightId", "dbo.Flights");
            DropIndex("dbo.Reservations", new[] { "TicketId" });
            DropIndex("dbo.Reservations", new[] { "FlightId" });
            DropIndex("dbo.Reservations", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.Reservations");
            DropTable("dbo.Flights");
        }
    }
}
