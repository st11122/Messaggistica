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
        private long mittenteID;
        private long destintarioID;



        public string Testo { get => testo; set => testo = value; }
        public DateTime Data { get => data; set => data = value; }
        public bool EliminatoDaMittente { get => eliminatoDaMittente; set => eliminatoDaMittente = value; }
        public bool EliminatoDaDestinatario { get => eliminatoDaDestinatario; set => eliminatoDaDestinatario = value; }
        public long DestintarioID { get => destintarioID; set => destintarioID = value; }
        public long MittenteID { get => mittenteID; set => mittenteID = value; }

        // --- COSTRUTTORE ---

        public ClsMessaggio()
        {

        }
        public ClsMessaggio(string testo, DateTime data, bool eliminatoDaMittente, bool eliminatoDaDestinatario, long mittenteID, long destintarioID)
        {
            this.testo = testo;
            this.data = data;
            this.eliminatoDaMittente = eliminatoDaMittente;
            this.eliminatoDaDestinatario = eliminatoDaDestinatario;
            this.mittenteID = mittenteID;
            this.destintarioID = destintarioID;
        }
    }
}
