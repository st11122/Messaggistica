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
    public partial class FrmElimina : Form
    {
        long messaggioID;

        public FrmElimina(long messaggio)
        {
            InitializeComponent();
            messaggioID = messaggio;
        }

        private void Elimina_Load(object sender, EventArgs e)
        {
            ClsMessaggio messaggio = TrovaMessaggioPerID(messaggioID);
            if (messaggio.MittenteID != Program.io.ID)
                btnTutti.Visible = false;
        }

        private ClsMessaggio TrovaMessaggioPerID(long messaggioID)
        {
            // Cerca dentro ogni chat
            foreach (List<ClsMessaggio> chat in Program.Messaggi)
            {
                // Cerca il primo messaggio che corrisponde all'ID cercato
                ClsMessaggio msg = chat.FirstOrDefault(m => m.Id == messaggioID);

                // Se lo trova lo restituisco
                if (msg != null)
                {
                    return msg;
                }
            }

            // Se non trova il messaggio
            return null;
        }

        private void btnTutti_Click(object sender, EventArgs e)
        {
            //elimino il messaggio per tutti
            string errore;
            MySqlConnection _conn = new MySqlConnection(Program.connectionString);
            ClsMessaggioBL.AllDelete(ref _conn, messaggioID, out errore);
            if (!string.IsNullOrEmpty(errore))
                MessageBox.Show($"Messaggio non eliminato\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            //elimino il messaggio per tutti
            string errore;
            MySqlConnection _conn = new MySqlConnection(Program.connectionString);
            ClsMessaggioBL.Delete(ref _conn, messaggioID, out errore);
            if (!string.IsNullOrEmpty(errore))
                MessageBox.Show($"Messaggio non eliminato\n {errore}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
