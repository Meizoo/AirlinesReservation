using System.Runtime.Serialization;
using System.ServiceModel;

namespace AirlinesReservation
{
	[ServiceContract]
	public interface IService1
	{
		[OperationContract]
		string GetData(int value);

		[OperationContract]
		CompositeType GetDataUsingDataContract(CompositeType composite);

		// TODO: Add your service operations here
	}

	[DataContract]
	public class CompositeType
	{
		[DataMember]
		public bool BoolValue { get; set; } = true;

		[DataMember]
		public string StringValue { get; set; } = "Hello ";
	}
}
