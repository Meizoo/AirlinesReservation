namespace AirlinesReservation.Migrations
{
    using AirlinesReservation.Models;
    using iText.Layout.Element;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Resources;

    internal sealed class Configuration : DbMigrationsConfiguration<AirlinesReservation.DB.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AirlinesReservation.DB.DataContext context)
        {
            var list = Enumerable.Range(1, 10);
            var flights = list.Select(i =>
            {
                return new Flight()
                {
                    Id = i,
                    Cost = i,
                    FromCity = $"Białystok{i}",
                    ToCity = $"Warszawa{i}",
                    Date = new DateTime(2020, 5, i, i, i, i),
                    Sits = i * 10,
                    TakenSits = i,
                };
            });

            var users = list.Select(i =>
            {
                return new User()
                {
                    Id = i,
                    Username = $"Test{i}",
                    Surname = $"Test{i}",
                    Birth = new DateTime(2020, i, i),
                    Gender = (Sex)(i % 2),
                    CreationTime = DateTime.Now,
                };
            });

            var tickets = list.Select(i =>
            {
                return new Ticket()
                {
                    Id = i,
                    IsBought = false,
                    Type = (TicketType)(i % 3),
                };
            });
            
            var reservations = list.Select(i =>
            {
                return new Reservation()
                {
                    Id = i,
                    CreationTime = DateTime.Now,
                    DurationTime = i,
                    FlightId = i,
                    Number = Guid.NewGuid(),
                    ReservationType = (ReservationType)(i % 4),
                    TicketId = i,
                    UserId = i
                };
            });
            context.Flights.AddRange(flights);
            context.Users.AddRange(users);
            context.Tickets.AddRange(tickets);
            context.Reservations.AddRange(reservations);
            context.SaveChanges();
        }
    }
}
