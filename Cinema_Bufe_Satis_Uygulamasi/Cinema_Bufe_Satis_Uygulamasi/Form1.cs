namespace Cinema_Bufe_Satis_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        int kasaTutar = 0; // bunu yapmam�n sebebi Butona her bast���mda buradaki i�lemi a���yla beraber yaps�n.
        private void button2_Click(object sender, EventArgs e)
        {
            int misir, su, bilet, cay,toplam;
            misir = Convert.ToInt16(textMisir.Text);
            su = Convert.ToInt16(textSu.Text);
            bilet = Convert.ToInt16(textBilet.Text);
            cay = Convert.ToInt16(textCay.Text);
            toplam = misir * 4 + su * 1 + cay * 5 + bilet * 30;
            labelToplam.Text = toplam+" TL";

            kasaTutar = kasaTutar + toplam;
            labelKasa.Text = kasaTutar+" TL";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBilet.Text = "";
            textCay.Text = "";
            textMisir.Text = "";
            textSu.Text = "";
            textBilet.Focus(); // burada s�f�rlad�ktan sonra imleci tekrardan bilete g�t�recek.
        }
    }
}