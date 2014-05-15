using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    public class StudentDAO : IDaoCrud<Student>
    {
        private MySqlConnection con;

        public StudentDAO(string host, string db, string user, string pass)
        {
            string connectionString = "server=localhost;user=" + user + ";pwd=" + pass + ";database=" + db;
            con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception e) { throw e; }
        }
        /*long create(Student entity)
        {
            string user = "root";
            string pass = "";
            string db = "dao";
            string connectionString = "server=localhost;user=" + user + ";pwd=" + pass + ";database=" + db;
            MySqlConnection con = new MySqlConnection(connectionString);
            // Unos novog studenata
            con.Open();
            string ime = "Adnan", prezime = "Kicin";
            MySqlCommand c = new MySqlCommand("insert into student values ('" + ime + "','" + prezime + "')", con);
            c.ExecuteNonQuery();
            // insert into...
        }
         */
        //    CRUD metode implementirane
    }
}
