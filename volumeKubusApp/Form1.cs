namespace volumeKubusApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int numSisi = 0;
            bool isNumSisi = int.TryParse(txtSisi.Text, out numSisi);

            if (isNumSisi)
            {
                int sisi = (int) Math.Pow((double)numSisi, 3.0);
                txtVolume.Text = sisi.ToString();
            } else
            {
                MessageBox.Show("Hanya Format Angka", "Error");
            }
        }
    }
}