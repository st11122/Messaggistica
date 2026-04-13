using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoDellAnno_CesarettiYang_Messaggistica
{
    class ClsMessaggio
    {
        string testo;
        DateTime data;
        bool eliminatoDaMittente;
        bool eliminatoDaDestinatario;

        public string Testo { get => testo; set => testo = value; }
        public DateTime Data { get => data; set => data = value; }
        public bool EliminatoDaMittente { get => eliminatoDaMittente; set => eliminatoDaMittente = value; }
        public bool EliminatoDaDestinatario { get => eliminatoDaDestinatario; set => eliminatoDaDestinatario = value; }
    }
}
