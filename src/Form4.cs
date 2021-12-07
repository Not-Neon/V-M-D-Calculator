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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out decimal MassArg);
            decimal.TryParse(textBox2.Text, out decimal DensityArg);

            ResultLabel.Text = Convert.ToString(Calculator.Calculator.Volume(MassArg, DensityArg));
        }
    }
}
