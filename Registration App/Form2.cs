using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value1 = (int)numericUpDown1.Value;
            int value2 = (int)numericUpDown2.Value;

            if(comboBox1.SelectedIndex == 0) {
                int sum = value1 + value2;
                label1.Text = sum.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int sub = value1 - value2;
                label1.Text = sub.ToString();
            }

            if (comboBox1.SelectedIndex == 2)
            {
                int mul = value1 * value2;
                label1.Text = mul.ToString();
            }
            
        }
    }
}
