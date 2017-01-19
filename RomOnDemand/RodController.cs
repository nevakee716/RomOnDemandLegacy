using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RomOnDemand
{


    class RodController
    {

        public Dictionary<string, Emulator> emuCollection { get; set; }
        public Dictionary<string, bool> RODOptions { get; set; }

        public string init()
        {
            foreach (string emuName in this.emuCollection.Keys)
            {
                emuCollection[emuName].init();
            }
            return null;
        }







        }
    }





