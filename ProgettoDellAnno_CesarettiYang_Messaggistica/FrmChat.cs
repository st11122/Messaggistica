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
<<<<<<< Updated upstream
=======

        private void btnInvia_Click(object sender, EventArgs e)
        {
            if (Program.utente != null)
            {
                if (Program.chat == -1) //controllo se esiste la chat e in caso ne creo una e vado all'ultima
                {
                    Program.Messaggi.Add(new List<ClsMessaggio>());
                    Program.chat = Program.Messaggi.Count - 1;
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
                    Program.Messaggi[Program.chat].Add(messaggio);
                    PopolaListViewChat();
                    rtbMessaggio.Text = ""; //libero la rtb                
                }
                else
                    MessageBox.Show($"Messaggio non inviato\n{errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            tmMessaggi.Start();
            MySqlConnection conn = new MySqlConnection(Program.connectionString);

            //prendo i contatti e li metto nel program
            string errore = "";
            Program.Contatti = ClsUtenteBL.PrendiContatti(ref conn, out errore);
            if (string.IsNullOrWhiteSpace(errore))
            {
                PopolaListViewContatti();
                ClsMessaggioBL.RecuperoMessaggi(ref conn, out errore);  //prendo i messaggi
                if (string.IsNullOrWhiteSpace(errore))
                    PopolaListViewContatti();
                else
                    MessageBox.Show($"Errore nel caricamento dei messaggi\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show($"Errore nel caricamento dei contatti\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        #region POPOLA LIST VIEW
        private void PopolaListViewContatti()
        {
            //popolo la listView
            lvElencoChat.Items.Clear();

            foreach(ClsUtente utente in Program.Contatti)
            {
                ListViewItem lvi = new ListViewItem(utente.Nickname);
                lvi.Tag = utente.ID;
                lvElencoChat.Items.Add(lvi);
            }
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
                    if (m.MittenteID == Program.utente.ID)
                    {
                        ListViewItem lvi = new ListViewItem(m.Testo);
                        lvi.SubItems.Add("");
                        lvChat.Items.Add(lvi);
                    }
                    else
                    {
                        ListViewItem lvi = new ListViewItem("");
                        lvi.SubItems.Add(m.Testo);
                        lvChat.Items.Add(lvi);
                    }
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
                Program.utente = Program.Contatti.FirstOrDefault(u => u.ID == Convert.ToInt64(lvElencoChat.SelectedItems[0].Tag));  //cerco il contatto con quel tag
                Program.chat = Program.Messaggi.FindIndex(chat => chat.Count > 0 && (chat[0].MittenteID == Program.io.ID && chat[0].DestinatarioID == Program.utente.ID));
                
                lblNomeGruppoOChat.Text = Program.utente.Nickname;
                PopolaListViewChat();
            }
            else
            {
                // Nessuna chat selezionata
                lblNomeGruppoOChat.Text = "Nessuna chat selezionata";
                lvChat.Items.Clear();
                rtbMessaggio.Text = "";
                Program.utente = null;
                Program.io2 = true;
            }
        }

        private void rtbMessaggio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnInvia_Click(sender, e);
        }

        private void tmMessaggi_Tick(object sender, EventArgs e)
        {
            //ogni 5 secondi controllo se ci sono dei messaggi

            MySqlConnection conn = new MySqlConnection(Program.connectionString);
            string errore = "";

            ClsMessaggioBL.RecuperoMessaggi(ref conn, out errore);  
            if (string.IsNullOrWhiteSpace(errore))
                PopolaListViewContatti();
        }
>>>>>>> Stashed changes
    }
}
