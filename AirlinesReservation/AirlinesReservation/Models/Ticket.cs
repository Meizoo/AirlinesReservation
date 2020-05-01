using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace AirlinesReservation.Models
{
    [DataContract]
    public class Ticket
    {
        public Ticket()
        {

        }
        [DataMember]
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [DataMember]
        public TicketType Type { get; set; }
        [DataMember]
        public bool IsBought { get; set; }

    }
}