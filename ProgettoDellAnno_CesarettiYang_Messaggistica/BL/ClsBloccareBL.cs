using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;

namespace Messaggistica
{
    internal class ClsBloccareBL
    {
        #region ATTRIBUTI
        private MySqlConnection _conn = null;
        #endregion

        #region COSTRUTTORI
        public ClsBloccareBL(MySqlConnection cn)
        {
            _conn = cn;
        }
        #endregion

        #region METODI

        #region BLOCCARE
        internal static void Bloccare(ref MySqlConnection conn, ClsBloccare clsBloccare, out string errore)
        {
            errore = String.Empty;

            try
            {
                //apro la connessione
                conn.Open();

                //creo la query
                string sql = "INSERT INTO bloccare (bloccato, bloccatoda) VALUES (@bloccato, @bloccatoda)";

                //creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@bloccato", clsBloccare.Bloccato);
                cmd.Parameters.AddWithValue("@bloccatoda", clsBloccare.BloccatoDa);

                int _righeInserite = cmd.ExecuteNonQuery();

                if (_righeInserite == 0)
                    errore = "Nessuna riga inserita";

                
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            finally
            {
                //chiudo la connessione
                conn.Close();
            }
        }
        #endregion

        #region GetBlocked

        internal static void GetBlocked(ref MySqlConnection conn, out string errore)
        {
            errore = String.Empty;

            try
            {
                conn.Open();
                string query = "SELECT * FROM bloccare WHERE bloccato = @id OR bloccatoda = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Program.io.ID);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);



                // Reset della lista bloccati
                Program.bloccati = new List<ClsBloccare>();

                foreach (DataRow row in dt.Rows)
                {
                    ClsBloccare bloccare = new ClsBloccare();
                    bloccare.Bloccato = Convert.ToInt64(row["bloccato"]);
                    bloccare.BloccatoDa = Convert.ToInt64(row["bloccatoda"]);

                    Program.bloccati.Add(bloccare); //aggiungo l'utente bloccato
                }

                
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            finally
            {
                //chiudo la connessione
                conn.Close();
            }
        }

        #endregion

        #region SBLOCCA
        internal static void Sblocca(ref MySqlConnection conn, long utenteID, out string errore)
        {
            errore = String.Empty;
            try
            {
                //apro la connessione
                conn.Open();

                //creo la query
                string sql = "DELETE FROM bloccare WHERE bloccato = @id";

                //creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", utenteID);
                //eseguo il comando
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            finally
            {
                //chiudo la connessione
                conn.Close();
            }
        }
        #endregion


        #endregion
    }
}
