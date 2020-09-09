using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {

        char op;
        float num1;
        float num2;
        float num3;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void sub_Click(object sender, EventArgs e)
        {
          
             num1 = float.Parse(input1.Text);
            op = '-';

        }

        private void mult_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(input1.Text);
            op = '*';
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(input1.Text);
            op = '/';
        }

        private void add_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(input1.Text);
            op = '+';
        }

        private void mod_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(input1.Text);
            op = '%';
        }

        private void eq_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(input2.Text);

            switch (op)
            {
                case '*':
                    num3 = num1 * num2;
                    reuslt.Text = num3+"";
                break;
                case '+':
                    num3 = num1 + num2;
                    reuslt.Text = num3 + "";
                    break;
                case '-':
                    num3 = num1 - num2;
                    reuslt.Text = num3 + "";
                    break;
                case '/':
                    num3 = num1 / num2;
                    reuslt.Text = num3+ "";
                    break;
                case '%':
                    num3 = num1 % num2;
                    reuslt.Text = num3 + "";
                    break;

            }
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            reuslt.Text =null;
            op =' ';
            input1.Text = null;
            input2.Text = null;

        }

    
    }
}