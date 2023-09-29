using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PustobaevDO.Sprint0.Task6.V0.Lib;


namespace Tyuiu.PustobaevDO.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            //Пример цикличесмкой структуры находится в библиотеке классов в методе AdditionArray
            Console.WriteLine("Сумма элементов массива =" + DataService.AdditionArray(numsArray));

            //Пример цикличесмкой структуры находится в библиотеке классов в методе SubtractionArray
            Console.WriteLine("Разность элементов массива =" + DataService.SubstractionArray(numsArray));

            //Пример цикличесмкой структуры находится в библиотеке классов в методе MultiplicationArray
            Console.WriteLine("Произведение элементов массива =" + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
