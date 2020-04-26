using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfDuplexService.Chat
{
	[DataContract]
	public class MessageDto
	{
		[DataMember]
		public string Message { get; set; }

		[DataMember]
		public DateTime SendDateTime { get; set; }
	}
}