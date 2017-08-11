using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CoffeCSharp
{
    public class Connection
    {        
        string ConnectionString = "Data Source=MARRYMEPLS;Initial Catalog=db_Coffe;Integrated Security=True";
        SqlConnection con;
        public void openConection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }


        public void closeConnection()
        {
            con.Close();
        }


        public void executeQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.ExecuteNonQuery();

        }


        public SqlDataReader dataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            PublicVar.dr = cmd.ExecuteReader();
            return PublicVar.dr;
        }


        public object showDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public object showData(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);
           
            dr.Fill(PublicVar.ds);

            return PublicVar.ds;
        }
    }
}
