using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;



/// <summary>
/// Summary description for DAL
/// </summary>
namespace noam
{
    public class DataSherut
    {
        
        private static string ConnectionString()
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\netunim\\data.accdb";
            return string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{0}';Persist Security Info=True", path);
        }
        // äçæøú òøê áåãã 
        public static Object ExecuteScalar(string strSql)
        {
            String connectionString = ConnectionString();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(strSql, connection);
            connection.Open();
            Object obj = command.ExecuteScalar();
            connection.Close();
            return obj;
        }
        // îçæéø òåú÷ ùì èáìä øöåéä
        public static DataSet GetDataSet(string strSql)
        {
            DataSet ds = new DataSet();
            String connectionString = ConnectionString();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(strSql, connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
            dataAdapter.Fill(ds);
            return ds;
        }
        // works for insert update delete
        public static int ExecuteNonQuery(string strSql)
        {
            int rowsAffected;
            String connectionString = ConnectionString();
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(strSql, connection);
            connection.Open();
            rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected;
        }
    }
}
