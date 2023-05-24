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
    public partial class HAHHa2 : Form
    {
        public HAHHa2()
        {
            InitializeComponent();
            Random rand = new Random();
            int x = rand.Next(0, 1920);
            int y = rand.Next(0, 1080);
            this.ShowInTaskbar = false;
            this.TopMost = false;
            this.Location = new Point(x, y);
            this.Visible= false;
        }

        private void HAHHa2_Load(object sender, EventArgs e)
        {

        }
    }
}
