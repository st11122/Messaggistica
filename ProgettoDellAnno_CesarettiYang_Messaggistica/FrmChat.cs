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
            lblNickname.Text = Program.io.Nickname;
        }
    }
}
