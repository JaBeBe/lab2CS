using System;

namespace lab2
{  
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pracownik("bebito", new DateTime(2010, 10, 01), 1000);
            Console.WriteLine(p1);

            var p2 = new Pracownik ("bebito", new DateTime(2010, 10, 01), 1000);
            Console.WriteLine(p2);

            System.Console.WriteLine(p1.Equals(p2));

            p2.Nazwisko = "Franek";

            System.Console.WriteLine(p1.Equals(p2));
            System.Console.WriteLine(p2);
        }
    }
}
