using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace AirlinesReservation.Models
{
    [DataContract]
    [KnownType(typeof(Reservation))]
    public class User
    {
        public User() => 
            this.Reservation = new List<Reservation>();

        [DataMember, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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