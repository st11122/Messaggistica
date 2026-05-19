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
    public partial class FrmImpostazioneUtente : Form
    {
        public FrmImpostazioneUtente()
        {
            InitializeComponent();
        }

        private void FrmImpostazioneUtente_Load(object sender, EventArgs e)
        {
            //inserisco i dati nelle form
            if(Program.io2 == true) //controllo se sono io l'utente o il contatto
            {
                tbNickname.Text = Program.io.Nickname;
                tbPassword.Text = Program.io.Password;
                dtpDataDiNascita.Value = Program.io.DataDiNascita;
                rtbBiografia.Text = Program.io.Descrizione;
                tbNickname.ReadOnly = false;
                tbPassword.Visible = true;
                dtpDataDiNascita.Enabled = true;
                rtbBiografia.ReadOnly = false;
                btnAnnulla.Text = "Annulla";
                lblImpostazioni.Text = "IMPOSTAZIONI UTENTE ID: " + Program.io.ID;
                btnBlocca.Visible = false;
            }
            else
            {
                tbPassword.Visible = false;
                lblPassword.Visible = false;
                cbMostraPassword.Visible = false;
                dtpDataDiNascita.Enabled = false;
                rtbBiografia.ReadOnly = true;
                btnAnnulla.Text = "Chiudi";
                tbNickname.Text = Program.utente.Nickname;
                dtpDataDiNascita.Value = Program.utente.DataDiNascita;
                rtbBiografia.Text = Program.utente.Descrizione;
                lblImpostazioni.Text = "INFORMAZIONI UTENTE ID: " + Program.utente.ID;
            }

        }

        private void cbMostraPassword_CheckedChanged(object sender, EventArgs e)
        {
            //mostro e nascondo la password
            if (cbMostraPassword.Checked == true)
                tbPassword.UseSystemPasswordChar = false;
            else
                tbPassword.UseSystemPasswordChar = true;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            Program.io.Nickname = tbNickname.Text;
            Program.io.Descrizione = rtbBiografia.Text;
            Program.io.DataDiNascita = dtpDataDiNascita.Value;
            Program.io.Password = tbPassword.Text;

            MySqlConnection conn = new MySqlConnection(Program.connectionString);
            string errore;
            //controllo se sto modificando me stesso o no
            if (Program.io2)
            {
                ClsUtenteBL.Modifica(ref conn, Program.io, out errore);
                if (string.IsNullOrWhiteSpace(errore))
                    MessageBox.Show("Modifica apportata");
                else
                    MessageBox.Show($"Modifica non apportata\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClsAggiungereBL.ModificaContatto(ref conn, Program.utente.ID, Program.io.ID, tbNickname.Text, out errore);
                if (string.IsNullOrWhiteSpace(errore))
                    MessageBox.Show("Utente modificato");
                else
                    MessageBox.Show($"Utente non modificato\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnBlocca_Click(object sender, EventArgs e)
        {
            //blocco l'uente
            MySqlConnection conn = new MySqlConnection(Program.connectionString);


            ClsBloccare bloccare = new ClsBloccare();
            bloccare.Bloccato = Program.utente.ID;
            bloccare.BloccatoDa = Program.io.ID;
            ClsBloccareBL.Bloccare(conn, bloccare, out string errore);
            if (string.IsNullOrWhiteSpace(errore))
                MessageBox.Show("Utente bloccato");
            else
                MessageBox.Show($"Utente non bloccato\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
