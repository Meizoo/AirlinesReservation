using System;
using System.Collections.Generic;
using System.ServiceModel;

using AirlinesReservation.Models;

namespace AirlinesReservation.Services
{
    [ServiceContract]
    public interface IReservationService
    {
        [OperationContract]
        void AddReservation(Flight flight, User user);

        [OperationContract]
        Reservation CheckReservation(Guid number, string username);

        [OperationContract]
        List<Reservation> ShowAllReservation(string username);

        [OperationContract]
        byte[] GetConfirmation(Guid user);
    }
}
