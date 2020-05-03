using System.Linq;
using System;

using AirlinesReservation.DB;
using AirlinesReservation.Models;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Collections.Generic;
using System.ServiceModel;
using iText.StyledXmlParser.Resolver.Resource;

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
            var res = context.Reservations.FirstOrDefault(r => r.Number == number && r.UserId == user.Id);
            res.Flight = context.Flights.FirstOrDefault(f => f.Id == res.FlightId);
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
            {
                var res = context.Reservations.FirstOrDefault(r => r.Number == number);
                PdfDocument pdfDoc = new PdfDocument(new PdfWriter("./simple.pdf"));
                Document doc = new Document(pdfDoc);
                Table table = new Table(UnitValue.CreatePercentArray(8)).UseAllAvailableWidth();

                table.AddCell($"From city: {res.Flight.FromCity}");
                table.AddCell($"To city: {res.Flight.ToCity}");


                doc.Add(table);

                doc.Close();
                throw new NotImplementedException();
            }
        }
    }
}
