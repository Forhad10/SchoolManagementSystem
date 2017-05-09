using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datalayer;
using entities;

using MetroFramework;

namespace Uilayer
{
    public partial class ADD_TEACHER : MetroFramework.Forms.MetroForm
    {
        public ADD_TEACHER()
        {
            InitializeComponent();
        }

        private void FINANCIAL_DISTRIBUTION_Load(object sender, EventArgs e)
        {
            TeacherData d = new TeacherData();

            metroGrid1.DataSource = d.showTeacher();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
        public string Name,Address,Type,Gender;
        
        public int Id,Phone, Age,Salary;

        TeacherData teacher = new TeacherData();
  

       

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IDmetroTextBox1.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            NAMEmetroTextBox2.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            AddressrichTextBox1.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            ContactmetroTextBox4.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            TYPEmetroComboBox1.Text = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            GendermetroComboBox2.Text = metroGrid1.SelectedRows[0].Cells[5].Value.ToString();

            AGEmetroTextBox5.Text = metroGrid1.SelectedRows[0].Cells[6].Value.ToString();
           
           
        }

       

        

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADDmetroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {

                Id = int.Parse(IDmetroTextBox1.Text);
                Name = NAMEmetroTextBox2.Text;
                Address = AddressrichTextBox1.Text;
                Phone = int.Parse(ContactmetroTextBox4.Text);
                Type = TYPEmetroComboBox1.Text;

                Gender = GendermetroComboBox2.Text;
                Age = int.Parse(AGEmetroTextBox5.Text);



                teacher.insertTeacher(Id, Name, Phone, Address, Age, Type, Gender, Salary);
                MetroMessageBox.Show(this, "NEW TEACHER ADDED SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "PLEASE CHECK UNIQUE ID ", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DELETEmetroButton3_Click_1(object sender, EventArgs e)
        {
            try
            {

                Id = int.Parse(IDmetroTextBox1.Text);
                Name = NAMEmetroTextBox2.Text;
                Address = AddressrichTextBox1.Text;
                Phone = int.Parse(ContactmetroTextBox4.Text);
                Type = TYPEmetroComboBox1.Text;

                Gender = GendermetroComboBox2.Text;
                Age = int.Parse(AGEmetroTextBox5.Text);



                teacher.DelteTeacher(Id);
                MetroMessageBox.Show(this, " TEACHER DELETE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "PLEASE CHECK ALL INFORMATION", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UPDATEmetroButton4_Click_1(object sender, EventArgs e)
        {

            try
            {

                Id = int.Parse(IDmetroTextBox1.Text);
                Name = NAMEmetroTextBox2.Text;
                Address = AddressrichTextBox1.Text;
                Phone = int.Parse(ContactmetroTextBox4.Text);
                Type = TYPEmetroComboBox1.Text;

                Gender = GendermetroComboBox2.Text;
                Age = int.Parse(AGEmetroTextBox5.Text);



                teacher.updateTeacher(Id, Name, Phone, Address, Age, Type, Gender, Salary);
                MetroMessageBox.Show(this, " TEACHER UPDATE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "PLEASE CHECK ALL INFORMATION", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void REFRESHmetroButton2_Click_1(object sender, EventArgs e)
        {
            TeacherData d = new TeacherData();

            metroGrid1.DataSource = d.showTeacher();
        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
