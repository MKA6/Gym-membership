using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_first_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textUserName.Text == "admin" && textPassword.Text == "admin") {
                Form1 form = new Form1();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login failed. Try again" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }
    }
}
