using System;
using System.Linq;
using AirlinesReservation.DB;
using AirlinesReservation.Models;

namespace AirlinesReservation.Services
{
	public class TicketService : ITicketService
	{
		public bool BuyTicket(User user, Flight flight, TicketType type)
		{
			using (var context = new DataContext())
			{
				var res = context.Reservations
					.FirstOrDefault(i => i.UserId == user.Id && i.FlightId == flight.Id);

				if (res is null)
					context.Reservations.Add(new Reservation
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

				context.SaveChanges();
			}
			return true;
		}
	}
}
