using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Assiment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            list.Items.Add(name.Text).SubItems.AddRange(new string[] { major.Text, gpa.Text });
        }

       



        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count > 0)
            {
                int var2 = list.Items.IndexOf(list.SelectedItems[0]);
                list.Items.Add(list.Items[var2].Text).SubItems.AddRange(new string[] { list.SelectedItems[0].SubItems[1].Text.ToString(), list.SelectedItems[0].SubItems[2].Text.ToString() });
                
            }

           

        }

       

      

     

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].Selected)
                {
                    list.Items[i].Remove();
                    i--;
                }
            }
        }

        private void fff(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].Selected)
                {
                    menu.Show(Cursor.Position);
                    break;
                    
                }
            }
        }
        }
    }


