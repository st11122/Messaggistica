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

        public string Nome { get => nome; set => nome = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public List<ClsUtente> Membri { get => membri; }

        // Costruttore: inizializza sempre la lista per evitare errori
        public ClsGruppo(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.membri = new List<ClsUtente>();
        }

        #region Gestione Membri

        // Aggiunge un utente al gruppo
        public void AggiungiMembro(ClsUtente utente)
        {
            if (utente != null && !membri.Contains(utente))
            {
                membri.Add(utente);
            }
        }

        // Rimuove un utente (es. quando qualcuno esce o viene rimosso)
        public void RimuoviMembro(ClsUtente utente)
        {
            if (membri.Contains(utente))
            {
                membri.Remove(utente);
            }
        }

        #endregion

        #region Funzionalità Gruppo

        // Restituisce il numero totale di partecipanti
        public int ContaMembri()
        {
            return membri.Count;
        }

        // Metodo per inviare un messaggio a tutto il gruppo
        // Restituisce una lista di messaggi pronti per essere salvati nel DB
        public List<ClsMessaggio> InviaMessaggioDiGruppo(ClsUtente mittente, string testo)
        {
            List<ClsMessaggio> messaggiInviati = new List<ClsMessaggio>();

            foreach (var destinatario in membri)
            {
                // Non inviamo il messaggio a noi stessi
                if (destinatario != mittente)
                {
                    ClsMessaggio m = new ClsMessaggio();
                    m.Testo = testo;
                    m.Data = DateTime.Now;
                    // Qui logicamente il mittente è 'mittente' e il destinatario è 'destinatario'
                    messaggiInviati.Add(m);
                }
            }
            return messaggiInviati;
        }

        #endregion
    }
}
