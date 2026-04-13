 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yang Francesco
namespace Messaggistica
{
    public class ClsMessaggio
    {
        private string testo;
        private DateTime data;
        private bool eliminatoDaMittente;
        private bool eliminatoDaDestinatario;

        public string Testo { get => testo; set => testo = value; }
        public DateTime Data { get => data; set => data = value; }
        public bool EliminatoDaMittente { get => eliminatoDaMittente; set => eliminatoDaMittente = value; }
        public bool EliminatoDaDestinatario { get => eliminatoDaDestinatario; set => eliminatoDaDestinatario = value; }

        // --- COSTRUTTORI ---

        // 1. Costruttore Vuoto (Default)
        public ClsMessaggio()
        {
            this.data = DateTime.Now; // Prende l'ora esatta del PC
            this.eliminatoDaMittente = false;
            this.eliminatoDaDestinatario = false;
        }

        // 2. Costruttore con il Testo (Il più usato per inviare)
        public ClsMessaggio(string testo) : this()
        {
            this.testo = testo;
        }

        // 3. Costruttore Completo (Utile se devi ricaricare messaggi vecchi dal DB)
        public ClsMessaggio(string testo, DateTime data, bool eliminatoDaMittente, bool eliminatoDaDestinatario)
        {
            this.testo = testo;
            this.data = data;
            this.eliminatoDaMittente = eliminatoDaMittente;
            this.eliminatoDaDestinatario = eliminatoDaDestinatario;
        }
    }
}
