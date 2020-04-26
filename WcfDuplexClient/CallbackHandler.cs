namespace WcfDuplexClient
{
	using System;

	using WcfDuplexClient.ChatDuplexService;

	public class CallbackHandler : IChatDuplexCallback
	{
		public void SendMessage(MessageDto message)
		{
			Console.WriteLine(
				message.SendDateTime.ToString("HH:mm:ss") + " | " +
				message.Message);
		}
	}
}