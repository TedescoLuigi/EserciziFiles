namespace eserciziFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeriPari = new List<int>();

            // lettura file
            using (StreamReader sr = new StreamReader("numeri.txt"))
            {
                string riga = sr.ReadLine();

                while (riga != null)
                {
                    int numero = int.Parse(riga);

                    // controllo pari
                    if (numero % 2 == 0)
                    {
                        numeriPari.Add(numero);
                    }

                    riga = sr.ReadLine();
                }
            }

            // calcolo media
            int somma = 0;

            for (int i = 0; i < numeriPari.Count; i++)
            {
                somma += numeriPari[i];
            }

            double media = 0;

            if (numeriPari.Count > 0)
            {
                media = (double)somma / numeriPari.Count;
            }

            Console.WriteLine("Media dei numeri pari: " + media);
        }
    }
}