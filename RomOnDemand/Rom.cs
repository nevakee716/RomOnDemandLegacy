using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomOnDemand
{
    class Rom
    {
        public string path { get; set; }
        public string cover { get; set; }

        public Rom(string path,string cover)
        {
            this.path = path;
            this.cover = cover;
        }

    }
}
