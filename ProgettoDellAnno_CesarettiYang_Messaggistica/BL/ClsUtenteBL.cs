using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace Messaggistica
{
    internal class ClsUtenteBL
    {        
        #region ATTRIBUTI
        private MySqlConnection _conn = null;
        #endregion

        #region COSTRUTTORI
        public ClsUtenteBL(MySqlConnection cn)
        {
            _conn = cn;
        }
        #endregion

        #region METODI

        #region PRENDO UTENTI
        public List<ClsUtente> getUtenti(ref string errore)
        {
            DataTable dt = null;
            List<ClsUtente> listUtenti = null;

            try
            {
                //Apertura connessione
                _conn.Open();

                string query = "select * from utenti"; //query veloce!

                //Creo l'oggetto dataadapter (a titolo di esempio, potevo usare altri oggetti [connessi e sconnessi])
                MySqlDataAdapter da = new MySqlDataAdapter(query, _conn);

                //Allineo il DA con i risultati della query
                dt = new DataTable();
                da.Fill(dt);

                listUtenti = new List<ClsUtente>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //ClsUtente ag = new ClsUtente((int)(dt.Rows[i]["ID"]), dt.Rows[i]["Descrizione"].ToString(), dt.Rows[i]["Nickname"].ToString(), (DateTime)(dt.Rows[i]["DataDiNascita"]), Convert.ToByte(dt.Rows[i]["Admin"]));
                    //listUtenti.Add(ag);
                }

                //Chiusura connessione (posso gestirla nella finally o anticiparla visto che lavoro con il DataTable)
                _conn.Close();

            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
            return listUtenti;
        }
        #endregion

        #region CREARE
        internal static long Create(ref MySqlConnection conn, ClsUtente utente, out string errore)
        {
            long ID = 0;
            errore = String.Empty;

            try
            {
                //apro la connessione
                conn.Open();

                //creo la query
                string sql = "INSERT INTO utenti (nickname, password, datadinascita, descrizione, admin) VALUES (@descrizone, @nickname, @datadinascita, @admin)";

                //creo l'oggetto command

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //assegno i valori
                cmd.Parameters.AddWithValue("@descrizione", utente.Descrizione);
                cmd.Parameters.AddWithValue("@nickname", utente.Nickname);
                cmd.Parameters.AddWithValue("@datadinascita", utente.DataDiNascita);
                cmd.Parameters.AddWithValue("@admin", utente.Admin);

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

        #region PRENDI CONTATTI DAL NICKNAME
        public List<ClsUtente> prendiNickname(ref MySqlConnection conn, string nickname, ref string errore)
        {
            DataTable dt = new DataTable();
            List<ClsUtente> _listaUtenti = null;

            try
            {
                //apro la connessione
                conn.Open();
                //Query
                string query = "SELECT * FROM aggiungere WHERE nickname=@nickname";

                //Costruisco la lista dei parametri
                MySqlParameter[] parametri = { new MySqlParameter("@nickname", nickname) };
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //Creo il comando
                cmd.Parameters.AddRange(parametri);

                //creo il dataAdapter
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                //Creo la lista con gli utenti
                if (string.IsNullOrEmpty(errore))
                {
                    _listaUtenti = new List<ClsUtente>();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ClsUtente _utente = new ClsUtente(
                            (int)dt.Rows[i]["ID"],
                            dt.Rows[i]["descrizione"].ToString(),
                            dt.Rows[i]["nickname"].ToString(),
                            dt.Rows[i]["password"].ToString(),
                            (DateTime)dt.Rows[i]["datadinascita"],
                            (byte)dt.Rows[i]["admin"]);
                        _listaUtenti.Add(_utente);
                    }
                }

                //chiudo la connessione
                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }

            return _listaUtenti;

        } 
        #endregion

        #region AGGIUNGERE

        void Aggiungere(ref MySqlConnection conn, string nickname, long utenteID, long contattoID , out string errore)
        {
            errore = String.Empty;

            try
            {
                //apro la connessione
                conn.Open();
                //query
                string sql = "INSERT INTO aggiungere (nickname, utenteID, contattoID) VALUES (@nickname, @utenteID, @contattoID)";

                //creo l'oggetto command
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //assegno i valori
                cmd.Parameters.AddWithValue("@nickname", nickname);
                cmd.Parameters.AddWithValue("@utenteID", utenteID);
                cmd.Parameters.AddWithValue("@contattoID", contattoID);

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

        #endregion
    }
}
