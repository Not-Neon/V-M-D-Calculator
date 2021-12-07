using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V_M_p_Calculator
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out decimal DensityArg);
            decimal.TryParse(textBox2.Text, out decimal VolumeArg);

            ResultLabel.Text = Convert.ToString(Calculator.Calculator.Mass(DensityArg, VolumeArg));
        }
    }
}
