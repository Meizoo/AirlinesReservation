using System.Runtime.Serialization;

namespace AirlinesReservation.Models
{
    [DataContract]
    public enum TicketType
    {
        [EnumMember]
        FirstClass,
        [EnumMember]
        BusinessClass,
        [EnumMember]
        RoundTrip
    }
}