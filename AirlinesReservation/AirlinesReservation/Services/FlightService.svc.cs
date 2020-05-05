using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AirlinesReservation.DB;
using AirlinesReservation.Models;

namespace AirlinesReservation.Services
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FlightService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select FlightService.svc or FlightService.svc.cs at the Solution Explorer and start debugging.
	[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
	public class FlightService : IFlightService
    {
        private readonly DataContext context = new DataContext();
        public List<Flight> GetAllFlights()
        {
            try
            {
                return this.context.Flights.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }
        
        public List<Flight> FindFlight(string toCity)
        {
            return this.context.Flights.Where(f => f.ToCity.Equals(toCity)).ToList();
        }

        public User Login(string username)
        {
            return context.Users.FirstOrDefault(u => u.Username == username);
        }

		public Reservation BuyTicket(User user, Flight flight, TicketType type)
		{
			Reservation ticket = null;
			using (var context = new DataContext())
			{
				var res = context.Reservations
					.FirstOrDefault(i => i.UserId == user.Id && i.FlightId == flight.Id);

				if (res is null)
					res = context.Reservations.Add(new Reservation
					{
						Number = Guid.NewGuid(),
						CreationTime = DateTime.Now,
						DurationTime = 30,
						Flight = flight,
						User = user,
						Ticket = new Ticket { IsBought = true, Type = type }
					});
				else if (res.Ticket is null)
					res.Ticket = new Ticket
					{
						IsBought = true,
						Type = type,
					};
				else
				{
					res.Ticket.IsBought = true;
					if (res.Ticket.Type != type)
						res.Ticket.Type = type;
				}
				res.ReservationType = ReservationType.Active;
				ticket = res;
				context.SaveChanges();
			}
			return ticket;
		}
	}
}
