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
                    c = new MySqlCommand("insert into platforme values ('" + entity.ID + "','" + entity.Naziv + "')", con);
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
                    c = new MySqlCommand("select * from platforme", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Platform> Platformi = new List<Platform>();
                    while (r.Read())
                        Platformi.Add(new Platform(r.GetInt32("id"), r.GetString("naziv")));
                    r.Close();
                    return Platformi;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Platform read(Platform entity)
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

            public Platform update(Platform entity)
            {
                try
                {
                    c = new MySqlCommand("select * from platforme where id = '" + entity.ID + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Platform pom = new Platform(r.GetInt32("id"), r.GetString("naziv"));
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

            public void delete(Platform entity)
            {
                try
                {
                    c = new MySqlCommand("delete from igrice where id ='" + entity.ID + "'", con);

                    c.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Platform getById(int id)
            {
                try
                {
                    c = new MySqlCommand("select * from platforme where id = '" + id + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Platform pom = new Platform(r.GetInt32("id"), r.GetString("naziv"));
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

            public Platform getByUsername(string username)
            {
                
                throw new NotImplementedException();
            }
            public List<Platform> getByExample(string nijebitno1, string nijebitno2)
            {
                throw new NotImplementedException();
            }

            #endregion


        }
    }
}