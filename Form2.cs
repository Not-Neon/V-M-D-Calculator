using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;

namespace V_M_p_Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out decimal MassArg);
            decimal.TryParse(textBox2.Text, out decimal VolumeArg);

            ResultLabel.Text = Convert.ToString(Calculator.Calculator.Density(MassArg, VolumeArg));
        }
    }
}
