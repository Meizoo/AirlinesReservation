using AirlinesReservation.DB;
using AirlinesReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlinesReservation.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReservationService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ReservationService.svc or ReservationService.svc.cs at the Solution Explorer and start debugging.
    public class ReservationService : IReservationService
    {
        public void AddReservation(Flight flight, User user)
        {
            var reservation = new Reservation
            {
                Id = InitialDB.Reservations.Count + 1,
                Number = Guid.NewGuid(),
                CreationTime = DateTime.Now,
                DurationTime = 30,
                Flight = flight,
                User = user
            };
            InitialDB.Reservations.Add(reservation);
            InitialDB.Users.Select(u => u = user).Where(u => u.Username == user.Username);
        }

        public bool CheckReservation(Guid number, string username)
        {
            return InitialDB.Users.FirstOrDefault(u => u.Username == username).Reservation.Exists(r => r.Number == number);
        }
        
        public List<Reservation> ShowAllReservation(string username)
        {
            return InitialDB.Users.FirstOrDefault(u => u.Username == username).Reservation;
        }

        public byte[] GetConfirmation(User user)
        {
            throw new NotImplementedException();
        }
    }
}
