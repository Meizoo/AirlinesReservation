namespace AirlinesReservation.Models
{
    using System;

    public class Flight
    {
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public int Sits { get; set; }
        public int TakenSits { get; set; }
        public double Cost { get; set; }
        public string FromCity { get; set; }
        public string ToCity { get; set; }
    }
}