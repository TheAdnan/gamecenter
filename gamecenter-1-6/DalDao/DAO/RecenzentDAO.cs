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

            public void create(Recenzent entity)
            {
                try
                {
                    c = new MySqlCommand("insert into recenzenti(ime,prezime,jmbg,kontakt,slika,email,username,password, plata, radnoVrijeme) values ('" + entity.Ime + "','" + entity.Prezime + "','" + entity.JMBG + "','" + entity.Kontakt + "','" + entity.slika + "','" + entity.E_Mail + "','" + entity.Username + "','" + entity.Password + "','" + entity.Plata + "','" + entity.RadnoVrijeme + "')", con);
                    c.ExecuteNonQuery();
                    
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
                        recenzenti.Add(new Recenzent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("slika"), r.GetString("email"), r.GetString("username"), r.GetString("password"),  r.GetDouble("plata"), r.GetInt32("radnoVrijeme")));
                    r.Close();
                    return recenzenti;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


          public Recenzent read(Recenzent entity)
            {
                try
                {
                    return getById(entity.ID);

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
           
            public Recenzent update(Recenzent entity)
            {
                try
                {
                    string query = "update recenzenti set ime = '" + entity.Ime + "', prezime = '" + entity.Prezime + "', kontakt = '" + entity.Kontakt + "', adresa= '" + entity.slika + "', email = '" + entity.E_Mail + "', password = '" + entity.Password + "', plata = '" + entity.Plata + "', radnovrijeme = '" + entity.RadnoVrijeme + "' where id ='" + entity.ID + "';";

                    c = new MySqlCommand(query, con);

                    c.ExecuteNonQuery();

                    return entity;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Recenzent entity)
            {
                try
                {
                    c = new MySqlCommand("delete from recenzenti where id ='" + entity.ID + "'", con);

                    c.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Recenzent getById(int id)
            {
                try
                {
                    c = new MySqlCommand("select * from recenzenti where id = '" + id + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Recenzent pom = new Recenzent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("slika"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetDouble("plata"), r.GetInt32("radnovrijeme"));
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

            public Recenzent getByUsername(string username)
            {
                try
                {
                    c = new MySqlCommand("select * from recenzenti where username = '" + username + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Recenzent pom = new Recenzent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("slika"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetDouble("plata"), r.GetInt32("radnovrijeme"));
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