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
    class Lessons
    {
        private int kod;
        private string teacher_id;
        private string student_id;
        private int kod_mik;
        private int kod_kita;
        private int kod_level;
        private string due_date;
        private int start_time;
        private int end_time;
        private string notes; 

        public Lessons(){}
        public DataTable GetLessonsTeachersStudentId()
        {
            string x = string.Format("SELECT teacher_id , student_id, due_date from tblLesson");
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public void AddLessons(string teacher, string student, int mik, int kita, int level, string date, int start, int end, string notes)
        {
            string x = string.Format("insert into tblLesson(teacher_id,student_id,kod_mik,kod_kita,kod_level,due_date,start_time,end_time,notes) values ('{0}','{1}',{2},{3},{4},'{5}',{6},{7},'{8}')",teacher, student, mik, kita, level, date,start, end, notes);
            DataSherut.ExecuteNonQuery(x);
        }
        public DataTable GetLessonsByStudentId(string id)
        {
            string x = string.Format("SELECT * from tblLesson where student_id='{0}' ",id);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public void Delete(string kod)
        {
            string x = string.Format("delete * from tblLesson where kod= {0}", kod);
            DataSherut.ExecuteNonQuery(x);
        }
        public DataTable GetLessonsByString(string field, string value)
        {
            string x = string.Format("SELECT * from tblLesson where {0} = {1} ",field,value);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
    }
}
