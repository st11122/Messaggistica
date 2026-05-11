using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Messaggistica.BL
{
    class ClsMessaggioBL
    {
        #region ATTRIBUTI
        private MySqlConnection _conn = null;
        #endregion

        #region COSTRUTTORI
        public ClsMessaggioBL(MySqlConnection cn)
        {
            _conn = cn;
        }
        #endregion
        #region METODI
        #region CREARE
        internal static long Create(ref MySqlConnection conn, ClsMessaggio messaggio, out string errore)
        {
            long ID = 0;
            errore = String.Empty;

            try
            {
                //apro la connessione
                conn.Open();

                //creo la query
                string sql = "INSERT INTO messaggi (testo, data, mittenteID, destintarioID ) VALUES (@testo, @data, @mittenteID, @destintarioID)";

                //creo l'oggetto command

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //assegno i valori
                cmd.Parameters.AddWithValue("@testo", messaggio.Testo);
                cmd.Parameters.AddWithValue("@data", messaggio.Data);
                cmd.Parameters.AddWithValue("@mittenteID", messaggio.MittenteID);
                cmd.Parameters.AddWithValue("@destintarioID", messaggio.DestintarioID);

                //eseguo il comando
                int numRec = cmd.ExecuteNonQuery();
                if (numRec == 1)
                    ID = cmd.LastInsertedId; //ottengo l'id automaticamente

                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }

            return ID;
        }
        #endregion

        #endregion
    }
}
