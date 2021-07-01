using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALC
{
    public partial class Form1 : Form
    {
        public bool field_number;
        public int field_number_lock;
        public char action_sign;
        public Form1()
        {
            InitializeComponent();
            field_number = false;
            field_number_lock = 0;
            action_sign = ' ';
            label1.Text = "";
            label3.Text = "";
            button18.Visible = false;
            button1.Enabled = true;
            button1.Visible = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
        }       

        public void button1_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '1';
            }
            else
            {
                textBox2.Text += '1';
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '2';
            }
            else
            {
                textBox2.Text += '2';
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '3';
            }
            else
            {
                textBox2.Text += '3';
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '4';
            }
            else
            {
                textBox2.Text += '4';
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '5';
            }
            else
            {
                textBox2.Text += '5';
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '6';
            }
            else
            {
                textBox2.Text += '6';
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '7';
            }
            else
            {
                textBox2.Text += '7';
            }
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '8';
            }
            else
            {
                textBox2.Text += '8';
            }
        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '9';
            }
            else
            {
                textBox2.Text += '9';
            }
        }

        public void button10_Click(object sender, EventArgs e)
        {
            if (field_number == false && (field_number_lock == 0 || field_number_lock == 2))
            {
                textBox1.Text += '0';
            }
            else
            {
                textBox2.Text += '0';
            }
        }

        public void button13_Click(object sender, EventArgs e)
        {
            if (field_number_lock == 0)
            {
                field_number = !field_number;
                action_sign = '+';
                label1.Text = Convert.ToString('+');
            }
            else
            {
                if (field_number_lock == 1)
                {
                    textBox2.Text += '+';
                }
                if (field_number_lock == 2)
                {
                    textBox1.Text += '+';
                }
            }
        }

        public void button14_Click(object sender, EventArgs e)
        {
            if (field_number_lock == 0)
            {
                field_number = !field_number;
                action_sign = '-';
                label1.Text = Convert.ToString('-');
            }
            else
            {
                if (field_number_lock == 1)
                {
                    textBox2.Text += '-';
                }
                if (field_number_lock == 2)
                {
                    textBox1.Text += '-';
                }
            }
        }

        public void button15_Click(object sender, EventArgs e)
        {
            if (field_number_lock == 0)
            {
                field_number = !field_number;
                action_sign = '*';
                label1.Text = Convert.ToString('*');
            }
            else
            {
                if (field_number_lock == 1)
                {
                    textBox2.Text += '*';
                }
                if (field_number_lock == 2)
                {
                    textBox1.Text += '*';
                }
            }
        }

        public void button16_Click(object sender, EventArgs e)
        {
            if (field_number_lock == 0)
            {
                field_number = !field_number;
                action_sign = '/';
                label1.Text = Convert.ToString('/');
            }
            else
            {
                if (field_number_lock == 1)
                {
                    textBox2.Text += '/';
                }
                if (field_number_lock == 2)
                {
                    textBox1.Text += '/';
                }
            }
        }
        public void button17_Click(object sender, EventArgs e)
        {
            field_number = true;
            field_number_lock = 1;
            textBox1.Text = "e";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "^";
            label3.Text = "Возведение экспоненты в степень";
            button18.Visible = true;
            button17.Visible = false;
            button19.Visible = true;
        }
        public void button18_Click(object sender, EventArgs e)
        {
            field_number = false;
            field_number_lock = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label3.Text = "Базовый калькулятор";
            button18.Visible = false;
            button17.Visible = true;
            button19.Visible = true;
        }
        public void button19_Click(object sender, EventArgs e)
        {
            field_number = false;
            field_number_lock = 2;
            textBox1.Text = "";
            textBox2.Text = "2";
            textBox3.Text = "";
            label1.Text = "^";
            label3.Text = "Возведение x во 2 степень";
            button18.Visible = true;
            button17.Visible = true;
            button19.Visible = false;
        }

        public void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if (field_number_lock == 0)
            {
                if(action_sign!=' ')
                {
                    double first_field=0,second_field=0,third_field=0;
                    first_field = Convert.ToInt32(textBox1.Text);
                    second_field = Convert.ToInt32(textBox2.Text);
                    if (action_sign == '+')
                    {
                       third_field = first_field + second_field;
                    }
                    if (action_sign == '-')
                    {
                        third_field = first_field - second_field;
                    }
                    if (action_sign == '*')
                    {
                        third_field = first_field * second_field;
                    }
                    if (action_sign == '/')
                    {
                        third_field = first_field / second_field;
                    }
                    textBox3.Text = Convert.ToString(third_field);
                }
                else
                {
                    label3.Text = Convert.ToString("Вы не выбрали действие");
                }
            }
            else
            {
                char[] check_mass;
                int check;
                double result;
                if (field_number_lock == 1)
                {
                    if (textBox2.Text != "")
                    {
                        check_mass = textBox2.Text.ToCharArray();
                        check = 0;
                        for (int i = 0; i < check_mass.Length - 1; i++)
                        {
                            if(check_mass[i]=='+'|| check_mass[i] == '-'|| check_mass[i] == '*'|| check_mass[i] == '/')
                            {
                                if(check_mass[i+1] == '+' || check_mass[i+1] == '-' || check_mass[i+1] == '*' || check_mass[i+1] == '/')
                                {
                                    check++;
                                }
                            }
                        }
                        if (check == 0)
                        {
                            result = Math.Pow(2.71, Convert.ToDouble(new DataTable().Compute(textBox2.Text, "")));
                            textBox3.Text = Convert.ToString(result);
                        }
                        else
                        {
                            label3.Text = "Некорректная формула";
                        }
                        
                    }
                    else
                    {
                        label3.Text = "Введите степень";
                    }
                }
                if (field_number_lock == 2)
                {
                    if (textBox1.Text != "")
                    {
                        check_mass = textBox1.Text.ToCharArray();
                        check = 0;
                        for (int i = 0; i < check_mass.Length - 1; i++)
                        {
                            if (check_mass[i] == '+' || check_mass[i] == '-' || check_mass[i] == '*' || check_mass[i] == '/')
                            {
                                if (check_mass[i + 1] == '+' || check_mass[i + 1] == '-' || check_mass[i + 1] == '*' || check_mass[i + 1] == '/')
                                {
                                    check++;
                                }
                            }
                        }
                        if (check == 0)
                        {
                            result = Math.Pow(Convert.ToDouble(new DataTable().Compute(textBox1.Text, "")),2);
                            textBox3.Text = Convert.ToString(result);
                        }
                        else
                        {
                            label3.Text = "Некорректная формула";
                        }
                    }
                    else
                    {
                        label3.Text = "Введите x";
                    }
                }
            }
        }

        public void button11_Click(object sender, EventArgs e)
        {
            if (field_number_lock == 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label1.Text = "";
                label3.Text = "Калькулятор очищен";
                field_number = false;
                action_sign = ' ';
            }
            else
            {
                if (field_number_lock == 1)
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    label3.Text = "Калькулятор очищен";
                }
                if (field_number_lock == 2)
                {
                    textBox1.Text = "";
                    textBox3.Text = "";
                    label3.Text = "Калькулятор очищен";
                }
            }
            
        }

        
    }
}
