using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
         private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        
        }

    private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму приложения, которая открыла текущую форму Form2, главная форма всегда = 0
            Form ifrm = Application.OpenForms[0];
            ifrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
