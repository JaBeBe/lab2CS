using System;
using System.Collections.Generic;

namespace lab2
{  
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Pracownik>();

            lista.Add(new Pracownik ("bebito", new DateTime(2010, 10, 01), 1000));
            lista.Add(new Pracownik ("SDA", new DateTime(2008, 11, 01), 1501));
            lista.Add(new Pracownik ("ASD", new DateTime(2009, 05, 01), 1020));
            lista.Add(new Pracownik ("APDS", new DateTime(2011, 01, 01), 1700));
            lista.Add(new Pracownik ("bebito", new DateTime(2010, 10, 01), 1100));
           
            foreach (var i in lista)
            {
                System.Console.WriteLine(i);
            }

            System.Console.WriteLine();

            lista.Sort();
            
            lista.ForEach((p) => {System.Console.WriteLine(p+",");});

        }
        static void Main1(string[] args)
        {
            var p1 = new Pracownik("bebito", new DateTime(2010, 10, 01), 1000);
            Console.WriteLine(p1);

            var p2 = new Pracownik ("bebito", new DateTime(2010, 10, 01), 1000);
            Console.WriteLine(p2);

            System.Console.WriteLine(p1.Equals(p2));

            p2.Nazwisko = "Franek";

            System.Console.WriteLine(p1.Equals(p2));
        }
    }
}
