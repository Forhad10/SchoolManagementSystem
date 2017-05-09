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
    public partial class RESET_BALANCE : MetroFramework.Forms.MetroForm
    {
        public RESET_BALANCE()
        {
            InitializeComponent();
        }

        private void RESET_BALANCE_Load(object sender, EventArgs e)
        {

        }

        studentdata employeeDataObj = new studentdata();

        private void MODIFYmetroButton1_Click(object sender, EventArgs e)
        {
            int Amount, Paid, Payable;
            string Class;



            try
            {

                Amount = int.Parse(AMMOUNTmetroTextBox1.Text);
                Paid = int.Parse(PAIDmetroTextBox2.Text);
                Payable = int.Parse(PAYABLEmetroTextBox3.Text);

                Class = CLASSmetroComboBox1.Text;




                employeeDataObj.ResetPayment(Class, Amount, Paid, Payable);
                MetroMessageBox.Show(this, "TRANSACTION COMPLETE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "TRANSACTION INCOMPLETE", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CANCELmetroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
