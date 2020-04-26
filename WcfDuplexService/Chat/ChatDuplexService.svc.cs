using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDuplexService.Chat
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatDuplexService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select ChatDuplexService.svc or ChatDuplexService.svc.cs at the Solution Explorer and start debugging.
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
	public class ChatDuplexService : IChatDuplex
	{
		public void SendMessage(MessageDto message)
		{
			throw new NotImplementedException();
		}

		public void SendUrgent(MessageDto message)
		{
			throw new NotImplementedException();
		}
	}
}
