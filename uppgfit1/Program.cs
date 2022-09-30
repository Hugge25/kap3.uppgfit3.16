using System;

namespace uppgfit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange längden på låten för att se om den får spelas på radion(ange med komma, exempel: 1,23)");
            double tid = double.Parse(Console.ReadLine());


            if (tid >= 2.45 && tid <= 4.20)
            {
                Console.WriteLine("Din låt kan spelas på radion");
            }
            else
            {
                
                Console.WriteLine("Din låt är för lång eller kort för att kunna spelas på radion");
            }
        }
    }
}