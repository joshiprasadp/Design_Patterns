using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method.Lib
{
    public class SportCarFactory : AudiCarFactory
    {
        protected override Car CreateCar()
        {
            Console.WriteLine("Audi Sports Car Build!");
            return new SportsCar();
        }
    }
}