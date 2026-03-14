using System.Security.Policy;

namespace Modul3_103022400108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double HitungKonversi(double nilai, string dari, string ke)
        {

            double celcius = 0;
            double hasil = 0;

            
            string dariLower = dari.ToLower();
            string keLower = ke.ToLower();

            if (dariLower == "celcius") celcius = nilai;
            else if (dariLower == "fahrenheit") celcius = (nilai - 32) * 5 / 9;
            else if (dariLower == "kelvin") celcius = nilai - 273.15;
            else if (dariLower == "reamur") celcius = nilai * 5 / 4;

            
            if (keLower == "celcius") hasil = celcius;
            else if (keLower == "fahrenheit") hasil = (celcius * 9 / 5) + 32;
            else if (keLower == "kelvin") hasil = celcius + 273.15;
            else if (keLower == "reamur") hasil = celcius * 4 / 5;

            
            return Math.Round(hasil, 2);
            return 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Masukkan angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               
                string inputRaw = textBox1.Text.Replace(',', '.');
                double nilaiAwal = double.Parse(inputRaw, System.Globalization.CultureInfo.InvariantCulture);

                string dari = comboBox1.SelectedItem.ToString();
                string ke = comboBox2.SelectedItem.ToString();

                double hasil = HitungKonversi(nilaiAwal, dari, ke);
                textBox2.Text = hasil.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
