using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserLogic
{
    public class WebBrowserViewModel
    {
        public WebBrowser WebBrowser { get; set; }

        public WebBrowserViewModel(WebBrowser webBrowser)
        {
            WebBrowser = webBrowser;
            WebBrowser.Url = new Uri(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        public void GoBack()
        {
            if (WebBrowser.CanGoBack)
            {
                WebBrowser.GoBack();
            }
        }

        public void GoForward()
        {
            if (WebBrowser.CanGoForward)
            {
                WebBrowser.GoForward();
            }
        }

        public void Navigate(string path)
        {
            try
            {
                WebBrowser.Url = new Uri(path);
            }
            catch(UriFormatException e)
            {
                throw e;
            }

            WebBrowser.Focus();
        }
    }
}
