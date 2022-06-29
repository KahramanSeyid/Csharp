namespace SinavNotHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ad, soyad;
            int sinav1, sinav2,proje;
            double ort;
           ad = textBox1.Text;
            soyad = textBox2.Text;
            sinav1 = Convert.ToInt16(textBox3.Text);
            sinav2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ort = (sinav1 + sinav2 + proje) / 3;
            listBox1.Items.Add("Ýsim: "+ad + " Soyisim" + soyad+" Ortalamasý:"+ort);

        }
    }
}