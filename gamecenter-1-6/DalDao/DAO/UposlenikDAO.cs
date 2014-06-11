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
        public class UposlenikDAO : IDaoCrud<Uposlenik>
        {
            #region IDaoCrud<Uposlenik> Members
            protected MySqlCommand c;

            public long create(Uposlenik entity)
            {
                try
                {
                    c = new MySqlCommand("insert into uposlenici values ('" + entity.Prezime + "','" + entity.Ime + "','" + entity.JMBG + "','" + entity.Kontakt + "','" + entity.slika + "','" + entity.E_Mail + "','" + entity.Username + "','" + entity.Password + "','" +  entity.Plata + "','" + entity.RadnoVrijeme + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Uposlenik> getAll()
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("select * from uposlenici", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Uposlenik> uposlenici = new List<Uposlenik>();
                    while (r.Read())
                        uposlenici.Add(new Uposlenik(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("slika"), r.GetString("email"), r.GetString("username"), r.GetString("password"),  r.GetDouble("plata"), r.GetInt32("radnoVrijeme")));
                    r.Close();
                    return uposlenici;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


          public Uposlenik read(Uposlenik entity)
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
           
            public Uposlenik update(Uposlenik entity)
            {
                try
                {
                    c = new MySqlCommand("update recenzenti set ime = '" + entity.Ime + "', prezime = '" + entity.Prezime + "', kontakt = '" + entity.Kontakt + "', adresa= '" + entity.slika + "', email = '" + entity.E_Mail + "', password = '" + entity.Password + "', plata = '" + entity.Plata + "', radnovrijeme = '" + entity.RadnoVrijeme + "' where id ='" + entity.ID + "'", con);

                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Uposlenik pom = new Uposlenik(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("slika"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetDouble("plata"), r.GetInt32("radnovrijeme"));

                        delete(entity);
                        r.Close();
                        return pom;
                    }
                    delete(entity);
                    r.Close();
                    return null;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Uposlenik entity)
            {
                try
                {
                    c = new MySqlCommand("delete from uposlenici where id ='" + entity.ID + "'", con);

                    c.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Uposlenik getById(int id)
            {
                try
                {
                    c = new MySqlCommand("select * from uposlenici where id = '" + id + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Uposlenik pom = new Uposlenik(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("slika"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetDouble("plata"), r.GetInt32("radnovrijeme"));
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

            public Uposlenik getByUsername(string username)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("select * from uposlenici where username = '" + username + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    while(r.Read())
                    {
                        Uposlenik pom = new Uposlenik(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("slika"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetDouble("plata"), r.GetInt32("radnovrijeme"));
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
            public List<Uposlenik> getByExample(string nijebitno1, string nijebitno2)
            {
                throw new NotImplementedException();
            }

            #endregion


        }
    }
}