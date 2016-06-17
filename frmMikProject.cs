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
    public partial class frmMikProject : Form
    {
        common_utilities cu = new common_utilities();
        public frmMikProject()
        {
            InitializeComponent();
        }

        private void frmMikProject_Load(object sender, EventArgs e)
        {
            MikP mik = new MikP();
            cu.charge_data_grid_view(mik.GetMikzoot(), dataGridViewMikP);
            cu.make_dgv_non_sortable(dataGridViewMikP);
            dataGridViewMikP.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(""))
            {
                MessageBox.Show("you can't add empty Mikzoa");
                return;
            }
            if (cu.is_value_exists(dataGridViewMikP, textBoxName.Text, 1))
            {
                MessageBox.Show(string.Format("you can't add existing Mikzoa {0} ! ", textBoxName.Text));
                return;
            }
            if(cu.is_one_value_short(textBoxName.Text))
            {
                MessageBox.Show("short name");
                return;
            }
            MikP mik = new MikP();
            mik.AddMikzoa(textBoxName.Text);
            cu.charge_data_grid_view(mik.GetMikzoot(), dataGridViewMikP);
            cu.stay_on_added_value(textBoxName.Text, dataGridViewMikP,1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!cu.is_dataGridView_colored(dataGridViewMikP))
            {
                MessageBox.Show("Nothing is picked on teachers!");
                return;
            }
            Lessons les = new Lessons();
            string field = "kod_mik";
            DataTable lessonsID = les.GetLessonsByString(field, cu.GetID(dataGridViewMikP));
            string mik_id = cu.GetID(dataGridViewMikP);
            foreach (DataRow dr in lessonsID.Rows)
            {
                if (dr[field].ToString() == mik_id && cu.is_date_in_future(dr["due_date"].ToString()))
                {
                    MessageBox.Show("Cannot delete mik with scheduled lessons!");
                    return;
                }
            }
            MikP mkk = new MikP();
            mkk.Delete(cu.GetID(dataGridViewMikP));
            cu.charge_data_grid_view(mkk.GetMikzoot(), dataGridViewMikP);
            this.dataGridViewMikP.ClearSelection();
        }

        private void dataGridViewMikP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMikP.ClearSelection();
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewMikP)))
            {
                dataGridViewMikP.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewMikP);
            cu.paint_chosen_row(e.RowIndex, dataGridViewMikP);
            textBoxName.Text = dataGridViewMikP.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(""))
            {
                MessageBox.Show("you can't add empty Mikzoa");
                return;
            }
            if (cu.is_value_exists(dataGridViewMikP, textBoxName.Text, 1))
            {
                MessageBox.Show(string.Format("you can't add existing level {0} ! ", textBoxName.Text));
                return;
            }
            if(!cu.is_dataGridView_colored(dataGridViewMikP))
            {
                dataGridViewMikP.ClearSelection();
                MessageBox.Show("Please choose");
                return;
            }
            if (cu.is_one_value_short(textBoxName.Text))
            {
                MessageBox.Show("short name");
                return;
            }
            string a = cu.GetID(dataGridViewMikP);
            MikP mk = new MikP();
            mk.Update(a, textBoxName.Text);
            cu.charge_data_grid_view(mk.GetMikzoot(), dataGridViewMikP);
            cu.stay_on_added_value(textBoxName.Text, dataGridViewMikP, 1);
        }
    }
}
