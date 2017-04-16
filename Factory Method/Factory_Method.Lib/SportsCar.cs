using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Method.Lib
{
    public class SportsCar : Car
    {
        public SportsCar()
        {
            Console.WriteLine(GetType().Name);
        }

        public override void Drive()
        {
            Console.WriteLine("Driving Fast because this is sports car.....");
        }
    }
}