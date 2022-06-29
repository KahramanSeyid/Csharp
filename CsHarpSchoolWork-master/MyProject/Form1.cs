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

namespace MyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stopwatch km = new Stopwatch();
        private void buttonBasla_Click(object sender, EventArgs e)
        {
            if (!km.IsRunning)
            {
                km.Start();
            }
        }

        private void buttonBekle_Click(object sender, EventArgs e)
        {
            if (km.IsRunning)
            {
                km.Stop();
            }
        }

        private void buttonTekrar_Click(object sender, EventArgs e)
        {
            labelKronomotre.Text =  "00:00:00:00:000";
            km.Restart();
        }

        private void timerZaman_Tick(object sender, EventArgs e)
        {
            if (km.IsRunning)
            {
                //zaman aralıgını almak için
                TimeSpan span = km.Elapsed;
                labelKronomotre.Text = String.Format
                    ("{0:00}:{1:00}:{2:00}:{3:000}:",
               span.Hours,span.Minutes,span.Seconds,span.Milliseconds);
            }
        }
    }
}
