using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class MyForm2 : Form
    {
        Bitmap akrepResim = new Bitmap(MyProject.Properties.Resources.akrep);
        Bitmap yelkovanResim = new Bitmap(MyProject.Properties.Resources.yelkovan);
        Bitmap saniyeResim = new Bitmap(MyProject.Properties.Resources.saniye);

        DateTime zaman1 = DateTime.Now;
        int saat = 0;
        int dakika = 0;
        int saniye = 0;

        private void timerZaman1_Tick(object sender, EventArgs e)
        {
            //Otomotik saat kodları

            //zaman1 = DateTime.Now;
            //saat = zaman1.Hour;
            //dakika = zaman1.Minute;
            //saniye = zaman1.Second;
            //Single saniyeAci = saniye * 6;
            //Single dakikaAci = dakika * 6 + saniyeAci / 60;
            //Single saatAci = saat * 30 + dakikaAci / 12;

            //pictureBoxAkrep.Image = resimCevir(akrepResim, saatAci);
            //pictureBoxYelkovan.Image = resimCevir(yelkovanResim, dakikaAci);
            //pictureBoxSaniye.Image = resimCevir(saniyeResim, saniyeAci);
        }
        private Bitmap resimCevir (Bitmap eskiResim, float aci) 
        {
            Bitmap yeniResim = new Bitmap(eskiResim.Width, eskiResim.Height);
            using (Graphics grap = Graphics.FromImage(yeniResim))
            {
                grap.TranslateTransform(eskiResim.Width / 2, eskiResim.Height / 2);
                grap.RotateTransform(aci);
                grap.TranslateTransform(-eskiResim.Width / 2, -eskiResim.Height /2);
                grap.DrawImage(eskiResim, new Point(0, 0));
            }
            return yeniResim;
        }    
        public MyForm2()
        {
            InitializeComponent();
        }

        private void buttonDur_Click(object sender, EventArgs e)
        {
            timerSaat.Stop();
            saat = 0;
            dakika = 0;
            saniye = 0;

            labelZaman.Text = String.Format("{0:00}:{1:00}:{2:00}",
                saat, dakika, saniye);
        }

        private void buttonBASLA_Click(object sender, EventArgs e)
        {
            saat   =   (int)numericUpDownSaat.Value;
            dakika = (int)numericUpDownDakika.Value;
            saniye = (int)numericUpDownSaniye.Value;
            timerSaat.Start();

        }

        private void timerZaman_Tick(object sender, EventArgs e)
        {
            //Manuel  saat kodları

            saat = saat;
            dakika = dakika;
            saniye = saniye;
            Single saniyeAci = saniye * 6;
            Single dakikaAci = dakika * 6 + saniyeAci / 60;
            Single saatAci = saat * 30 + dakikaAci / 12;

            pictureBoxAkrep.Image = resimCevir(akrepResim, saatAci);
            pictureBoxYelkovan.Image = resimCevir(yelkovanResim, dakikaAci);
            pictureBoxSaniye.Image = resimCevir(saniyeResim, saniyeAci);


            if (saniye == 60)
            {

                dakika++;
                saniye = 0;
                if (dakika == 60)
                {
                    saat++;
                    dakika = 0;

                }
                if (saat == 13)
                {
                    saat = 0;
                    dakika = 0;
                    saniye = 0;
                }
            }

            labelZaman.Text = String.Format("{0:00}:{1:00}:{2:00}",
                saat, dakika, saniye);

            saniye++;

        }

        private void MyForm2_Load(object sender, EventArgs e)
        {
            pictureBoxAkrep.Parent = pictureBoxSaat;
            pictureBoxAkrep.Location = new Point(0, 0);

            pictureBoxYelkovan.Parent = pictureBoxAkrep;
            pictureBoxYelkovan.Location = new Point(0, 0);

            pictureBoxSaniye.Parent = pictureBoxYelkovan;
            pictureBoxSaniye.Location = new Point(0, 0);

            labelZaman.Parent = pictureBoxSaniye;
        }

    
    }
}
