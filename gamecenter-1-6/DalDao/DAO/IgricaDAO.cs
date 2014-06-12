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

            public void create(Igrica entity)
            {
                try
                {
                    string query = "insert into igrice(naziv, trailer, dostupnost, cijena, kategorija, platforma, slika) values ('" + entity.Naziv + "','" + entity.Trailer + "','" + entity.Dostupnost + "','" + entity.Cijena + "','" + entity.Kategorija + "','" + entity.Platforma + "','" + entity.slika + "');";


                    c = new MySqlCommand(query, con);
                    c.ExecuteNonQuery();

                    
                }
                catch (Exception e)
                {
                    throw e;
                }
                //try
                //{
                //    c = new MySqlCommand("insert into igrice values ('" + entity.Naziv + "','" + entity.Trailer + "','" + entity.Dostupnost + "','" + entity.Cijena + "','" + entity.Kategorija + "','" + entity.Platforma + "')", con);
                //    c.ExecuteNonQuery();
                //    return c.LastInsertedId;
                //}
                //catch (Exception e)
                //{
                //    throw e;
                //}
            }

            public List<Igrica> getAll()
            {
                try
                {
                    c = new MySqlCommand("select * from igrice", con);
                    MySqlDataReader r = c.ExecuteReader();
                    List<Igrica> igrice = new List<Igrica>();
                    while (r.Read())
                        igrice.Add(new Igrica(r.GetInt32("sifra"), r.GetString("naziv"), r.GetBoolean("trailer"), r.GetInt32("dostupnost"), r.GetDouble("cijena"), r.GetInt32("platforma"), r.GetString("kategorija"), r.GetString("slika")));
                    r.Close();
                    return igrice;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }


            public Igrica read(Igrica entity)
            {
                try
                {
                    return getById(entity.Sifra);

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void update(Igrica entity)
            {
                try
                {
                    var updateCommand = new MySqlCommand("UPDATE igrice SET naziv = @ex SET trailer = @ex1 SET dostupnost = @ex2 SET cijena = @ex3 SET kategorija = @ex4  SET platforma = @ex5 SET slika = @ex6 WHERE sifra =  @id");
                    updateCommand.Parameters.Add("@ex", MySqlDbType.Text);
                    updateCommand.Parameters["@ex"].Value = entity.Naziv;
                    updateCommand.Parameters.Add("@ex1", MySqlDbType.Byte);
                    updateCommand.Parameters["@ex1"].Value = entity.Trailer.ToString();
                    updateCommand.Parameters.Add("@ex2", MySqlDbType.Int32);
                    updateCommand.Parameters["@ex2"].Value = entity.Dostupnost.ToString();
                    updateCommand.Parameters.Add("@ex3", MySqlDbType.Double);
                    updateCommand.Parameters["@ex3"].Value = entity.Cijena.ToString();
                    updateCommand.Parameters.Add("@ex4", MySqlDbType.Text);
                    updateCommand.Parameters["@ex4"].Value = entity.Kategorija;
                    updateCommand.Parameters.Add("@ex5", MySqlDbType.Int32);
                    updateCommand.Parameters["@ex5"].Value = entity.Platforma.ToString();
                    updateCommand.Parameters.Add("@ex6", MySqlDbType.Text);
                    updateCommand.Parameters["@ex6"].Value = entity.Naziv;
                    updateCommand.Parameters.Add("@id", MySqlDbType.Int32);
                    updateCommand.Parameters["@id"].Value = entity.Sifra.ToString();

                    string query = "update igrice set naziv = '" + entity.Naziv + "', trailer = '" + entity.Trailer + "', dostupnost = '" + entity.Dostupnost + "',  cijena= '" + entity.Cijena + "', kategorija = '" + entity.Kategorija + "', platforma = '" + entity.Platforma + "'slika = '" + entity.slika + "' where sifra ='" + entity.Sifra + "';";

                    c = updateCommand;

                    c.ExecuteNonQuery();

                    

                    
                    
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public void delete(Igrica entity)
            {
                try
                {
                    c = new MySqlCommand("delete from igrice where sifra ='" + entity.Sifra + "'", con);

                    c.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            public Igrica getById(int id)
            {
                try
                {
                    c = new MySqlCommand("select * from igrice where sifra = '" + id + "'", con);
                    MySqlDataReader r = c.ExecuteReader();
                    if (r.Read())
                    {
                        Igrica pom = new Igrica(r.GetInt32("sifra"), r.GetString("naziv"), r.GetBoolean("trailer"), r.GetInt32("dostupnost"), r.GetDouble("cijena"), r.GetInt32("platforma"), r.GetString("kategorija"), r.GetString("slika"));
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

            public Igrica getByUsername(string username)
            {
                throw new NotImplementedException();
            }
            public List<Igrica> getByExample(string nijebitno1, string nijebitno2)
            {
                throw new NotImplementedException();
            }

            #endregion


        }
    }
}