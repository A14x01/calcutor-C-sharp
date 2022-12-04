using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type first x: ");
            string ax_1 = Console.ReadLine();
            Console.Write("Type first y: ");
            string ay_1 = Console.ReadLine();
            Console.Write("Type second x: ");
            string bx_1 = Console.ReadLine();
            Console.Write("Type second y: ");
            string by_1 = Console.ReadLine();

            double ax = Convert.ToInt32(ax_1);
            double ay = Convert.ToInt32(ay_1);
            double bx = Convert.ToInt32(bx_1);
            double by = Convert.ToInt32(by_1);

            double vypocet_1 = (bx - ax);
            double vypocet_2 = (by - ay);
            double delka_1 = Math.Pow(vypocet_1, 2) + Math.Pow(vypocet_2, 2);
            double delka = Math.Sqrt(delka_1);

            double vypocet_stredu_1 = vypocet_1/ 2 + ax;
            double vypocet_stredu_2 = vypocet_2 / 2 + ay;

            double uhel = Math.Atan2(vypocet_1, vypocet_2);
            double vypocitanej_uhel = uhel * 180 / Math.PI;

            Console.WriteLine("Length : {0}", delka);
            Console.WriteLine("Center : X {0}, Y {1}", vypocet_stredu_1, vypocet_stredu_2);
            Console.WriteLine("Angle : {0} ", vypocitanej_uhel);


        }
    }
}