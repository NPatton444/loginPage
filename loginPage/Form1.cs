using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPage
{
    public partial class Form1 : Form
    {
        public static string username = "NoahPatton444";
        public static string password = "noahiscool123";

        public Form1()
        {
            InitializeComponent();
            loginInputPage lip = new loginInputPage();
            this.Controls.Add(lip);
        }
    }
}
