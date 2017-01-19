using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RomOnDemand
{
    class Emulator
    {
        public string emulateur_exe { get; set; }
        public string rom_folder { get; set; }
        public string rom_extension { get; set; }

        public string cover { get; set; }
        public Dictionary<string, Rom> RomCollection { get; set; }
        public Dictionary<string, bool> options { get; set; }

        static String[] cover_filter = { "jpg", "jpeg", "png", "gif", "tiff", "bmp" };

        public string loadRoms()
        {

            this.RomCollection = new Dictionary<string, Rom>();

            DirectoryInfo dir = new DirectoryInfo(this.rom_folder);
            FileInfo[] fichiers = dir.GetFiles("*." + this.rom_extension);

            foreach (FileInfo rom_file in fichiers)
            {
                String rom_name = rom_file.Name.Replace(rom_file.Extension, "");

                FileInfo[] covers = dir.GetFiles(rom_name + "*");
                var romcover_path = "";
                foreach (FileInfo romcover in covers)
                {
                    if (cover_filter.Contains(romcover.Extension.Replace(".","")))
                    {
                        romcover_path = romcover.FullName;
                    }
                }
                
                if (romcover_path != "")
                {
                    var tempRom = new Rom(rom_file.FullName, romcover_path);
                    this.RomCollection.Add(rom_name, tempRom);
                }
            }

            return null;
        }

        public string init()
        {


            if (File.Exists(this.emulateur_exe))
            {
                this.loadRoms();
            }

            return null;
        }

    }

}
