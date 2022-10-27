using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public class Calculator
    {
        double number1, number2; 
        string sign; 
        bool znak; 
        bool cheaksign; 
        bool cheakask;
        bool cheaknum; 
        bool chknum2; 

        public void formload(TextBox textBoxAsk, Label labe) 
        {
            znak = true; 
            cheaksign = false; 
            cheakask = false; 
            cheaknum = false; 
            chknum2 = false; 
            textBoxAsk.Text = "0"; 
            labe.Text = ""; 
        }

        public void Sign(string sign2, TextBox textBoxAsk, Label labe) 
        {
            if (!chknum2)
            {
                sign = sign2;
            }
            if (!cheakask)
            {
                number1 = Num(textBoxAsk);
                if (!znak)
                {
                    number1 *= -1;
                }
                cheaknum = true;
                znak = true;
                cheaksign = true;
                cheakask = true;
            }
            if (chknum2)
            {
                Ask(textBoxAsk, labe);
                number1 = Num(textBoxAsk);
                if (!znak)
                {
                    number1 *= -1;
                }
                znak = true;
                sign = sign2;
                cheaknum = true;
                cheaksign = true;
                cheakask = true;
            }
        }

        public void Number(string number, TextBox textBoxAsk, Label plusminus) 
        {
            if (cheaknum)
            {
                chknum2 = true;
                cheaknum = false;
            }
            if (textBoxAsk.Text == "0")
            {
                textBoxAsk.Text = "";
            }
            if (textBoxAsk.TextLength < 9 || cheaksign)
            {
                if (cheaksign)
                {
                    textBoxAsk.Clear();
                    plusminus.Text = "";
                    cheaksign = false;
                }
                textBoxAsk.Text += number;
            }
        }

        public void Ask(TextBox textBoxAsk, Label labe) 
        {
            if (cheakask && chknum2)
            {
                Calculate(textBoxAsk, labe);
            }
        }

        public double Num(TextBox textBoxAsk) 
        {
            return Convert.ToDouble(textBoxAsk.Text);
        }
        public void Askmet(TextBox textBoxAsk) => textBoxAsk.Text = Math.Round(number2, 1).ToString(); 

        public void Calculate(TextBox textBoxAsk, Label plusminus)
        {
            double num = Num(textBoxAsk);
            if (!znak)
            {
                num *= -1;
            }
            znak = true;
            switch (sign)
            {
                case "+":
                    number2 = number1 + num;
                    Askmet(textBoxAsk);
                    break;
                case "-":
                    number2 = number1 - num;
                    Askmet(textBoxAsk);
                    break;
                case "*":
                    number2 = number1 * num;
                    Askmet(textBoxAsk);
                    break;
                case "/":
                    number2 = number1 / num;
                    Askmet(textBoxAsk);
                    if (num == 0)
                    {
                        textBoxAsk.Text = "not / 0"; 
                    }
                    break;
                default:
                    break;
            }
            number2 = Math.Round(number2, 1);
            if (number2 <= 0)
            {
                plusminus.Text = "-";
                znak = false;
            }
            if (number2 >= 0 || textBoxAsk.Text == "0")
            {
                plusminus.Text = "";
            }
            string btest = number2.ToString();
            if (btest.Length > 9)
            {
                textBoxAsk.Text = "EXCEEDED"; 
            }
            textBoxAsk.Text = textBoxAsk.Text.Replace("-", "");
            cheakask = false;
            chknum2 = false;
            cheaksign = true;
        }

        public void PlusMinus(Label labelplusminus, TextBox textBoxAsk) 
        {
            if (znak)
            {
                labelplusminus.Text = "-";
                znak = false;
            }
            else if (!znak)
            {
                labelplusminus.Text = "";
                znak = true;
            }
        }
    }
}

