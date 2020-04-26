namespace WcfDuplexService.Chat
{
	using System.ServiceModel;

	[ServiceContract(CallbackContract = typeof(IChatDuplex), SessionMode = SessionMode.Required)]
	public interface IChatDuplex
	{
		[OperationContract(IsOneWay = true)]
		void SendMessage(MessageDto message);

		//[OperationContract(IsOneWay = true)]
		//void SendUrgent(MessageDto message);
	}
}