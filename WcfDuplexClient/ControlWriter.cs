using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfDuplexClient
{
    public class ControlWriter : TextWriter
    {
        private TextBoxBase textbox;
        public ControlWriter(TextBoxBase textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.AppendText(value.ToString());
        }

        public override void Write(string value)
        {
            textbox.AppendText(value);
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
