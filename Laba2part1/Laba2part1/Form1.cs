using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2part1
{
    public partial class Form1 : Form
    {
        private int s1 = 0, m1 = 0, h1 = 0;
        private int s = 0, m = 0, h = 0 , interval = 1;
        private int s2 = 0, m2 = 0, h2 = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            progressBar1.Value = 0;
            label1.Text = "0 0";
            label2.Text = "0 0";
            label3.Text = "0 0";
            this.Text = "0" + " : " + "0" + " : " + "0";
            s1 = 0;
            m1 = 0;
            h1 = 0;
            s = 0;
            m = 0;
            h = 0;
            interval = 1;
            s2 = 0;
            m2 = 0;
            h2 = 0;
    }

        public Form1()  
        {
            InitializeComponent();
            
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "seconds")
            {
                s = Convert.ToInt32(numericUpDown1.Text);

                s2 = Convert.ToInt32(numericUpDown1.Text);
                interval = s;
            }
            if (comboBox1.Text == "minutes")
            {
                m = Convert.ToInt32(numericUpDown1.Text);
                m2 = Convert.ToInt32(numericUpDown1.Text);
                interval = m * 60;
            }
            if (comboBox1.Text == "hours")
            {
                h = Convert.ToInt32(numericUpDown1.Text);
                h2 = Convert.ToInt32(numericUpDown1.Text);
                interval = h * 3600;
            }
            timer1.Start();
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (s == 0 && m == 0 && h == 0)
            {
                MessageBox.Show("Кнопка не доступна");
                button2.Enabled = false;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            s1 = s1 + 1;
            if (s1 == 60)
            {
                m1 = m1 + 1;
                s1 = 0;
            }
            if (m1 == 60)
            {
                h1 = h1 - 1;
                m1 = 0;
            }
            if (s1 == s2 && m1 == m2 && h1 == h2)
            {
                timer2.Stop();
            }
            this.Text = s1.ToString() + " : " + m1.ToString() + " : " + h1.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numericUpDown1.Text == "0")
            {
                s = 0;
                m = 0;
                h = 0;
                timer1.Stop();

            }
            else if(label1.Text == "0" && label2.Text == "0" && label3.Text == "0")
            {
                s = Convert.ToInt32(numericUpDown1.Text);
                m = 0;
                h = 0;
            }
            else
            {
                s = s - 1;
                if (s == -1)
                {
                    m = m - 1;
                    s = 59;
                }
                if (m == -1)
                {
                    h = h - 1;
                    m = 59;
                }
                if (s == 0 && m == 0 && h == 0)
                {
                    timer1.Stop();
                    timer2.Stop();
                    Application.Exit();

                }
                progressBar1.Maximum = interval;
                progressBar1.Minimum = 0;
                progressBar1.PerformStep();
                label3.Text = s.ToString();
                label2.Text = m.ToString();
                label1.Text = h.ToString();
            }
        }
    }
}
