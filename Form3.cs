using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHJWARE_2._0
{
    public partial class Form3 : Form
    {
        int hoursleft = 01;
        int minutesleft  = 30;
        int secondesleft = 00;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("You must see rules!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (minutesleft == 0)
            {
                if(hoursleft== 0)
                {
                    MessageBox.Show("Time left!");
                    Process.Start("taskkill");
                    return;
                }
                hoursleft--;
                minutesleft = minutesleft + 60;
                return;
            }
            if (secondesleft== 0) {
                minutesleft--;
                secondesleft = secondesleft + 60;

                return;
            }
            
            secondesleft--;
            label1.Text = hoursleft.ToString() + ":" + minutesleft.ToString() + ":" + secondesleft.ToString();

        }
    }
}
