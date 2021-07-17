using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { checkBox13.Checked = false; checkBox14.Checked = false; checkBox15.Checked = false; checkBox16.Checked = false; checkBox10.Checked = false; checkBox9.Checked = false; checkBox11.Checked = false; checkBox12.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; textBox1.Text = ""; }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) { checkBox13.Checked = false; checkBox14.Checked = false; checkBox15.Checked = false; checkBox16.Checked = false; checkBox10.Checked = false; checkBox9.Checked = false; checkBox11.Checked = false; checkBox12.Checked = false; checkBox1.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; textBox1.Text = ""; }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true) { checkBox13.Checked = false; checkBox14.Checked = false; checkBox15.Checked = false; checkBox16.Checked = false; checkBox10.Checked = false; checkBox9.Checked = false; checkBox11.Checked = false; checkBox12.Checked = false; checkBox2.Checked = false; checkBox1.Checked = false; checkBox4.Checked = false; textBox1.Text = ""; }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true) { checkBox13.Checked = false; checkBox14.Checked = false; checkBox15.Checked = false; checkBox16.Checked = false; checkBox10.Checked = false; checkBox9.Checked = false; checkBox11.Checked = false; checkBox12.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox1.Checked = false; textBox1.Text = ""; }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true) { checkBox5.Checked = false; checkBox6.Checked = false; checkBox7.Checked = false; }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true) { checkBox5.Checked = false; checkBox8.Checked = false; checkBox7.Checked = false; }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true) { checkBox5.Checked = false; checkBox6.Checked = false; checkBox8.Checked = false; }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true) { checkBox8.Checked = false; checkBox6.Checked = false; checkBox7.Checked = false; }
        }

        
        public void Convertt()
        {
            int.TryParse(textBox1.Text, out int input);
            string inpStr = textBox1.Text;
            int[] bits;

            if (checkBox1.Checked) // из десятич
            {
                bits = FromDec(input);
            } // из десятич
            else if (checkBox2.Checked) // из двоич
            {

                bits = FromBinary(inpStr);
            } // из двоич
            else if (checkBox3.Checked) // из восьмерич
            {
                bits = FromOctal(inpStr);
            } // из восьмерич
            else if (checkBox4.Checked) // из шестнадц
            {
                bits = FromHexical(inpStr);
            } // из шестнадц
            else bits = new int[0];

            if (checkBox8.Checked) //в десятич
            {
                InDEcemal(bits);
            } //в десятич
            if (checkBox6.Checked) // в восьмерич
            {
                InOctal(bits);
            } // в восьмерич
            if (checkBox5.Checked) // в шестнадц
            {
                InHeximal(bits);
            } // в шестнадц
            if (checkBox7.Checked) // в двоич
            {
                InBinary(bits);
            } // в двоич
        }
        public void Calc()
        {
            int.TryParse(textBox3.Text, out int input);
            string inpStr = textBox3.Text;
            int[] bits;
            if (checkBox9.Checked) // из десятич
            {
                bits = FromDec(input);
            } // из десятич
            else if (checkBox10.Checked) // из двоич
            {

                bits = FromBinary(inpStr);
            } // из двоич
            else if (checkBox11.Checked) // из восьмерич
            {
                bits = FromOctal(inpStr);
            } // из восьмерич
            else if (checkBox12.Checked) // из шестнадц
            {
                bits = FromHexical(inpStr);
            } // из шестнадц
            else bits = new int[0];

            int.TryParse(textBox4.Text, out int input1);
            string inpStr1 = textBox4.Text;
            int[] bits1;
            if (checkBox13.Checked) // из десятич
            {
                bits1 = FromDec(input1);
            } // из десятич
            else if (checkBox14.Checked) // из двоич
            {

                bits1 = FromBinary(inpStr1);
            } // из двоич
            else if (checkBox15.Checked) // из восьмерич
            {
                bits1 = FromOctal(inpStr1);
            } // из восьмерич
            else if (checkBox16.Checked) // из шестнадц
            {
                bits1 = FromHexical(inpStr1);
            } // из шестнадц
            else bits1 = new int[0];

            MainCalc(bits, bits1); // на вход двоич , на выход вывод
        }
        private void InBinary(int[] bits)
        {
            string tmpString = "";
            for (int i = 0; i < bits.Length; i++)
            {
                tmpString += bits[i];
            }
            string output = "";
            for (int i = 0; i < bits.Length; i++)
            {
                output += bits[bits.Length - i - 1];
            }
            textBox2.Text = output;
            if (checkBox8.Checked || checkBox6.Checked || checkBox5.Checked || checkBox7.Checked) textBox2.Text = output;
            if (checkBox17.Checked || checkBox18.Checked || checkBox19.Checked || checkBox20.Checked) textBox5.Text = output;
        }

        private void InHeximal(int[] bits)
        {
            int quartet = 0;
            string[] strg = new string[(int)(Math.Ceiling(bits.Length / 4.0))];
            for (int i = 0; i < (int)(Math.Ceiling(bits.Length / 4.0)); i++)
            {
                quartet = 0;
                for (int j = 0; j < 4; j++)
                {
                    int index = j + 4 * i;
                    if (index >= bits.Length) break;
                    quartet += bits[index] == 1 ? (int)Math.Pow(2, j) : 0;
                }
                strg[i] = quartet.ToString();
            }
            for (int i = 0; i < strg.Length; i++)
            {
                switch (strg[i])
                {
                    case "10":
                        strg[i] = "A";
                        break;
                    case "11":
                        strg[i] = "B";
                        break;
                    case "12":
                        strg[i] = "C";
                        break;
                    case "13":
                        strg[i] = "D";
                        break;
                    case "14":
                        strg[i] = "E";
                        break;
                    case "15":
                        strg[i] = "F";
                        break;
                }
            }
            string tmpString = "";
            for (int i = 0; i < strg.Length; i++)
            {
                tmpString += strg[i];
            }
            string tmpString1 = "";
            for (int i = 0; i < strg.Length; i++)
            {
                tmpString1 += strg[strg.Length - i - 1];
            }
            textBox2.Text = tmpString1;
            if (checkBox8.Checked || checkBox6.Checked || checkBox5.Checked || checkBox7.Checked) textBox2.Text = tmpString1;
            if (checkBox17.Checked || checkBox18.Checked || checkBox19.Checked || checkBox20.Checked) textBox5.Text = tmpString1;
        }

        private void InOctal(int[] bits)
        {
            int triad = 0;
            string octal = "";
            for (int i = 0; i < (int)(Math.Ceiling(bits.Length / 3.0)); i++)
            {
                triad = 0;
                for (int j = 0; j < 3; j++)
                {
                    int index = j + 3 * i;
                    if (index >= bits.Length) break;
                    triad += bits[index] == 1 ? (int)Math.Pow(2, j) : 0;
                }
                octal += triad;
            }
            string tmpString = "";
            for (int i = 0; i < octal.Length; i++)
            {
                tmpString += octal[octal.Length - i - 1];
            }
            textBox2.Text = tmpString;
            if (checkBox8.Checked || checkBox6.Checked || checkBox5.Checked || checkBox7.Checked) textBox2.Text = tmpString;
            if (checkBox17.Checked || checkBox18.Checked || checkBox19.Checked || checkBox20.Checked) textBox5.Text = tmpString;
        }

        private void InDEcemal(int[] bits)
        {
            int dec = 0;
            for (int i = 0; i < bits.Length; i++)
            {
                dec += bits[i] == 1 ? (int)Math.Pow(2, i) : 0;
            }
            if (checkBox8.Checked || checkBox6.Checked || checkBox5.Checked || checkBox7.Checked) textBox2.Text = dec.ToString();
            if (checkBox17.Checked || checkBox18.Checked || checkBox19.Checked || checkBox20.Checked) textBox5.Text = dec.ToString();
        }
        public void MainCalc(int[] bits1, int[] bits2)
        {
            int dec1 = 0;
            for (int i = 0; i < bits1.Length; i++)
            {
                dec1 += bits1[i] == 1 ? (int)Math.Pow(2, i) : 0;
            }
            int dec2 = 0;
            for (int i = 0; i < bits2.Length; i++)
            {
                dec2 += bits2[i] == 1 ? (int)Math.Pow(2, i) : 0;
            }
            int result;
            if (comboBox1.SelectedIndex == 0) result = dec1 + dec2;
            else if (comboBox1.SelectedIndex == 1) result = dec1 - dec2;
            else if (comboBox1.SelectedIndex == 2) result = dec1 * dec2;
            else if (comboBox1.SelectedIndex == 3) result = dec1 / dec2;
            else result = 0;

            int[] bits;
            bits = FromDec(result);

            if (checkBox17.Checked) //в десятич
            {
                InDEcemal(bits);
            } //в десятич
            if (checkBox18.Checked) // в двоич
            {
                InBinary(bits);
            } // в двоич
            if (checkBox19.Checked) // в восьмерич
            {
                InOctal(bits);
            } // в восьмерич
            if (checkBox20.Checked) // в шестнадц
            {
                InHeximal(bits);
            } // в шестнадц
        }
        private static int[] FromHexical(string inpStr)
        {
            int[] bits;
            string temp = "";
            int[] temt = new int[4] { 0, 0, 0, 0 };
            for (int i = 0; i < inpStr.Length; i++)
            {
                int wtf = 0;
                switch (inpStr[i])
                {
                    case 'A':
                        wtf = 10;
                        break;
                    case 'B':
                        wtf = 11;
                        break;
                    case 'C':
                        wtf = 12;
                        break;
                    case 'D':
                        wtf = 13;
                        break;
                    case 'E':
                        wtf = 14;
                        break;
                    case 'F':
                        wtf = 15;
                        break;
                    case 'a':
                        wtf = 10;
                        break;
                    case 'b':
                        wtf = 11;
                        break;
                    case 'c':
                        wtf = 12;
                        break;
                    case 'd':
                        wtf = 13;
                        break;
                    case 'e':
                        wtf = 14;
                        break;
                    case 'f':
                        wtf = 15;
                        break;
                    default:
                        wtf = inpStr[i];
                        break;
                }
                int[] temd = FromDec(wtf);
                for (int j = 3; j >= 0; j--)
                {
                    temt[j] = temd[j];
                    temp += temt[j];
                }
            }
            bits = new int[temp.Length];
            string strtemp = "";
            for (int i = 0; i < temp.Length; i++)
            {
                strtemp += temp[temp.Length - i - 1];
            }
            for (int i = 0; i < strtemp.Length; i++)
            {
                bits[i] = Convert.ToInt32(strtemp[i].ToString());
            }

            return bits;
        }

        private static int[] FromOctal(string inpStr)
        {
            int[] bits;
            string temp = "";
            int[] temt = new int[3] { 0, 0, 0 }; //53  <<  101 11
            for (int i = 0; i < inpStr.Length; i++)
            {
                int[] temd = FromDec(inpStr[i]);
                for (int j = 2; j >= 0; j--)
                {
                    temt[j] = temd[j];
                    temp += temt[j];
                }
            }
            bits = new int[temp.Length];
            string strtemp = "";
            for (int i = 0; i < temp.Length; i++)
            {
                strtemp += temp[temp.Length - i - 1];
            }
            for (int i = 0; i < strtemp.Length; i++)
            {
                bits[i] = Convert.ToInt32(strtemp[i].ToString());
            }

            return bits;
        }

        private static int[] FromBinary(string inpStr)
        {
            int[] bits = new int[inpStr.Length];
            for (int i = 0; i < inpStr.Length; i++)
            {
                bits[i] = Convert.ToInt32(inpStr[i].ToString());
            }
            string strtemp = "";
            for (int i = 0; i < bits.Length; i++)
            {
                strtemp += bits[bits.Length - i - 1];
            }
            for (int i = 0; i < strtemp.Length; i++)
            {
                bits[i] = Convert.ToInt32(strtemp[i].ToString());
            }

            return bits;
        }

        private static int[] FromDec(int input)
        {
            int[] bits;
            int temp1;
            List<int> s = new List<int>();
            while (input > 0)
            {
                temp1 = input % 2;
                input = input / 2;
                s.Add(temp1);
            }
            bits = s.ToArray();
            return bits;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Convertt();
        }

        private void КонвертерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void КалькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            Calc();
        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true) { checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox10.Checked = false; checkBox11.Checked = false; checkBox12.Checked = false; textBox3.Text = ""; }

        }

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true) { checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox9.Checked = false; checkBox11.Checked = false; checkBox12.Checked = false; textBox3.Text = ""; }

        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true) { checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox10.Checked = false; checkBox9.Checked = false; checkBox12.Checked = false; textBox3.Text = ""; }

        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true) { checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox10.Checked = false; checkBox11.Checked = false; checkBox9.Checked = false; textBox3.Text = ""; }

        }

        private void CheckBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true) { checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox14.Checked = false; checkBox15.Checked = false; checkBox16.Checked = false; textBox4.Text = ""; }
        }

        private void CheckBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true) { checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox13.Checked = false; checkBox15.Checked = false; checkBox16.Checked = false; textBox4.Text = ""; }

        }

        private void CheckBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true) { checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox14.Checked = false; checkBox13.Checked = false; checkBox16.Checked = false; textBox4.Text = ""; }

        }

        private void CheckBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true) { checkBox1.Checked = false; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; checkBox14.Checked = false; checkBox15.Checked = false; checkBox13.Checked = false; textBox4.Text = ""; }

        }

        private void CheckBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true) { checkBox18.Checked = false; checkBox19.Checked = false; checkBox20.Checked = false; }

        }

        private void CheckBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true) { checkBox17.Checked = false; checkBox19.Checked = false; checkBox20.Checked = false; }

        }

        private void CheckBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true) { checkBox18.Checked = false; checkBox17.Checked = false; checkBox20.Checked = false; }
        }

        private void CheckBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true) { checkBox18.Checked = false; checkBox19.Checked = false; checkBox17.Checked = false; }

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (checkBox4.Checked) // шестнадцатизначные цифры и клавиша BackSpace
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 64 || e.KeyChar >= 71) && (e.KeyChar <= 96 || e.KeyChar >= 103) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox3.Checked) // восьмизначные цифры и клавиша BackSpace 
            {
                if ((e.KeyChar <= 46 || e.KeyChar >= 56) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox2.Checked) // бинарные цифры и клавиша BackSpace 
            {
                if ((e.KeyChar <= 46 || e.KeyChar >= 50) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox1.Checked) // цифры и клавиша BackSpace
            {
                if (!Char.IsDigit(number) && number != 8)
                {
                    e.Handled = true;
                }
            }
        }
        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (checkBox12.Checked) // шестнадцатизначные цифры и клавиша BackSpace
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 64 || e.KeyChar >= 71) && (e.KeyChar <= 96 || e.KeyChar >= 103) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox11.Checked) // восьмизначные цифры и клавиша BackSpace 
            {
                if ((e.KeyChar <= 46 || e.KeyChar >= 56) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox10.Checked) // бинарные цифры и клавиша BackSpace 
            {
                if ((e.KeyChar <= 46 || e.KeyChar >= 50) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox9.Checked) // цифры и клавиша BackSpace
            {
                if (!Char.IsDigit(number) && number != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (checkBox16.Checked) // шестнадцатизначные цифры и клавиша BackSpace
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 64 || e.KeyChar >= 71) && (e.KeyChar <= 96 || e.KeyChar >= 103) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox15.Checked) // восьмизначные цифры и клавиша BackSpace 
            {
                if ((e.KeyChar <= 46 || e.KeyChar >= 56) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox14.Checked) // бинарные цифры и клавиша BackSpace 
            {
                if ((e.KeyChar <= 46 || e.KeyChar >= 50) && number != 8)
                {
                    e.Handled = true;
                }
            }
            if (checkBox13.Checked) // цифры и клавиша BackSpace
            {
                if (!Char.IsDigit(number) && number != 8)
                {
                    e.Handled = true;
                }
            }
        }
        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
