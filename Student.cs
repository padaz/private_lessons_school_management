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
    class Student
    {
        private string tz;
        private string shem;
        private string mish;
        private string yom;
        private string mobile_telephone;
        private string home_telephone;
        private string ktovet;


        public Student() { }

        public DataTable GetStudents()
        {
            string x = string.Format("select tz, shem, mish, yom, mobile_telephone, home_telephone, ktovet from tblStudents");
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public void AddStudent(string id, string shem, string lastshem, string bday,string num1, string num2, string address)
        {
            string x = string.Format("insert into tblStudents(tz, shem, mish, yom, mobile_telephone, home_telephone, ktovet) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", id, shem, lastshem, bday,num1, num2, address);
            //MessageBox.Show(x);
            DataSherut.ExecuteNonQuery(x);
        }
        public void Delete(string tz)
        {
            string x = string.Format("delete * from tblStudents where tz= '{0}'", tz);
            DataSherut.ExecuteNonQuery(x);
        }
        public void Update(string tz, string firstname, string lastname,string bday, string num1, string num2, string address)
        {
            string x = string.Format("update tblStudents set shem='{1}', mish='{2}', yom='{3}', mobile_telephone='{4}', home_telephone='{5}',ktovet='{6}' where tz='{0}' ", tz, firstname, lastname, bday, num1, num2, address);
            //MessageBox.Show(x);
            DataSherut.ExecuteNonQuery(x);
        }
        public DataTable GetStudentsByID(string tz)
        {
            string x = string.Format("select tz, shem, mish from tblStudents where tz='{0}'",tz);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }

    }
}
