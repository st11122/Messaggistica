using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Messaggistica
{
    class ClsGruppoBL
    {
        #region ATTRIBUTI
        private MySqlConnection _conn = null;
        #endregion

        #region COSTRUTTORI
        public ClsGruppoBL(MySqlConnection cn)
        {
            _conn = cn;
        }
        #endregion

        #region METODI
        #region CREARE
        internal static long Create(ref MySqlConnection conn, ClsGruppo gruppo, out string errore)
        {
            long ID = 0;
            errore = String.Empty;

            try
            {
                //apro la connessione
                conn.Open();

                //creo la query
                string sql = "INSERT INTO gruppi (nome, descrizione) VALUES (@nome, @descrizione)";

                //creo l'oggetto command

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //assegno i valori
                cmd.Parameters.AddWithValue("@nome", gruppo.Nome);
                cmd.Parameters.AddWithValue("@descrizione", gruppo.Descrizione);

                //eseguo il comando
                int numRec = cmd.ExecuteNonQuery();
                if (numRec == 1)
                    ID = cmd.LastInsertedId; //ottengo l'id automaticamente
                
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

            return ID;
        }
        #endregion

        #region  AGGIUNGI
        internal static void Unire (ref MySqlConnection conn, List<long> utentiId, long gruppoId, out string errore)
        {
            errore = string.Empty;

            try
            {
                //apro la connessione
                conn.Open();

                foreach(long utenteId in utentiId)
                {
                    //creo la query
                    string sql = "INSERT INTO unire (data_ingresso, utenteid, gruppoid) VALUES (@data, @utenteid, @gruppoid)";

                    //creo l'oggetto command
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    //assegno i valori
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);
                    cmd.Parameters.AddWithValue("@utenteid", utenteId);
                    cmd.Parameters.AddWithValue("@gruppoid", gruppoId);

                    //eseguo il comando
                    cmd.ExecuteNonQuery();
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
        #endregion
    }
}
