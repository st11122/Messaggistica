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

        internal static void RecuperoMessaggi(ref MySqlConnection conn, out string errore)
        {
            errore = String.Empty;

            try
            {
                conn.Open();
                string query = "SELECT * FROM messaggi WHERE mittenteID = @id OR destinatarioID = @id ORDER BY data ASC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Program.io.ID);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                

                // Reset della struttura delle chat
                Program.Messaggi = new List<List<ClsMessaggio>>();

                foreach (DataRow row in dt.Rows)
                {
                    ClsMessaggio messaggio = new ClsMessaggio();
                    messaggio.Id = Convert.ToInt64(row["ID"]);
                    messaggio.Testo = row["testo"].ToString();
                    messaggio.Data = Convert.ToDateTime(row["data"]);
                    messaggio.EliminatoDaMittente = Convert.ToBoolean(row["eliminato_mittente"]);
                    messaggio.EliminatoDaDestinatario = Convert.ToBoolean(row["eliminato_destinatario"]);
                    messaggio.MittenteID = Convert.ToInt64(row["mittenteID"]);
                    messaggio.DestinatarioID = Convert.ToInt64(row["destinatarioID"]);

                    if (row["gruppoID"] == DBNull.Value)
                        messaggio.GruppoID = -1;
                    else
                        messaggio.GruppoID = Convert.ToInt64(row["gruppoID"]);

                    //controllo che il messaggio non sia stato eliminato per me
                    if ((messaggio.MittenteID == Program.io.ID && messaggio.EliminatoDaMittente) ||
                    (messaggio.DestinatarioID == Program.io.ID && messaggio.EliminatoDaDestinatario))
                    {
                        continue; // Salta il messaggio corrente e passa al prossimo record
                    }

                    // Determino con chi sto chattando
                    long altroUtenteID = (messaggio.MittenteID == Program.io.ID) ? messaggio.DestinatarioID : messaggio.MittenteID;

                    // Cerco se esiste già una chat con questo utente
                    bool chatEsistente = false;
                    for (int i = 0; i < Program.Messaggi.Count; i++)
                    {
                        if (Program.Messaggi[i].Count > 0)
                        {
                            ClsMessaggio primoMsg = Program.Messaggi[i][0];
                            long idAltro = (primoMsg.MittenteID == Program.io.ID) ? primoMsg.DestinatarioID : primoMsg.MittenteID;

                            if (idAltro == altroUtenteID)
                            {
                                // Chat trovata, aggiungo il messaggio
                                Program.Messaggi[i].Add(messaggio);
                                chatEsistente = true;
                                break;
                            }
                        }
                    }

                    if (!chatEsistente)
                    {
                        // Creo nuova chat
                        List<ClsMessaggio> nuovaChat = new List<ClsMessaggio>();
                        nuovaChat.Add(messaggio);
                        Program.Messaggi.Add(nuovaChat);
                    }
                }
                //chiudo la connessione
                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
        }


        #endregion

        #region ELIMINA PER TUTTI
        internal static void AllDelete(ref MySqlConnection conn, long messaggioID, out string errore)
        {
            errore = String.Empty;
            try
            {
                //apro la connessione
                conn.Open();

                //creo la query
                string sql = "DELETE FROM messaggi WHERE ID = @id";

                //creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", messaggioID);
                //eseguo il comando
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
        }
        #endregion

        #region ELIMINA PER ME
        internal static void Delete(ref MySqlConnection conn, long messaggioID, out string errore)
        {
            errore = String.Empty;
            try
            {
                //apro la connessione
                conn.Open();

                string sql = "SELECT mittenteID FROM messaggi WHERE ID = @messaggioid";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@messaggioid", messaggioID);
                //eseguo il comando
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value) //controllo che ho preso il valore
                {
                    long mittenteID = Convert.ToInt64(result);
                    string sqlUpdate = "";

                    if (mittenteID == Program.io.ID)
                    {
                        // Sono il mittente
                        sqlUpdate = "UPDATE messaggi SET eliminato_mittente = 1 WHERE ID = @messaggioID";
                    }
                    else
                    {
                        // Sono il destinatario
                        sqlUpdate = "UPDATE messaggi SET eliminato_destinatario = 1 WHERE ID = @messaggioID";
                    }
                    MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@messaggioID", messaggioID);
                    cmdUpdate.ExecuteNonQuery();

                    //controllo se il messaggio è stato cancellato da entrambi gli utenti
                    string sqlControlloEliminati = "SELECT eliminato_mittente, eliminato_destinatario FROM messaggi WHERE ID = @id";
                    MySqlCommand cmdControllo = new MySqlCommand(sqlControlloEliminati, conn);
                    cmdControllo.Parameters.AddWithValue("@id", messaggioID);

                    bool cancellaDefinitivo = false;

                    // Dichiarazione ed esecuzione del Reader senza using
                    MySqlDataReader dr = cmdControllo.ExecuteReader();

                    if (dr.Read())
                    {
                        bool elimMittente = Convert.ToBoolean(dr["eliminato_mittente"]);
                        bool elimDestinatario = Convert.ToBoolean(dr["eliminato_destinatario"]);

                        // Se entrambi lo hanno eliminato
                        if (elimMittente && elimDestinatario)
                        {
                            cancellaDefinitivo = true; //dico che va cancellato
                        }
                    }
                    dr.Close();

                    // Se entrambi lo hanno eliminato il messaggio
                    if (cancellaDefinitivo)
                    {
                        //creo la query
                        string sqlDelete = "DELETE FROM messaggi WHERE ID = @id";

                        //creo l'oggetto command
                        MySqlCommand cmdDelete = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", messaggioID);
                        //eseguo il comando
                        cmd.ExecuteNonQuery();
                    }




                }
                else
                    errore = "Messaggio non trovato";

                conn.Close();
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
