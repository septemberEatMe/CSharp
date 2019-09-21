﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsageCode
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                //небезопасный код работа с указателями
                int number;
                int* pnumber = &number;
                Console.WriteLine("{0:X}", (int)pnumber);

                List<int> nums = new List<int>() { 1, 23, 5, 24, 78, 345, 0, 3 };
                {
                };

                //LINQ запрос пример
                var result = from item in nums where item < 5 select item;

                Console.WriteLine(result.GetType().Name);
                //вывод результата
                foreach(var r in result)
                {
                    Console.WriteLine(r);
                }
                Console.ReadLine();

                
            }
        }
    }
}