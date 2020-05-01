using System.Runtime.Serialization;

namespace AirlinesReservation.Models
{
    [DataContract]
    public enum ReservationType
    {
        [EnumMember]
        Active,
        [EnumMember]
        Pending,
        [EnumMember]
        Inactive,
        [EnumMember]
        Done,
    }
}