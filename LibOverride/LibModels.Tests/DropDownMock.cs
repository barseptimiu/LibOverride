using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels.Tests
{
    class DropDownMock
    {
        public string SelectedItem(int index)
        {
            switch (index)
            {

                case 0:
                    return "AndroidAutoApp";
                case 1:
                    return "libAndroidAutoAppLogic.so";

                case 2:
                    return "libAndroidAutoAppFramework.so";

                case 3:
                    return "libAAutoHMILib.so";

                default:
                    return "null";
            }    
        }
    }
}
