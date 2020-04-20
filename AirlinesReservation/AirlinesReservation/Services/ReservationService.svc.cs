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
        public void AddReservation(Flight flight, User user) => throw new NotImplementedException();
        public bool CheckReservation(Guid number) => throw new NotImplementedException();
        public byte[] ConfirmReservation(User user) => throw new NotImplementedException();

        public void DoWork()
        {
        }
    }
}
