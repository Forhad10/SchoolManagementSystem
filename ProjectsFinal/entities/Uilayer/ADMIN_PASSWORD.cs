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
    public partial class ADMIN_PASSWORD : MetroFramework.Forms.MetroForm
    {
        public ADMIN_PASSWORD(string username)
        {
            InitializeComponent();
            USERNAMEmetroTextBox1.Text = username;

        }

        private void ADMIN_PASSWORD_Load(object sender, EventArgs e)
        {

        }
        userData employeData = new userData();
        private void MODIFYmetroButton1_Click(object sender, EventArgs e)
        {
            string userName ;
            string password ;
            string new_password;


            try
            {
                userName=USERNAMEmetroTextBox1.Text;
                password=PASSWORDmetroTextBox2.Text;
                new_password=NEWPASSWORDmetroTextBox3.Text;

                employeData.updatePassword(userName,password,new_password);
                MetroMessageBox.Show(this, "PASSWORD UPDATE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "UPDATE FAILED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
