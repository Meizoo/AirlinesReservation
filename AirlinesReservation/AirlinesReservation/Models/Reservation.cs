namespace AirlinesReservation.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [DataContract]
    [KnownType(typeof(User)), KnownType(typeof(Flight)), KnownType(typeof(Ticket))]
    public class Reservation
    {
        public Reservation()
        {

        }
        [DataMember]
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataMember]
        public Guid Number { get; set; }
        [DataMember]
        public DateTime CreationTime { get; set; }
        [DataMember]
        public int DurationTime { get; set; }
        [DataMember]
        public ReservationType ReservationType { get; set; }

        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public int FlightId { get; set; }
        [DataMember]
        public int TicketId { get; set; }

        [DataMember]
        public User User { get; set; }
        [DataMember]
        public Flight Flight { get; set; }
        [DataMember]
        public Ticket Ticket { get; set; }
    }
}