using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfDuplexClient.ChatDuplexService;

namespace WcfDuplexClient
{
    public class CallbackHandler : IChatDuplexCallback
    {
        public void SendMessage(MessageDto message)
        {
            Console.WriteLine(
                message.SendDateTime.ToShortTimeString() + " | " +
                message.Message);
        }
    }
}
