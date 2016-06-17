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
    public partial class frmCreateLesson : Form
    {
        bool first;
        int hatchala, siyum;
        public frmCreateLesson()
        {
            InitializeComponent();
        }
        common_utilities cu = new common_utilities();

        private void frmBigForm_Load(object sender, EventArgs e)
        {
            MikP mik = new MikP();
            dataGridViewMikP.DataSource = mik.GetMikzoot();
            cu.clean_dataGridView(dataGridViewMikP);
            levels level = new levels();
            dataGridViewLevels.DataSource = level.GetLevels();
            cu.clean_dataGridView(dataGridViewLevels);
            kita kita = new kita();
            dataGridViewKita.DataSource = kita.GetKita();
            cu.clean_dataGridView(dataGridViewKita);
            tan();
       
            cu.clean_dataGridView(dataGridViewZmanProject);
            cu.zman(dataGridViewZmanProject);
            first = true;
            cu.make_dgv_non_sortable(dataGridViewKita, dataGridViewLevels, dataGridViewMikP, dataGridViewMorimProject, dataGridViewStudents, dataGridViewZmanProject);
            dataGridViewStudents.ClearSelection();
            dataGridViewZmanProject.ClearSelection();
        }

        public void tan()
        {
            bool flag = cu.is_dataGridView_colored(dataGridViewStudents);
            string chosen_id="";
            if (flag)
                chosen_id = cu.GetID(dataGridViewStudents);
            string x =textBoxFind.Text;
            dataGridViewStudents.Rows.Clear();
            Student student = new Student();
            DataTable data_table = student.GetStudents();
            foreach (DataRow row in data_table.Rows)
            {
                string tz = row["tz"].ToString();
                string shem = row["shem"].ToString();
                string mish = row["mish"].ToString();
                string yom = row["yom"].ToString();
                string mobile = row["mobile_telephone"].ToString();
                string home = row["home_telephone"].ToString();
                string ktovet = row["ktovet"].ToString();
                if (tz.Contains(x) || shem.Contains(x) || mish.Contains(x))
                    dataGridViewStudents.Rows.Add(tz, shem, mish, yom, mobile, home, ktovet);
            }
            if(flag)
                cu.stay_on_added_value(chosen_id, dataGridViewStudents, 0);
            dataGridViewStudents.ClearSelection();
        }

        private void dataGridViewMikP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewMikP)))
            {
                dataGridViewMikP.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewMikP);
            cu.paint_chosen_row(e.RowIndex, dataGridViewMikP);
            dataGridViewMikP.ClearSelection();
            if (is_three_colored()) launch_morim();
        }

        private void dataGridViewKita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewKita)))
            {
                dataGridViewKita.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewKita);
            cu.paint_chosen_row(e.RowIndex, dataGridViewKita);
            dataGridViewKita.ClearSelection();
            if (is_three_colored()) launch_morim();
        }

        private void dataGridViewLevels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewLevels)))
            {
                dataGridViewLevels.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewLevels);
            cu.paint_chosen_row(e.RowIndex, dataGridViewLevels);
            dataGridViewLevels.ClearSelection();
            if (is_three_colored()) launch_morim();
        }

        private void dataGridViewMorimProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewMorimProject)))
            {
                dataGridViewMorimProject.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewMorimProject);
            cu.clean_dataGridView(dataGridViewZmanProject);
            cu.paint_chosen_row(e.RowIndex, dataGridViewMorimProject);
            dataGridViewMorimProject.ClearSelection();
            zvaTarich();
        }

        private void dataGridViewZmanProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!cu.is_dataGridView_colored(dataGridViewMorimProject) || e.ColumnIndex == 0 || cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewZmanProject)))
            {
                dataGridViewZmanProject.ClearSelection();
                return;
            }
            
            if (first)
            {
                hatchala = e.RowIndex;
                first = false;
                zvaTarich();
            }
            else if (e.RowIndex < hatchala)
            {
                hatchala = e.RowIndex;
            }
            else
            {
                zvaTarich();
                siyum = e.RowIndex;
                if (is_range_taken(hatchala, siyum))
                {
                    MessageBox.Show("Cannot schedule lesson! Existing one or free hours!");
                    first = true;
                    return;
                }
                for (int i = hatchala; i <= siyum; i++)
                    dataGridViewZmanProject.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                first = true;
            }

            dataGridViewZmanProject.ClearSelection();
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
            dataGridViewStudents.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!is_three_colored() || !cu.is_dataGridView_colored(dataGridViewStudents) || !cu.is_dataGridView_colored(dataGridViewMorimProject) || !first)
            {
                MessageBox.Show("Not all details are provided. Select on Tables the details of lesson!");
                return;
            }
            int counter = 0;
            while (counter<dataGridViewZmanProject.RowCount && dataGridViewZmanProject.Rows[counter].Cells[1].Style.BackColor !=Color.Yellow)
            {
                counter++;
            }
            if(counter == dataGridViewZmanProject.RowCount)
            {
                MessageBox.Show("Lesson time is not picked!");
                return;
            }
            Lessons les = new Lessons();
            les.AddLessons(cu.GetID(dataGridViewMorimProject), cu.GetID(dataGridViewStudents), int.Parse(cu.GetID(dataGridViewMikP)), int.Parse(cu.GetID(dataGridViewKita)), int.Parse(cu.GetID(dataGridViewLevels)), dateTimePicker1.Value.ToShortDateString(), hatchala, siyum, textBoxNotes.Text.ToString());
            zvaTarich();
            first = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            cu.clean_dataGridView(dataGridViewZmanProject);
            zvaTarich();
        }



        public void zvaTarich()
        {
            if (!cu.is_dataGridView_colored(dataGridViewMorimProject))
            {
                dataGridViewZmanProject.ClearSelection();
                return;
            }

            cu.clean_dataGridView(dataGridViewZmanProject);
            DateTime tarich = dateTimePicker1.Value;
            int misparYom = (int)tarich.DayOfWeek + 1;
            string id = cu.GetID(dataGridViewMorimProject);

            PanuiProject pa = new PanuiProject();
            DataTable dt = pa.GetPanuiForDay(misparYom, id);
            foreach (DataRow dr in dt.Rows)
            {
                int row = int.Parse(dr["shaa"].ToString());
                dataGridViewZmanProject.Rows[row].Cells[1].Style.BackColor = Color.MediumPurple;
            }

            BigForm bf = new BigForm();
            DataTable lessons = bf.GetLessonTimeDetailsForTeacher(id);
            foreach (DataRow lesson in lessons.Rows)
            {
                int start = int.Parse(lesson["start_time"].ToString());
                int end = int.Parse(lesson["end_time"].ToString());
                string due = lesson["due_date"].ToString();
                if (due.Equals(dateTimePicker1.Value.ToShortDateString()))
                {
                    for (int i = start; i <= end; i++)
                    {
                        dataGridViewZmanProject.Rows[i].Cells[1].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        public bool is_three_colored()
        {
            return cu.is_dataGridView_colored(dataGridViewKita) && cu.is_dataGridView_colored(dataGridViewMikP) && cu.is_dataGridView_colored(dataGridViewLevels);
        }

        public void launch_morim()
        {
            int mik_kod = int.Parse(cu.GetID(dataGridViewMikP)), kita_kod = int.Parse(cu.GetID(dataGridViewKita)), level_kod = int.Parse(cu.GetID(dataGridViewLevels));
            BigForm op = new BigForm();
            dataGridViewMorimProject.DataSource = op.GetMorim(mik_kod, level_kod, kita_kod);
            if (dataGridViewMorimProject.RowCount == 0)
                MessageBox.Show("No Teacher teaches this comination!");
            dataGridViewMorimProject.ClearSelection();
        }

        public bool is_range_taken(int start, int end)
        {
            for (int i = start; i <= end; i++)
                if (dataGridViewZmanProject.Rows[i].Cells[1].Style.BackColor != Color.MediumPurple)
                    return true;
            return false;
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            tan();
        }

    }
}
