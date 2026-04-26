using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesaretti Devis
namespace Messaggistica
{
    public class ClsBloccare
    {
        long bloccato;
        long bloccatoDa;

        public long Bloccato { get => bloccato; set => bloccato = value; }
        public long BloccatoDa { get => bloccatoDa; set => bloccatoDa = value; }

        public ClsBloccare(long bloccato, long bloccatoDa)
        {
            this.Bloccato = bloccato;
            this.BloccatoDa = bloccatoDa;
        }

        public ClsBloccare()
        {
            
        }
    }
}
