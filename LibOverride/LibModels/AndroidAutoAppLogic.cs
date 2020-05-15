using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class AndroidAutoAppLogic : ReplaceableLib
    {
        private const string path = "/usr/lib/ovip/Android";
        private const string fileName = "libAndroidAutoAppLogic.so";

        public AndroidAutoAppLogic()
        {
            Path = path;
            FileName = fileName;
        }
    }
}
