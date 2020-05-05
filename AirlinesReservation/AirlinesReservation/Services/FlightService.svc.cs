using System;
using System.Collections.Generic;
using System.Linq;

using AirlinesReservation.DB;
using AirlinesReservation.Models;

namespace AirlinesReservation.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FlightService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FlightService.svc or FlightService.svc.cs at the Solution Explorer and start debugging.
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
    }
}
