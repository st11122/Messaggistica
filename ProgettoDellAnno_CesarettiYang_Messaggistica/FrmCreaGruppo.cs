using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Messaggistica
{
    public partial class FrmCreaGruppo : Form
    {
        public FrmCreaGruppo()
        {
            InitializeComponent();
        }

        private void btnCreaAggiungi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNomeGruppo.Text))
                MessageBox.Show("Inserisci il nome del gruppo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //creo il gruppo mi aggiungo e mi metto admin
                ClsGruppo gruppo = new ClsGruppo();
                gruppo.Nome = tbNomeGruppo.Text;
                gruppo.Descrizione = rtbDescrizione.Text;
                gruppo.IdAdmin.Add(Program.io.ID);

                MySqlConnection conn = new MySqlConnection(Program.connectionString);
                string errore = "";

                long idGruppo = ClsGruppoBL.Create(ref conn, gruppo, out errore);
                if (!string.IsNullOrWhiteSpace(errore))
                    MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    List<long> Utenti = new List<long>();
                    foreach (ListViewItem item in lvContatti.SelectedItems)
                    {
                        if (item.Tag != null)
                        {
                            long id = Convert.ToInt64(item.Tag);
                            Utenti.Add(id);
                        }
                    }
                    ClsGruppoBL.Unire(ref conn, Utenti, idGruppo, out errore);
                    if (!string.IsNullOrWhiteSpace(errore))
                        MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }

        private void FrmCreaGruppo_Load(object sender, EventArgs e)
        {
            PopolaListView();
        }

        private void PopolaListView()
        {
            lvContatti.Items.Clear();

            foreach (ClsUtente utente in Program.Contatti)
            {
                //non puoi aggiungere persone bloccate o che ti hanno bloccato
                if (!ControllaSeBloccato(utente.ID) && !ControllaSeSonoBloccato(utente.ID))
                {
                    ListViewItem lvi = new ListViewItem(utente.Nickname);
                    lvi.SubItems.Add(utente.ID.ToString());
                    lvi.Tag = utente.ID;
                    lvContatti.Items.Add(lvi);
                }
            }
        }
        private bool ControllaSeBloccato(long utenteID)
        {
            bool isBloccato = false;
            // Controlla nella lista dei bloccati se l'utente corrente è bloccato
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
            // Controlla nella lista dei bloccati se l'utente corrente è bloccato
            foreach (ClsBloccare bloccato in Program.bloccati)
            {
                if (bloccato.BloccatoDa == utenteID && bloccato.Bloccato == Program.io.ID)
                    isBloccato = true;
            }

            return isBloccato;
        }
    }
}
