namespace AirlinesReservation.Models
{
    using System;

    public class Reservation
    {
        public DateTime CreationTime { get; set; }
        public DateTime DurationTime { get; set; }
        public User User { get; set; }
        public Flight Flight { get; set; }
    }
}