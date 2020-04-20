using AirlinesReservation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirlinesReservation.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReservationService" in both code and config file together.
    [ServiceContract]
    public interface IReservationService
    {
        [OperationContract]
        void AddReservation(Flight flight, User user);
        [OperationContract]
        byte[] ConfirmReservation(User user); // zwrócić pdf zakodowane w MIME
        [OperationContract]
        bool CheckReservation(Guid number);

    }
}
