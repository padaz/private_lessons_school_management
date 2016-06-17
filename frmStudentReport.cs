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
    public partial class frmStudentReport : Form
    {
        common_utilities cu = new common_utilities();
        public frmStudentReport()
        {
            InitializeComponent();
        }

        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            Student stu = new Student();
            dataGridViewStudents.DataSource = stu.GetStudents();
            cu.clean_dataGridView(dataGridViewStudents);
            cu.make_dgv_non_sortable(dataGridViewLessonsFuture, dataGridViewLessonsPast, dataGridViewStudents);            
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewStudents)))
            {
                dataGridViewStudents.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewStudents);
            cu.paint_chosen_row(e.RowIndex, dataGridViewStudents);
            Lessons ls = new Lessons();
            dataGridViewLessonsPast.DataSource = cu.change_keys_to_values(ls.GetLessonsByStudentId(cu.GetID(dataGridViewStudents)),"past");
            dataGridViewLessonsFuture.DataSource = cu.change_keys_to_values(ls.GetLessonsByStudentId(cu.GetID(dataGridViewStudents)));
            dataGridViewLessonsPast.ClearSelection();
            dataGridViewLessonsFuture.ClearSelection();
        }

        private void dataGridViewLessonsPast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLessonsPast.ClearSelection();
        }

        private void dataGridViewLessonsFuture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLessonsFuture.ClearSelection();
        }
    }
}
