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
    public partial class frmDeleteLesson : Form 
    {
        common_utilities cu = new common_utilities();
        public frmDeleteLesson()
        {
            InitializeComponent();
        }

        private void frmDeleteLesson_Load(object sender, EventArgs e)
        {
            Student stu = new Student();
            cu.charge_data_grid_view(stu.GetStudents(), dataGridViewStudents);
            cu.clean_dataGridView(dataGridViewStudents);
            dataGridViewStudents.ClearSelection();
            dataGridViewLessons.ClearSelection();
            cu.make_dgv_non_sortable(dataGridViewLessons, dataGridViewStudents);
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewStudents.ClearSelection();
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewStudents)))
                return;
            cu.clean_dataGridView(dataGridViewStudents);
            cu.paint_chosen_row(e.RowIndex, dataGridViewStudents);
            Lessons ls = new Lessons();
            cu.charge_data_grid_view(cu.change_keys_to_values(ls.GetLessonsByStudentId(cu.GetID(dataGridViewStudents))), dataGridViewLessons);
        }

        private void dataGridViewLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewLessons)))
            {
                dataGridViewLessons.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewLessons);
            cu.paint_chosen_row(e.RowIndex, dataGridViewLessons);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!cu.is_dataGridView_colored(dataGridViewLessons))
            {
                MessageBox.Show("Please choose lesson");
                return;
            }
            string id = cu.GetID(dataGridViewLessons);
            Lessons les = new Lessons();
            les.Delete(id);
            cu.charge_data_grid_view(cu.change_keys_to_values(les.GetLessonsByStudentId(cu.GetID(dataGridViewStudents))), dataGridViewLessons);
            dataGridViewLessons.ClearSelection();
        }

    }
}
