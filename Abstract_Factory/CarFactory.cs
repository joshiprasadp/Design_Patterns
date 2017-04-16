using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public abstract class CarFactory 
    {
        public abstract FamilyCar CreateFamilyCar();

        public abstract SportsCar CreateSportsCar();
    }
}