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
    public partial class frmStudents : Form
    {
        common_utilities cu = new common_utilities();
        string id = "";
        public frmStudents()
        {
            InitializeComponent();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            cu.make_dgv_non_sortable(dataGridViewStudents);
            tan();

   
        }
        public void tan()
        {
            if (cu.is_dataGridView_colored(dataGridViewStudents))
                id = cu.GetID(dataGridViewStudents);
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
                string ktovet =  row["ktovet"].ToString();
                if (tz.Contains(x) || shem.Contains(x) || mish.Contains(x))
                    dataGridViewStudents.Rows.Add(tz, shem ,mish ,yom ,mobile ,home ,ktovet);
            }
            int counter = 0;
             while(counter < dataGridViewStudents.RowCount && !dataGridViewStudents.Rows[counter].Cells[0].Value.ToString().Equals(id))
            {
                counter++;
            }
            if (counter == dataGridViewStudents.RowCount)
                cu.set_scroller_after_load(0, dataGridViewStudents);
            else if (counter > 5)
                cu.set_scroller_after_load(counter - 5, dataGridViewStudents);
            else
                cu.set_scroller_after_load(0, dataGridViewStudents);
            dataGridViewStudents.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cu.is_important_field_empty(textBoxTZ.Text, textBoxShem.Text, textBoxMish.Text))
            {
                MessageBox.Show("important field is missing");
                return;
            }
            if (cu.is_id_exists(textBoxTZ.Text, dataGridViewStudents) || cu.is_id_belongs_to_strudent_or_teacher(textBoxTZ.Text,"teachers") || !cu.is_id_validated(textBoxTZ.Text))
            {
                MessageBox.Show(string.Format("{0} is already existing ID or non-valid id!", textBoxTZ.Text));
                return;
            }
            if (cu.is_one_value_short(textBoxMish.Text, textBoxShem.Text, textBoxHome.Text, textBoxMobile.Text, textBoxKtovet.Text))
            {
                MessageBox.Show("value needs to be at least 2 chars");
                return;
            }
            if (!cu.is_phone_valid(textBoxHome.Text) || !cu.is_phone_valid(textBoxMobile.Text))
                return;
            Student p = new Student();
            p.AddStudent(textBoxTZ.Text, textBoxShem.Text, textBoxMish.Text, dateTimePickerBday.Value.ToShortDateString(), textBoxMobile.Text, textBoxHome.Text, textBoxKtovet.Text);
            tan();
            cu.stay_on_added_value(textBoxTZ.Text, dataGridViewStudents, 0);
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewStudents.ClearSelection();
            if (cu.is_out_of_dataGridView_range(e.RowIndex, e.ColumnIndex, dataGridViewStudents.RowCount))
            {
                dataGridViewStudents.ClearSelection();
                return;
            }
            cu.clean_dataGridView(dataGridViewStudents);
            cu.paint_chosen_row(e.RowIndex, dataGridViewStudents);
            textBoxTZ.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxShem.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxMish.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePickerBday.Value = DateTime.ParseExact(dataGridViewStudents.Rows[e.RowIndex].Cells[3].Value.ToString(),"d/M/yyyy",null);
            textBoxMobile.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxHome.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBoxKtovet.Text = dataGridViewStudents.Rows[e.RowIndex].Cells[6].Value.ToString();

            dataGridViewStudents.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!cu.is_dataGridView_colored(dataGridViewStudents))
            {
                MessageBox.Show("Nothing is picked on table!");
                return;
            }
            string a = cu.GetID(dataGridViewStudents);
            Lessons les = new Lessons();
            string field = "student_id";
            DataTable lessonsID = les.GetLessonsTeachersStudentId();
            foreach (DataRow dr in lessonsID.Rows)
            {
                if (dr[field].ToString() == a && cu.is_date_in_future(dr["due_date"].ToString()))
                {
                    MessageBox.Show("Cannot delete student with scheduled lessons!");
                    return;
                }
            }
            Student mkk = new Student();
            mkk.Delete(a);
            tan();
            dataGridViewStudents.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!cu.is_dataGridView_colored(dataGridViewStudents))
            {
                MessageBox.Show("Nothing is picked on table!");
                return;
            }
            if (cu.is_important_field_empty(textBoxTZ.Text, textBoxShem.Text, textBoxMish.Text))
            {
                MessageBox.Show("One of the Important Field is Empty!");
                return;
            }
            if (cu.is_id_exists(textBoxTZ.Text, dataGridViewStudents) || cu.is_id_belongs_to_strudent_or_teacher(textBoxTZ.Text,"teachers"))
            {
                MessageBox.Show(string.Format("you can't change existing id {0}!", textBoxTZ.Text));
                return;
            }
            if (!cu.is_id_validated(textBoxTZ.Text))
            {
                MessageBox.Show(string.Format("id {0} is not valid!", textBoxTZ.Text));
                return;
            }
            if (cu.is_one_value_short(textBoxMish.Text, textBoxShem.Text, textBoxHome.Text, textBoxMobile.Text, textBoxKtovet.Text))
            {
                MessageBox.Show("value needs to be at least 2 chars");
                return;
            }
            if (!cu.is_phone_valid(textBoxHome.Text) || !cu.is_phone_valid(textBoxMobile.Text))
                return;
            Student d = new Student();
            d.Update(textBoxTZ.Text, textBoxShem.Text, textBoxMish.Text, dateTimePickerBday.Value.ToShortDateString(), textBoxMobile.Text, textBoxHome.Text, textBoxKtovet.Text);
            tan();
            cu.stay_on_added_value(textBoxTZ.Text, dataGridViewStudents, 0);
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            bool flag = cu.is_dataGridView_colored(dataGridViewStudents);
            tan();
            cu.stay_on_added_value(textBoxTZ.Text, dataGridViewStudents, 0);
        }
    }
    }

