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
                label1.Text = "Se hai un'account";
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
                label1.Text = "Se non hai un'account";
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
                if (string.IsNullOrWhiteSpace(tbNickname.Text)) //Controllo se ha inserito il nickname
                    errore = "Nickname non inserito";
                else
                {
                    if (dtpDataDiNascita.Value > (DateTime.Now.AddYears(-14)))  //controllo se ha 14 anni
                        errore = "Devi avere almeno 14 anni per poter usare messaggistica";
                    else
                    {
                        if (tbPassword.Text.Length < 8) //controllo se la password è di almeno 8 caratteri
                            errore = "La password deve essere lunga almeno 8 caratteri";
                        else
                        {

                            //registro i valori
                            io.Admin = false;
                            io.DataDiNascita = dtpDataDiNascita.Value;
                            io.Descrizione = rtbBiografia.Text;
                            io.ID = ClsUtenteBL.Create(ref conn, io, out errore);
                            Program.io = io;

                            Program.io.Password = tbPassword.Text;
                            if (string.IsNullOrWhiteSpace(errore))
                                MessageBox.Show($"ID generato: {io.ID}");
                            else
                                MessageBox.Show($"Errore nella registrazione {errore}");
                        }
                    }
                }
            }
            else
            {
                //faccio il login
                Program.io = ClsUtenteBL.Login(ref conn, io.Nickname, io.Password, ref errore);
                if (string.IsNullOrWhiteSpace(errore))
                {
                    MessageBox.Show("Accesso eseguito con successo!");
                    Program.io.Password = tbPassword.Text;
                }
                else
                    MessageBox.Show($"Accesso non eseguito {errore}");
            }

            if (string.IsNullOrWhiteSpace(errore))
            {
                //apro la chat
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
            }
            else
                MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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