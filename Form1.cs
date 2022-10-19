using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pound_conversion_to_Bdt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pound = Convert.ToDouble(textBox1.Text);
            double calc = pound * 120;
            textBox2.Text = Convert.ToString(calc);
        }
    }
}
