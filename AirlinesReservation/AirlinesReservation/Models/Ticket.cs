namespace AirlinesReservation.Models
{
    public class Ticket
    {
        public TicketType Type { get; set; }
        public Reservation Reservation { get; set; }
        public double Cost { get; set; }
    }
}