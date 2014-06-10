﻿using System;
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
                    c = new MySqlCommand("insert into klijenti values ('" + entity.Prezime + "','" + entity.Ime + "','" + entity.JMBG + "','" + entity.Kontakt + "','" + entity.Adresa + "','" + entity.E_Mail + "','" + entity.Username + "','" + entity.Password +  "','" + entity.TipRegistracije + "')", con);
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
                        klijenti.Add(new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetInt16("tipregistracije")));
                    return klijenti;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Klijent read(Klijent entity)
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

            public Klijent update(Klijent entity)
            {
                try
                {
                    c = new MySqlCommand("update klijenti set ime = '" + entity.Ime + "', prezime = '" + entity.Prezime + "', kontakt = '" + entity.Kontakt + "', adresa= '" + entity.Adresa + "', email = '" + entity.E_Mail + "', password = '"+ entity.Password + "' , tipregistracije = '" + entity.TipRegistracije + "' where id ='" + entity.ID + "'", con);

                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Klijent pom = new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetInt16("tipregistracije"));
                        delete(entity);
                        return pom;
                    }
                    delete(entity);
                    return null;

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Klijent entity)
            {
                try
                {
                    c = new MySqlCommand("delete from klijenti where id ='" + entity.ID + "'", con);

                    c.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Klijent getById(int id)
            {
                try
                {
                    c = new MySqlCommand("select * from klijenti where id = '" + id + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Klijent pom = new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetInt16("tipregistracije"));
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

            public Klijent getByUsername(string username)
            {
                try
                {
                    c = new MySqlCommand("select * from klijenti where username = '" + username + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Klijent pom = new Klijent(r.GetInt32("id"), r.GetString("ime"), r.GetString("prezime"), r.GetString("jmbg"), r.GetString("kontakt"), r.GetString("adresa"), r.GetString("email"), r.GetString("username"), r.GetString("password"), r.GetInt16("tipregistracije"));
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
            public List<Klijent> getByExample(string nijebitno1, string nijebitno2)
            {
                throw new NotImplementedException();
            }

            #endregion


        }
    }
}