using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class AndroidAutoApp : ReplaceableLib
    {
        private const string path = "/usr/bin/ovip/Android";
        private const string fileName = "AndroidAutoApp";

        public AndroidAutoApp()
        {
            Path = path;
            FileName = fileName;
        }
    }
}
