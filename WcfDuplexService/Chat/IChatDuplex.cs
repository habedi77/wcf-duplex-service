using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;


namespace WcfDuplexService.Chat
{
	[ServiceContract(CallbackContract = typeof(IChatDuplex), SessionMode = SessionMode.Required)]
	public interface IChatDuplex
	{
		[OperationContract(IsOneWay = true)]
		void SendMessage(MessageDto message);

		//[OperationContract(IsOneWay = true)]
		//void SendUrgent(MessageDto message);
	}
}