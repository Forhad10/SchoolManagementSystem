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
using framework;

using MetroFramework;

namespace Uilayer
{
    public partial class STUDENT_ADD : MetroFramework.Forms.MetroForm
    {
        public STUDENT_ADD()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       public string Class, NName, Address, Register, Gender, Father, Mother;
        int ID, Contactno, Age, Contact;


        studentdata employeeDataObj = new studentdata();
      

       

       
        private void STUDENT_ADD_Load(object sender, EventArgs e)
        {
            studentdata d = new studentdata();
            
            metroGrid1.DataSource = d.showStudent();
            
        }

      
    private void DELETEmetroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            comboBox1.Text = metroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            richTextBox1.Text = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            textBox1.Text = metroGrid1.SelectedRows[0].Cells[5].Value.ToString();

            dateTimePicker2.Text = metroGrid1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox2.Text = metroGrid1.SelectedRows[0].Cells[7].Value.ToString();
            textBox5.Text = metroGrid1.SelectedRows[0].Cells[8].Value.ToString();
            textBox6.Text = metroGrid1.SelectedRows[0].Cells[9].Value.ToString();
            textBox7.Text = metroGrid1.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void ADDmetroButton2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void REFRESHmetroButton3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ADDmetroButton1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void ADDmetroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Class = comboBox1.Text;
                ID = int.Parse(textBox2.Text);
                NName = textBox3.Text;
                Contactno = int.Parse(textBox4.Text);
                Address = richTextBox1.Text;
                Age = int.Parse(textBox1.Text);
                Register = dateTimePicker2.Text;
                Gender = comboBox2.Text;
                Father = textBox5.Text;
                Mother = textBox6.Text;
                Contact = int.Parse(textBox7.Text);

                employeeDataObj.insert(Class, ID, NName, Contactno, Address, Age, Register, Gender, Father, Mother, Contact);
                MetroMessageBox.Show(this, "NEW STUDENT ADD SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "PLEASE CHECK ALL INFORMATION", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UPDATEmetroButton1_Click_2(object sender, EventArgs e)
        {
            try
            {
                Class = comboBox1.Text;
                ID = int.Parse(textBox2.Text);
                NName = textBox3.Text;
                Contactno = int.Parse(textBox4.Text);
                Address = richTextBox1.Text;
                Age = int.Parse(textBox1.Text);
                Register = dateTimePicker2.Text;
                Gender = comboBox2.Text;
                Father = textBox5.Text;
                Mother = textBox6.Text;
                Contact = int.Parse(textBox7.Text);

                employeeDataObj.update(Class, ID, NName, Contactno, Address, Age, Register, Gender, Father, Mother, Contact);
                MetroMessageBox.Show(this, " STUDENT UPDATE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "PLEASE CHECK ALL INFORMATION", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void REFRESHmetroButton3_Click(object sender, EventArgs e)
        {
            studentdata d = new studentdata();

            metroGrid1.DataSource = d.showStudent();
        }

     

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void DELETEmetroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Class = comboBox1.Text;
                ID = int.Parse(textBox2.Text);
                NName = textBox3.Text;
                Contactno = int.Parse(textBox4.Text);
                Address = richTextBox1.Text;
                Age = int.Parse(textBox1.Text);
                Register = dateTimePicker2.Text;
                Gender = comboBox2.Text;
                Father = textBox5.Text;
                Mother = textBox6.Text;
                Contact = int.Parse(textBox7.Text);


                employeeDataObj.deltec(ID);

                MetroMessageBox.Show(this, " STUDENT DELETE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this, "PLEASE CHECK ALL INFORMATION", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
        }
        
        }
        
        
    

