using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Form1 : Form
    {
        Calculator calculate = new Calculator();   
        public Form1()
        {
            InitializeComponent();
        }
        

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            calculate.Sign("-", textBoxAsk, labelPlusMinus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate.Number("1", textBoxAsk, labelPlusMinus);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculate.Number("2", textBoxAsk, labelPlusMinus);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calculate.Number("3", textBoxAsk, labelPlusMinus);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calculate.Number("4", textBoxAsk, labelPlusMinus);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calculate.Number("5", textBoxAsk, labelPlusMinus);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calculate.Number("6", textBoxAsk, labelPlusMinus);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calculate.Number("7", textBoxAsk, labelPlusMinus);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calculate.Number("8", textBoxAsk, labelPlusMinus);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calculate.Number("9", textBoxAsk, labelPlusMinus);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            calculate.Number("0", textBoxAsk, labelPlusMinus);
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            calculate.PlusMinus(labelPlusMinus, textBoxAsk);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            calculate.formload(textBoxAsk, labelPlusMinus);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            calculate.Sign("/", textBoxAsk, labelPlusMinus);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            calculate.Sign("*", textBoxAsk, labelPlusMinus);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            calculate.Sign("+", textBoxAsk, labelPlusMinus);
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            calculate.Ask(textBoxAsk, labelPlusMinus);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calculate.formload(textBoxAsk, labelPlusMinus);
        }
    }
}
