using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MySql.Data.MySqlClient;
using System.Data;
using gameCenter;

namespace DAL
{
    partial class DAL
    {
        public class UposlenikDAO : IDAOCrud<Uposlenik>
        {
            #region IDAOCrud<Osoba> Members
            protected MySqlCommand c;

               public List<Uposlenik> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from uposlenik", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Uposlenik> osobe = new List<Uposlenik>();
                    while (r.Read())
                        uposlenici.Add(new Uposlenik(r.GetString("ime"), r.GetString("prezime")));
                     return uposlenici;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public long create(Uposlenik entity)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("insert into uposlenici (ime, prezime, id, jmbg, kontakt, adresa, email)" +
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
       
            public Uposlenik read(Uposlenik entity)
            {
                throw new NotImplementedException();
            }

            public Uposlenik update(Uposlenik entity)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("update uposlenici set ime = " + entity.Ime + ", prezime = " + entity.Prezime + " where id=" + entity.IdOsoba, con);
                    c.ExecuteNonQuery();
                    return entity;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public void delete(Uposlenik entity)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("delete from uposlenici where idOsobe = " + entity.Id, con);
                    c.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public Uposlenik getById(int id)
            {
                try
                {
                    MySqlCommand c = new MySqlCommand("select * from uposlenici where id = " + id, con);
                    MySqlDataReader r = c.ExecuteReader();
                    r.Read();
                    Uposlenik o = new Uposlenik(r.GetString("ime"), r.GetString("prezime"));
                    return o;
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public List<Uposlenik> getByExample(string name, string value)
            {
                throw new NotImplementedException();
            }

            #endregion
        }
    }
}

