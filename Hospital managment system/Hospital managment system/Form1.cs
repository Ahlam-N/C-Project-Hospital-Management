using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_managment_system
{
    public partial class Login_Form : System.Windows.Forms.Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            String username = UserName_txt.Text;
            String pass = Password_txt.Text;

            if(username=="hms" && pass == "pass")
  {
                // MessageBox.Show(“ you have entered right username and password “);
                this.Hide();
                Control cn = new Control();
                cn.Show();

            }

  else
            {
                MessageBox.Show("Wrong username or Password");
            }

        }
    }
}
