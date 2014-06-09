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
        public class IgricaDAO : IDaoCrud<Igrica>
        {
            #region IDaoCrud<Igrica> Members
            protected MySqlCommand c;

            public long create(Igrica entity)
            {
                try
                {
                    c = new MySqlCommand("insert into igrice values ('" + entity.Naziv + "','" + entity.Trailer + "','" + entity.Dostupnost + "','" + entity.Cijena + "','" + entity.Kategorija + "','" + entity.Platforma + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Igrica> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from igrice", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Igrica> igrice = new List<Igrica>();
                    while (r.Read())
                        igrice.Add(new Igrica(r.GetInt32("sifra"), r.GetString("naziv"), r.GetBoolean("trailer"), r.GetInt32("dostupnost"), r.GetDouble("cijena"), r.GetInt32("platforma"), r.GetString("kategorija")));
                    return igrice;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Igrica read(Igrica entity)
            {
                throw new NotImplementedException();
            }

            public Igrica update(Igrica entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Igrica entity)
            {
                throw new NotImplementedException();
            }

            public Igrica getById(int id)
            {
                throw new NotImplementedException();
            }

            public Igrica getByUsername(string username)
            {
                try
                {
                    c = new MySqlCommand("select * from igrice where username = '" + username + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Igrica pom = new Igrica(r.GetInt32("sifra"), r.GetString("naziv"), r.GetBoolean("trailer"), r.GetInt32("dostupnost"), r.GetDouble("cijena"), r.GetInt32("platforma"), r.GetString("kategorija"));
                        return pom;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public List<Igrica> getByExample(string nijebitno1, string nijebitno2)
            {
                throw new NotImplementedException();
            }

            #endregion


        }
    }
}