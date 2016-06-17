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
    class CanTeachProject
    {
        private string id;
        private int MikCode;
        private int LevelCode;
        private int KitaCode;

        public CanTeachProject() { }
        public void DeleteCanTeach(int kitaCode,int levelCode,int mikCode, string id)
        {
            string x = string.Format("delete * from tblCanTeachProject where MikCode= {0} and LevelCode={1} and KitaCode={2} and id='{3}'", mikCode,levelCode,kitaCode,id);
            DataSherut.ExecuteNonQuery(x);
        }
        public void AddCanTeachProject(int kitaCode, int levelCode, int mikCode, string id)
        {
            string x = string.Format("insert into tblCanTeachProject(id,MikCode,LevelCode,KitaCode) values ('{0}', {1},{2},{3})", id,mikCode,levelCode,kitaCode);
            DataSherut.ExecuteNonQuery(x);
        }
        public DataTable GetAll(string id)
        {
            string x = string.Format("SELECT tblCanTeachProject.MikCode, tblCanTeachProject.LevelCode, tblCanTeachProject.KitaCode FROM (tblMorimProject INNER JOIN  tblCanTeachProject ON tblCanTeachProject.id = tblMorimProject.id) where tblMorimProject.id='{0}'",id);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
    }
}
