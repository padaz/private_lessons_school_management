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
    public partial class frmMorimProject : Form
    {
        common_utilities cu = new common_utilities();
        public frmMorimProject()
        {
            InitializeComponent();
        }

        private void frmMorimProject_Load(object sender, EventArgs e)
        {
            MorimProject mik = new MorimProject();
            cu.charge_data_grid_view(mik.GetMorim(), dataGridViewMorimProject);
            cu.make_dgv_non_sortable(dataGridViewMorimProject);
            dataGridViewMorimProject.ClearSelection();
        }

        private void dataGridViewMorimProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMorimProject.ClearSelection();
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex,cu.get_dgv_last_row(dataGridViewMorimProject)))
            {
                dataGridViewMorimProject.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewMorimProject);
            cu.paint_chosen_row(e.RowIndex, dataGridViewMorimProject);
            textBoxId.Text = dataGridViewMorimProject.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridViewMorimProject.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewMorimProject.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridViewMorimProject.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxNum1.Text = dataGridViewMorimProject.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxNum2.Text = dataGridViewMorimProject.Rows[e.RowIndex].Cells[5].Value.ToString();
            dataGridViewMorimProject.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cu.is_id_exists(textBoxId.Text,dataGridViewMorimProject) || cu.is_id_belongs_to_strudent_or_teacher(textBoxId.Text,"students") || !cu.is_id_validated(textBoxId.Text))
            {
                MessageBox.Show(string.Format("{0} is alreadt existing ID or not valid ID!", textBoxId.Text));
                return;
            }
            if(cu.is_important_field_empty(textBoxId.Text, textBoxFirstName.Text, textBoxLastName.Text))
            {
                MessageBox.Show("important field is empty!");
                return;
            }
            if(cu.is_one_value_short(textBoxAddress.Text,textBoxFirstName.Text,textBoxLastName.Text,textBoxNum1.Text,textBoxNum2.Text))
            {
                MessageBox.Show("value needs to be at least 2 chars");
                return;
            }
            if (!cu.is_phone_valid(textBoxNum1.Text) || !cu.is_phone_valid(textBoxNum2.Text))
                return;
            MorimProject mik = new MorimProject();
            mik.AddMorim(textBoxId.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, textBoxNum1.Text,textBoxNum2.Text);
            cu.charge_data_grid_view(mik.GetMorim(), dataGridViewMorimProject);
            cu.stay_on_added_value(textBoxId.Text, dataGridViewMorimProject, 0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!cu.is_dataGridView_colored(dataGridViewMorimProject))
            {
                MessageBox.Show("Nothing is picked on table!");
                return;
            }
            string a = cu.GetID(dataGridViewMorimProject);
            Lessons les = new Lessons();
            DataTable lessonsID = les.GetLessonsTeachersStudentId();
            foreach (DataRow dr in lessonsID.Rows)
            {
                if (dr["teacher_id"].ToString() == a && cu.is_date_in_future(dr["due_date"].ToString()))
                {
                    MessageBox.Show(dr["due_date"].ToString());
                    MessageBox.Show("Cannot delete teachers with scheduled lessons!");
                    return;
                }
            }
            MorimProject mkk = new MorimProject();
            mkk.DeleteButton(a);
            cu.charge_data_grid_view(mkk.GetMorim(), dataGridViewMorimProject);
            dataGridViewMorimProject.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!cu.is_dataGridView_colored(dataGridViewMorimProject))
            {
                MessageBox.Show("Nothing is picked on table!");
                return;
            }
            if (cu.is_important_field_empty(textBoxId.Text, textBoxFirstName.Text, textBoxLastName.Text))
            {
                MessageBox.Show("One of the Important Field is Empty!");
                return;
            }
            if (cu.is_id_exists(textBoxId.Text , dataGridViewMorimProject) || cu.is_id_belongs_to_strudent_or_teacher(textBoxId.Text,"students"))
            {
                MessageBox.Show(string.Format("you can't change to id {0}, it exists!", textBoxId.Text));
                return;
            }
            if (!cu.is_id_validated(textBoxId.Text))
            {
                MessageBox.Show(string.Format("you can't change to invalid id {0}!", textBoxId.Text));
                return;
            }
            if (cu.is_one_value_short(textBoxAddress.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxNum1.Text, textBoxNum2.Text))
            {
                MessageBox.Show("value needs to be at least 2 chars");
                return;
            }
            if (!cu.is_phone_valid(textBoxNum1.Text) || !cu.is_phone_valid(textBoxNum2.Text))
                return;
            MorimProject mk = new MorimProject();
            mk.Update(textBoxId.Text, textBoxFirstName.Text, textBoxLastName.Text, textBoxAddress.Text, textBoxNum1.Text,textBoxNum2.Text);
            cu.charge_data_grid_view(mk.GetMorim(), dataGridViewMorimProject);
            dataGridViewMorimProject.ClearSelection();
            cu.stay_on_added_value(textBoxId.Text, dataGridViewMorimProject, 0);
        }
    }
}
