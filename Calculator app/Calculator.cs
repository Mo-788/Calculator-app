using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            if (double.TryParse(Num1textBox.Text, out _) & double.TryParse(Num2textBox.Text, out _))
            {
                OutputLabel.Text = "Output: " + Functions.add(double.Parse(Num1textBox.Text), double.Parse(Num2textBox.Text));
                ECLabel.Text = "";
            }
            else
            {
                ECLabel.Text = "Please enter a number into the text box";
            }

        }

        private void Num1textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (double.TryParse(Num1textBox.Text, out _) & double.TryParse(Num2textBox.Text, out _))
            {
                OutputLabel.Text = "Output: " + Functions.sub(double.Parse(Num1textBox.Text), double.Parse(Num2textBox.Text));
                ECLabel.Text = "";
            }
            else
            {
                ECLabel.Text = "Please enter a number into the text box";
            }

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {

            if (double.TryParse(Num1textBox.Text, out _) & double.TryParse(Num2textBox.Text, out _))
            {
                OutputLabel.Text = "Output: " + Functions.multiply(double.Parse(Num1textBox.Text), double.Parse(Num2textBox.Text));
                ECLabel.Text = "";
            }

            else
            {
                ECLabel.Text = "Please enter a number into the text box";
            }

        }


        private void divideButton_Click(object sender, EventArgs e)
        {

            if (double.TryParse(Num1textBox.Text, out _) & double.TryParse(Num2textBox.Text, out _))
            {
                OutputLabel.Text = "Output: " + Functions.divide(double.Parse(Num1textBox.Text), double.Parse(Num2textBox.Text));
                ECLabel.Text = "";
            }
            else
            {
                ECLabel.Text = "Please enter a number into the text box";
            }
        }
    }
}
