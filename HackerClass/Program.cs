﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createClass
{
    class Program
    {
        static void Main(string[] args)
<<<<<<< HEAD
        {
            unsafe
=======
          
        {//1.Тут открывается скобка метода Мейн всё что внутри скобки будет в рантайме
            //создаём Объект, нашего Класса, который мы написали на первой странице, имя Объекта Элиот,
            //Конструктор класса принимает параметр строки где мы присвоили ИМЯ.
            Hacker Elliot = new Hacker("Elliot");
            
            Console.WriteLine("1:Взломать Корпроацию зла");
            int handle = Int32.Parse(Console.ReadLine());
            switch(handle)
>>>>>>> 8e23dc7d33173c47d71824962459ab0eaec84912
            {
                int a = 10;
                int* p = &a;
                Console.WriteLine("{0}", *p);

                Hacker Elliot = new Hacker("Elliot");

                Console.WriteLine("1:Взломать Корпроацию зла");
                int handle = Int32.Parse(Console.ReadLine());
                switch (handle)
                {
                    case (1):
                        Elliot.hackCoorpEvil();
                        break;
                    case (2):
                        Elliot.GoToTyrell();
                        break;
                    default:
                        Console.WriteLine("Введите команду");

                        break;
                }

                Console.WriteLine(Elliot.ToString());
                Console.ReadLine();
            }
        }
    }
}
