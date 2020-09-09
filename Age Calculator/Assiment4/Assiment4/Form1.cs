using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment4
{
    public partial class Form1 : Form
    {
        int year, month, day;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            day = DateTime.Now.Day;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            if (Date.Value.Day > DateTime.Now.Day)
            {
                day = day + 30;
                month= month - 1;
                day = day - Date.Value.Day;
            }
            else
            {
                day = day - Date.Value.Day;
            }
            if (Date.Value.Month > DateTime.Now.Month)
            {
                month = month + 12;
                year = year - 1;
                month = month - Date.Value.Month;
            }
            else
            {
                month = month - Date.Value.Month;
            }

            year = year - Date.Value.Year;



            MessageBox.Show("Your age is "+year+ " Years "+ month + " Months "+ day+" Days");
        }
    }
}
