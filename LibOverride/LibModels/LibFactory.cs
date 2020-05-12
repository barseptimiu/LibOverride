using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public class LibFactory
    {
        public ReplaceableLib Create(string LibType)
        {
            switch(LibType)
            {
                case "AndroidAutoApp":
                    return new AndroidAutoApp();

                case "libAndroidAutoAppLogic.so":
                    return new AndroidAutoAppLogic();

                case "libAndroidAutoAppFramework.so":
                    return new AndroidAutoAppFramework();

                case "libAAutoHMILib.so":
                    return new AndroidAutoHMI();

                default:
                    return null;
            }
        }
    }
}
