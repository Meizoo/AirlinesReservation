using AirlinesReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirlinesReservation.DB
{
    public static class InitialDB
    {
        public static List<Flight> Flights { get; set; }
        public static List<Reservation> Reservations { get; set; }
        public static List<User> Users { get; set; }
        public static List<Ticket> Tickets { get; set; }
        public static void Init()
        {
            var list = Enumerable.Range(1, 10);
            Flights = new List<Flight>(list.Select<int, Flight>(i => new Flight
            {
                Id = i,
                Date = DateTime.UtcNow,
                FromCity = "Białystok" + i,
                ToCity = "Warszawa" + i,
                Sits = i * 10,
                TakenSits = i,
                Cost = i * 101.01,
            }));

            Tickets = new List<Ticket>(list.Select<int, Ticket>(i => new Ticket
            {
                Id = i,
                Type = (TicketType)(i % 3)
            }));

            Users = new List<User>(list.Select<int, User>(i => new User
            {
                Id = i,
                Surname = "Test" + i,
                Username = "Test" + i,
                CreationTime = DateTime.UtcNow,
                DateOfBirth = new DateTime(2000, i, i),
                Gender = (Sex)(i % 2),
            }));

            Reservations = new List<Reservation>(list.Select<int, Reservation>(i => new Reservation
            {
                Id = i,
                CreationTime = DateTime.UtcNow,
                DurationTime = i,
                Flight = Flights[i - 1],
                Number = Guid.NewGuid(),
                ReservationType = (ReservationType) (i % 4),
                Ticket = Tickets[i - 1],
                User = Users[i - 1],
            }));
            // Dodać rezerwację do usersów.
        }
    }
}