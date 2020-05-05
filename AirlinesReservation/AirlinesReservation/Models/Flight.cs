using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace AirlinesReservation.Models
{
    [DataContract]
    public class Flight
    {
        public Flight()
        {
        }

        public Flight(DateTime date, int sits, int takenSits, double cost, string fromCity, string toCity)
        {
            this.Date      = date;
            this.Sits      = sits;
            this.TakenSits = takenSits;
            this.Cost      = cost;
            this.FromCity  = fromCity ?? throw new ArgumentNullException(nameof(fromCity));
            this.ToCity    = toCity   ?? throw new ArgumentNullException(nameof(toCity));
        }

        [DataMember]
        public DateTime Date { get; set; }

        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataMember]
        public int Sits { get; set; }

        [DataMember]
        public int TakenSits { get; set; }

        [DataMember]
        public double Cost { get; set; }

        [DataMember]
        public string FromCity { get; set; }

        [DataMember]
        public string ToCity { get; set; }

    }
}