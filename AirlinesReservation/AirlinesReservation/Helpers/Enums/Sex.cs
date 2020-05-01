using System.Runtime.Serialization;

namespace AirlinesReservation.Models
{
    [DataContract]
    public enum Sex
    {
        [EnumMember]
        Male,
        [EnumMember]
        Female
    }
}