using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Windows.Forms;
using datalayer;
using entities;

using MetroFramework;

namespace Uilayer
{
    public partial class admin : MetroFramework.Forms.MetroForm
    {
        public admin()
        {
            InitializeComponent();
        }
       

        private void admin_Load(object sender, EventArgs e)
        {

            userData admin = new userData();

           

            //d.showStudent();
            NEW_ADMINmetroGrid1.DataSource = admin.showId();
        }
       
       public  int Id;
       public string Name, Passowrd;

       userData a = new userData();

        private void ADDmetroButton2_Click(object sender, EventArgs e)
        {
            try
            {

                Id = int.Parse(IDmetroTextBox1.Text);
                Name = USERNAMEmetroTextBox2.Text;
                Passowrd = PASSWORDmetroTextBox3.Text;




                a.insertAdmin(Id, Name, Passowrd);
                MetroMessageBox.Show(this, "NEW ADMIN ADDED SUCESSFULLY", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MetroMessageBox.Show(this,"PLEASE CHECK UNIQUE ID", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
