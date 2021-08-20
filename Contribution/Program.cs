using System;

namespace Contribution
{
    class Program
    {
        static void Main(string[] args)
        {

            double Summa = 1000;
            double Persent = 0.02;
            int month = 0;
            
            while (Summa <= 1200)
            {
                double adding = Summa * Persent;
                Summa += adding;
                month++;
            }

            Console.WriteLine($"The amount of the deposit will increase to 1200 in {month} months");
        }
    }
}
