﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PustobaevDO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PustobaevDO.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода Getmessage
            //из библиоотеки Tyuiu.PustobaevDO.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Дмитрий"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
