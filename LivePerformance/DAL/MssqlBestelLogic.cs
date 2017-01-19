using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivePerformance
{
    class MssqlBestelLogic : IBestelServices
    {
        //Connectiestring met database
        private const string Connectie =
            "Server=mssql.fhict.local;Database=dbi347556;User Id=dbi347556;Password=Qwerty1";

        public void AddBestelling(int klantnr, int pizzanr, string artikelnm)
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
                            cmd.CommandText = "EXECUTE AddBestelling @klantnr, @pizzanr, @artikelnm";
                            cmd.Connection = conn;

                            cmd.Parameters.AddWithValue("@klantnr", klantnr);
                            cmd.Parameters.AddWithValue("@pizzanr", pizzanr);
                            cmd.Parameters.AddWithValue("@artikelnm", artikelnm);

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

        public List<Bestelling> ListBestellingen()
        {
            using (SqlConnection conn = new SqlConnection(Connectie))
            {
                List<Bestelling> bestellingen = new List<Bestelling>();

                //if (conn.State != ConnectionState.Open)
                //{
                //    conn.Open();
                //    using (SqlCommand cmd = new SqlCommand())
                //    {
                //        try
                //        {
                //            cmd.CommandText = "SELECT * FROM Bestelling";
                //            cmd.Connection = conn;

                //            SqlDataReader reader = cmd.ExecuteReader();
                //            while (reader.Read())
                //            {
                //                string naam = reader.GetString(0);
                //                int inkoopprijs = reader.GetInt32(1);
                //                int verkoopprijs = reader.GetInt32(2);
                //                int btwpercentage = reader.GetInt32(3);

                //                bestellingen.Add(new Bestelling(naam, inkoopprijs, verkoopprijs, btwpercentage));
                //            }
                //            return artikelen;
                //        }
                //        catch (Exception ex)
                //        {
                //            throw;
                //        }
                //        finally
                //        {
                //            conn.Close();
                //        }
                //    }
                //}
                return null;
            }
        }
    }
}
