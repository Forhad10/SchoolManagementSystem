using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using framework;
using entities;
using datalayer;

using MetroFramework;

namespace Uilayer
{
    public partial class STUDENT_PAYMENT : MetroFramework.Forms.MetroForm
    {
        public STUDENT_PAYMENT()
        {
            InitializeComponent();
        }
        public string Cls_ID;

        private void STUDENT_PAYMENT_Load(object sender, EventArgs e)
        {
            studentdata d = new studentdata();

           Cls_ID = IDmetroTextBox1.Text;

            
            PaymentGrid.DataSource = d.showStudentPayment(Cls_ID);
        }

        studentdata employeeDataObj = new studentdata();

        private void SEARCHmetroButton1_Click(object sender, EventArgs e)
        {
            studentdata d = new studentdata();

            Cls_ID = IDmetroTextBox1.Text;

            
            PaymentGrid.DataSource = d.showStudentPayment(Cls_ID);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PAYmetroButton2_Click(object sender, EventArgs e)
        {
            int Amount,Paid,Payable,Id;



            try
            {

                Amount = int.Parse(AmmountmetroTextBox4.Text);
                Paid = int.Parse(PayedmetroTextBox5.Text);
                Payable = int.Parse(PayablemetroTextBox6.Text);

                Id = int.Parse(IdmetroTextBox2.Text);


               

                employeeDataObj.updatePayment(Id, Amount, Paid, Payable);
                MetroMessageBox.Show(this, "TRANSACTIONCOMPLETE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "TRANSACTION INCOMPLETE", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClassmetroTextBox1.Text = PaymentGrid.SelectedRows[0].Cells[0].Value.ToString();

            NamemetroTextBox3.Text = PaymentGrid.SelectedRows[0].Cells[1].Value.ToString();
            IdmetroTextBox2.Text = PaymentGrid.SelectedRows[0].Cells[2].Value.ToString();
            AmmountmetroTextBox4.Text = PaymentGrid.SelectedRows[0].Cells[3].Value.ToString();
            PayedmetroTextBox5.Text = PaymentGrid.SelectedRows[0].Cells[4].Value.ToString();
            PayablemetroTextBox6.Text = PaymentGrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void PayablemetroTextBox6_Click(object sender, EventArgs e)
        {
           //int a = int.Parse(PayablemetroTextBox6.Text);
            int b = int.Parse(PayedmetroTextBox5.Text);
            int c = int.Parse(AmmountmetroTextBox4.Text);
            PayablemetroTextBox6.Text= (c-b).ToString();
          
        }

        private void PaymentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
