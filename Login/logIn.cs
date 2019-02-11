using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class logIn : UserControl
    {
        public logIn()
        {
            InitializeComponent();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            

            if (userIn.Text == Form1.username)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                Welcome ss = new Welcome();
                f.Controls.Add(ss);
            }

            
        }

        private void logIn_Load(object sender, EventArgs e)
        {

        }
    }
}
