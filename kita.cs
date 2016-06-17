using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace noam
{
    class kita
    {   
        private int Code; 
        private string class_name;
        public kita() { }

        public DataTable GetKita()
        {
            string x = string.Format("select Code, class from tblagesproject");
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }
        public DataTable GetKitaByCode(string code)
        {
            string x = string.Format("select class from tblagesproject where code=  {0}",code);
            DataSet ds = DataSherut.GetDataSet(x);
            return ds.Tables[0];
        }

        public void AddKita(string shem)
        {
            string x = string.Format("insert into tblagesproject(class) values ('{0}')", shem);
            DataSherut.ExecuteNonQuery(x);
        }

        public void Delete(string kod)
        {
            string x = string.Format("delete code from tblagesproject where Code= {0}", kod);
            DataSherut.ExecuteNonQuery(x);
        }

        public void Update(string kod, string shem)
        {
            string x = string.Format("update tblagesproject set class='{0}' where Code= {1}", shem, kod);
            DataSherut.ExecuteNonQuery(x);
        }

    }
}
