using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibModels
{
    public abstract class ReplaceableLib
    {
        protected string Path { get; set; }

        public void ReplaceLib()
        {
            // temporary
            Debug.WriteLine(Path);
        }
    }
}
