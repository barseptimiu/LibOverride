using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLogic
{
    public class OutputManager
    {
        private readonly TextBox Output;

        public OutputManager(TextBox textBox)
        {
            Output = textBox;
        }

        public void Writeline(string text)
        {
            Output.Text += text + "\n";
        }

        public void Clear()
        {
            Output.Text = "";
        }
    }
}
