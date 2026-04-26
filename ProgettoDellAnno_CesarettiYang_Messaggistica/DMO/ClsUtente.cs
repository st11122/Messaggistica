using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesaretti Devis
namespace Messaggistica
{
    public class ClsUtente
    {
        private long _ID;
        private string _descrizione;
        private string _nickname;
        private string _password;
        private DateTime _dataDiNascita;
        private byte _admin;

       

        public long ID { get => _ID; set => _ID = value; }
        public string Descrizione { get => _descrizione; set => _descrizione = value; }
        public string Nickname { get => _nickname; set => _nickname = value; }
        public DateTime DataDiNascita { get => _dataDiNascita; set => _dataDiNascita = value; }
        public string Password { get => _password; set => _password = value; }
        public byte Admin { get => _admin; set => _admin = value; }

        // Costruttore della classe Utente
        public ClsUtente() { }

        public ClsUtente(long ID, string descrizione, string nickname, string password, DateTime dataDiNascita, byte admin)
        {
            _ID = ID;
            _descrizione = descrizione;
            _nickname = nickname;
            _password = password;
            _dataDiNascita = dataDiNascita;
            _admin = admin;
        }
    }
}
