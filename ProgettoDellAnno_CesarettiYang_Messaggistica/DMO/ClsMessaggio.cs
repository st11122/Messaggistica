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
        
        public ClsMessaggio()
        {
           
        }
        
        public ClsMessaggio(string testo, DateTime data, bool eliminatoDaMittente, bool eliminatoDaDestinatario, long mittenteID, long destinatarioID, long gruppoID)
        {
            this._testo = testo;
            this._data = data;
            this._eliminatoDaMittente = eliminatoDaMittente;
            this._eliminatoDaDestinatario = eliminatoDaDestinatario;
            this._mittenteID = mittenteID;
            this._destinatarioID = destinatarioID;
            this._gruppoID = gruppoID;
        }
    }
}
