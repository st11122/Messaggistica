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
    public partial class FrmAggiungi : Form
    {
        public FrmAggiungi()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Program.connectionString);

            ClsAggiungereBL.Aggiungere(ref conn, tbNickname.Text, Program.io.ID, (long)nudIDcontatto.Value, out string errore);
            if (string.IsNullOrWhiteSpace(errore))
                MessageBox.Show("Contatto aggiunto con successo");
            else
                MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
