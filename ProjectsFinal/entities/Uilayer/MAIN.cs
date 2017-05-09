using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Uilayer
{
    public partial class MAIN : MetroFramework.Forms.MetroForm
    {
        public MAIN(string username)
        {
            InitializeComponent();
            ADMIN.Text = username;
            timer1.Start();
        }

      

       

        private void MAIN_Load(object sender, EventArgs e)
        {
           
        }

        private void ADDSTUDENTmetroButton1_Click(object sender, EventArgs e)
        {
            STUDENT_ADD s = new STUDENT_ADD();
            s.Show();
        }

        private void GRADEmetroButton2_Click(object sender, EventArgs e)
        {
            grade g = new grade();
            g.Show();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SIGNIN f = new SIGNIN();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.metroButton4.Text = dt.ToString();
          

        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void FINANCEmetroButton3_Click(object sender, EventArgs e)
        {
            STUDENT_PAYMENT s = new STUDENT_PAYMENT();
            s.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ADD_TEACHERmetroButton5_Click(object sender, EventArgs e)
        {
            ADD_TEACHER teacher = new ADD_TEACHER();
            teacher.Show();
        }

        private void MODIFYSALARYmetroButton1_Click_1(object sender, EventArgs e)
        {
            RESET_BALANCE r = new RESET_BALANCE();
            r.Show();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void TEACHER_FINANCEmetroButton7_Click(object sender, EventArgs e)
        {
            teacher_SALARYs t = new teacher_SALARYs();
            t.Show();
        }

        private void ADD_ADMINmetroButton10_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.Show();
        }

        private void SALARY_MODIFYmetroButton8_Click(object sender, EventArgs e)
        {
            SALARY_OF_TEACHER sal = new SALARY_OF_TEACHER();
            sal.Show();
        }

        private void CHANGE_PASSWORDmetroButton9_Click(object sender, EventArgs e)
        {
            ADMIN_PASSWORD admin = new ADMIN_PASSWORD(ADMIN.Text);
            admin.Show();

        }

        private void LOGOUTbutton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            SIGNIN a = new SIGNIN();
            a.Show();
        }
    }
}
