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
    public partial class loginInputPage : UserControl
    {
        public loginInputPage()
        {
            InitializeComponent();  
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameBox.Text == Form1.username && passwordBox.Text == Form1.password)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                welcomePage wp = new welcomePage();
                f.Controls.Add(wp);
            }

            else
            {
                userNameBox.Clear();
                passwordBox.Clear();

                failedLabel.Visible = true;
            }
        }
    }
}

