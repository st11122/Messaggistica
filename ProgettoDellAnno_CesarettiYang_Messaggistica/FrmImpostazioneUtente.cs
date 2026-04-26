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
    public partial class FrmImpostazioneUtente : Form
    {
        public FrmImpostazioneUtente()
        {
            InitializeComponent();
        }

        private void FrmImpostazioneUtente_Load(object sender, EventArgs e)
        {
            //inserisco i dati nelle form
            tbNickname.Text = Program.io.Nickname;
            tbPassword.Text = Program.io.Password;
            dtpDataDiNascita.Value = Program.io.DataDiNascita;
            rtbBiografia.Text = Program.io.Descrizione;
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
