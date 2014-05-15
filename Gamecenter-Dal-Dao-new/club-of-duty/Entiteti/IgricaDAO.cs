using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MySql.Data.MySqlClient;
using System.Data;
using gameCenter;

namespace DalDao
{
    public class IgricaDAO : IDaoCrud<Igrica>
    {
        private MySqlConnection con;

        public IgricaDAO(string host, string db, string user, string pass)
        {
            string connectionString = "server=localhost;user=" + user + ";pwd=" + pass + ";database=" + db;
            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception e) { throw e; }
        }
     long create(Igrica entity)
        {
            string user = "root";
            string pass = "";
            string db = "dao";
            string connectionString = "server=localhost;user=" + user + ";pwd=" + pass + ";database=" + db;
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string ime = "Super Mario";
            MySqlCommand c = new MySqlCommand("insert into igrica values ('" + ime + "')", con);
            c.ExecuteNonQuery();
  
        }
   
    }
}
