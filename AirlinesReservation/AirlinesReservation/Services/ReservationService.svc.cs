using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using AirlinesReservation.DB;
using AirlinesReservation.Models;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using PdfGen;

namespace AirlinesReservation.Services
{
	[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
	public class ReservationService : IReservationService
	{
		DataContext context = new DataContext();
		public void AddReservation(Flight flight, User user)
		{
			var reservation = new Reservation
			{
				Number = Guid.NewGuid(),
				CreationTime = DateTime.Now,
				DurationTime = 30,
				Flight = flight,
				User = user,
				Ticket = new Ticket() { IsBought = false, Type = TicketType.BusinessClass }
			};

			using (var context = new DataContext())
			{
				context.Reservations.Add(reservation);
				context.SaveChanges();
			}
		}
		public Reservation CheckReservation(Guid number, string username)
		{
			var user = this.context.Users.FirstOrDefault(r => r.Username == username);
			var res = this.context.Reservations.FirstOrDefault(r => r.Number == number && r.UserId == user.Id);
			res.Flight = this.context.Flights.FirstOrDefault(f => f.Id == res.FlightId);
			return res;
		}

		public List<Reservation> ShowAllReservation(string username)
		{
			var user = this.context.Users.FirstOrDefault(r => r.Username == username);
			var resrv = this.context.Reservations.Where(r => r.UserId == user.Id).ToList();
			return resrv;
		}

		public byte[] GetConfirmation(Guid number)
		{
			using (var context = new DataContext())
			using (var pdf = new PdfBuilder("./simple.pdf"))
				try
				{
					var res = context.Reservations.FirstOrDefault(r => r.Number == number);

					pdf.AddTable(
						$"From city: {res.Flight.FromCity}",
						$"To city: {res.Flight.ToCity}"
					);

					return Encoding.UTF8.GetBytes("Success");
				}
				catch { }
			return Encoding.UTF8.GetBytes("Failure");
		}
	}
}
