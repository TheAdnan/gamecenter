using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCenter.klase;
using DAL.Interfejsi;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class RecenzentDAO : IDaoCrud<Recenzent>
        {
            #region IDaoCrud<Recenzent> Members
            protected MySqlCommand c;

            public long create(Recenzent entity)
            {
                try
                {
                    c = new MySqlCommand("insert into recenzenti values ('" + entity.Prezime + "','" + entity.Ime + "','" + entity.JMBG + "','" + entity.Kontakt + "','" + entity.Adresa + "','" + entity.E_Mail + "','" + entity.Username + "','" + entity.Password + "','" +  entity.Plata + "','" + entity.RadnoVrijeme + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Recenzent> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from recenzenti", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Recenzent> recenzenti = new List<Recenzent>();
                    while (r.Read())
                        recenzenti.Add(new Recenzent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"),  r.GetDouble("plata"), r.GetInt32("radnoVrijeme")));
                    return recenzenti;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


          public Recenzent read(Recenzent entity)
            {
                throw new NotImplementedException();
            }
           
            public Recenzent update(Recenzent entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Recenzent entity)
            {
                throw new NotImplementedException();
            }

            public Recenzent getById(int id)
            {
                throw new NotImplementedException();
            }

            public Recenzent getByUsername(string username)
            {
                try
                {
                    c = new MySqlCommand("select * from recenzenti where username = '" + username + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Recenzent pom = new Recenzent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetDouble("plata"), r.GetInt32("radnovrijeme"));
                        r.Close();
                        return pom;
                    }
                    r.Close();
                    return null;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public List<Recenzent> getByExample(string nijebitno1, string nijebitno2)
            {
                throw new NotImplementedException();
            }

            #endregion


        }
    }
}