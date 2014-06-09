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
                    c = new MySqlCommand("insert into uposlenici values ('" + entity.Prezime + "','" + entity.Ime + "','" + entity.JMBG + "','" + entity.Kontakt + "','" + entity.Adresa + "','" + entity.E_Mail + "','" + entity.Username + "','" + entity.Password + "','" +  entity.Plata + "','" + entity.RadnoVrijeme + "')", con);
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
                    c = new MySqlCommand("select * from uposlenici", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Uposlenik> uposlenici = new List<Uposlenik>();
                    while (r.Read())
                        uposlenici.Add(new Uposlenik(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"),  r.GetDouble("plata"), r.GetInt32("radnoVrijeme")));
                    return uposlenici;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


          public Uposlenik read(Uposlenik entity)
            {
                throw new NotImplementedException();
            }
           
            public Uposlenik update(Uposlenik entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Uposlenik entity)
            {
                throw new NotImplementedException();
            }

            public Uposlenik getById(int id)
            {
                throw new NotImplementedException();
            }

            public Uposlenik getByUsername(string username)
            {
                try
                {
                    c = new MySqlCommand("select * from uposlenici where username = '" + username + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Uposlenik pom = new Uposlenik(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetDouble("plata"), r.GetInt32("radnovrijeme"));
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