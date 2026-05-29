using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Yang Francesco
namespace Messaggistica
{
    public class ClsGruppo
    {
        private string nome;
        private string descrizione;
        // La lista dei membri deve essere di tipo ClsUtente
        private List<ClsUtente> membri;
        private List<long> idAdmin = new List<long>();

        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public List<ClsUtente> Membri { get => membri; }
        public List<long> IdAdmin { get => idAdmin; set => idAdmin = value; }

        

        public ClsGruppo()
        {

        }

        public ClsGruppo(string nome, string descrizione, List<ClsUtente> membri, List<long> idAdmin)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.membri = membri;
            this.idAdmin = idAdmin;
        }
    }
}
