namespace eserciziFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esercizio 1
            string cartella = "Configurazione", riga, riga2, riga3;
            string dataOra = DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss");
            string percorsoFile = Path.Combine(cartella, "impostazioni.log");

            if (!Directory.Exists("Configurazione"))
            {
                Directory.CreateDirectory("Configurazione");
            }

            // elimina file se esiste
            if (File.Exists(percorsoFile))
            {
                File.Delete(percorsoFile);
            }

            // lettura file sorgente
            using (StreamReader sr = new StreamReader("info_sistema.txt"))
            {
                riga = sr.ReadLine();
                riga2 = sr.ReadLine();
                riga3 = sr.ReadLine();
            }

            // scrittura file log
            using (StreamWriter sw = new StreamWriter(percorsoFile))
            {
                sw.WriteLine("[SESSION_START] " + dataOra);
                sw.WriteLine("UTENTE => " + riga);
                sw.WriteLine("SISTEMA => " + riga2);
                sw.WriteLine("RISOLUZIONE => " + riga3);
                sw.WriteLine("LINGUA => IT");
                sw.WriteLine("LIVELLO => ADMIN");
                sw.WriteLine("AUTOSAVE => ATTIVO");
                sw.WriteLine("--------------------");
                sw.WriteLine("EOF");
            }

            // conteggio caratteri
            string rigaTot = "";
            using (StreamReader sr = new StreamReader(percorsoFile))
            {
                string riga4 = sr.ReadLine();
                while (riga4 != null)
                {
                    rigaTot += riga4;
                    riga4 = sr.ReadLine();
                }
            }

            Console.WriteLine("Procedura completata: log generato correttamente, i caratteri totali scritti sono : " + rigaTot.Length);
        }
    }
}