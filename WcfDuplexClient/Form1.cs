namespace WcfDuplexClient
{
	using System;
	using System.ServiceModel;
	using System.Windows.Forms;

	using WcfDuplexClient.ChatDuplexService;

	public partial class Form1 : Form
	{
		private InstanceContext instanceContext;
		private ChatDuplexClient client;
		private ControlWriter outGoingWriter;
		private ControlWriter incomingWriter;

		public Form1()
		{
			InitializeComponent();
			instanceContext = new InstanceContext(new CallbackHandler());
			outGoingWriter = new ControlWriter(textBoxOut);
			incomingWriter = new ControlWriter(textBoxIn);
			Console.SetOut(incomingWriter);
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			client = new ChatDuplexClient(instanceContext);
			buttonSend.Enabled = true;
			buttonStart.Enabled = false;
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			try
			{
				var msg = new MessageDto()
				{
					SendDateTime = DateTime.Now,
					Message = textBoxMessage.Text,
				};
				textBoxMessage.Text = string.Empty;
				client.SendMessage(msg);
				outGoingWriter.WriteLine(msg.SendDateTime.ToString("HH:mm:ss") + " | " +
					msg.Message);
			}
			catch (TimeoutException timeProblem)
			{
				Console.Error.WriteLine("The service operation timed out. " + timeProblem.Message);
				client.Abort();
				buttonSend.Enabled = false;
				buttonStart.Enabled = true;
			}
			catch (CommunicationException commProblem)
			{
				Console.Error.WriteLine("There was a communication problem. " + commProblem.Message);
				client.Abort();
				buttonSend.Enabled = false;
				buttonStart.Enabled = true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Unkonw Error: " + ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
				client.Abort();
				buttonSend.Enabled = false;
				buttonStart.Enabled = true;
			}
		}
	}
}