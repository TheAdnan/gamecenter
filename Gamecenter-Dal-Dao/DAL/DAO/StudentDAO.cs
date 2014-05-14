using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Interfejsi;
using DAL.Entiteti;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class StudentDAO : IDaoCrud<Student>
        {
            #region IDaoCrud<Student> Members
            protected MySqlCommand c;

            public long create(Student entity)
            {
                try
                {
                    c = new MySqlCommand("insert into student values ('" + entity.Ime + "','" + entity.Prezime + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Student> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from student", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Student> studenti = new List<Student>();
                    while (r.Read())
                        studenti.Add(new Student(r.GetString("ime"), r.GetString("prezime")));
                     return studenti;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Student read(Student entity)
            {
                throw new NotImplementedException();
            }

            public Student update(Student entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Student entity)
            {
                throw new NotImplementedException();
            }

            public Student getById(int id)
            {
                throw new NotImplementedException();
            }

            public List<Student> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}
