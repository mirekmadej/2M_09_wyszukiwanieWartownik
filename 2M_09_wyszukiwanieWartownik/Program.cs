namespace _2M_09_wyszukiwanieWartownik
{
    class Wyszukiwanie
    {
        private const int N = 50;
        private int[] liczby = new int[N+1];
        private int szukana;
        public Wyszukiwanie(int szukana = 0)
        {
            this.szukana = szukana;
            generujDane();
            int poz = wyszukaj();
            wypiszTablice();
            if (poz == N)
                Console.WriteLine("element nie został znaleziny");
            else
                Console.WriteLine($"element jest na pozycji {poz}");
        }
        private void wypiszTablice()
        {
            for(int i = 0; i < N; i++)          
                Console.Write($"{liczby[i]}, ");
            Console.WriteLine();
        }
        private int wyszukaj()
        {
            for(int i = 0; ; i++) 
                if (liczby[i] == szukana)
                    return i;
        }
        private void generujDane()
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
                liczby[i] = random.Next(1,100);
            liczby[N] = szukana;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("podaj liczbę w zakresie 1 - 100: ");
            //nt x = int.Parse(Console.ReadLine());
            int x = 5; 
            Wyszukiwanie w = new Wyszukiwanie(x);
        }
    }
}