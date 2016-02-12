using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginPage
{
    public partial class welcomePage : UserControl
    {
        public welcomePage()
        {
            InitializeComponent();
            welcomeLabel.Text = "Welcome Back " + Form1.username + "!";
        }
    }
}
