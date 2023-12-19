using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATEURS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("saisir le montant des dommages  ");
            double dommage = Convert.ToDouble(Console.ReadLine());
            double franchise = Math.Min(dommage * 0.10, 4000);
            double rembourse = dommage - franchise;
            Console.WriteLine("la franchise : " + franchise );
            Console.WriteLine("le montant remboursé : " + rembourse );
            Console.ReadKey();
        }
    }
}
