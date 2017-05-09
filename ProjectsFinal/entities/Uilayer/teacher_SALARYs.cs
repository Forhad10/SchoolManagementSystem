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

namespace Uilayer
{
    public partial class teacher_SALARYs : MetroFramework.Forms.MetroForm
    {
        public teacher_SALARYs()
        {
            InitializeComponent();
        }

        private void teacher_SALARYs_Load(object sender, EventArgs e)
        {
            TeacherData d = new TeacherData();

            SALARYGRIDVIEW.DataSource = d.showTeacherPayment();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
