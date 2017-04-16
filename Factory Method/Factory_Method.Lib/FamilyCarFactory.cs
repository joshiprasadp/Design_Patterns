using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method.Lib
{
    public class FamilyCarFactory : AudiCarFactory
    {
        protected override Car CreateCar()
        {
            Console.WriteLine("Audi Family Car Build!");
            return new FamilyCar();
        }
    }
}