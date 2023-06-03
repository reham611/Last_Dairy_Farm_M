using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cow_Farm_System
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
           
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            Password.Text = "";
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            if (Role.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Role");
            }
            else if (UserName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter username and password");
            }
            else
            {
                if (Role.SelectedItem.ToString() == "Admin")
                {
                    if (UserName.Text == "Admin" && Password.Text == "Admin")
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("Wrong Admin name or Password");
                    }
                }
                else if (Role.SelectedItem.ToString() == "Employee")
                {
                    string Query = "Select count(*) from EmpTbl where EmpName='" + UserName.Text + "' and EmpPass='" + Password.Text + "'";
                    if (ToString() == "1")
                    {
                       
                    }
                    else
                    {
                        MessageBox.Show("Wrong UserName or Password");
                    }

                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
