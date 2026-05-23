using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace Messaggistica
{
    internal class ClsMessaggioBL
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
                string sql = "INSERT INTO messaggi (testo, data, mittenteID, destinatarioID ) VALUES (@testo, @data, @mittenteID, @destinatarioID)";

                //creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //assegno i valori
                cmd.Parameters.AddWithValue("@testo", messaggio.Testo);
                cmd.Parameters.AddWithValue("@data", messaggio.Data);
                cmd.Parameters.AddWithValue("@mittenteID", messaggio.MittenteID);
                cmd.Parameters.AddWithValue("@destinatarioID", messaggio.DestinatarioID);
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

        #region RECUPERO MESSAGGI

        internal static void RecuperoMessaggi (ref MySqlConnection conn,  out string errore)
        {
            Program.Messaggi = new List<List<ClsMessaggio>>();
            errore = String.Empty;

            try
            {
                conn.Open();
                string query = "SELECT testo, data, eliminato_mittente, eliminato_destinatario, mittenteID, destinatarioID, gruppoID FROM messaggi WHERE mittenteID = @id || destinatarioID = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", Program.io.ID);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ClsMessaggio messaggio = new ClsMessaggio();
                    messaggio.Testo = row["testo"].ToString();
                    messaggio.Data = Convert.ToDateTime(row["data"]);
                    messaggio.EliminatoDaMittente = Convert.ToBoolean(row["eliminato_mittente"]);
                    messaggio.EliminatoDaDestinatario = Convert.ToBoolean(row["eliminato_destinatario"]);
                    messaggio.MittenteID = Convert.ToInt64(row["mittenteID"]);
                    messaggio.DestinatarioID = Convert.ToInt64(row["destinatarioID"]);
                    if (row["gruppoID"] == DBNull.Value)
                        messaggio.GruppoID = -1; //se gruppo è null
                    else
                        messaggio.GruppoID = Convert.ToInt64(row["gruppoID"]);


                    //prendo l'id dell'altro utente
                    long messaggioID = 0;
                    if (messaggio.MittenteID == Program.io.ID)  
                        messaggioID = messaggio.DestinatarioID;
                    else
                        messaggioID = messaggio.MittenteID;

                    int _chatIndex = Program.Messaggi.FindIndex(i => i.Any(m => m.DestinatarioID == messaggioID || m.MittenteID == messaggioID));   //trovo la chat a cui si riferisce il messaggio
                    if (_chatIndex == -1)   //se non esiste la creo e aggiungo il messaggio
                    {
                        Program.Messaggi.Add(new List<ClsMessaggio>());
                        Program.Messaggi[Program.Messaggi.Count - 1].Add(messaggio);
                    }
                    else
                    {
                        Program.Messaggi[_chatIndex].Add(messaggio);
                    }
                }

                conn.Close();

                foreach (List<ClsMessaggio> m in Program.Messaggi)
                    m.Sort((a, b) => a.Data.CompareTo(b.Data)); //ordino tutti i messaggi per data decrescente
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
        }


        #endregion

        #endregion
    }
}
