using Calculator;

namespace V_M_p_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Density")
            {
                var form2 = new Form2();

                form2.ShowDialog();
            }
            else if (comboBox1.Text == "Mass")
            {
                var form3 = new Form3();

                form3.ShowDialog();
            }
            else if (comboBox1.Text == "Volume")
            {
                var form4 = new Form4();

                form4.ShowDialog();
            }
            else
            {
                label2.Text = "Error : Enter a valid parameter to calculate. Do not leave this box blank.";
            }
        }
    }
}