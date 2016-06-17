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
    class common_utilities
    {
        public common_utilities() { }

        public bool is_one_value_short(params string[] values)
        {
            for(int i=0; i<values.Length;i++)
            {
                if (values[i].Length == 1)
                    return true;
            }
            return false;
        }

        public bool is_phone_valid(string phone)
        {
            for (int i = 0; i < phone.Length; i++)
            {
                if (i == 0 && !Char.IsDigit(phone[i]) && phone[i].Equals('+'))
                {
                    MessageBox.Show("phone is not valid");
                    return false;
                }
                if (i == phone.Length - 1 && !Char.IsDigit(phone[i]))
                {
                    MessageBox.Show("phone is not valid");
                    return false;
                }
                if (!Char.IsDigit(phone[i]) && !phone[i].Equals('-'))
                {
                    MessageBox.Show("phone is not valid");
                    return false;
                }
            }
            return true;
        }

        public void charge_data_grid_view(DataTable dt , DataGridView dgv)
        {
            int row = save_scroll_before_load(dgv);
            dgv.DataSource = dt;
            set_scroller_after_load(row, dgv);
            dgv.ClearSelection();
        }
        public int save_scroll_before_load(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
                return 0;
            return dgv.FirstDisplayedCell.RowIndex;
        }
        public void set_scroller_after_load(int row,DataGridView dgv)
        {
            if (row == 0)
                return;
            if (row >= dgv.RowCount)
                return;
            dgv.FirstDisplayedScrollingRowIndex = row;
        }

        public bool is_id_belongs_to_strudent_or_teacher(string id, params string[] to_check)
        {
            for (int counter = 0; counter < to_check.Length; counter++)
            {
                if (to_check[counter].Equals("students"))
                {
                    Student st = new Student();
                    DataTable students = st.GetStudents();
                    foreach (DataRow dt in students.Rows)
                    {
                        if (id.Equals(dt["tz"].ToString()))
                            return true;
                    }
                }
                else if (to_check[counter].Equals("teachers"))
                {
                    MorimProject st = new MorimProject();
                    DataTable morim = st.GetMorim();
                    foreach (DataRow dt in morim.Rows)
                    {
                        if (id.Equals(dt["id"].ToString()))
                            return true;
                    }
                }
                else
                {
                    MessageBox.Show("Developer, you do not check ID validation as needed.");
                }
            }
            return false;
        }

        public void stay_on_added_value(string value, DataGridView dgv ,int cell)
        {
            clean_dataGridView(dgv);
            int counter = 0;
            while (counter < dgv.RowCount && !dgv.Rows[counter].Cells[cell].Value.ToString().Equals(value))
            {
                counter++;
            }
            if (counter == dgv.RowCount)
                return;
            paint_chosen_row(counter, dgv);
        }

        public void make_dgv_non_sortable(params DataGridView[] dgvs)
        {
            for (int counter = 0; counter < dgvs.Length; counter++)
            {
                for (int col = 0; col < dgvs[counter].ColumnCount; col++)
                {
                    dgvs[counter].Columns[col].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        }

        public int get_dgv_last_row(DataGridView dgv)
        {
            int i = 0;
            while (i < dgv.RowCount && dgv.Rows[i].Cells[0].Value!=null && !dgv.Rows[i].Cells[0].Value.ToString().Equals(""))
            {
                i++;
                try
                {
                    string x = dgv.Rows[i].Cells[0].Value.ToString();
                        
                }
                catch
                {
                    break;
                }
            }
            return i;
        }

        public bool is_value_exists(DataGridView dgv, string value, int col)
        {
            try
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    if (dgv.Rows[i].Cells[col].Value.ToString().Equals(value)) return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetMorim()
        {
            string x = string.Format("SELECT id, FirstName, LastName FROM tblMorimProject");
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }

        public bool is_dataGridView_colored(DataGridView d)
        {
            bool ok = false;
            int i = 0;
            while (i < d.RowCount && !ok)
            {
                ok = d.Rows[i].Cells[0].Style.BackColor == Color.MediumPurple;
                i++;
            }
            return ok;
        }

        public void zman(DataGridView dataGridViewZmanProject)
        {
            for (int h = 8; h <= 17; h++)
            {
                int index = dataGridViewZmanProject.Rows.Add();
                dataGridViewZmanProject.Rows[index].Cells[0].Value = h + ":00";
                index = dataGridViewZmanProject.Rows.Add();
                dataGridViewZmanProject.Rows[index].Cells[0].Value = h + ":15";
                index = dataGridViewZmanProject.Rows.Add();
                dataGridViewZmanProject.Rows[index].Cells[0].Value = h + ":30";
                index = dataGridViewZmanProject.Rows.Add();
                dataGridViewZmanProject.Rows[index].Cells[0].Value = h + ":45";
            }
        }

        public void clean_dataGridView(DataGridView d)
        {
            for (int i = 0; i < d.ColumnCount; i++)
            {
                for (int k = 0; k < d.RowCount; k++)
                {
                    d.Rows[k].Cells[i].Style.BackColor = Color.Empty;

                }
            }
            d.ClearSelection();
        }

        public void paint_chosen_row(int index, DataGridView d)
        {
            for (int i = 0; i < d.ColumnCount; i++)
            {
                if (is_out_of_dataGridView_range(index, i, d.RowCount))
                    return;
                d.Rows[index].Cells[i].Style.BackColor = Color.MediumPurple;
            }
            d.ClearSelection();
        }

        public string GetID(DataGridView dgv)
        {
            int i = 0;
            while (i < dgv.RowCount && dgv.Rows[i].Cells[0].Style.BackColor != Color.MediumPurple) { i++; }
            return dgv.Rows[i].Cells[0].Value.ToString();
        }

        public bool is_out_of_dataGridView_range(int row, int column, int end)//true is outrange ,false in range//
        {
            return row < 0 || column < 0 || row > end - 1;
        }

        public string Get_Value_of_kita(string code)
        {
            kita k = new kita();
            DataTable classes = k.GetKitaByCode(code);
            return classes.Rows[0]["class"].ToString();
        }
        public string Get_Value_of_level(string code)
        {
            levels k = new levels();
            DataTable classes = k.GetLevelByCode(code);
            return classes.Rows[0]["rama"].ToString();
        }
        public string Get_Value_of_mik(string code)
        {
            MikP k = new MikP();
            DataTable classes = k.GetMikByCode(code);
            return classes.Rows[0]["mikName"].ToString();
        }
        public string Get_Value_of_Morim(string code)
        {
            MorimProject k = new MorimProject();
            DataTable classes = k.GetNameById(code);
            return classes.Rows[0]["FirstName"].ToString() + " " + classes.Rows[0]["LastName"].ToString();
        }

        public string Get_Value_of_Students(string code)
        {
            Student k = new Student();
            DataTable classes = k.GetStudentsByID(code);
            return classes.Rows[0]["shem"].ToString() + " " + classes.Rows[0]["mish"].ToString();
        }

        public string get_hour_by_index(int row)
        {
            int index = 0;
            for (int h = 8; h <= 17; h++)
            {
                if (index == row)
                    return h + ":00";
                index++;
                if (index == row)
                    return h + ":15";
                index++;
                if (index == row)
                    return h + ":30";
                index++;
                if (index == row)
                    return h + ":45";
                index++;
            }
            return "";

        }

        public bool is_date_in_future(string from_db)
        {
            return DateTime.Compare(DateTime.ParseExact(from_db,"d/M/yyyy",null), DateTime.Today) >= 0;
        }

        public DataTable change_keys_to_values(DataTable original_lessons, string point = "future")
        {
            DataTable new_one = new DataTable();
            new_one.Columns.Add("kod");
            new_one.Columns.Add("teacher_name");
            new_one.Columns.Add("student_name");
            new_one.Columns.Add("mik");
            new_one.Columns.Add("kita");
            new_one.Columns.Add("level");
            new_one.Columns.Add("due_date");
            new_one.Columns.Add("start_time");
            new_one.Columns.Add("end_time");
            new_one.Columns.Add("notes");
            foreach (DataRow or_row in original_lessons.Rows)
            {
                if (DateTime.Compare(DateTime.Parse(or_row["due_date"].ToString()), DateTime.Parse(DateTime.Today.ToShortDateString())) < 0 && point.Equals("future"))
                    continue;
                else if (DateTime.Compare(DateTime.Parse(or_row["due_date"].ToString()), DateTime.Parse(DateTime.Today.ToShortDateString())) >= 0 && point.Equals("past"))
                    continue;
                DataRow row = new_one.Rows.Add();
                row["kod"] = or_row["kod"];
                row["due_date"] = or_row["due_date"];
                row["notes"] = or_row["notes"];

                row["student_name"] = Get_Value_of_Students(or_row["student_id"].ToString());
                row["teacher_name"] = Get_Value_of_Morim(or_row["teacher_id"].ToString());
                row["mik"] = Get_Value_of_mik(or_row["kod_mik"].ToString());
                row["kita"] = Get_Value_of_kita(or_row["kod_kita"].ToString());
                row["level"] = Get_Value_of_level(or_row["kod_level"].ToString());
                row["start_time"] = get_hour_by_index(int.Parse(or_row["start_time"].ToString()));
                string end = get_hour_by_index(int.Parse(or_row["end_time"].ToString()));
                string[] hour = end.Split(':').ToArray<string>();
                if(hour[1].Equals("45"))
                    row["end_time"] = (int.Parse(hour[0])+1).ToString() + ":00";
                else
                    row["end_time"] = hour[0]+":"+ (int.Parse(hour[1])+15).ToString();
            }

            return new_one;
        }

        public DataTable GetLessonsByTeacherIdAndDate(string id, string due)
        {
            string x = string.Format("SELECT * from tblLesson where teacher_id='{0}' and due_date='{1}' ", id, due);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }

        public bool is_id_exists(string id, DataGridView d)
        {
            for (int i = 0; i < d.RowCount - 1; i++)
            {
                if (d.Rows[i].Cells[0].Value.ToString().Equals(id) && d.Rows[i].Cells[0].Style.BackColor == Color.Empty) return true;
            }
            return false;
        }

        public bool is_important_field_empty(params string[] fields)
        {
            for (int i = 0; i < fields.Length; i++) { if (fields[i].Length == 0) return true; }
            return false;
        }
        public bool is_id_validated(string id)
        // סוכם את כל המספרים במקומות הזוגיים עם הסכום של המכפלות ב2 של המספרים במקומות האי זוגיים
        // אם המכפלה ב2 של מקום אי זוגי גדולה מ10 הוא מוסיף את סכום הספרות
        // הת"ז תקין אם הסכום הסופי מתחלק ב10
        {
            int x, sum = 0;
            Boolean mazav = true;
            long output;
            if (!long.TryParse(id, out output))
                return false;
            if (id.Length != 9)
                return false;
            for (int i = 8; i >= 0; i--)
            {
                x = int.Parse(id[i].ToString());
                if (!mazav)
                    x = x * 2;
                if (x > 9)
                    x = x / 10 + x % 10;
                sum = sum + x;
                mazav = !mazav;
            }
            if (sum % 10 != 0)
                return false;
            return true;
        }

        public string generate_random_id()
        {
            int sum = 0;
            Random ran = new Random();
            string id = "";
            bool state = true;
            int x;
            for (int i = 0; i < 8; i++)
            {
                x = ran.Next(0, 10);
                id += x.ToString();
                if (!state)
                    x = x * 2;
                if (x > 9)
                    x = x / 10 + x % 10;
                sum = sum + x;
                state = !state;

            }
            x = 10 - sum % 10;
            id += x.ToString();
            return id;
        }

        public void create_test_data_students()
        {
            Random ran = new Random();
            Student st = new Student();
            string id = generate_random_id();
            string shem = "תלמיד";
            string mish = "תלמידתלמיד";
            string date;
            string num1;
            string num2;
            string address;
            for (int i = 1; i <= 150; i++)
            {
                shem = i + shem;
                mish = i + mish;
                int day = ran.Next(1, 27);
                int mon = ran.Next(1, 12);
                int year = ran.Next(1990, 2005);
                string yom, hod;
                if (day < 10)
                    yom = "0" + day.ToString();
                else
                    yom =day.ToString();
                if (mon < 10)
                    hod = "0" + mon.ToString();
                else
                    hod = mon.ToString();
                date = yom + "/" + hod + "/" + year.ToString();
                num1 = "09-" + i.ToString();
                num2 = "054-" + i.ToString();
                address = i.ToString() + "הלימון";
                st.AddStudent(id, shem, mish, date, num1, num2, address);
                id = generate_random_id();
                shem = "תלמיד";
                mish = "תלמידתלמיד";
            }
        }

        public void can_teach_create_test_data()
        {
            MorimProject mp = new MorimProject();
            kita kit = new kita();
            levels level = new levels();
            MikP mik = new MikP();

            DataTable morim = mp.GetMorim();
            DataTable kitot = kit.GetKita();
            DataTable ramot = level.GetLevels();
            DataTable mikzoot = mik.GetMikzoot();
            Random ran = new Random();
            int top_morim = morim.Rows.Count;
            int top_kitot = kitot.Rows.Count;
            int top_ramot = ramot.Rows.Count;
            int top_mikzoot = mikzoot.Rows.Count;
            for (int i = 0; i < 200; i++)
            {
                int morim_row = ran.Next(0, top_morim);
                int kitot_row = ran.Next(0, top_kitot);
                int ramot_row = ran.Next(0, top_ramot);
                int mikzoot_row = ran.Next(0, top_mikzoot);

                string code_more = morim.Rows[morim_row]["id"].ToString();
                string code_kita = kitot.Rows[kitot_row]["Code"].ToString();
                string code_level = ramot.Rows[ramot_row]["code"].ToString();
                string mik_code = mikzoot.Rows[mikzoot_row]["mikCode"].ToString();

                CanTeachProject ct = new CanTeachProject();
                try
                {
                    ct.AddCanTeachProject(int.Parse(code_kita), int.Parse(code_level), int.Parse(mik_code), code_more);
                }
                catch
                { }
            }
        }

        public void panui_create_test_data()
        {
            MorimProject mp = new MorimProject();
            DataTable morim = mp.GetMorim();
            Random ran = new Random();
            int top_morim = morim.Rows.Count;
            PanuiProject pa = new PanuiProject();
            for (int i = 0; i < 800; i++)
            {
                int morim_row = ran.Next(0, top_morim);
                string code_more = morim.Rows[morim_row]["id"].ToString();
                int day = ran.Next(1, 7);
                int hour = ran.Next(0, 40);
                try
                {
                    pa.Add(code_more, day, hour);
                }
                catch { }
            }
        }

        public void create_lessons()
        {
            kita kit = new kita();
            levels level = new levels();
            MikP mik = new MikP();
            BigForm bf = new BigForm();
            Student st = new Student();
            PanuiProject pp = new PanuiProject();
            Lessons les = new Lessons();

            DataTable kitot = kit.GetKita();
            DataTable ramot = level.GetLevels();
            DataTable mikzoot = mik.GetMikzoot();
            Random ran = new Random();

            int top_kitot = kitot.Rows.Count;
            int top_ramot = ramot.Rows.Count;
            int top_mikzoot = mikzoot.Rows.Count;
            for (int i = 0; i < 800; i++)
            {
                int kitot_row = ran.Next(0, top_kitot);
                int ramot_row = ran.Next(0, top_ramot);
                int mikzoot_row = ran.Next(0, top_mikzoot);

                string code_kita = kitot.Rows[kitot_row]["Code"].ToString();
                string code_level = ramot.Rows[ramot_row]["code"].ToString();
                string mik_code = mikzoot.Rows[mikzoot_row]["mikCode"].ToString();

                DataTable morim = bf.GetMorim(int.Parse(mik_code), int.Parse(code_level), int.Parse(code_kita));
                if (morim.Rows.Count == 0)
                    continue;
                int teacher_index = ran.Next(0, morim.Rows.Count);
                string teacher_id = morim.Rows[teacher_index]["id"].ToString();
                DataTable students = st.GetStudents();
                int student_index = ran.Next(0, students.Rows.Count);
                string student_id = students.Rows[student_index]["tz"].ToString();
                int mon = ran.Next(4, 8);
                int day = ran.Next(1, 30);
                string yom, hod;
                if (day < 10)
                    yom = "0" + day.ToString();
                else
                    yom = day.ToString();
                if (mon < 10)
                    hod = "0" + mon.ToString();
                else
                    hod = mon.ToString();
                string due = yom + "/" + hod + "/2016";
                int in_week = (int)(DateTime.ParseExact(due, "d/M/yyyy", null).DayOfWeek) +1;
                DataTable panui = pp.GetPanuiForDay(in_week, teacher_id);
                if (panui.Rows.Count == 0)
                    continue;
                int panui_index = ran.Next(0, panui.Rows.Count);
                int start = int.Parse(panui.Rows[panui_index]["shaa"].ToString());
                int end = start;
                int counter = 0;
                while (counter< panui.Rows.Count)
                {
                    if (int.Parse(panui.Rows[counter]["shaa"].ToString()) - 1 == end)
                        end++;
                    counter++;
                }
                DataTable lessons_for_teacher = bf.GetLessonTimeDetailsForTeacher(teacher_id);
                DataTable lessons_for_student = les.GetLessonsByStudentId(student_id);
                bool flag = true;
                if(lessons_for_teacher.Rows.Count !=0)
                {
                    foreach(DataRow dr in lessons_for_teacher.Rows)
                    {
                        if (dr["due_date"].ToString().Equals(due) && dr["start_time"].ToString().Equals(start) && dr["end_time"].ToString().Equals(end))
                            flag = false;
                    }
                }
                if (lessons_for_student.Rows.Count != 0)
                {
                    foreach (DataRow dr in lessons_for_student.Rows)
                    {
                        if (dr["due_date"].ToString().Equals(due) && dr["start_time"].ToString().Equals(start) && dr["end_time"].ToString().Equals(end))
                            flag = false;
                    }
                }
                if (!flag) continue;

                les.AddLessons(teacher_id, student_id, int.Parse(mik_code), int.Parse(code_kita), int.Parse(code_level), due, start, end, "");
            }
        }
    }
}
