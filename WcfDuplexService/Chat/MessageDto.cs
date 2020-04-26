namespace WcfDuplexService.Chat
{
	using System;
	using System.Runtime.Serialization;

	[DataContract]
	public class MessageDto
	{
		[DataMember]
		public string Message { get; set; }

		[DataMember]
		public DateTime SendDateTime { get; set; }
	}
}