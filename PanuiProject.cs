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
    class PanuiProject
    {
        private int yom;
        private int shaa;
        private string id;

        public PanuiProject() { }

        public DataTable GetPanui(string tz)
        {
            string x = string.Format("select yom, shaa from tblPanuiProject where id='{0}'", tz);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public void Add(string id, int yom, int shaa)
        {
            string x = string.Format("insert into tblPanuiProject(id, yom, shaa) values ('{0}', {1}, {2})", id, yom, shaa);
            DataSherut.ExecuteNonQuery(x);
        }
        public void Delete(string id, int yom, int shaa)
        {
            string x = string.Format("delete * from tblPanuiProject where id='{0}' and yom={1} and shaa={2}", id, yom, shaa);
            DataSherut.ExecuteNonQuery(x);
        }
        public DataTable GetPanuiForDay(int day,string id)
        { 
            string x = string.Format("select shaa from tblPanuiProject where yom={0} and id='{1}'", day,id);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
    }
}
