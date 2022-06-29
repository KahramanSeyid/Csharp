namespace UcakBiletRezervasiyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: "+comboBox1.Text+"  Nereye: "+comboBox2.Text+" Tarih:"+dateTimePicker1.Text
                +" Saat:"+maskedTextBox1.Text+" Yolcu Ýsim Soyisim:"+textBox1.Text
                +" Yolcu TC No:"+maskedTextBox2.Text+" Yolcu Telefon No:"+maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}