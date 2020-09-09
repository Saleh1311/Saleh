using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addn_Click(object sender, EventArgs e)
        {
            
            tree.Nodes.Add("Laptops");
            tree.Nodes.Add("Smart Phones");
            tree.Nodes.Add("Printers");

        }

        private void Move(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.Gray;
        }

        private void Lave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.OrangeRed;

        }

       

        private void l2(object sender, EventArgs e)
        {
            panel2.BackColor = Color.OrangeRed;

        }



        private void l3(object sender, EventArgs e)
        {
            panel3.BackColor = Color.OrangeRed;

        }



        private void l4(object sender, EventArgs e)
        {
            panel4.BackColor = Color.OrangeRed;

        }

        private void m2(object sender, MouseEventArgs e)
        {
            panel2.BackColor = Color.Gray;

        }

        private void m3(object sender, MouseEventArgs e)
        {
            panel3.BackColor = Color.Gray;

        }

        private void m4(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.Gray;

        }

        private void addc_Click(object sender, EventArgs e)
        {
            tree.Nodes[0].Nodes.Add("Dell");
            tree.Nodes[0].Nodes.Add("Toshiba");
            tree.Nodes[0].Nodes.Add("Acer");
            tree.Nodes[1].Nodes.Add("iPhone");
            tree.Nodes[1].Nodes.Add("Samsung");
            tree.Nodes[1].Nodes.Add("LG");
            tree.Nodes[2].Nodes.Add("Canon");
            tree.Nodes[2].Nodes.Add("Epson");
            
        }

        private void removen_Click(object sender, EventArgs e)
        {
            tree.SelectedNode.Remove();
        }

        private void deletet_Click(object sender, EventArgs e)
        {
            tree.Nodes.Clear();
        }
    }
}
