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
    public partial class frmPanuiProject : Form
    {
        common_utilities cu = new common_utilities();
        public frmPanuiProject()
        {
            InitializeComponent();
        }

        private void frmPanuiProject_Load(object sender, EventArgs e)
        {
            MorimProject mik = new MorimProject();
            cu.charge_data_grid_view(mik.GetMorim(), dataGridViewMorimProject);
            cu.zman(dataGridViewZmanProject);
            cu.make_dgv_non_sortable(dataGridViewZmanProject, dataGridViewMorimProject);
            dataGridViewZmanProject.ClearSelection();
        }

        private void dataGridViewMorimProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMorimProject.ClearSelection();
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewMorimProject)))
            {
                return;
            }
            cu.clean_dataGridView(dataGridViewMorimProject);
            cu.clean_dataGridView(dataGridViewZmanProject);
            cu.paint_chosen_row(e.RowIndex, dataGridViewMorimProject);
            string id = cu.GetID(dataGridViewMorimProject);
            PanuiProject pl = new PanuiProject();
            DataTable dt = pl.GetPanui(id);
            foreach (DataRow row in dt.Rows)
            {
                int yom = int.Parse(row["yom"].ToString());
                int shaa = int.Parse(row["shaa"].ToString());
                dataGridViewZmanProject.Rows[shaa].Cells[yom].Style.BackColor = Color.MediumPurple;
            }
            dataGridViewMorimProject.ClearSelection();
            dataGridViewZmanProject.ClearSelection();
        }

        private void dataGridViewZmanProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewZmanProject)))
            {
                dataGridViewZmanProject.ClearSelection();
                return;
            }
            if (!cu.is_dataGridView_colored(dataGridViewMorimProject))
            {
                dataGridViewZmanProject.ClearSelection();
                return;
            }
            PanuiProject ct = new PanuiProject();
            string id = cu.GetID(dataGridViewMorimProject);
            if (dataGridViewZmanProject.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Empty)
            {
                dataGridViewZmanProject.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.MediumPurple;
                ct.Add(id, e.ColumnIndex ,e.RowIndex);
            }
            else if(dataGridViewZmanProject.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.MediumPurple)
            {
                dataGridViewZmanProject.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Empty;
                ct.Delete(id, e.ColumnIndex ,e.RowIndex);
            }
            dataGridViewZmanProject.ClearSelection();
        }
    }
}
