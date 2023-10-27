namespace _2M_09_wyszukiwanieWartownik
{
    class Wyszukiwanie
    {
        private const int N = 50;
        private int[] liczby = new int[N+1];
        private int szukana;
        public Wyszukiwanie()
        {
            generujDane();
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
            Console.WriteLine("Hello, World!");
        }
    }
}