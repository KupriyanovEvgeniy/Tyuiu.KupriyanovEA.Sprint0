using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KupriyanovEA.Sprint0.Task3.V0.Lib;

namespace Tyuiu.KupriyanovEA.Sprint0.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слагаемое: ");
            string S1 = Console.ReadLine();
            Console.Write("Введите слагаемое: ");
            string S2 = Console.ReadLine();
            Console.WriteLine($"Сумма" {S1 + S2});
            //Console.WriteLine(DataService.Sum(7, 7));
            //Console.WriteLine(DataService.Min(10, 7));
            Console.ReadKey();
        }
    }
}
