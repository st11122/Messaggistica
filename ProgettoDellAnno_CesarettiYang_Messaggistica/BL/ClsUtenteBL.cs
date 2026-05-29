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
                string sql = "INSERT INTO utenti (nickname, password, biografia, datadinascita, admin) VALUES (@nickname, SHA2(@password, 256), @biografia, @datadinascita, @admin)";

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

        #region ACCEDI
        internal static ClsUtente Login(ref MySqlConnection conn, string nickname, string password, ref string errore)
        {
            ClsUtente io = null;
            try
            {
                conn.Open();    //apro la connessione

                // Usa DataTable per gestire i risultati
                DataTable dt = new DataTable();

                string query = "SELECT * FROM utenti WHERE nickname = @nickname AND password = SHA2(@password, 256)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nickname", nickname);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        // La connessione si apre/chiude automaticamente
                        adapter.Fill(dt);
                    }
                }

                // Verifica se esiste almeno una riga
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    io = new ClsUtente
                    {
                        ID = Convert.ToUInt32(row["ID"]),
                        Nickname = row["nickname"].ToString(),
                        Password = row["password"].ToString(),
                        Descrizione = row["biografia"].ToString(),
                        DataDiNascita = Convert.ToDateTime(row["datadinascita"]),
                        Admin = Convert.ToBoolean(row["admin"])
                    };
                }
                else
                {
                    errore = "Nickname o password errati";
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

            return _listaUtenti;

        }
        #endregion

        #region PRENDI CONTATTI
        internal static List<ClsUtente> PrendiContatti(ref MySqlConnection conn, out string errore)
        {
            List<ClsUtente> Contatti = new List<ClsUtente>();
            errore = String.Empty;

            try
            {
                conn.Open();
                string query = "SELECT u.ID, a.nickname, u.datadinascita, u.biografia FROM utenti AS u " +
                    "INNER JOIN aggiungere AS a ON u.ID = a.contattoID " + 
                    "WHERE a.utenteID = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", Program.io.ID);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    ClsUtente contatto = new ClsUtente();
                    contatto.ID = Convert.ToInt64(row["ID"]);
                    contatto.Nickname = row["nickname"].ToString();
                    contatto.DataDiNascita = Convert.ToDateTime(row["datadinascita"]);
                    contatto.Descrizione = row["biografia"].ToString();
                    contatto.Password = "";
                    contatto.Admin = false;

                    Contatti.Add(contatto);
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

            return Contatti;
        }
        #endregion


        #region MODIFICA
        internal static void Modifica(ref MySqlConnection conn, ClsUtente io, out string errore)
        {
            errore = String.Empty;

            try
            {
                //apro la connessione
                conn.Open();

                //creo la query
                string query = "UPDATE utenti SET nickname = @nickname, password = SHA2(@password, 256), biografia = @biografia, datadinascita = @datadinascita WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                //modifico i parametri
                cmd.Parameters.AddWithValue("@id", io.ID);
                cmd.Parameters.AddWithValue("@nickname", io.Nickname);
                cmd.Parameters.AddWithValue("@password", io.Password);
                cmd.Parameters.AddWithValue("@biografia", io.Descrizione);
                cmd.Parameters.AddWithValue("@datadinascita", io.DataDiNascita);

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
