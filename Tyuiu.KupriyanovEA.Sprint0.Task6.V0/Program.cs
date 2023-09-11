using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KupriyanovEA.Sprint0.Task6.V0.Lib;
namespace Tyuiu.KupriyanovEA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            //Пример находится в библиотеке метод: AdditionArray
            Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(numsArray));

            //Пример находится в библиотеке метод: SubtractionArray
            Console.WriteLine("Разность элементов массива =" + DataService.SubtractionArray(numsArray));

            //Пример находится в библиотеке метод: MultiplicationArray
            Console.WriteLine("Произведение элементов массива =" + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
