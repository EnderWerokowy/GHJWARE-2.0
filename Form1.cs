using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GHJWARE_2._0
{
    public partial class HAHHa : Form
    {
        public HAHHa()
        {
            InitializeComponent();
            Random rand = new Random();
            int x = rand.Next(0, 1920);
            int y = rand.Next(0, 1080);
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Location = new Point(x, y);
        }

        private void HAHHa_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(WorkThreadFunctionChangeLoc));
            thread.Start();
        }
        static void WorkThreadFunctionChangeLoc()
        {
            while(true)
            {
                Random rand = new Random();
                int x = rand.Next(0, 1920);
                int y = rand.Next(0, 1080);
                new HAHHa().Location = new Point(x, y);
                Thread.Sleep(250);
            }
           
        }
    }
}
