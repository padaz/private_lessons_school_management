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
    public partial class frmCanTeachProject : Form
    {

        common_utilities cu = new common_utilities();

        public frmCanTeachProject()
        {
            InitializeComponent();
        }
        static kita x = new kita();
        DataTable kitot = x.GetKita();

        static levels levelim = new levels();
        DataTable ramot = levelim.GetLevels();

        static MikP m2ik = new MikP();
        DataTable mikzoot = m2ik.GetMikzoot();

        private void frmCanTeachProject_Load(object sender, EventArgs e)
        {
            MorimProject mik = new MorimProject();
            cu.charge_data_grid_view(mik.GetIdAndName(), dataGridViewMorimProject);
            foreach (DataRow mikzoa in mikzoot.Rows)
            {
                string mikzo = mikzoa["mikName"].ToString();
                tabControlMik.TabPages.Add(mikzo);
            }
            foreach (DataRow kita in kitot.Rows)
            {
                string x = kita["class"].ToString();
                dataGridViewInfo.Columns.Add("aa", x);
            }
            foreach (DataRow level in ramot.Rows)
            {
                string x = level["rama"].ToString();
                dataGridViewInfo.Rows.Add(x);
            }
            cu.make_dgv_non_sortable(dataGridViewMorimProject, dataGridViewInfo);
            dataGridViewInfo.ClearSelection();
        }

        private void tabControlMik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cu.is_dataGridView_colored(dataGridViewMorimProject)) return;
            string id = cu.GetID(dataGridViewMorimProject);
            Set_Info(id);
        }

        private void dataGridViewInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewInfo)) || e.ColumnIndex==0)
            {
                dataGridViewInfo.ClearSelection();
                return;
            }
            if(!cu.is_dataGridView_colored(dataGridViewMorimProject))
            {
                dataGridViewInfo.ClearSelection();
                MessageBox.Show("Please Choose Teacher");
                return;
            }
            string mik = tabControlMik.SelectedTab.Text;
            string level = dataGridViewInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            string kita = dataGridViewInfo.Columns[e.ColumnIndex].HeaderText;
            int MikCode = 0;
            int kitaCode = 0;
            int LevelCode = 0;
            string TeacherCode = "";
            foreach(DataRow dr in mikzoot.Rows)
            {
                if (dr["mikName"].ToString().Equals(mik))
                    MikCode = int.Parse(dr["mikCode"].ToString());
            }
            foreach (DataRow dr in ramot.Rows)
            {
                if (dr["rama"].ToString().Equals(level))
                    LevelCode = int.Parse(dr["code"].ToString());
            }
            foreach (DataRow dr in kitot.Rows)
            {
                if (dr["class"].ToString().Equals(kita))
                    kitaCode = int.Parse(dr["Code"].ToString());
            }

            for (int d = 0; d < dataGridViewMorimProject.RowCount; d++)
            {
                if (dataGridViewMorimProject.Rows[d].Cells[0].Style.BackColor == Color.MediumPurple)
                {
                    TeacherCode = dataGridViewMorimProject.Rows[d].Cells[0].Value.ToString();
                }
            }
            if (TeacherCode == "")
            {
                dataGridViewInfo.ClearSelection();
                return;
            }

            if (dataGridViewInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.MediumPurple) 
            {
                Lessons les = new Lessons();
                DataTable lessons = les.GetLessonsByString("teacher_id", "'"+TeacherCode+"'");
                foreach (DataRow lesson in lessons.Rows)
                {
                    if(cu.is_date_in_future(lesson["due_date"].ToString()) && lesson["kod_mik"].ToString().Equals(MikCode.ToString()) && lesson["kod_kita"].ToString().Equals(kitaCode.ToString()) && lesson["kod_level"].ToString().Equals(LevelCode.ToString()))
                    {
                        dataGridViewInfo.ClearSelection();
                        MessageBox.Show("Cannot delete, Future lesson is scheduled");
                        return;
                    }
                }
                dataGridViewInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                CanTeachProject x = new CanTeachProject();
                x.DeleteCanTeach(kitaCode, LevelCode, MikCode, TeacherCode);
            }   
            else if (dataGridViewInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Empty) 
            {
                    dataGridViewInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.MediumPurple;
                    CanTeachProject x = new CanTeachProject();
                    x.AddCanTeachProject(kitaCode, LevelCode, MikCode, TeacherCode);
            }
            dataGridViewInfo.ClearSelection();
        }

        private void Set_Info(string id)
        {
            cu.clean_dataGridView(dataGridViewInfo);
            CanTeachProject ct = new CanTeachProject();
            DataTable x = ct.GetAll(id);
            foreach (DataRow t in x.Rows)
            {
                int mik_code = int.Parse(t["MikCode"].ToString());
                int level_code = int.Parse(t["LevelCode"].ToString());
                int kita_code = int.Parse(t["KitaCode"].ToString());
                string mik_name = "", level_name = "", kita_name = "";
                foreach(DataRow mikzoa in mikzoot.Rows)
                {
                    if (int.Parse(mikzoa["mikCode"].ToString()) == mik_code)
                        mik_name = mikzoa["mikName"].ToString();
                }
                foreach (DataRow kita in kitot.Rows)
                {
                    if (int.Parse(kita["code"].ToString()) == kita_code)
                        kita_name = kita["class"].ToString();
                }
                foreach (DataRow rama in ramot.Rows)
                {
                    if (int.Parse(rama["code"].ToString()) == level_code)
                        level_name = rama["rama"].ToString();
                }
                if (tabControlMik.SelectedTab.Text.ToString() == mik_name)
                {
                    int row = 0;
                    while (row<dataGridViewInfo.RowCount && dataGridViewInfo.Rows[row].Cells[0].Value.ToString()!=level_name)
                    {
                        row++;
                    }
                    int counter = 0,cell=0;
                    foreach (DataGridViewColumn col in dataGridViewInfo.Columns)
                    {
                        if (col.HeaderText==kita_name)
                        {
                            cell = counter;
                        }
                        counter++;
                    }
                    dataGridViewInfo.Rows[row].Cells[cell].Style.BackColor = Color.MediumPurple;

                }
            }
        }

        private void dataGridViewMorimProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewMorimProject)))
            {
                dataGridViewMorimProject.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewMorimProject);
            cu.paint_chosen_row(e.RowIndex, dataGridViewMorimProject);
            string id = cu.GetID(dataGridViewMorimProject);
            Set_Info(id);
            dataGridViewMorimProject.ClearSelection();
        }
    }
}
