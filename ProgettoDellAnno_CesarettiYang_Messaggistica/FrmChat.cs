using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaggistica
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (!ControllaSeSonoBloccato(Program.utente.ID))
            {
                if (!ControllaSeBloccato(Program.utente.ID))
                {
                    // Cerco l'indice della chat
                    int chatIndex = TrovaIndiceChat(Program.utente.ID);

                    if (chatIndex == -1)
                    {
                        // Nuova chat
                        Program.Messaggi.Add(new List<ClsMessaggio>());
                        chatIndex = Program.Messaggi.Count - 1;
                    }

                    ClsMessaggio messaggio = new ClsMessaggio();
                    messaggio.Data = DateTime.Now;
                    messaggio.Testo = rtbMessaggio.Text;
                    messaggio.DestinatarioID = Program.utente.ID;
                    messaggio.MittenteID = Program.io.ID;

                    MySqlConnection conn = new MySqlConnection(Program.connectionString);
                    string errore = "";
                    ClsMessaggioBL.Create(ref conn, messaggio, out errore);

                    if (string.IsNullOrWhiteSpace(errore))
                    {
                        Program.Messaggi[chatIndex].Add(messaggio);

                        // Aggiorna Program.chat all'indice corrente
                        Program.chat = chatIndex;

                        PopolaListViewChat();
                        rtbMessaggio.Text = "";
                    }
                    else
                    {
                        MessageBox.Show($"Messaggio non inviato\n{errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Hai bloccato questo contatto", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Questo utente ti ha bloccato", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

    
        private void btnAggiungiContatto_Click(object sender, EventArgs e)
        {
            FrmAggiungi frmAggiungi = new FrmAggiungi();
            frmAggiungi.ShowDialog();

            MySqlConnection conn = new MySqlConnection(Program.connectionString);

            //prendo i contatti e li metto nel program
            string errore = "";
            Program.Contatti = ClsUtenteBL.PrendiContatti(ref conn, out errore);
            PopolaListViewContatti();   //popolo la listView
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //stampo il proprio nome utente sulla form main
            lblNickname.Text = Program.io.Nickname;


            MySqlConnection conn = new MySqlConnection(Program.connectionString);

            //prendo i contatti e li metto nel program
            string errore = "";
            Program.Contatti = ClsUtenteBL.PrendiContatti(ref conn, out errore);
            if (string.IsNullOrWhiteSpace(errore))
            {
                PopolaListViewContatti();
                ClsMessaggioBL.RecuperoMessaggi(ref conn, out errore);
                if (!string.IsNullOrWhiteSpace(errore))
                    MessageBox.Show($"Errore nel caricamento dei messaggi\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show($"Errore nel caricamento dei contatti\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //avvio il timer per il polling
            tmMessaggi.Interval = 5000; // 5 secondi
            tmMessaggi.Enabled = true;
            tmMessaggi.Start();

        }


        #region POPOLA LIST VIEW
        private void PopolaListViewContatti()
        {
            // imposto -1 come valore di default
            long idSelezionato = -1;

            if (lvElencoChat.SelectedItems.Count > 0)
            {
                idSelezionato = Convert.ToInt64(lvElencoChat.SelectedItems[0].Tag);
            }

            lvElencoChat.SelectedIndexChanged -= lvElencoChat_SelectedIndexChanged; //disattivo la selezione dell'utente per evitare errori durante il caricamento dei messaggi
            lvElencoChat.Items.Clear();

            foreach (ClsUtente utente in Program.Contatti)
            {
                ListViewItem lvi = new ListViewItem(utente.Nickname);
                lvi.Tag = utente.ID;
                lvElencoChat.Items.Add(lvi);

                // Controlli se l'ID corrisponde a quello salvato
                if (idSelezionato != -1 && utente.ID == idSelezionato)
                {
                    lvi.Selected = true;
                }
            }

            lvElencoChat.SelectedIndexChanged += lvElencoChat_SelectedIndexChanged; //riseleziono l'elemetno
        }

        private void PopolaListViewChat()
        {
            lvChat.Items.Clear();
                int u = Program.Messaggi.FindIndex(i => i.Any(m => m.DestinatarioID == Program.utente.ID || m.MittenteID == Program.utente.ID));  //Trovo l'indice della chat con il destinatario
                if (u == -1)
                {   //controllo se ho una chat e in caso ne creo una
                    Program.Messaggi.Add(new List<ClsMessaggio>());
                    u = Program.Messaggi.Count - 1;
                }
                foreach (ClsMessaggio m in Program.Messaggi[u])
                {
                    ListViewItem lvi;
                    if (m.MittenteID == Program.utente.ID)
                    {
                        lvi = new ListViewItem(m.Testo);
                        lvi.SubItems.Add("");
                    }
                    else
                    {
                        lvi = new ListViewItem("");
                        lvi.SubItems.Add(m.Testo);
                    }

                    lvi.Tag = m.Id;
                    lvChat.Items.Add(lvi);
                }
                if (lvChat.Items.Count > 0)
                    lvChat.EnsureVisible(lvChat.Items.Count - 1);   //vado all'ultimo messaggio inviato

        }
        #endregion

        private void ptImpostazioni_Click(object sender, EventArgs e)
        {
            Program.io2 = true;
            FrmImpostazioneUtente frmImpostazioneUtente = new FrmImpostazioneUtente();
            frmImpostazioneUtente.ShowDialog();
        }

        private void btnCreaGruppo_Click(object sender, EventArgs e)
        {
            FrmCreaGruppo frmCreaGruppo = new FrmCreaGruppo();
            frmCreaGruppo.ShowDialog();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            FrmAggiungi frmAggiungi = new FrmAggiungi();
            frmAggiungi.ShowDialog();
        }

        private void btnTestDiConnessione_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.dbConnString;

            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                MessageBox.Show("Connessione OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Test di connessione fallito! {ex.Message} ");
            }
            finally
            {
                conn.Close();
            }
        }

        private void lblNomeGruppoOChat_Click(object sender, EventArgs e)
        {
            if (Program.Contatti.Count > 0)
            {
                Program.io2 = false;
                FrmImpostazioneUtente frmImpostazioneUtente = new FrmImpostazioneUtente();
                frmImpostazioneUtente.ShowDialog();
            }
        }

        private void lvElencoChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvElencoChat.SelectedItems.Count > 0)
            {
                Program.utente = Program.Contatti.FirstOrDefault(u => u.ID == Convert.ToInt64(lvElencoChat.SelectedItems[0].Tag));

                if (Program.utente != null)
                {
                    // Usa il metodo unificato
                    Program.chat = TrovaIndiceChat(Program.utente.ID);

                    // Se non esiste, crea una nuova chat (ma non ancora salvata nel DB)
                    if (Program.chat == -1)
                    {
                        Program.Messaggi.Add(new List<ClsMessaggio>());
                        Program.chat = Program.Messaggi.Count - 1;
                    }

                    lblNomeGruppoOChat.Text = Program.utente.Nickname;
                    PopolaListViewChat();
                }
            }
            else
            {
                lblNomeGruppoOChat.Text = "Nessuna chat selezionata";
                lvChat.Items.Clear();
                rtbMessaggio.Text = "";
                Program.utente = null;
                Program.chat = -1;
            }
        }

        private void rtbMessaggio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnInvia_Click(sender, e);
        }

        private void tmMessaggi_Tick(object sender, EventArgs e)
        {
            tmMessaggi.Stop();
            try
            {
                ElaboraPolling();  // CHIAMA UN METODO SEPARATO
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Errore nel timer: {ex.Message}");
            }
            finally
            {
                tmMessaggi.Start();
            }
        }

        private void ElaboraPolling()
        {
            MySqlConnection conn = new MySqlConnection(Program.connectionString);
            string errore = "";

            // Recupera i nuovi messaggi dal database
            ClsMessaggioBL.RecuperoMessaggi(ref conn, out errore);

            if (string.IsNullOrWhiteSpace(errore))
            {
                // Aggiorna la lista dei contatti
                Program.Contatti = ClsUtenteBL.PrendiContatti(ref conn, out errore);

                if (string.IsNullOrWhiteSpace(errore))
                {
                    PopolaListViewContatti();

                    // Se � selezionata la chat
                    if (Program.utente != null)
                    {
                        // Ricalcola l'indice della chat
                        int chatIndex = TrovaIndiceChat(Program.utente.ID);

                        if (chatIndex != -1)
                        {
                            Program.chat = chatIndex;
                            PopolaListViewChat();
                        }
                    }
                }
            }
        }

        private int TrovaIndiceChat(long utenteID)
        {
            // Cerca se esiste gi� una chat con questo utente
            int indice = Program.Messaggi.FindIndex(chat => chat.Any(m =>
                (m.MittenteID == Program.io.ID && m.DestinatarioID == utenteID) ||
                (m.MittenteID == utenteID && m.DestinatarioID == Program.io.ID)));

            return indice;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //chiudo il programma
            Application.Exit();
        }

        private void btnEliminaMessaggio_Click(object sender, EventArgs e)
        {
            if (lvChat.SelectedItems.Count > 0)
            {
                // Prendo l'id del messaggio
                long idMessaggioSelezionato = Convert.ToInt64(lvChat.SelectedItems[0].Tag);
                FrmElimina frmElimina = new FrmElimina(idMessaggioSelezionato);
                frmElimina.ShowDialog();
            }
        }

        private bool ControllaSeBloccato(long utenteID)
        {
            bool isBloccato = false;
            // Controlla nella lista dei bloccati se l'utente corrente � bloccato
            foreach (ClsBloccare bloccato in Program.bloccati)
            {
                if (bloccato.Bloccato == utenteID && bloccato.BloccatoDa == Program.io.ID)
                    isBloccato = true;
            }

            return isBloccato;
        }

        private bool ControllaSeSonoBloccato(long utenteID)
        {
            bool isBloccato = false;
            // Controlla nella lista dei bloccati se l'utente corrente � bloccato
            foreach (ClsBloccare bloccato in Program.bloccati)
            {
                if (bloccato.BloccatoDa == utenteID && bloccato.Bloccato == Program.io.ID)
                    isBloccato = true;
            }

            return isBloccato;
        }

    }
}
