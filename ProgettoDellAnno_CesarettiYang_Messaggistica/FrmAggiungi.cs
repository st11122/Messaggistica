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
            /*
            // App.config
            string connectionString = ConfigurationManager.ConnectionStrings["messaggistica"].ConnectionString;
            // Properties > Settings
            //string connectionString = Properties.Settings.Default.dbConnString;
            MySqlConnection conn = new MySqlConnection(connectionString);
            string errore = "";

            ClsUtente utente = new ClsUtente();

            utente.ID = ClsUtenteBL.Create(ref conn, clsLibro, out errore);
            MessageBox.Show($"ID generato: {clsLibro.ID}"); */
        }
    }
}
