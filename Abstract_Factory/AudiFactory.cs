using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstract_Factory
{
    public class AudiFactory : CarFactory
    {
        public override FamilyCar CreateFamilyCar()
        {
            return new AudiFamilyCar();
        }

        public override SportsCar CreateSportsCar()
        {
            return new AudiSportsCar();
        }
    }
}