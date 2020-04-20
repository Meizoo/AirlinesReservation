namespace AirlinesReservation.Services
{
    using System.Collections.Generic;
    using System.ServiceModel;

    using AirlinesReservation.Models;

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFlightService" in both code and config file together.
    [ServiceContract]
    public interface IFlightService
    {
        [OperationContract]
        List<Flight> FindFlight();
        //[OperationContract]
        //List<Flight> ();

    }
}
