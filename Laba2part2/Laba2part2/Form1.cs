using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2part2
{
    public partial class Form1 : Form
    {
       
       
       
        public Form1()
        {
            InitializeComponent();
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Laba2part2.Properties.Resources.maxresdefault;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Laba2part2.Properties.Resources.Mockup_1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Laba2part2.Properties.Resources.Иннополис;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Laba2part2.Properties.Resources.iMac_Office_Mockup_with_items;
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(listBox1.SelectedIndex == 0)
            {
                Font = new Font("Times New Roman",8);
            }
            if (listBox1.SelectedIndex == 1)
            {
                Font = new Font("Arial", 8);
            }
            if (listBox1.SelectedIndex == 2)
            {
                Font = new Font("Ms Sans Serif", 8);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
               Text = comboBox1.Items[0].ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                Text = comboBox1.Items[1].ToString();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Text = comboBox1.Items[2].ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Text = comboBox1.Items[3].ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if(numericUpDown1.Value != 0)
            {
               Width = Convert.ToInt32(numericUpDown1.Value);
            }
           
            

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown2.Value != 0)
            {
                Height = (int)numericUpDown2.Value;
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 2400;
            numericUpDown1.Minimum = -100;
            numericUpDown2.Maximum = 2400;
            numericUpDown2.Minimum = -100;
            numericUpDown2.Value = Size.Height;
            numericUpDown1.Value = Size.Width;
            Width = Convert.ToInt32(numericUpDown1.Value);
            Height = (int)numericUpDown2.Value;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int w, h;
            w =  Size.Width/2 - 100;
            h =  Size.Height/4;
           
            numericUpDown1.Value = Size.Width;
            numericUpDown2.Value = Size.Height;
            numericUpDown1.Location = new Point(w, h);
            numericUpDown2.Location = new Point(w + 70, h);
            if (Size.Height  > 130)
            {
                h = Size.Height/4;
            }

        }

        private void numericUpDown1_DoubleClick(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 137)
            {
                Width = Convert.ToInt32(numericUpDown1.Value);
            }     
        }

        private void numericUpDown2_DoubleClick(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 200)
            {
                Height = (int)numericUpDown2.Value;
            }
        }
    }
}
