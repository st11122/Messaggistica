using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Messaggistica.BL
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
                string sql = "INSERT INTO messaggi (nome, descrizione) VALUES (@nome, @descrizione)";

                //creo l'oggetto command

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //assegno i valori
                cmd.Parameters.AddWithValue("@nome", gruppo.Nome);
                cmd.Parameters.AddWithValue("@descrizione", gruppo.Descrizione);

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
