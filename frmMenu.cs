using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noam
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCanTeachProject frm = new frmCanTeachProject();
            frm.ShowDialog();
        }

        private void btnPanui_Click(object sender, EventArgs e)
        {
            frmPanuiProject frm = new frmPanuiProject();
            frm.ShowDialog();
        }

        private void btnMorim_Click(object sender, EventArgs e)
        {
            frmMorimProject frm = new frmMorimProject();
            frm.ShowDialog();
        }

        private void btnLevels_Click(object sender, EventArgs e)
        {
            frmLevelsProject frm = new frmLevelsProject();
            frm.ShowDialog();
        }

        private void btnKita_Click(object sender, EventArgs e)
        {
            frmKita frm = new frmKita();
            frm.ShowDialog();
        }

        private void btnMik_Click(object sender, EventArgs e)
        {
            frmMikProject frm = new frmMikProject();
            frm.ShowDialog();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            frmStudents frm = new frmStudents();
            frm.ShowDialog();
        }


        private void btnBigForm_Click(object sender, EventArgs e)
        {
            frmCreateLesson frm = new frmCreateLesson();
            frm.ShowDialog();
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            frmDeleteLesson frm = new frmDeleteLesson();
            frm.ShowDialog();
        }

        private void btnTeacherReport_Click(object sender, EventArgs e)
        {
            frmTeacherReport frm = new frmTeacherReport();
            frm.ShowDialog();
        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            frmStudentReport frm = new frmStudentReport();
            frm.ShowDialog();
        }
    }
}
