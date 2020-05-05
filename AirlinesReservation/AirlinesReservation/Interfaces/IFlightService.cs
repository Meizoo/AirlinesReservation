using System.Collections.Generic;
using System.ServiceModel;

using AirlinesReservation.Models;

namespace AirlinesReservation.Services
{
	[ServiceContract]
	public interface IFlightService
	{
		[OperationContract]
		List<Flight> FindFlight(string toCity);

		[OperationContract]
		List<Flight> GetAllFlights();

		[OperationContract]
		User Login(string username);
		[OperationContract]
		Reservation BuyTicket(User user, Flight flight, TicketType type);
		//[OperationContract]
		//List<Flight> ();
	}
}
