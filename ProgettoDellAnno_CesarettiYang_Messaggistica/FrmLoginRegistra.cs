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
    public partial class FrmLoginRegistra : Form
    {
        // Variabili
        private string nome;
        private string descrizione;
        private List<ClsUtente> membri;

        // Proprietà
        public string Nome { get => nome; set => nome = value; }
        public string Descizione { get => descrizione; set => descrizione = value; }

        

        public void AggiungiMembro(ClsUtente utente)
        {
            if (utente != null) membri.Add(utente);
        }

        private void FrmLoginRegistra_Load(object sender, EventArgs e)
        {

        }
    }
}
