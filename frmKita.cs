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
    public partial class frmKita : Form
    {
        common_utilities cu = new common_utilities();
        public frmKita()
        {
            InitializeComponent();
        }

        private void frmKita_Load(object sender, EventArgs e)
        {
            kita mik = new kita();
            cu.charge_data_grid_view(mik.GetKita(), dataGridViewKita);
            cu.make_dgv_non_sortable(dataGridViewKita);
            dataGridViewKita.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxKita.Text.Equals(""))
            {
                MessageBox.Show("you can't add empty Kita");
                return;
            }
            if (cu.is_value_exists(dataGridViewKita, textBoxKita.Text, 1))
            {
                MessageBox.Show(string.Format("you can't add existing kita {0} ! ", textBoxKita.Text));
                return;
            }
            kita mik = new kita();
            mik.AddKita(textBoxKita.Text);
            cu.charge_data_grid_view(mik.GetKita(), dataGridViewKita);
            cu.stay_on_added_value(textBoxKita.Text, dataGridViewKita, 1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!cu.is_dataGridView_colored(dataGridViewKita))
            {
                MessageBox.Show("Nothing is picked on table!");
                return;
            }
            Lessons les = new Lessons();
            string field = "kod_kita";
            string code = cu.GetID(dataGridViewKita);
            DataTable lessonsID = les.GetLessonsByString(field, code);
            foreach (DataRow dr in lessonsID.Rows)
            {
                if (dr[field].ToString().Equals(code) || cu.is_date_in_future(dr["due_date"].ToString()))
                {
                    MessageBox.Show("Cannot delete class with scheduled lessons!");
                    return;
                }
            }
            kita mkk = new kita();
            mkk.Delete(code);
            cu.charge_data_grid_view(mkk.GetKita(), dataGridViewKita);
            this.dataGridViewKita.ClearSelection();
        }

        private void dataGridViewKita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewKita.ClearSelection();
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, cu.get_dgv_last_row(dataGridViewKita)))
            {
                dataGridViewKita.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewKita);
            cu.paint_chosen_row(e.RowIndex, dataGridViewKita);
            textBoxKita.Text = dataGridViewKita.Rows[e.RowIndex].Cells[1].Value.ToString();
            dataGridViewKita.ClearSelection();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)

        { 
            if(!cu.is_dataGridView_colored(dataGridViewKita))
            {
                MessageBox.Show("Choose kita");
                return;
            }
            if (textBoxKita.Text.Equals(""))
            {
                MessageBox.Show("you can't add empty Kita");
                return;
            }
            if (cu.is_value_exists(dataGridViewKita, textBoxKita.Text, 1))
            {
                MessageBox.Show(string.Format("you can't add existing kita {0} ! ", textBoxKita.Text));
                return;
            }
            kita mk = new kita();
            mk.Update(cu.GetID(dataGridViewKita), textBoxKita.Text);
            cu.charge_data_grid_view(mk.GetKita(), dataGridViewKita);
            cu.stay_on_added_value(textBoxKita.Text, dataGridViewKita, 1);
        }
    }
}
