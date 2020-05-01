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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FlightService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FlightService.svc or FlightService.svc.cs at the Solution Explorer and start debugging.
    public class FlightService : IFlightService
    {
        DataContext context = new DataContext();
        public List<Flight> GetAllFlights()
        {
            try
            {

            return context.Flights.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
        }
        public List<Flight> FindFlight(string toCity)
        {
            return context.Flights.Where(f => f.ToCity.Equals(toCity)).ToList();
        }
    }
}
