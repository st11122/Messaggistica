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
        ClsUtente bloccato;
        ClsUtente bloccatoDa;

        public ClsBloccare(ClsUtente bloccato, ClsUtente bloccatoDa)
        {
            this.bloccato = bloccato;
            this.bloccatoDa = bloccatoDa;
        }

        public ClsBloccare()
        {

        }
    }
}
