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
    public partial class FrmLoginRegistra : Form
    {
        public FrmLoginRegistra()
        {
            InitializeComponent();
        }


        bool _accediRegistra = false;   //Se false sta accedendo
        private void label2_Click(object sender, EventArgs e)
        {
            if (!_accediRegistra)
            {
                //cambio gui per la registrazione
                lblBiografia.Visible = true;
                lblDataDiNascita.Visible = true;
                btnAccediRegistra.Text = "Registrati";
                lblCambio.Text = "accedi";
                lblLogin.Text = "REGISTRA";
                dtpDataDiNascita.Visible = true;
                rtbBiografia.Visible = true;
                _accediRegistra = true;
            }
            else
            {
                //cambio gui per il login
                lblBiografia.Visible = false;
                lblDataDiNascita.Visible = false;
                btnAccediRegistra.Text = "Accedi";
                lblCambio.Text = "registrati";
                lblLogin.Text = "LOGIN";
                dtpDataDiNascita.Visible = false;
                rtbBiografia.Visible = false;
                _accediRegistra = false;
            }
        }

        private void btnAccediRegistra_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(Program.connectionString);

            //Salvo i miei dati nel program per averli più velocemente
            ClsUtente io = new ClsUtente();

            io.Nickname = tbNickname.Text;
            io.Password = tbPassword.Text;


            
            string errore = "";

            if (_accediRegistra)
            {
                io.Admin = false;
                io.DataDiNascita = dtpDataDiNascita.Value;
                io.Descrizione = rtbBiografia.Text;
                io.ID = ClsUtenteBL.Create(ref conn, io, out errore);
                if (string.IsNullOrWhiteSpace(errore))
                    MessageBox.Show($"ID generato: {io.ID}");
                else
                    MessageBox.Show($"Errore nella registrazione {errore}");
            }
            else
            {
                io = ClsUtenteBL.Login(ref conn, io.Nickname, io.Password, ref errore);
                if(string.IsNullOrWhiteSpace(errore))
                    MessageBox.Show($"Accesso eseguito con successo!");
                else
                    MessageBox.Show($"Accesso non eseguito {errore}");
            }
            if (string.IsNullOrWhiteSpace(errore))
            {
                Program.io = io;
                //apro la chat
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
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
    }
}
