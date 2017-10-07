using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Laba1
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 f2 = new Form2();
        Random rand = new Random();
       
         

        private void button1_Click(object sender, EventArgs e)
        {
             Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number;
            number = rand.Next(1,10);
            switch(number){
                case 1:
                    this.BackColor = Color.Red;
                    label1.Text = "red";
                    break;
                case 2:
                    this.BackColor = Color.Black;
                    break;
                case 3:
                    this.BackColor = Color.Green;
                    break;
                case 4:
                    this.BackColor = Color.White;
                    break;
                case 5:
                    this.BackColor = Color.Brown;
                    break;
                case 6:
                    this.BackColor = Color.Blue;
                    break;
                case 7:
                    this.BackColor = Color.Pink;
                    break;
                case 8:
                    this.BackColor = Color.Gold;
                    break;
                case 9:
                    this.BackColor = Color.DarkBlue;
                    break;
                

            }
           

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           

            
        }
        private void button4_Click(object sender, EventArgs e)
        {
             f2.Show();
             Hide();
        }
    }
}
