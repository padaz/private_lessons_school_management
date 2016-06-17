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
    class levels
    {
    private int Code;
    private string rama;

    public levels() {}
        
    public DataTable GetLevels()
        {
            string x = string.Format("select Code, rama from tblLevelsProject");
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
    public DataTable GetLevelByCode(string code)
    {
        string x = string.Format("select  rama from tblLevelsProject where Code ={0}",code);
        DataSet ds = DataSherut.GetDataSet(x);
        return ds.Tables[0];
    }
        public void AddLevel(string shem)
    {
        string x = string.Format("insert into tblLevelsProject(rama) values ('{0}')", shem);
        DataSherut.ExecuteNonQuery(x);
    }

    public void Delete(string kod)
    {
        string x = string.Format("delete code from tbllevelsproject where Code= {0}", kod);
        DataSherut.ExecuteNonQuery(x);
    }

    public void Update(string kod, string shem)
    {
        string x = string.Format("update tbllevelsproject set rama='{0}' where Code= {1}", shem, kod);
        //MessageBox.Show(x);
        DataSherut.ExecuteNonQuery(x);
    }

    }
}
