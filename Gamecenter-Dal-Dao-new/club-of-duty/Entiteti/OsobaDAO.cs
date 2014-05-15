using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    partial class DAL
    {
        public class OsobaDAO : IDAOCrud<Osoba>
        {
            #region IDAOCrud<Osoba> Members
            protected MySqlCommand c;

               public List<Osoba> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from osoba", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Osoba> osobe = new List<Osoba>();
                    while (r.Read())
                        osobe.Add(new Osoba(r.GetString("ime"), r.GetString("prezime")));
                     return osobe;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public long create(Osoba entity)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("insert into osobe (ime, prezime, id, jmbg, kontakt, adresa, email)" +
                        "values ( @Ime, @Prezime, @ID, @JMBG, @Kontakt, @Adresa, @Email)", con);

                 
                    c.Parameters.Add("@Ime", MySqlDbType.VarChar).Value = entity.Ime;
                    c.Parameters.Add("@Prezime", MySqlDbType.VarChar).Value = entity.Prezime;
                    c.Parameters.Add("@ID", MySqlDbType.VarChar).Value = entity.ID;
                    c.Parameters.Add("@JMBG", MySqlDbType.VarChar).Value = entity.JMBG;
                    c.Parameters.Add("@Kontakt", MySqlDbType.VarChar).Value = entity.Kontakt;
                    c.Parameters.Add("@Adresa", MySqlDbType.VarChar).Value = entity.Adresa;
                    c.Parameters.Add("@Email", MySqlDbType.VarChar).Value = entity.Email;
                   
                    c.ExecuteNonQuery();
                    return c.LastInsertedId;
                }
                catch (Exception e)
                {
                    throw e;
                }
       
            public Osoba read(Osoba entity)
            {
                throw new NotImplementedException();
            }

            public Osoba update(Osoba entity)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("update osobe set ime = " + entity.Ime + ", prezime = " + entity.Prezime + " where id=" + entity.IdOsoba, con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public void delete(Osoba entity)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("delete from osobe where idOsobe = " + entity.Id, con);
                    c.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public Osoba getById(int id)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("select * from osobe where id = " + id, con);
                    MySqlDataReader r = c.ExecuteReader();
                    r.Read();
                    Osoba o = new Osoba(r.GetString("ime"), r.GetString("prezime"));
                    return o;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public List<Osoba> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}