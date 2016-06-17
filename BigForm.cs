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
    class BigForm
    {
        public BigForm() { }

        public DataTable GetMorim(int MikCode, int LevelCode, int KitaCode)
        {
            string x = string.Format("SELECT tblMorimProject.id, tblMorimProject.FirstName, tblMorimProject.LastName FROM (tblCanTeachProject INNER JOIN  tblMorimProject ON tblCanTeachProject.id = tblMorimProject.id) where tblCanTeachProject.MikCode = {0} and  tblCanTeachProject.LevelCode = {1} and tblCanTeachProject.KitaCode = {2}", MikCode, LevelCode, KitaCode);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public DataTable GetLessonTimeDetailsForTeacher(string id)
        {
            string x = string.Format("SELECT due_date,start_time,end_time FROM tblLesson where teacher_id='{0}' ", id);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
    }
}
