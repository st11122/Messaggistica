using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Messaggistica
{
    internal class ClsAggiungereBL
    {
        #region ATTRIBUTI
        private MySqlConnection _conn = null;
        #endregion

        #region COSTRUTTORI
        public ClsAggiungereBL(MySqlConnection cn)
        {
            _conn = cn;
        }
        #endregion

        #region AGGIUNGERE

        internal static void Aggiungere(ref MySqlConnection conn, string nickname, long utenteID, long contattoID, out string errore)
        {
            errore = String.Empty;

            try
            {
                //apro la connessione
                conn.Open();
                //query
                string sql = "INSERT INTO aggiungere (nickname, utenteID, contattoID) VALUES (@nickname, @utenteID, @contattoID)";
                string sql2 = "INSERT INTO aggiungere (nickname, utenteID, contattoID) VALUES (@nickname, @contattoID, @utenteID)";

                //creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //assegno i valori
                cmd.Parameters.AddWithValue("@nickname", nickname);
                cmd.Parameters.AddWithValue("@utenteID", utenteID);
                cmd.Parameters.AddWithValue("@contattoID", contattoID);

                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@nickname", $"Contatto sconosciuto {Program.io.ID}");
                cmd2.Parameters.AddWithValue("@utenteID", utenteID);
                cmd2.Parameters.AddWithValue("@contattoID", contattoID);

                int _righeInserite = cmd.ExecuteNonQuery();
                int _righeInserite2 = cmd2.ExecuteNonQuery();

                if (_righeInserite == 0 && _righeInserite2 == 0)
                    errore = "Nessuna riga inserita";

                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
        }
        #endregion


    }
}
