using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class MssqlGebruikerLogic : IGebruikerServices
    {
        //Connectiestring met database
        private const string Connectie =
            "Server=mssql.fhict.local;Database=dbi347556;User Id=dbi347556;Password=Qwerty1";

        public void AddKlant(Klant klant)
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "EXECUTE AddKlant @naam , @adres";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", klant.Naam);
                            cmd.Parameters.AddWithValue("@adres", klant.Adres);

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        public void EditKlant(Klant klant)
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "EXECUTE EditKlant @nr, @naam, @adres";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@nr", klant.Gebruikernr);
                            cmd.Parameters.AddWithValue("@naam", klant.Naam);
                            cmd.Parameters.AddWithValue("@adres", klant.Adres);

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }

        public Klant KlantByNaam(string naam)
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "SELECT * FROM Gebruiker g left join Klant k on g.Gebruikernr = k.Gebruikernr WHERE g.Naam = @naam";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", naam);

                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Read();

                            int nr = reader.GetInt32(0);
                            string nm = reader.GetString(1);
                            string adres = reader.GetString(4);

                            return new Klant(nr, nm, adres);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                return null;
            }
        }

        public List<Klant> ListKlanten()
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                List<Klant> klanten = new List<Klant>();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText = "SELECT * FROM Gebruiker g left join Klant k on g.Gebruikernr = k.Gebruikernr";
                            cmd.Connection = conn;

                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                int nr = reader.GetInt32(0);
                                string naam = reader.GetString(1);
                                string adres = reader.GetString(4);

                                klanten.Add(new Klant(nr, naam, adres));
                            }
                            return klanten;
                        }
                        catch (Exception ex)
                        {
                            throw;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                return null;
            }
        }

        public Manager LoginManager(string naam, string wachtwoord)
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "SELECT * FROM Gebruiker g left join Manager m on g.Gebruikernr = m.Gebruikernr WHERE Naam = @naam AND Wachtwoord = @ww";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@ww", wachtwoord);
                            cmd.Parameters.AddWithValue("@naam", naam);

                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Read();

                            int nr = reader.GetInt32(0);
                            string nm = reader.GetString(1);
                            string ww = reader.GetString(4);

                            return new Manager(nr, nm, ww);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                return null;
            }
        }

        public void RemoveKlant(Klant klant)
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText =
                                "EXECUTE RemoveKlant @nr";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@nr", klant.Gebruikernr);

                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
        }
    }
}
