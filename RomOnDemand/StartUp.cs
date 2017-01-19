using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;    // to read a local text file
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RomOnDemand
{
    public partial class StartUp : Form
    {

        private ImageList consoleImageList;
        private RodController ROD;
        public string SelectedEmu;
        public string SelectedRom;
        public Dictionary<string, int> emuTable { get; set; }
        public Dictionary<int, string> emuTableReverse { get; set; }

        public StartUp()
        {
            InitializeComponent();
            consoleImageList = new ImageList();
            emuTable = new Dictionary<string, int>();
            emuTableReverse = new Dictionary<int, string>();
        }

        public string LoadConfig()
        {
            this.ROD = JsonConvert.DeserializeObject<RodController>(File.ReadAllText(@"config.json"));
            this.ROD.init();
            return null;
        }


        private void OnLoadStartup(object sender, EventArgs e)
        {
            this.LoadConfig();


            var k = 0;
            foreach (string emuName in this.ROD.emuCollection.Keys)
            {
                Image i = new Bitmap(ROD.emuCollection[emuName].cover);
                consoleImageList.Images.Add(emuName, i);
                emuTable.Add(emuName, k);
                emuTableReverse.Add(k, emuName);
                k++;
            }
            SelectedEmu = emuTableReverse[0];


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ClientSize = new Size((int)(this.Width * 0.6), (int) (this.Height*0.6));
            pictureBox1.Location = new Point(
                (int) (this.Width * 0.5) - pictureBox1.Size.Width/2,
                (int) (this.Height * 0.05)
            );
            pictureBox1.Image = consoleImageList.Images[0];
        }


    }
}
