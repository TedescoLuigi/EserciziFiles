namespace es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            double[] prezzi = { 10.5, 20.99, 5.75, 100, 42.3 };
            string file = "prezzi.dat";

            bool append = false;

            // controllo se il file esiste
            if (File.Exists(file))
            {
                Console.WriteLine("Il file esiste già. Vuoi sovrascrivere (S) o aggiungere (A)?");
                string scelta = Console.ReadLine();

                if (scelta.ToUpper() == "A")
                {
                    append = true;
                }
                else
                {
                    append = false;
                }
            }

            // scrittura file
            using (StreamWriter sw = new StreamWriter(file, append))
            {
                for (int i = 0; i < prezzi.Length; i++)
                {
                    sw.WriteLine(prezzi[i]);
                }
            }

            Console.WriteLine("Operazione completata.");
        }
    }
}