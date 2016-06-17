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
    class MikP
    {
        private int mikCode;
        private string mikName;
        public MikP()
        { }

        public DataTable GetMikzoot()
        {
            string x = string.Format("select mikCode, mikName from tblMikProject");
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public DataTable GetMikByCode(string code)
        {
            string x = string.Format("select  mikName from tblMikProject where mikCode={0}", code);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }

        public void AddMikzoa(string shem)
        {
            string x = string.Format("insert into tblMikProject(mikname) values ('{0}')", shem);
            DataSherut.ExecuteNonQuery(x);

        }
        public void Delete(string kod)
        {
            string x = string.Format("delete mikCode from tblMikProject where mikCode= {0}", kod);
            DataSherut.ExecuteNonQuery(x);
        }
        public void Update(string kod, string shem)
        {
            string x = string.Format("update tblMikProject set mikName='{0}' where mikCode= {1}", shem, kod);
            DataSherut.ExecuteNonQuery(x);
        }
        
    }
}
