using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Messaggistica
{
    class ClsBloccareBL
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

        void Bloccare(MySqlConnection conn, ClsBloccare clsBloccare, out string errore)
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
