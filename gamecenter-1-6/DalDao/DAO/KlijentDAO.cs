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
        public class KlijentDAO : IDaoCrud<Klijent>
        {
            #region IDaoCrud<Klijent> Members
            protected MySqlCommand c;

            public long create(Klijent entity)
            {
                try
                {
                    c = new MySqlCommand("insert into klijenti values ('" + entity.Prezime + "','" + entity.Ime + "','" + entity.JMBG + "','" + entity.Kontakt + "','" + entity.Adresa + "','" + entity.E_Mail + "','" + entity.Username + "','" + entity.Password +  "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Klijent> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from klijenti", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Klijent> klijenti = new List<Klijent>();
                    while (r.Read())
                        klijenti.Add(new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password")));
                    return klijenti;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Klijent read(Klijent entity)
            {
                throw new NotImplementedException();
            }

            public Klijent update(Klijent entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Klijent entity)
            {
                throw new NotImplementedException();
            }

            public Klijent getById(int id)
            {
                throw new NotImplementedException();
            }

            public Klijent getByUsername(string username)
            {
                try
                {
                    c = new MySqlCommand("select * from klijenti where username = '" + username + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Klijent pom = new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"));
                        return pom;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public List<Klijent> getByExample(string nijebitno1, string nijebitno2)
            {
                throw new NotImplementedException();
            }

            #endregion


        }
    }
}