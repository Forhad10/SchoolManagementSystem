using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using entities;
using framework;
using datalayer;
using MetroFramework;


namespace Uilayer
{
    public partial class SIGNIN : MetroFramework.Forms.MetroForm
    {
        userData employeData = new userData();
        public SIGNIN()
        {
            InitializeComponent();
            passwordTextBox2.PasswordChar = '*';
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

     private void LOGIN_Click_1(object sender, EventArgs e)
        {
            string userName = usernameTextBox1.Text;
            string password = passwordTextBox2.Text;


            if (employeData.Login(userName, password))
            {
                MetroMessageBox.Show(this, "WELCOME TO SCHOOL MANAGMENT SYSTEM", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MAIN m = new MAIN(  usernameTextBox1.Text);
                m.Show();
              
            }
            else
            {
                MetroMessageBox.Show(this, "PLEASE CHECK USERNAME AND PASSWORD COMBINATION", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void CANCEL_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void usernameTextBox1_Click(object sender, EventArgs e)
        {

        }
        }
    }

