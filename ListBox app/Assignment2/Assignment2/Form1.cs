using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (leftlistbox.SelectedIndex != -1)
            {
                rightlistbox.Items.Add(leftlistbox.SelectedItem);
                leftlistbox.Items.RemoveAt(leftlistbox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You Must Select one item From left box");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (rightlistbox.SelectedIndex != -1)
            {
                leftlistbox.Items.Add(rightlistbox.SelectedItem);
                rightlistbox.Items.RemoveAt(rightlistbox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You Must Select one item From right box");
            }
            }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
