namespace AirlinesReservation.Models
{
    using System;

    public class Reservation
    {
        public int Id { get; set; }
        public Guid Number { get; set; }
        public DateTime CreationTime { get; set; }
        public int DurationTime { get; set; }
        public ReservationType ReservationType { get; set; }
        public User User { get; set; }
        public Flight Flight { get; set; }
        public Ticket Ticket { get; set; }
    }
}