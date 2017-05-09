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

using System.Data.SqlClient;
using datalayer;

using MetroFramework;

namespace Uilayer
{
    public partial class grade : MetroFramework.Forms.MetroForm
    {
        public grade()
        {
            InitializeComponent();
        }
        studentdata employeeDataObj = new studentdata();
        public string CLS;
      

       

        private void grade_Load(object sender, EventArgs e)
        {
             
            
            studentdata d = new studentdata();

            CLS = SearchComboBox1.Text;

            //d.showStudent();
            GRADE_TABLEmetroGrid1.DataSource = d.showStudentResult(CLS);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            studentdata d = new studentdata();

            CLS = SearchComboBox1.Text;

            //d.showStudent();
            GRADE_TABLEmetroGrid1.DataSource = d.showStudentResult(CLS);
        }

     

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void SAVEmetroButton2_Click(object sender, EventArgs e)
        {
            int Math, English, Bangla, Science, Total_mark, Id;
           
        

            try
            {
                Math = int.Parse(MathTextBox4.Text);
                English = int.Parse(EnglishTextBox5.Text);
                Bangla = int.Parse(BanglaTextBox6.Text);
                Science = int.Parse(ScienceTextBox7.Text);
                Total_mark = int.Parse(Total_markTextBox8.Text);
               
                Id = int.Parse(IdTextBox3.Text);

                employeeDataObj.updateResult(Id, Math, English, Bangla, Science, Total_mark);
                MetroMessageBox.Show(this, "MARK UPDATE SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "UPDATE FAILED", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {
            int a = int.Parse(MathTextBox4.Text);
            int b = int.Parse(EnglishTextBox5.Text);
            int c = int.Parse(BanglaTextBox6.Text);
            int d = int.Parse(ScienceTextBox7.Text);


            int f = a + b + c + d;
            Total_markTextBox8.Text = f.ToString();
           

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
           
            

         
               
            

           


             
           

        }

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClassTextBox1.Text = GRADE_TABLEmetroGrid1.SelectedRows[0].Cells[0].Value.ToString();
            NameTextBox2.Text = GRADE_TABLEmetroGrid1.SelectedRows[0].Cells[1].Value.ToString();
            IdTextBox3.Text = GRADE_TABLEmetroGrid1.SelectedRows[0].Cells[2].Value.ToString();
            MathTextBox4.Text = GRADE_TABLEmetroGrid1.SelectedRows[0].Cells[3].Value.ToString();
            EnglishTextBox5.Text = GRADE_TABLEmetroGrid1.SelectedRows[0].Cells[4].Value.ToString();
            BanglaTextBox6.Text = GRADE_TABLEmetroGrid1.SelectedRows[0].Cells[5].Value.ToString();
           // ScienceTextBox7.Text = metroGrid1.SelectedRows[0].Cells[6].Value.ToString();
            Total_markTextBox8.Text = GRADE_TABLEmetroGrid1.SelectedRows[0].Cells[7].Value.ToString();
          
        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
