using System;

namespace AbstractFactory
{
    public abstract class AbstractFactoryBase
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
