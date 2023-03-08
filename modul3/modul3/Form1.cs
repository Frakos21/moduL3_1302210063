namespace modul3
{
    public partial class Form1 : Form
    {
        string temp = "";
        int d1 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text += "1";
            this.temp+= "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text += "2";
            this.temp += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label1.Text += "3";
            this.temp += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a= d1 + int.Parse(temp);
            this.label1.Text = a.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.label1.Text += "+";
            this.d1 += int.Parse(temp);
            temp = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.label1.Text += "0";
            this.temp += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.label1.Text += "9";
            this.temp += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.label1.Text += "8";
            this.temp += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.label1.Text += "7";
            this.temp += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.label1.Text += "6";
            this.temp += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label1.Text += "5";
            this.temp += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label1.Text += "4";
            this.temp += "4";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.label1.Text += "1";
            this.temp += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}