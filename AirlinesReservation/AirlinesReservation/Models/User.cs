namespace AirlinesReservation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Dynamic;
    using System.Runtime.Serialization;

    [DataContract]
    [KnownType(typeof(Reservation))]
    public class User
    {
        public User()
        {
            Reservation = new List<Reservation>();
        }
        [DataMember]
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public DateTime Birth { get; set; }
        [DataMember]
        public DateTime CreationTime { get; set; }
        [DataMember]
        public Sex Gender { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
    }
}