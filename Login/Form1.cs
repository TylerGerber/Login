using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public static string username = "tyG";
        public string password = "amen";

        public Form1()
        {
            // Create an instance of the MainScreen 
            logIn ms = new logIn();

            // Add the User Control to the Form 
            this.Controls.Add(ms);
            InitializeComponent();
        }
            
    }
    }


