using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

string user = "root";
string pass = "";
string db = "dao";
string connectionString = "server=localhost;user="+user+";pwd="+pass+";database="+db;
MySqlConnection con = new MySqlConnection(connectionString);
// Unos novog studenata
con.Open();
string ime="Adnan", prezime= "Kicin";
MySqlCommand c = new MySqlCommand("insert into student values ('" + ime + "','" +prezime+ "')", con);
c.ExecuteNonQuery();


// Ucitavanje studenata u listu
    List<Student> studenti = new List<Student>();
    c = new MySqlCommand("select * from student", con);
    MySqlDataReader r = c.ExecuteReader();
    while (r.Read())
        studenti.Add(new Student(r.GetString("ime"), r.GetString("prezime")));
               }
             catch(Exception){
                  Console.WriteLine("greska");
            }
        }
    }
}
