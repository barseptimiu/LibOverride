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

        public AndroidAutoAppLogic()
        {
            Path = path;
        }
    }
}
