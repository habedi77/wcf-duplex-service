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
using WcfDuplexClient.CalculatorDuplexService;

namespace WcfDuplexClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			// Construct InstanceContext to handle messages on callback interface
			InstanceContext instanceContext = new InstanceContext(new CallbackHandler());

			// Create a client
			CalculatorDuplexClient client = new CalculatorDuplexClient(instanceContext);
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{

		}
	}
}
