﻿using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryBase factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            AbstractFactoryBase factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }
    }
}
