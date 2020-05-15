using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class AndroidAutoAppFramework : ReplaceableLib
    {
        private const string path = "/usr/lib/ovip/AppFwk/Domains";
        private const string fileName = "libAndroidAutoAppFramework.so";

        public AndroidAutoAppFramework()
        {
            Path = path;
            FileName = fileName;
        }
    }
}
