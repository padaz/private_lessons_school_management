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
    public partial class frmTeacherReport : Form
    {
        common_utilities cu = new common_utilities();
        public frmTeacherReport()
        {
            InitializeComponent();
        }

        private void frmTeacherReport_Load(object sender, EventArgs e)
        {
            cu.charge_data_grid_view(cu.GetMorim(), dataGridViewMorimProject);
            cu.make_dgv_non_sortable(dataGridViewLessons, dataGridViewMorimProject);
            dataGridViewMorimProject.ClearSelection();
        }

        private void dataGridViewMorimProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cu.is_out_of_dataGridView_range(e.RowIndex,e.ColumnIndex,cu.get_dgv_last_row(dataGridViewMorimProject)))
            {
                dataGridViewMorimProject.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewMorimProject);
            cu.paint_chosen_row(e.RowIndex, dataGridViewMorimProject);
            Update_Lessons_Table();
        }
        public void Update_Lessons_Table()
        {
            if (!cu.is_dataGridView_colored(dataGridViewMorimProject))
            {
                MessageBox.Show("No Teacher selected!");
                return;
            }
            string due = dateTimePicker1.Value.ToShortDateString();
            string x = cu.GetID(dataGridViewMorimProject);
            cu.charge_data_grid_view(cu.change_keys_to_values(cu.GetLessonsByTeacherIdAndDate(x, due)), dataGridViewLessons);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Update_Lessons_Table();
        }

        private void dataGridViewLessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLessons.ClearSelection();
        }
    }
}
