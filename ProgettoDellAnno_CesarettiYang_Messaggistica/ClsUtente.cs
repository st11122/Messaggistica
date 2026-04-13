using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoDellAnno_CesarettiYang_Messaggistica
{
    public class ClsUtente
    {
        string _nickname;
        string _numero;
        DateTime _dataDiNascita;
        string _biografia;
        bool _admin;
        List<ClsUtente> contatti = new List<ClsUtente>();



        public string Nickname
        {
            get => _nickname;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))  //controllo
                    _nickname = value;
                else
                    throw new Exception("Il nickname non può essere vuoto o spazi");    //stampo errore
            }
        }
        public string Numero
        {
            get => _numero;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))  //controllo
                    _numero = value;
                else
                    throw new Exception("Il numero non può essere vuoto o spazi");    //stampo errore
            }
        }
        public DateTime DataDiNascita
        {
            get => _dataDiNascita;
            set
            {
                if (DateTime.Now.Subtract(value).Days > 5110)    //controllo se ha almeno 14 anni
                    _dataDiNascita = value;
                else
                    throw new Exception("Devi avere almeno 14 anni");
            }
        }
        public string Biografia { get => _biografia; set => _biografia = value; }
        public bool Admin { get => _admin; set => _admin = value; }
        public List<ClsUtente> Contatti { get => contatti; set => contatti = value; }


        public ClsUtente()
        {

        }

        public ClsUtente(string nickname, string numero, DateTime dataDiNascita, string biografia, bool admin, List<ClsUtente> contatti)
        {
            _nickname = nickname;
            _numero = numero;
            _dataDiNascita = dataDiNascita;
            _biografia = biografia;
            _admin = admin;
            this.contatti = contatti;
        }











    }

}
