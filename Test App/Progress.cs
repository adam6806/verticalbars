using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    class Progress
    {

        private static int maxHeight = 200;
        private bool isPeaked;
        private int countSincePeaked;
        private PictureBox progressBar;
        private Random random;

        public Progress(PictureBox progressBar, Random random)
        {
            
            this.progressBar = progressBar;
            this.random = random;
            isPeaked = false;
            countSincePeaked = -1;
            progressBar.Height = maxHeight;
        }

        public void updateHeight()
        {
            int randomNum = 0;
            if (progressBar.Height == 0)
            {
                isPeaked = true;
            }

            if (isPeaked && progressBar.Height < 75)
            {
                randomNum = random.Next(-3, 5);
            }
            else if (isPeaked && progressBar.Height >= 75)
            {
                isPeaked = false;
            }

            if (!isPeaked)
            {
                if (progressBar.Height < 50)
                {
                    randomNum = random.Next(-5, 1);
                }
                else if (progressBar.Height > 150)
                {
                    randomNum = random.Next(-10, 8);
                }
                else
                {
                    randomNum = random.Next(-10, 11);
                }
            }

            if (randomNum + progressBar.Height < 0)
            {
                progressBar.Height = 0;
            }
            else if (randomNum + progressBar.Height > maxHeight)
            {
                progressBar.Height = maxHeight;
            }
            else
            {
                progressBar.Height = progressBar.Height += randomNum;
            }

            
        }
    }
}
