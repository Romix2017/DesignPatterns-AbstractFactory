using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryRealWorld
{
    public abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
