using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public class MercedesFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }

        public override SportsCar CreateSportsCar()
        {
            return new MercedesSportsCar();
        }
    }
}