using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    public class MssqlProductLogic : IProductServices
    {
        //Connectiestring met database
        private const string Connectie =
            "Server=mssql.fhict.local;Database=dbi347556;User Id=dbi347556;Password=Qwerty1";

        public void AddArtikel(Artikel artikel)
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
                                "INSERT INTO Artikel (Naam, Inkoopprijs, Verkoopprijs, btw_percentage) VALUES (@naam, @inkpr, @verkpr, @btw)";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", artikel.Naam);
                            cmd.Parameters.AddWithValue("@inkpr", artikel.Inkoopprijs);
                            cmd.Parameters.AddWithValue("@verkpr", artikel.Verkoopprijs);
                            cmd.Parameters.AddWithValue("@btw", artikel.BtwPercentage);

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

        public void AddIngrediënt(Ingrediënt ingrediënt)
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
                                "INSERT INTO Ingrediënt (Naam, Inkoopprijs, Verkoopprijs) VALUES (@naam, @inkpr, @verkpr)";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", ingrediënt.Naam);
                            cmd.Parameters.AddWithValue("@inkpr", ingrediënt.Inkoopprijs);
                            cmd.Parameters.AddWithValue("@verkpr", ingrediënt.Verkoopprijs);

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

        public void AddPizza(Pizza pizza)
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
                                "INSERT INTO Pizza (Naam, Vorm, Formaat, Standaard) VALUES (@naam, @vorm, @formaat, @standaard)";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", pizza.Naam);
                            cmd.Parameters.AddWithValue("@vorm", pizza.Vorm);
                            cmd.Parameters.AddWithValue("@formaat", pizza.Formaat);
                            cmd.Parameters.AddWithValue("@standaard", pizza.Standaard);

                            cmd.ExecuteNonQuery();
                            foreach (var item in pizza.Ingrediënten)
                            {
                                AddPizzaIngrediënten(pizza.Pizzanr, item.Naam);
                            }
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

        public void AddPizzaIngrediënten(int pizzanr, string ingrediënt)
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
                                "INSERT INTO Pizzaingrediënt (Pizzanr, Ingrediëntnm) VALUES (@pizzanr, @ingrnm)";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@pizzanr", pizzanr);
                            cmd.Parameters.AddWithValue("@ingrnm", ingrediënt);

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

        public void EditArtikel(Artikel artikel)
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
                                "UPDATE Artikel SET Inkoopprijs = @inkpr, Verkoopprijs = @verkpr WHERE Naam = @naam";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", artikel.Naam);
                            cmd.Parameters.AddWithValue("@inkpr", artikel.Inkoopprijs);
                            cmd.Parameters.AddWithValue("@verkpr", artikel.Verkoopprijs);

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

        public void EditIngrediënt(Ingrediënt ingrediënt)
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
                                "UPDATE Ingrediënt SET Inkoopprijs = @inkpr, Verkoopprijs = @verkpr WHERE Naam = @naam";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", ingrediënt.Naam);
                            cmd.Parameters.AddWithValue("@inkpr", ingrediënt.Inkoopprijs);
                            cmd.Parameters.AddWithValue("@verkpr", ingrediënt.Verkoopprijs);

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

        public void EditPizza(Pizza pizza)
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
                                "UPDATE Pizza SET Naam = @naam, Vorm = @vorm, Formaat = @formaat, Standaard = @standaard WHERE Pizzanr = @nr";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", pizza.Naam);
                            cmd.Parameters.AddWithValue("@vorm", pizza.Vorm);
                            cmd.Parameters.AddWithValue("@formaat", pizza.Formaat);
                            cmd.Parameters.AddWithValue("@standaard", pizza.Standaard);
                            cmd.Parameters.AddWithValue("@nr", pizza.Pizzanr);

                            cmd.ExecuteNonQuery();
                            //Verwijdert de ingrediënten van de pizza
                            RemovePizzaIngrediënten(pizza.Pizzanr);
                            //Voegt de ingrediënten opnieuw toe aan de pizza
                            foreach (var item in pizza.Ingrediënten)
                            {
                                AddPizzaIngrediënten(pizza.Pizzanr, item.Naam);
                            }
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

        public List<Artikel> ListArtikelen()
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                List<Artikel> artikelen = new List<Artikel>();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText = "SELECT * FROM Artikel";
                            cmd.Connection = conn;

                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                string naam = reader.GetString(0);
                                decimal inkoopprijs = reader.GetDecimal(1);
                                decimal verkoopprijs = reader.GetDecimal(2);
                                int btwpercentage = reader.GetInt32(3);

                                artikelen.Add(new Artikel(naam, inkoopprijs, verkoopprijs, btwpercentage));
                            }
                            return artikelen;
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

        public List<Ingrediënt> ListIngrediënten()
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                List<Ingrediënt> ingrediënten = new List<Ingrediënt>();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText = "SELECT * FROM Ingrediënt";
                            cmd.Connection = conn;

                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                string naam = reader.GetString(0);
                                decimal inkoopprijs = reader.GetDecimal(1);
                                decimal verkoopprijs = reader.GetDecimal(2);

                                ingrediënten.Add(new Ingrediënt(naam, inkoopprijs, verkoopprijs));
                            }
                            return ingrediënten;
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

        public List<Ingrediënt> GetIngrediënten(int pizzanr)
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                List<Ingrediënt> ingrediënten = new List<Ingrediënt>();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText = "SELECT * FROM ingrediënt i WHERE i.naam IN (SELECT ingrediëntnm FROM Pizzaingrediënt WHERE Pizzanr = @pizzanr)";
                            cmd.Connection = conn;
                            cmd.Parameters.AddWithValue("@pizzanr", pizzanr);

                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                string naam = reader.GetString(0);
                                decimal inkoopprijs = reader.GetDecimal(1);
                                decimal verkoopprijs = reader.GetDecimal(2);

                                ingrediënten.Add(new Ingrediënt(naam, inkoopprijs, verkoopprijs));
                            }
                            return ingrediënten;
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

        public List<Pizza> ListPizzas()
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                List<Pizza> pizzas = new List<Pizza>();

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        try
                        {
                            cmd.CommandText = "SELECT * FROM Pizza";
                            cmd.Connection = conn;

                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                int pizzanr = reader.GetInt32(0);
                                string naam = reader.GetString(1);
                                Vorm vorm = (Vorm) Enum.Parse(typeof(Vorm), reader.GetString(2));
                                string formaat = reader.GetString(3);
                                bool standaard = reader.GetBoolean(4);
                                List<Ingrediënt> ingrediënten = GetIngrediënten(pizzanr);

                                pizzas.Add(new Pizza(pizzanr, naam, vorm, formaat, standaard, ingrediënten));
                            }
                            return pizzas;
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

        public List<Product> ListProducten()
        {
            throw new NotImplementedException();
        }

        public void RemoveArtikel(Artikel artikel)
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
                                "DELETE FROM Artikel WHERE Naam = @naam";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", artikel.Naam);

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

        public void RemoveIngrediënt(Ingrediënt ingrediënt)
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
                                "DELETE FROM Ingrediënt WHERE Naam = @naam";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@naam", ingrediënt.Naam);

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

        public void RemovePizza(Pizza pizza)
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
                                "DELETE FROM Pizza WHERE Pizzanr = @nr";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@nr", pizza.Pizzanr);

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

        public void RemovePizzaIngrediënten(int pizzanr)
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
                                "DELETE FROM Pizzaingrediënt WHERE Pizzanr = @nr";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@nr", pizzanr);

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
