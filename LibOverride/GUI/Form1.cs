using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;

namespace GUI
{
    public partial class Form1 : Form
    {
        readonly WebBrowserViewModel webBrowserViewModel;
        public Form1()
        {
            InitializeComponent();
            webBrowserViewModel = new WebBrowserViewModel(webBrowser1);
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\CachedValues.txt");
            LoadCachedValues(filePath);
        }

        private void LoadCachedValues(string filePath)
        {
            List<String> values = new List<string>();

            try
            {
                using (StreamReader fileReader = File.OpenText(filePath))
                {
                    while (!fileReader.EndOfStream)
                    {
                        values.Add(fileReader.ReadLine());
                    }
                }

                username_textBox.Text = values[0];
                ipAddress_textBox.Text = values[1];
                port_textBox.Text = values[2];
                if (values.Count > 3)
                    password_textBox.Text = values[3];
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            

            comboBox1.SelectedIndex = comboBox1.FindStringExact("libAndroidAutoAppLogic.so");

            // change the focus from textboxes
            webBrowser1.TabIndex = 0;
        }

        private void goBack_button_Click(object sender, EventArgs e)
        {
            webBrowserViewModel.GoBack();
        }

        private void goForward_button_Click(object sender, EventArgs e)
        {
            webBrowserViewModel.GoForward();
        }

        private void path_textBox_Enter(object sender, EventArgs e)
        {
            path_textBox.Text = "";
        }

        private void path_textBox_Leave(object sender, EventArgs e)
        {
            path_textBox.Text = "You can paste the full path here and press enter.";
        }

        private void path_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    webBrowserViewModel.Navigate(path_textBox.Text);
                    e.Handled = e.SuppressKeyPress = true;
                }
                catch(UriFormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    webBrowser1.Focus();
                }
            }
        }

    }
}
