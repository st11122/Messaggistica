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
        private string nome;
        private string descrizione;
        private List<ClsUtente> membri;
        private string _nickname;
        private string _numero;
        private List<ClsUtente> contatti = new List<ClsUtente>();

        //Y
        // Costruttore della classe Utente
        public ClsUtente(string nickname, string numero)
        {
            this._nickname = nickname;
            this._numero = numero;
        }

        #region Crea gruppo
        public ClsGruppo creaGruppo(string nome, string descrizione)
        {
            // Usiamo il costruttore di ClsGruppo che abbiamo appena sistemato
            ClsGruppo _nuovoGruppo = new ClsGruppo(nome, descrizione);

            // Aggiungiamo l'utente attuale (this) come primo membro
            _nuovoGruppo.AggiungiMembro(this);

            return _nuovoGruppo;
        }
        #endregion


        public string Nome { get => nome; set => nome = value; }

        // Controlla se qui hai scritto Descizione o Descrizione
        public string Descizione { get => descrizione; set => descrizione = value; }

        #region Metodi Gestione Gruppo

        // Metodo per aggiungere un utente alla lista membri
        public void AggiungiPartecipante(ClsUtente utente)
        {
            if (utente != null && !membri.Contains(utente))
                membri.Add(utente);
        }

        // Metodo per rimuovere un utente
        public void RimuoviPartecipante(ClsUtente utente)
        {
            if (membri.Contains(utente))
                membri.Remove(utente);
        }

        // Metodo per cambiare il nome (potevi farlo anche dalla property, ma così è più "metodo")
        public void CambiaNome(string nuovoNome)
        {
            if (!string.IsNullOrWhiteSpace(nuovoNome))
                this.nome = nuovoNome;
        }

        #endregion









    }

}
