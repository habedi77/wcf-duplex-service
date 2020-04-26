using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfDuplexClient.ChatDuplexService;


namespace WcfDuplexClient
{
	public partial class Form1 : Form
	{

		private InstanceContext instanceContext;
		private ChatDuplexClient client;
		private ControlWriter outGoingWriter;
		private ControlWriter incomingWriter;
		public Form1()
		{
			InitializeComponent();

			// Construct InstanceContext to handle messages on callback interface
			instanceContext = new InstanceContext(new CallbackHandler());

			// Create a client
			//client = new CalculatorDuplexClient(instanceContext);


			outGoingWriter = new ControlWriter(textBoxOut);
			incomingWriter = new ControlWriter(textBoxIn);
			Console.SetOut(incomingWriter);
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			client = new ChatDuplexClient(instanceContext);
			buttonSend.Enabled = true;
			//try
			//{
			//    // Call the AddTo service operation.
			//    double value = 100.00D;
			//    client.AddTo(value);

			//    // Call the SubtractFrom service operation.
			//    value = 50.00D;
			//    client.SubtractFrom(value);

			//    // Call the MultiplyBy service operation.
			//    value = 17.65D;
			//    client.MultiplyBy(value);

			//    // Call the DivideBy service operation.
			//    value = 2.00D;
			//    client.DivideBy(value);

			//    // Complete equation.
			//    client.Clear();

			//    // Wait for callback messages to complete before
			//    // closing.
			//    System.Threading.Thread.Sleep(5000);

			//    // Close the WCF client.
			//    client.Close();
			//    Console.WriteLine("Done!");
			//}
			//catch (TimeoutException timeProblem)
			//{
			//    Console.WriteLine("The service operation timed out. " + timeProblem.Message);
			//    client.Abort();
			//    Console.Read();
			//}
			//catch (CommunicationException commProblem)
			//{
			//    Console.WriteLine("There was a communication problem. " + commProblem.Message);
			//    client.Abort();
			//    Console.Read();
			//}

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
				outGoingWriter.WriteLine(msg.SendDateTime.ToString("HH:mm:ss")+ " | " +
					msg.Message);
			}
			catch (TimeoutException timeProblem)
			{
				Console.Error.WriteLine("The service operation timed out. " + timeProblem.Message);
				client.Abort();
			}
			catch (CommunicationException commProblem)
			{
				Console.Error.WriteLine("There was a communication problem. " + commProblem.Message);
				client.Abort();
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine("Unkonw Error: " + ex.Message);
				Console.Error.WriteLine(ex.StackTrace);
				client.Abort();
			}
		}
	}
}
