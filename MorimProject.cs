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
    class MorimProject
    {
        private string id;
        private string FirstName;
        private string LastName;
        private string Address;
        private string Num1;
        private string Num2;

        public MorimProject() {}

        public DataTable GetMorim()
        {
            string x = string.Format("select id, FirstName, LastName, Address, Num1, Num2 from tblMorimProject");
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public void DeleteButton(string tz)
        {
            string x = string.Format("delete * from tblMorimProject where id= '{0}'", tz);
            DataSherut.ExecuteNonQuery(x);
        }
        public void AddMorim(string id, string shem, string lastshem, string address, string num1, string num2)
        {
            string x = string.Format("insert into tblMorimProject(id, FirstName, LastName, Address, Num1,Num2) values ('{0}','{1}','{2}','{3}','{4}','{5}')", id, shem, lastshem, address, num1, num2);
            //MessageBox.Show(x);
            DataSherut.ExecuteNonQuery(x);
        }
        public void Update(string tz, string firstname, string lastname, string address, string num1,string num2)
        {
            string x = string.Format("update tblMorimProject set firstname='{1}', lastname='{2}', address='{3}', Num1='{4}', Num2='{5}' where id='{0}' ", tz, firstname, lastname, address, num1, num2);
            //MessageBox.Show(x);
            DataSherut.ExecuteNonQuery(x);
        }

        public DataTable GetIdAndName()
        {
            string x = string.Format("select id, FirstName, LastName from tblMorimProject");
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public DataTable GetNameById(string id)
        {
            string x = string.Format("select FirstName, LastName from tblMorimProject where id='{0}'",id);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }

    }
}
