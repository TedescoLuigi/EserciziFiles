namespace eserciziFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "log.txt";
            string dataOra = DateTime.Now.ToString("yyyy-MM-dd | HH:mm:ss");

            using (StreamWriter sw = new StreamWriter(file, true)) // true = append
            {
                sw.WriteLine(dataOra + " - Sessione utente avviata");
            }

            Console.WriteLine("Sessione registrata.");
        }
    }
}