using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_app
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Num1textBox.Text != "" & Num2textBox.Text != "")
            {
                OutputLabel.Text = "Output: " + Functions.add(double.Parse(Num1textBox.Text), double.Parse(Num1textBox.Text));
            }
        }

        private void Num1textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Num1textBox.Text != "" & Num2textBox.Text != "")
            {
                OutputLabel.Text = "Output: " + Functions.sub(double.Parse(Num1textBox.Text), double.Parse(Num1textBox.Text));
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (Num1textBox.Text != "" & Num2textBox.Text != "")
            {
                OutputLabel.Text = "Output: " + Functions.multiply(double.Parse(Num1textBox.Text), double.Parse(Num1textBox.Text));
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (Num1textBox.Text != "" & Num2textBox.Text != "")
            {
                OutputLabel.Text = "Output: " + Functions.divide(double.Parse(Num1textBox.Text), double.Parse(Num1textBox.Text));
            }
        }
    }
}
