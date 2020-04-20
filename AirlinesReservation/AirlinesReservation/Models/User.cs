namespace AirlinesReservation.Models
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreationTime { get; set; }
        public Sex Gender { get; set; }
        public List<Reservation> Reservation { get; set; }
    }
}