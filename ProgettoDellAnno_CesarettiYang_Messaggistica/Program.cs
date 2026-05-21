using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaggistica
{
    static class Program
    {
<<<<<<< Updated upstream
=======

        public static ClsUtente io = new ClsUtente();
        public static ClsUtente utente = null;
        public static string connectionString = Properties.Settings.Default.dbConnString;
        public static List<ClsUtente> Contatti = new List<ClsUtente>();
        public static bool io2;
        public static List<List<ClsMessaggio>> Messaggi = new List<List<ClsMessaggio>>();
        public static int chat = -1;

>>>>>>> Stashed changes
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLoginRegistra());
        }
    }
}
