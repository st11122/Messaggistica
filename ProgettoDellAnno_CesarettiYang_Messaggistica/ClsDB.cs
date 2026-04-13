using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoDellAnno_CesarettiYang_Messaggistica
{
    class ClsDB
    {
        //List
        static List<ClsGruppo> _gruppi = new List<ClsGruppo>();
        static List<ClsMessaggio> _messaggi = new List<ClsMessaggio>();

        //Proprieta 
        public static List<ClsGruppo> Gruppi { get => _gruppi; set => _gruppi = value; }
        public static List<ClsMessaggio> Messaggi { get => _messaggi; set => _messaggi = value; }


    }
}
