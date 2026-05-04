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
                string sql = "INSERT INTO utenti (nickname, password, biografia, datadinascita, admin) VALUES (@nickname, @password, @biografia, @datadinascita, @admin)";

                //creo l'oggetto command

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                //assegno i valori
                cmd.Parameters.AddWithValue("@nickname", utente.Nickname);
                cmd.Parameters.AddWithValue("@password", utente.Password);
                cmd.Parameters.AddWithValue("@biografia", utente.Descrizione);
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

        #region ACCEDI
        internal static ClsUtente Login(ref MySqlConnection conn, string nickname, string password, ref string errore)
        {
            //creo l'utente per i dati
            ClsUtente io = null;

            try
            {
                //apro la connessione
                conn.Open();

                //query
                string query = "SELECT * FROM utenti WHERE nickname = @nickname AND password = @password";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nickname", nickname);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    io = new ClsUtente();
                    io.ID = dr.GetUInt32("ID");
                    io.Nickname = dr.GetString("nickname");
                    io.Password = dr.GetString("password");
                    io.Descrizione = dr.GetString("biografia");
                    io.DataDiNascita = dr.GetDateTime("datadinascita");
                    io.Admin = dr.GetBoolean("admin");
                }
                else
                    errore = "Nickname o password errati";

                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }

            return io;
        }
        #endregion

        #region PRENDI CONTATTI DAL NICKNAME
        internal static List<ClsUtente> prendiNickname(ref MySqlConnection conn, string nickname, ref string errore)
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
                            (bool)dt.Rows[i]["admin"]);
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

        #region PRENDI CONTATTI
        internal static void getAllIDContact(ref MySqlConnection conn, long id, out string errore)
        {
            List<long> contattiID = new List<long>();
            errore = String.Empty;
            try
            {
                // Query
                string query = "SELECT contattoID FROM aggiungere WHERE utenteID = @id";

                // Creo il comando
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Aggiungo il parametro PRIMA di eseguire
                cmd.Parameters.AddWithValue("@id", id);

                // Uso DataAdapter + DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                // Apro la connessione e riempio il DataTable
                conn.Open();
                da.Fill(dt);

                // Leggo le righe del DataTable
                foreach (DataRow row in dt.Rows)
                {
                    contattiID.Add(Convert.ToInt64(row["contattoID"]));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }
        }
        #endregion

        #region GET ALL CONTACT
        internal static List<ClsUtente> getAllContact(ref MySqlConnection conn, long id, out string errore)
        {
            List<ClsUtente> contatti = new List<ClsUtente>();
            errore = String.Empty;
            try
            {
                conn.Open();

                if (Program.contattiID.Count > 0)
                {
                    foreach (long contattoId in Program.contattiID)
                    {
                        string query = "SELECT * FROM utenti WHERE ID = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@id", contattoId);
                        MySqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            ClsUtente utente = new ClsUtente();
                            utente.ID = dr.GetInt32("ID");
                            utente.Nickname = dr.GetString("nickname");
                            utente.Password = dr.GetString("password");
                            utente.Descrizione = dr.GetString("biografia");
                            utente.DataDiNascita = dr.GetDateTime("datadinascita");
                            utente.Admin = dr.GetBoolean("admin");

                            contatti.Add(utente);
                        }

                        dr.Close();
                        cmd.Dispose();

                    }

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                errore = ex.Message;
            }

            return contatti;
        }

        #endregion

        #region MODIFICA
        internal static void Modifica(MySqlConnection conn, ClsUtente io, out string errore)
        {
            errore = String.Empty;

            try
            {
                //apro la connessione
                conn.Open();

                //creo la query
                string query = "UPDATE utenti SET nickname = @nickname, password = @password, biografia = @biografia, datadinascita = @datadinascita WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                //modifico i parametri
                MySqlParameter[] parametri = {
                    cmd.Parameters.AddWithValue("@id", io.ID),
                    cmd.Parameters.AddWithValue("@nickname", io.Nickname),
                    cmd.Parameters.AddWithValue("@password", io.Password),
                    cmd.Parameters.AddWithValue("@biografia", io.Descrizione),
                    cmd.Parameters.AddWithValue("@datadinascita", io.DataDiNascita)
                };

                //eseguo la query
                int _righeModificate = cmd.ExecuteNonQuery();

                //controllo se le modifiche sono state apportate
                if (_righeModificate < 1)
                    errore = "Modifica non apportata";
                else
                    Program.io = io;    //modifico il mio utente
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
