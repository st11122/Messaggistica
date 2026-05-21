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
<<<<<<< Updated upstream
        private string testo;
        private DateTime data;
        private bool eliminatoDaMittente;
        private bool eliminatoDaDestinatario;

        public string Testo { get => testo; set => testo = value; }
        public DateTime Data { get => data; set => data = value; }
        public bool EliminatoDaMittente { get => eliminatoDaMittente; set => eliminatoDaMittente = value; }
        public bool EliminatoDaDestinatario { get => eliminatoDaDestinatario; set => eliminatoDaDestinatario = value; }

        // --- COSTRUTTORI ---
=======
        private string _testo;
        private DateTime _data;
        private bool _eliminatoDaMittente;
        private bool _eliminatoDaDestinatario;
        private long _mittenteID;
        private long _destinatarioID;
        private long _gruppoID;


        public string Testo { get => _testo; set => _testo = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public bool EliminatoDaMittente { get => _eliminatoDaMittente; set => _eliminatoDaMittente = value; }
        public bool EliminatoDaDestinatario { get => _eliminatoDaDestinatario; set => _eliminatoDaDestinatario = value; }
        public long DestinatarioID { get => _destinatarioID; set => _destinatarioID = value; }
        public long MittenteID { get => _mittenteID; set => _mittenteID = value; }
        public long GruppoID { get => _gruppoID; set => _gruppoID = value; }

        //COSTRUTTORE
>>>>>>> Stashed changes

        // 1. Costruttore Vuoto (Default)
        public ClsMessaggio()
        {
            this.data = DateTime.Now; // Prende l'ora esatta del PC
            this.eliminatoDaMittente = false;
            this.eliminatoDaDestinatario = false;
        }
<<<<<<< Updated upstream

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
=======
        public ClsMessaggio(string testo, DateTime data, bool eliminatoDaMittente, bool eliminatoDaDestinatario, long mittenteID, long destinatarioID, long gruppoID)
        {
            this._testo = testo;
            this._data = data;
            this._eliminatoDaMittente = eliminatoDaMittente;
            this._eliminatoDaDestinatario = eliminatoDaDestinatario;
            this._mittenteID = mittenteID;
            this._destinatarioID = destinatarioID;
            this._gruppoID = gruppoID;
>>>>>>> Stashed changes
        }
    }
}
