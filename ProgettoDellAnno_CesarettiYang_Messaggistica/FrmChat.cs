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
            ClsMessaggio messaggio = new ClsMessaggio();
            messaggio.Data = DateTime.Now;
            messaggio.Testo = rtbMessaggio.Text;

        }

        private void btnAggiungiContatto_Click(object sender, EventArgs e)
        {
            FrmAggiungi frmAggiungi = new FrmAggiungi();
            frmAggiungi.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //stampo il proprio nome utente sulla form main
            lblNickname.Text = Program.io.Nickname;

            MySqlConnection conn = new MySqlConnection(Program.connectionString);

            //prendo i contatti e li metto nel program
            Program.Contatti = ClsUtenteBL.getAllContact(ref conn, Program.io.ID, out string errore);
            if (string.IsNullOrWhiteSpace(errore))
                PopolaListView(Program.Contatti);
            else
                MessageBox.Show($"Errore nel caricamento dei contatti\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #region POPOLA LIST VIEW
        private void PopolaListView(List<ClsUtente> contatti)
        {
            //popolo la listView
            lvElencoChat.Items.Clear();

            foreach(ClsUtente utente in contatti)
            {
                ListViewItem lvi = new ListViewItem(utente.Nickname);
                lvi.Tag = utente;
                lvElencoChat.Items.Add(lvi);
            }
        }
        #endregion

        private void ptImpostazioni_Click(object sender, EventArgs e)
        {
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
    }
}
