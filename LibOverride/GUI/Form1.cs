using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.Url = new Uri(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            comboBox1.SelectedIndex = comboBox1.FindStringExact("libAndroidAutoAppLogic.so");
        }
    }
}
