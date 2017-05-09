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
    public partial class SALARY_OF_TEACHER : MetroFramework.Forms.MetroForm
    {
        public SALARY_OF_TEACHER()
        {
            InitializeComponent();
        }

        private void SALARY_OF_TEACHER_Load(object sender, EventArgs e)
        {
            TeacherData d = new TeacherData();

            metroGrid1.DataSource = d.ShowTypeSalary();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        TeacherData teacherObject = new TeacherData();

        private void MODIFYmetroButton2_Click(object sender, EventArgs e)
        {
            int Ammount;
            string Type;



            try
            {

                Ammount = int.Parse(SALARYmetroTextBox2.Text);
                

                Type = TYPEmetroComboBox1.Text;




                teacherObject.ResetTeacherPayment(Type,Ammount);
                MetroMessageBox.Show(this, "TRANSACTIONCOMPLETE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TYPEmetroComboBox1.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            SALARYmetroTextBox2.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void REFRESHmetroButton1_Click(object sender, EventArgs e)
        {
            TeacherData teacher = new TeacherData();

            metroGrid1.DataSource = teacher.ShowTypeSalary();
        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
