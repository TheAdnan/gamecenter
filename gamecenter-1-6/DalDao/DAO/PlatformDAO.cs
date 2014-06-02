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
        public class PlatformDAO : IDaoCrud<Platform>
        {
            #region IDaoCrud<Platform> Members
            protected MySqlCommand c;

            public long create(Platform entity)
            {
                try
                {
                    c = new MySqlCommand("insert into platforme values ('" + entity.Naziv + "')", con);
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public List<Platform> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from Platformi", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Platform> Platformi = new List<Platform>();
                    while (r.Read())
                        Platformi.Add(new Platform(r.GetString("naziv")));
                    return Platformi;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Platform read(Platform entity)
            {
                throw new NotImplementedException();
            }

            public Platform update(Platform entity)
            {
                throw new NotImplementedException();
            }

            public void delete(Platform entity)
            {
                throw new NotImplementedException();
            }

            public Platform getById(int id)
            {
                throw new NotImplementedException();
            }

            public Platform getByUsername(string username)
            {
                try
                {
                    c = new MySqlCommand("select * from Platformi where username = '" + username + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Platform pom = new Platform(r.GetString("naziv"));
                        return pom;
                    }
                    return null;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            public List<Platform> getByExample(string nijebitno1, string nijebitno2)
            {
                throw new NotImplementedException();
            }

            #endregion


        }
    }
}