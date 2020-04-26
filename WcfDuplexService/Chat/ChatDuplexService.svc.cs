namespace WcfDuplexService.Chat
{
	using System;
	using System.ServiceModel;
	using System.Threading;

	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChatDuplexService" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select ChatDuplexService.svc or ChatDuplexService.svc.cs at the Solution Explorer and start debugging.
	[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
	public class ChatDuplexService : IChatDuplex
	{
		private Random rand = new Random(DateTime.Now.Millisecond);

		public void SendMessage(MessageDto message)
		{
			if (rand.Next(0, 10) > 6)
			{
				return;
			}
			Thread.Sleep(rand.Next(100, 2000));
			message.SendDateTime = DateTime.Now;
			message.Message = "ECHO: " + message.Message;
			Callback.SendMessage(message);
		}

		IChatDuplex Callback
		{
			get
			{
				return OperationContext.Current.GetCallbackChannel<IChatDuplex>();
			}
		}
	}
}