using System;
using System.Data;
using System.Windows.Forms;

namespace noam
{
    public partial class frmLevelsProject : Form
    {
        common_utilities cu = new common_utilities();
        public frmLevelsProject()
        {
            InitializeComponent();
        }

        private void frmLevelsProject_Load(object sender, EventArgs e)
        {
            levels mik = new levels();
            cu.charge_data_grid_view(mik.GetLevels(), dataGridViewLevels);
            cu.make_dgv_non_sortable(dataGridViewLevels);
            dataGridViewLevels.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLevel.Text.Equals(""))
            {
                MessageBox.Show("you can't add empty level");
                return;
            }
            if (cu.is_value_exists(dataGridViewLevels, textBoxLevel.Text, 1))
            {
                MessageBox.Show(string.Format("you can't add existing level {0} ! ",textBoxLevel.Text));
                return;
            }
            if (cu.is_one_value_short(textBoxLevel.Text))
            {
                MessageBox.Show("short name");
                return;
            }
            levels mik = new levels();
            mik.AddLevel(textBoxLevel.Text);
            cu.charge_data_grid_view(mik.GetLevels(), dataGridViewLevels);
            cu.stay_on_added_value(textBoxLevel.Text, dataGridViewLevels,1);
        }

        private void dataGridViewLevels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewLevels.ClearSelection();
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewLevels)))
            {
                dataGridViewLevels.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewLevels);
            cu.paint_chosen_row(e.RowIndex, dataGridViewLevels);
            textBoxLevel.Text = dataGridViewLevels.Rows[e.RowIndex].Cells[1].Value.ToString();
            dataGridViewLevels.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!cu.is_dataGridView_colored(dataGridViewLevels))
            {
                MessageBox.Show("Nothing is picked on table!");
                return;
            }
            Lessons les = new Lessons();
            string field = "kod_level";
            string code = cu.GetID(dataGridViewLevels);
            DataTable lessonsID = les.GetLessonsByString(field, code);
            foreach (DataRow dr in lessonsID.Rows)
            {
                if (dr[field].ToString().Equals(code) && cu.is_date_in_future(dr["due_date"].ToString()))
                {
                    MessageBox.Show("Cannot delete level with scheduled lessons!");
                    return;
                }
            }
            levels mkk = new levels();
            mkk.Delete(cu.GetID(dataGridViewLevels));
            cu.charge_data_grid_view(mkk.GetLevels(), dataGridViewLevels);
            dataGridViewLevels.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!cu.is_dataGridView_colored(dataGridViewLevels))
            {
                MessageBox.Show("Pick something to update");
                return;
            }
            if (textBoxLevel.Text.Equals(""))
            {
                MessageBox.Show("you can't add empty level");
                return;
            }
            if (cu.is_value_exists(dataGridViewLevels,textBoxLevel.Text,1))
            {
                MessageBox.Show(string.Format("you can't add existing level {0} ! ", textBoxLevel.Text));
                return;
            }
            if (cu.is_one_value_short(textBoxLevel.Text))
            {
                MessageBox.Show("short name");
                return;
            }
            string a = cu.GetID(dataGridViewLevels);
            levels mk = new levels();
            mk.Update(a, textBoxLevel.Text);
            cu.charge_data_grid_view(mk.GetLevels(), dataGridViewLevels);
            cu.stay_on_added_value(textBoxLevel.Text, dataGridViewLevels,1);
        }
    }
}
