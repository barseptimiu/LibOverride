using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class AndroidAutoHMI : ReplaceableLib
    {
        private const string path = "/usr/lib/ovip/AAuto";
        private const string fileName = "libAAutoHMILib.so";

        public AndroidAutoHMI()
        {
            Path = path;
            FileName = fileName;
        }
    }
}
