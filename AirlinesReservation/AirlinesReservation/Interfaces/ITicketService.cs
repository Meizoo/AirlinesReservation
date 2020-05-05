using System.ServiceModel;

using AirlinesReservation.Models;

namespace AirlinesReservation.Services
{
	[ServiceContract]
	public interface ITicketService
	{
		[OperationContract]
		bool BuyTicket(User user, Flight flight, TicketType type);
	}
}
