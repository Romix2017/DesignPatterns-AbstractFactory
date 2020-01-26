using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        private AbstractProductA abstractProductA;
        private AbstractProductB abstractProductB;
        public Client(AbstractFactoryBase factory)
        {
            abstractProductB = factory.CreateProductB();
            abstractProductA = factory.CreateProductA();
        }
        public void Run()
        {
            abstractProductB.Interact(abstractProductA);
        }
    }
}
