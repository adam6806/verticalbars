using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    public partial class Form1 : Form
    {

        private Random rand = new Random();
        private int maxHeight = 200;
        private Progress battProgress;
        private Progress networkProgress;
        private Progress motherboardProgress;
        private Progress cpuProgress;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            battProgress = new Progress(battPic, rand);
            networkProgress = new Progress(networkPic, rand);
            motherboardProgress = new Progress(motherboardPic, rand);
            cpuProgress = new Progress(cpuPic, rand);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            // Calculate and set new heights
            battProgress.updateHeight();
            networkProgress.updateHeight();
            motherboardProgress.updateHeight();
            cpuProgress.updateHeight();
            
        }
    }
}
